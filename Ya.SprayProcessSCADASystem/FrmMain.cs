using Sunny.UI;

namespace Ya.SprayProcessSCADASystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame
    {
        public FrmMain()
        {
            InitializeComponent();

            //���ó�ʼҳ������������ҳ�棬Ψһ���ظ����ɣ�
            int pageIndex = 1000;

            TreeNode parent = Aside.CreateNode("���ģ��", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor1(), ++pageIndex));

            TreeNode parent1 = Aside.CreateNode("�ܿ�ģ��", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(new PageTotalEquipmentControl(), ++pageIndex));


        }

      
    }
}
