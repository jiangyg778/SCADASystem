using HZY.Framework.DependencyInjection;
using IoTClient.Common.Enums;
using IoTClient.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MiniExcelLibs;
using Sunny.UI;
using System.IO.Pipelines;
using System.Timers;
using Ya.BLL;
using Ya.Helper;
using Ya.Model;
using Ya.SprayProcessSCADASystem.Pages;

namespace Ya.SprayProcessSCADASystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency

    {
        private bool plcIsConnected = false; // plc是否连接
        private CancellationTokenSource cts = new CancellationTokenSource();
        private readonly ILogger<FrmMain> _logger;
        private readonly UserManager _userManager;
        private readonly AuthManager _authManager;
        private System.Timers.Timer timer = new System.Timers.Timer();

        private Dictionary<string, Control> pageControls = new Dictionary<string, Control>
{
    { "控制模块", Globals.ServiceProvider.GetRequiredService<PageTotalEquipmentControl>() },
    { "用户模块", Globals.ServiceProvider.GetRequiredService<PageUserManage>() },
    { "权限模块", Globals.ServiceProvider.GetRequiredService<PageAuthManage>() },
    { "监控模块1", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor3>() },
    { "监控模块2", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor1>() },
    { "监控模块3", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor2>() },
    { "配方模块", Globals.ServiceProvider.GetRequiredService<PageRecipeManage>() },
    { "日志模块", Globals.ServiceProvider.GetRequiredService<PageLogManage>() },
    { "报表模块", Globals.ServiceProvider.GetRequiredService<PageReportManage>() },
    { "图表模块", Globals.ServiceProvider.GetRequiredService<PageChartManage>() },
    { "参数模块", Globals.ServiceProvider.GetRequiredService<PageSystemParameterSet>() }
};

        public FrmMain(ILogger<FrmMain> logge, UserManager userManager, AuthManager authManager)
        {
            this._logger = logge;

            InitializeComponent();
            Init();
            _userManager = userManager;
            _authManager = authManager;
            this.lbl_User.Text = "访客";
            //Globals.IniFile.Write("PLC参数", "变量表地址", Application.StartupPath + "\\PLC_Var_Config.xlsx");

        }

        public override void Init()
        {
            InitConfig();
            InitAsideUI();
            InitHeaderUI();
            InitPlcClient();
            this.FormClosed += FrmMain_FormClosed;
            InitOther();
        }

        private void InitOther()
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (plcIsConnected)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(() =>
                    {
                        this.lbl_ProducteCount.Text = Globals.DataDic[this.lbl_ProducteCount.TagString].ToString();
                        this.lbl_BadCount.Text = Globals.DataDic[this.lbl_BadCount.TagString].ToString();
                        this.lbl_Temperature.Text = Globals.DataDic[this.lbl_Temperature.TagString].ToString() + "℃";
                        this.lbl_Humidness.Text = Globals.DataDic[this.lbl_Humidness.TagString].ToString() + "%";
                        this.lbl_ProducteCount.Text = Globals.DataDic[this.lbl_ProducteCount.TagString].ToString();
                        this.lbl_Beat.Text = Globals.DataDic[this.lbl_Beat.TagString].ToString();
                        this.lbl_TotalAlarm.Text = Globals.DataDic[this.lbl_TotalAlarm.TagString].ToString();
                    });
                }
                
            }
        }

        private void FrmMain_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Globals.SiemensClient.Close();
        }

        private void InitConfig()
        {
            Globals.PlcVarConfigPath = Globals.IniFile.ReadString("PLC参数", "变量表地址", Application.StartupPath + "\\PLC_Var_Config.xlsx");
            // 读取PLC的Ip地址
            Globals.IpAddress = Globals.IniFile.ReadString("PLC参数", "PLC地址", "127.0.0.1");
            // 读取PLC的端口号
            Globals.Port = Globals.IniFile.ReadInt("PLC参数", "PLC端口", 102);
            // 读取PLC的CPU类型
            Globals.CpuType = Enum.Parse<SiemensVersion>(Globals.IniFile.ReadString("PLC参数", "CPU类型", "S7_1200"));
            // 读取PLC的插槽号
            Globals.Slot = Globals.IniFile.ReadByte("PLC参数", "插槽号", 0);
            // 读取PLC的机架号
            Globals.Rack = Globals.IniFile.ReadByte("PLC参数", "机架号", 0);
            // 读取PLC的链接超时时间
            Globals.ConnectTimeOut = Globals.IniFile.ReadInt("PLC参数", "链接超时时间", 3000);
            // 读取PLC的读取循环时间
            Globals.ReadTimeInterval = Globals.IniFile.ReadInt("PLC参数", "循环读取时间", 500);
            // 读取PLC的重连时间
            Globals.ReConnectTimeInterval = Globals.IniFile.ReadInt("PLC参数", "重连时间", 3000);
            _logger.LogInformation("读取配置文件成功");


        }

        private void InitPlcClient()
        {
            //  读取表格的路径

            // 导入PLC变量
            var plcVarList = MiniExcel.Query<PLCVarConfigModel>(Globals.PlcVarConfigPath).ToList();

            // 初始化plc客户端 西门子
            Globals.SiemensClient = new IoTClient.Clients.PLC.SiemensClient(Globals.CpuType, Globals.IpAddress, Globals.Port, Globals.Slot, Globals.Rack, Globals.ConnectTimeOut);

            // 第一次连接
            var connectResult = Globals.SiemensClient.Open();
            if (connectResult.IsSucceed)
            {
                plcIsConnected = true;
                this.led_PlcState.On = true;
            }
            else
            {
                plcIsConnected = false;
                this.led_PlcState.On = false;
            }

            for (int i = 0; i < plcVarList.Count; i++)
            {
                // 初始化plc变量地址 地址-类型
                Globals.ReadDic.Add(plcVarList[i].PLC地址, Enum.Parse<DataTypeEnum>(plcVarList[i].变量类型, true));
                // 初始化plc变量写入 名称-值
                Globals.WriteDic.Add(plcVarList[i].名称, plcVarList[i].PLC地址);
                // 初始化plc变量读取 名称-值
                Globals.DataDic.Add(plcVarList[i].名称, "NA");
            }
            _logger.LogInformation("初始化plc客户端成功");

            try
            {
                Task.Run(async () =>
                {
                    while (!cts.IsCancellationRequested)
                    {
                        if (plcIsConnected)
                        {
                            //批量读取
                            var readResult = Globals.SiemensClient.BatchRead(Globals.ReadDic);
                            if (readResult.IsSucceed)
                            {
                                for (int i = 0; i < plcVarList.Count; i++)
                                {
                                    Globals.DataDic[plcVarList[i].名称] = readResult.Value[plcVarList[i].PLC地址];
                                }
                            }
                            else
                            {
                                Globals.SiemensClient.Close();
                                plcIsConnected = false;
                                this.Invoke(() =>
                                {
                                    this.led_PlcState.On = false;
                                });
                            }
                            await Task.Delay(Globals.ReadTimeInterval);
                        }
                        else
                        {
                            // 重新连接
                            var reConnectResult = Globals.SiemensClient.Open();
                            if (reConnectResult.IsSucceed)
                            {
                                plcIsConnected = true;
                                this.Invoke(() =>
                                {
                                    this.led_PlcState.On = true;
                                });
                            }
                            else
                            {
                                plcIsConnected = false;
                                this.Invoke(() =>
                                {
                                    this.led_PlcState.On = false;
                                });
                            }
                            await Task.Delay(Globals.ReConnectTimeInterval);
                        }

                    }
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void InitAsideUI()
        {
            int pageIndex = 1000;
            TreeNode parent0 = Aside.CreateNode("控制模块", 361461, 34, pageIndex);
            Aside.CreateChildNode(parent0, AddPage(Globals.ServiceProvider.GetRequiredService<PageTotalEquipmentControl>(), ++pageIndex));

            TreeNode parent1 = Aside.CreateNode("用户模块", 61447, 34, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(Globals.ServiceProvider.GetRequiredService<PageUserManage>(), ++pageIndex));
            Aside.CreateChildNode(parent1, AddPage(Globals.ServiceProvider.GetRequiredService<PageAuthManage>(), ++pageIndex));

            TreeNode parent2 = Aside.CreateNode("监控模块", 560066, 34, pageIndex);
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor1>(), ++pageIndex));
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor2>(), ++pageIndex));
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor3>(), ++pageIndex));


            TreeNode parent3 = Aside.CreateNode("配方模块", 162677, 34, pageIndex);
            Aside.CreateChildNode(parent3, AddPage(Globals.ServiceProvider.GetRequiredService<PageRecipeManage>(), ++pageIndex));

            TreeNode parent4 = Aside.CreateNode("日志模块", 57557, 34, pageIndex);
            Aside.CreateChildNode(parent4, AddPage(Globals.ServiceProvider.GetRequiredService<PageLogManage>(), ++pageIndex));

            TreeNode parent5 = Aside.CreateNode("报表模块", 57586, 34, pageIndex);
            Aside.CreateChildNode(parent5, AddPage(Globals.ServiceProvider.GetRequiredService<PageReportManage>(), ++pageIndex));

            TreeNode parent6 = Aside.CreateNode("图表模块", 61950, 34, pageIndex);
            Aside.CreateChildNode(parent6, AddPage(Globals.ServiceProvider.GetRequiredService<PageChartManage>(), ++pageIndex));

            TreeNode parent7 = Aside.CreateNode("参数模块", 559576, 34, pageIndex);
            Aside.CreateChildNode(parent7, AddPage(Globals.ServiceProvider.GetRequiredService<PageSystemParameterSet>(), ++pageIndex));

            _logger.LogInformation("侧边栏初始化完成");
        }

        private void InitHeaderUI()
        {
            //设置关联
            Header.TabControl = MainTabControl;


            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.SetNodeSymbol(Header.Nodes[0], 558295, 34);
            Header.SetNodeSymbol(Header.Nodes[1], 61489, 34);
            Header.SetNodeSymbol(Header.Nodes[2], 557925, 34);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[0], style.DisplayText(), style.Value());
            }

            //获取枚举FontsType的所有字体名称
            for (int i = 0; i < Enum.GetValues(typeof(SystemEnums.FontsType)).Length; i++)
            {
                Header.CreateChildNode(Header.Nodes[1], Enum.GetName(typeof(SystemEnums.FontsType), i), i + 1);
            }

            //获取枚举FontSize的所有字体大小  75-125的范围 75 80 85 90 95 100 105 110 115 120 125
            for (int i = 75; i <= 125; i += 5)
            {
                Header.CreateChildNode(Header.Nodes[2], i.ToString(), i);
            }
            _logger.LogInformation("头部菜单初始化完成");


        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                    UIStyle style = (UIStyle)pageIndex;
                    if (pageIndex < UIStyle.Colorful.Value())
                    {
                        StyleManager.Style = style;

                        if (UIExtension.SetStyleManger != null)
                        {
                            UIExtension.SetStyleManger(StyleManager);
                        }
                    }
                    break;

                case 1:
                    UIStyles.DPIScale = true;
                    UIStyles.GlobalFont = true;
                    UIStyles.GlobalFontName = itemText;

                    UIStyles.GlobalFontScale = SystemConsts.DefaultFontScale;
                    UIStyles.SetDPIScale();
                    break;

                case 2:
                    UIStyles.GlobalFontScale = int.Parse(itemText);
                    UIStyles.SetDPIScale();
                    break;

                default:

                    break;
            }
        }

        private void lbl_Min_Click(object sender, EventArgs e)
        {
            // 最小化
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            // 关闭
            this.Close();
        }

        // 移动窗体
        private Point mPoint;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //把Aside折叠起来
            Aside.CollapseAll();
            Aside.SelectFirst();

            var frmLogin = Globals.ServiceProvider.GetRequiredService<FrmLogin>();
            frmLogin.ShowDialog();
            if (frmLogin.IsLogin)
            {
                //更新登录用户
                this.lbl_User.Text = frmLogin.UserName;
                foreach (var control in pageControls.Values)
                {
                    control.Enabled = true;
                }
            }

        }

        private async void Aside_BeforeExpandAsync(object sender, TreeViewCancelEventArgs e) //异步展开
        {
            UINavMenu uINavMenu = sender as UINavMenu;

            string moduleName = e.Node.Text; //模块名称

            string user = this.lbl_User.Text;
            var roleRes = await _userManager.GetUserAuthAsync(new QueryUserAuthDto() { UserName = user });

            if (roleRes.Status == SystemEnums.Result.Success)
            {
                if (roleRes.Data[0].Role != "管理员")
                {
                    var authRes = await _authManager.GetAuthAsync(new QueryAuthDto { Role = roleRes.Data[0].Role });
                    if (authRes.Status == SystemEnums.Result.Success)
                    {
                        UpdateControlAccess(moduleName, authRes.Data[0], pageControls);
                    }
                }
            }
        }

        private void UpdateControlAccess(string moduleName, QueryAuthResultDto authDto, Dictionary<string, Control> pageControls)
        {
            switch (moduleName)
            {
                case "控制模块":
                    pageControls["控制模块"].Enabled = authDto.ControlModule;
                    break;

                case "用户模块":
                    pageControls["用户模块"].Enabled = false;
                    pageControls["权限模块"].Enabled = false;
                    break;

                case "监控模块":
                    pageControls["监控模块3"].Enabled = authDto.MonitorModule;
                    pageControls["监控模块1"].Enabled = authDto.MonitorModule;
                    pageControls["监控模块2"].Enabled = authDto.MonitorModule;
                    break;

                case "配方模块":
                    pageControls["配方模块"].Enabled = authDto.RecipeModule;
                    break;

                case "日志模块":
                    pageControls["日志模块"].Enabled = authDto.LogModule;
                    break;

                case "报表模块":
                    pageControls["报表模块"].Enabled = authDto.ReportModule;
                    break;

                case "图表模块":
                    pageControls["图表模块"].Enabled = authDto.ChartModule;
                    break;

                case "参数模块":
                    pageControls["参数模块"].Enabled = authDto.ParamModule;
                    break;

                default:
                    break;
            }
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
