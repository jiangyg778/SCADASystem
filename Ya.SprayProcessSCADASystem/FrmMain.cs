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
        private bool plcIsConnected = false; // plc�Ƿ�����
        private CancellationTokenSource cts = new CancellationTokenSource();
        private readonly ILogger<FrmMain> _logger;
        private readonly UserManager _userManager;
        private readonly AuthManager _authManager;
        private System.Timers.Timer timer = new System.Timers.Timer();

        private Dictionary<string, Control> pageControls = new Dictionary<string, Control>
{
    { "����ģ��", Globals.ServiceProvider.GetRequiredService<PageTotalEquipmentControl>() },
    { "�û�ģ��", Globals.ServiceProvider.GetRequiredService<PageUserManage>() },
    { "Ȩ��ģ��", Globals.ServiceProvider.GetRequiredService<PageAuthManage>() },
    { "���ģ��1", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor3>() },
    { "���ģ��2", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor1>() },
    { "���ģ��3", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor2>() },
    { "�䷽ģ��", Globals.ServiceProvider.GetRequiredService<PageRecipeManage>() },
    { "��־ģ��", Globals.ServiceProvider.GetRequiredService<PageLogManage>() },
    { "����ģ��", Globals.ServiceProvider.GetRequiredService<PageReportManage>() },
    { "ͼ��ģ��", Globals.ServiceProvider.GetRequiredService<PageChartManage>() },
    { "����ģ��", Globals.ServiceProvider.GetRequiredService<PageSystemParameterSet>() }
};

        public FrmMain(ILogger<FrmMain> logge, UserManager userManager, AuthManager authManager)
        {
            this._logger = logge;

            InitializeComponent();
            Init();
            _userManager = userManager;
            _authManager = authManager;
            this.lbl_User.Text = "�ÿ�";
            //Globals.IniFile.Write("PLC����", "�������ַ", Application.StartupPath + "\\PLC_Var_Config.xlsx");

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
                        this.lbl_Temperature.Text = Globals.DataDic[this.lbl_Temperature.TagString].ToString() + "��";
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
            Globals.PlcVarConfigPath = Globals.IniFile.ReadString("PLC����", "�������ַ", Application.StartupPath + "\\PLC_Var_Config.xlsx");
            // ��ȡPLC��Ip��ַ
            Globals.IpAddress = Globals.IniFile.ReadString("PLC����", "PLC��ַ", "127.0.0.1");
            // ��ȡPLC�Ķ˿ں�
            Globals.Port = Globals.IniFile.ReadInt("PLC����", "PLC�˿�", 102);
            // ��ȡPLC��CPU����
            Globals.CpuType = Enum.Parse<SiemensVersion>(Globals.IniFile.ReadString("PLC����", "CPU����", "S7_1200"));
            // ��ȡPLC�Ĳ�ۺ�
            Globals.Slot = Globals.IniFile.ReadByte("PLC����", "��ۺ�", 0);
            // ��ȡPLC�Ļ��ܺ�
            Globals.Rack = Globals.IniFile.ReadByte("PLC����", "���ܺ�", 0);
            // ��ȡPLC�����ӳ�ʱʱ��
            Globals.ConnectTimeOut = Globals.IniFile.ReadInt("PLC����", "���ӳ�ʱʱ��", 3000);
            // ��ȡPLC�Ķ�ȡѭ��ʱ��
            Globals.ReadTimeInterval = Globals.IniFile.ReadInt("PLC����", "ѭ����ȡʱ��", 500);
            // ��ȡPLC������ʱ��
            Globals.ReConnectTimeInterval = Globals.IniFile.ReadInt("PLC����", "����ʱ��", 3000);
            _logger.LogInformation("��ȡ�����ļ��ɹ�");


        }

        private void InitPlcClient()
        {
            //  ��ȡ����·��

            // ����PLC����
            var plcVarList = MiniExcel.Query<PLCVarConfigModel>(Globals.PlcVarConfigPath).ToList();

            // ��ʼ��plc�ͻ��� ������
            Globals.SiemensClient = new IoTClient.Clients.PLC.SiemensClient(Globals.CpuType, Globals.IpAddress, Globals.Port, Globals.Slot, Globals.Rack, Globals.ConnectTimeOut);

            // ��һ������
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
                // ��ʼ��plc������ַ ��ַ-����
                Globals.ReadDic.Add(plcVarList[i].PLC��ַ, Enum.Parse<DataTypeEnum>(plcVarList[i].��������, true));
                // ��ʼ��plc����д�� ����-ֵ
                Globals.WriteDic.Add(plcVarList[i].����, plcVarList[i].PLC��ַ);
                // ��ʼ��plc������ȡ ����-ֵ
                Globals.DataDic.Add(plcVarList[i].����, "NA");
            }
            _logger.LogInformation("��ʼ��plc�ͻ��˳ɹ�");

            try
            {
                Task.Run(async () =>
                {
                    while (!cts.IsCancellationRequested)
                    {
                        if (plcIsConnected)
                        {
                            //������ȡ
                            var readResult = Globals.SiemensClient.BatchRead(Globals.ReadDic);
                            if (readResult.IsSucceed)
                            {
                                for (int i = 0; i < plcVarList.Count; i++)
                                {
                                    Globals.DataDic[plcVarList[i].����] = readResult.Value[plcVarList[i].PLC��ַ];
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
                            // ��������
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
            TreeNode parent0 = Aside.CreateNode("����ģ��", 361461, 34, pageIndex);
            Aside.CreateChildNode(parent0, AddPage(Globals.ServiceProvider.GetRequiredService<PageTotalEquipmentControl>(), ++pageIndex));

            TreeNode parent1 = Aside.CreateNode("�û�ģ��", 61447, 34, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(Globals.ServiceProvider.GetRequiredService<PageUserManage>(), ++pageIndex));
            Aside.CreateChildNode(parent1, AddPage(Globals.ServiceProvider.GetRequiredService<PageAuthManage>(), ++pageIndex));

            TreeNode parent2 = Aside.CreateNode("���ģ��", 560066, 34, pageIndex);
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor1>(), ++pageIndex));
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor2>(), ++pageIndex));
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor3>(), ++pageIndex));


            TreeNode parent3 = Aside.CreateNode("�䷽ģ��", 162677, 34, pageIndex);
            Aside.CreateChildNode(parent3, AddPage(Globals.ServiceProvider.GetRequiredService<PageRecipeManage>(), ++pageIndex));

            TreeNode parent4 = Aside.CreateNode("��־ģ��", 57557, 34, pageIndex);
            Aside.CreateChildNode(parent4, AddPage(Globals.ServiceProvider.GetRequiredService<PageLogManage>(), ++pageIndex));

            TreeNode parent5 = Aside.CreateNode("����ģ��", 57586, 34, pageIndex);
            Aside.CreateChildNode(parent5, AddPage(Globals.ServiceProvider.GetRequiredService<PageReportManage>(), ++pageIndex));

            TreeNode parent6 = Aside.CreateNode("ͼ��ģ��", 61950, 34, pageIndex);
            Aside.CreateChildNode(parent6, AddPage(Globals.ServiceProvider.GetRequiredService<PageChartManage>(), ++pageIndex));

            TreeNode parent7 = Aside.CreateNode("����ģ��", 559576, 34, pageIndex);
            Aside.CreateChildNode(parent7, AddPage(Globals.ServiceProvider.GetRequiredService<PageSystemParameterSet>(), ++pageIndex));

            _logger.LogInformation("�������ʼ�����");
        }

        private void InitHeaderUI()
        {
            //���ù���
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

            //��ȡö��FontsType��������������
            for (int i = 0; i < Enum.GetValues(typeof(SystemEnums.FontsType)).Length; i++)
            {
                Header.CreateChildNode(Header.Nodes[1], Enum.GetName(typeof(SystemEnums.FontsType), i), i + 1);
            }

            //��ȡö��FontSize�����������С  75-125�ķ�Χ 75 80 85 90 95 100 105 110 115 120 125
            for (int i = 75; i <= 125; i += 5)
            {
                Header.CreateChildNode(Header.Nodes[2], i.ToString(), i);
            }
            _logger.LogInformation("ͷ���˵���ʼ�����");


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
            // ��С��
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            // �ر�
            this.Close();
        }

        // �ƶ�����
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
            //��Aside�۵�����
            Aside.CollapseAll();
            Aside.SelectFirst();

            var frmLogin = Globals.ServiceProvider.GetRequiredService<FrmLogin>();
            frmLogin.ShowDialog();
            if (frmLogin.IsLogin)
            {
                //���µ�¼�û�
                this.lbl_User.Text = frmLogin.UserName;
                foreach (var control in pageControls.Values)
                {
                    control.Enabled = true;
                }
            }

        }

        private async void Aside_BeforeExpandAsync(object sender, TreeViewCancelEventArgs e) //�첽չ��
        {
            UINavMenu uINavMenu = sender as UINavMenu;

            string moduleName = e.Node.Text; //ģ������

            string user = this.lbl_User.Text;
            var roleRes = await _userManager.GetUserAuthAsync(new QueryUserAuthDto() { UserName = user });

            if (roleRes.Status == SystemEnums.Result.Success)
            {
                if (roleRes.Data[0].Role != "����Ա")
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
                case "����ģ��":
                    pageControls["����ģ��"].Enabled = authDto.ControlModule;
                    break;

                case "�û�ģ��":
                    pageControls["�û�ģ��"].Enabled = false;
                    pageControls["Ȩ��ģ��"].Enabled = false;
                    break;

                case "���ģ��":
                    pageControls["���ģ��3"].Enabled = authDto.MonitorModule;
                    pageControls["���ģ��1"].Enabled = authDto.MonitorModule;
                    pageControls["���ģ��2"].Enabled = authDto.MonitorModule;
                    break;

                case "�䷽ģ��":
                    pageControls["�䷽ģ��"].Enabled = authDto.RecipeModule;
                    break;

                case "��־ģ��":
                    pageControls["��־ģ��"].Enabled = authDto.LogModule;
                    break;

                case "����ģ��":
                    pageControls["����ģ��"].Enabled = authDto.ReportModule;
                    break;

                case "ͼ��ģ��":
                    pageControls["ͼ��ģ��"].Enabled = authDto.ChartModule;
                    break;

                case "����ģ��":
                    pageControls["����ģ��"].Enabled = authDto.ParamModule;
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
