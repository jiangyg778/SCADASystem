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
    public partial class PageEquipmentMonitor1 : UIPage, ISingletonSelfDependency
    {
        //  监控界面1
        public PageEquipmentMonitor1()
        {
            InitializeComponent();
        }

        private void userDeviceUnitControl1_ClickEvent(object sender, EventArgs e)
        {

        }
    }
}
