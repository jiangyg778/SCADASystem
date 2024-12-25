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
        List<Control> controls;
        //  监控界面1
        public PageEquipmentMonitor1()
        {
            InitializeComponent();
            controls = Globals.GetAllControls(this);
            this.timer1.Interval = 5000;
            this.timer1.Tick += Timer1_Tick;
            this.timer1.Start();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            if (Globals.SiemensClient.Connected)
            {
                foreach (Control control in controls)
                {
                    if (control is UserDeviceState userDeviceState)
                    {
                        userDeviceState.State = Globals.DataDic[userDeviceState.VariableName].ToString() == "1" ? true : false;
                    }
                    else if (control is UserVarCurrentValue userVarCurrentValue)
                    {
                        // 读取变量值
                        userVarCurrentValue.VarValue = Globals.DataDic[userVarCurrentValue.VariableName].ToString().ToFloat();
                    }
                    else if (control is UserAlarmState userAlarmState)
                    {
                        // 读取报警状态
                        userAlarmState.State = Globals.DataDic[userAlarmState.VariableName].ToString() != "1";
                    }
                }
            }
        }

       
    }
}
