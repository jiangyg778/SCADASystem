using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ya.SprayProcessSCADASystem
{
    public partial class PageReportManage : UIPage, ISingletonSelfDependency
    {
        // 报表页面
        public PageReportManage()
        {
            InitializeComponent();
        }
    }
}
