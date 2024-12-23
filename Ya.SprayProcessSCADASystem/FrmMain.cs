using HZY.Framework.DependencyInjection;
using IoTClient.Common.Enums;
using IoTClient.Enums;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using Sunny.UI;
using System.IO.Pipelines;
using Ya.Helper;
using Ya.Model;
using Ya.SprayProcessSCADASystem.Pages;

namespace Ya.SprayProcessSCADASystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency
    {
        public FrmMain()
        {
            InitializeComponent();

            //Globals.IniFile.Write("PLC����", "�������ַ", Application.StartupPath + "\\PLC_Var_Config.xlsx");
            InitConfig();
            InitAsideUI();
            InitHeaderUI();
            InitPlcClient();
        }

        private bool plcIsConnected = false; // plc�Ƿ�����
        private CancellationTokenSource cts = new CancellationTokenSource();

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
    }
}
