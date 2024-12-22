using Sunny.UI;

namespace Ya.SprayProcessSCADASystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame
    {
        public FrmMain()
        {
            InitializeComponent();

            //设置初始页面索引（关联页面，唯一不重复即可）
            int pageIndex = 1000;

            TreeNode parent = Aside.CreateNode("监控模块", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor1(), ++pageIndex));

            TreeNode parent1 = Aside.CreateNode("总控模块", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(new PageTotalEquipmentControl(), ++pageIndex));


        }

      
    }
}
