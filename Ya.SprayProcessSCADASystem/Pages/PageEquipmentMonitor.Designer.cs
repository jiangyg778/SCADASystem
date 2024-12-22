namespace Ya.SprayProcessSCADASystem
{
    partial class PageEquipmentMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            userDeviceState1 = new UserDeviceState();
            userDeviceState2 = new UserDeviceState();
            userAlarmState1 = new UserAlarmState();
            userVarCurrentValue1 = new UserVarCurrentValue();
            userVarCurrentValue2 = new UserVarCurrentValue();
            uiTitlePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userVarCurrentValue2);
            uiTitlePanel1.Controls.Add(userVarCurrentValue1);
            uiTitlePanel1.Controls.Add(userAlarmState1);
            uiTitlePanel1.Controls.Add(userDeviceState2);
            uiTitlePanel1.Controls.Add(userDeviceState1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(9, 7);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1059, 167);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "脱脂工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceState1
            // 
            userDeviceState1.DeviceRunName = "脱脂喷淋泵运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState1.Location = new Point(12, 36);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.Size = new Size(260, 60);
            userDeviceState1.State = false;
            userDeviceState1.TabIndex = 0;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "脱脂喷淋泵运行状态";
            // 
            // userDeviceState2
            // 
            userDeviceState2.DeviceRunName = "脱脂排风机运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState2.Location = new Point(385, 36);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.Size = new Size(260, 60);
            userDeviceState2.State = false;
            userDeviceState2.TabIndex = 0;
            userDeviceState2.Text = "userDeviceState1";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "脱脂排风机运行状态";
            // 
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "脱脂低液位报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState1.Location = new Point(784, 36);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.Size = new Size(250, 60);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 1;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "脱脂低液位报警";
            // 
            // userVarCurrentValue1
            // 
            userVarCurrentValue1.DeviceVarName = "脱脂喷淋泵压力值";
            userVarCurrentValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue1.Location = new Point(122, 102);
            userVarCurrentValue1.MinimumSize = new Size(1, 1);
            userVarCurrentValue1.Name = "userVarCurrentValue1";
            userVarCurrentValue1.Size = new Size(414, 47);
            userVarCurrentValue1.TabIndex = 2;
            userVarCurrentValue1.Text = "userVarCurrentValue1";
            userVarCurrentValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue1.Unit = "Mpa";
            userVarCurrentValue1.VariableName = "脱脂喷淋泵压力值";
            userVarCurrentValue1.VarValue = 0F;
            // 
            // userVarCurrentValue2
            // 
            userVarCurrentValue2.DeviceVarName = "脱脂pH值";
            userVarCurrentValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue2.Location = new Point(542, 102);
            userVarCurrentValue2.MinimumSize = new Size(1, 1);
            userVarCurrentValue2.Name = "userVarCurrentValue2";
            userVarCurrentValue2.Size = new Size(437, 47);
            userVarCurrentValue2.TabIndex = 2;
            userVarCurrentValue2.Text = "userVarCurrentValue1";
            userVarCurrentValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue2.Unit = "PH";
            userVarCurrentValue2.VariableName = "脱脂pH值";
            userVarCurrentValue2.VarValue = 0F;
            // 
            // PageEquipmentMonitor
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor";
            Symbol = 57397;
            Text = "设备监控";
            uiTitlePanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserDeviceState userDeviceState2;
        private UserDeviceState userDeviceState1;
        private UserVarCurrentValue userVarCurrentValue2;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserAlarmState userAlarmState1;
    }
}