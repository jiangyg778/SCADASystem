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
    public partial class PageRecipeManage : UIPage, ISingletonSelfDependency
    {
        // 配方页面
        public PageRecipeManage()
        {
            InitializeComponent();
        }
    }
}
