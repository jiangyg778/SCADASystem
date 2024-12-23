using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Sunny.UI;
using Ya.Helper;
using Ya.SprayProcessSCADASystem.Pages;

namespace Ya.SprayProcessSCADASystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency
    {
        public FrmMain()
        {
            InitializeComponent();
            InitAsideUI();
            InitHeaderUI();
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

    }
}
