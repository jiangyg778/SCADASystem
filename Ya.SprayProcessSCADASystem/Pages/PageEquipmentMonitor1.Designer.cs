namespace Ya.SprayProcessSCADASystem
{
    partial class PageEquipmentMonitor1
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
            userVarCurrentValue2 = new UserVarCurrentValue();
            userVarCurrentValue1 = new UserVarCurrentValue();
            userAlarmState1 = new UserAlarmState();
            userDeviceState2 = new UserDeviceState();
            userDeviceState1 = new UserDeviceState();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue4 = new UserVarCurrentValue();
            userAlarmState3 = new UserAlarmState();
            userAlarmState2 = new UserAlarmState();
            userDeviceState4 = new UserDeviceState();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue5 = new UserVarCurrentValue();
            userDeviceState5 = new UserDeviceState();
            userVarCurrentValue3 = new UserVarCurrentValue();
            userAlarmState4 = new UserAlarmState();
            userAlarmState5 = new UserAlarmState();
            userDeviceState3 = new UserDeviceState();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
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
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "脱脂低液位报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState1.Location = new Point(784, 36);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.RectColor = Color.Transparent;
            userAlarmState1.Size = new Size(250, 60);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 1;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "脱脂低液位报警";
            // 
            // userDeviceState2
            // 
            userDeviceState2.DeviceRunName = "脱脂排风机运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState2.Location = new Point(385, 36);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(260, 60);
            userDeviceState2.State = false;
            userDeviceState2.TabIndex = 0;
            userDeviceState2.Text = "userDeviceState1";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "脱脂排风机运行状态";
            // 
            // userDeviceState1
            // 
            userDeviceState1.DeviceRunName = "脱脂喷淋泵运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState1.Location = new Point(12, 36);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(260, 60);
            userDeviceState1.State = false;
            userDeviceState1.TabIndex = 0;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "脱脂喷淋泵运行状态";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userVarCurrentValue4);
            uiTitlePanel2.Controls.Add(userAlarmState3);
            uiTitlePanel2.Controls.Add(userAlarmState2);
            uiTitlePanel2.Controls.Add(userDeviceState4);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(9, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1059, 167);
            uiTitlePanel2.TabIndex = 0;
            uiTitlePanel2.Text = "粗洗工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue4
            // 
            userVarCurrentValue4.DeviceVarName = "粗洗喷淋泵压力值";
            userVarCurrentValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue4.Location = new Point(122, 102);
            userVarCurrentValue4.MinimumSize = new Size(1, 1);
            userVarCurrentValue4.Name = "userVarCurrentValue4";
            userVarCurrentValue4.Size = new Size(414, 47);
            userVarCurrentValue4.TabIndex = 2;
            userVarCurrentValue4.Text = "userVarCurrentValue1";
            userVarCurrentValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue4.Unit = "Mpa";
            userVarCurrentValue4.VariableName = "粗洗喷淋泵压力值";
            userVarCurrentValue4.VarValue = 0F;
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "粗洗低液位报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState3.Location = new Point(395, 36);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.RectColor = Color.Transparent;
            userAlarmState3.Size = new Size(250, 60);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 1;
            userAlarmState3.Text = "userAlarmState1";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "粗洗低液位报警";
            // 
            // userAlarmState2
            // 
            userAlarmState2.DeviceName = "粗洗低液位报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState2.Location = new Point(784, 36);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.RectColor = Color.Transparent;
            userAlarmState2.Size = new Size(250, 60);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 1;
            userAlarmState2.Text = "userAlarmState1";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "粗洗低液位报警";
            // 
            // userDeviceState4
            // 
            userDeviceState4.DeviceRunName = "粗洗喷淋泵运行状态";
            userDeviceState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState4.Location = new Point(12, 36);
            userDeviceState4.MinimumSize = new Size(1, 1);
            userDeviceState4.Name = "userDeviceState4";
            userDeviceState4.RectColor = Color.Transparent;
            userDeviceState4.Size = new Size(260, 60);
            userDeviceState4.State = false;
            userDeviceState4.TabIndex = 0;
            userDeviceState4.Text = "userDeviceState1";
            userDeviceState4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState4.VariableName = "粗洗喷淋泵运行状态";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(userVarCurrentValue5);
            uiTitlePanel3.Controls.Add(userDeviceState5);
            uiTitlePanel3.Controls.Add(userVarCurrentValue3);
            uiTitlePanel3.Controls.Add(userAlarmState4);
            uiTitlePanel3.Controls.Add(userAlarmState5);
            uiTitlePanel3.Controls.Add(userDeviceState3);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.Location = new Point(9, 371);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(1059, 167);
            uiTitlePanel3.TabIndex = 0;
            uiTitlePanel3.Text = "陶化工位";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue5
            // 
            userVarCurrentValue5.DeviceVarName = "陶化pH值";
            userVarCurrentValue5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue5.Location = new Point(584, 92);
            userVarCurrentValue5.MinimumSize = new Size(1, 1);
            userVarCurrentValue5.Name = "userVarCurrentValue5";
            userVarCurrentValue5.Size = new Size(395, 44);
            userVarCurrentValue5.TabIndex = 3;
            userVarCurrentValue5.Text = "userVarCurrentValue1";
            userVarCurrentValue5.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue5.Unit = "Mpa";
            userVarCurrentValue5.VariableName = "陶化pH值";
            userVarCurrentValue5.VarValue = 0F;
            // 
            // userDeviceState5
            // 
            userDeviceState5.DeviceRunName = "陶化排风机运行状态";
            userDeviceState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState5.Location = new Point(278, 36);
            userDeviceState5.MinimumSize = new Size(1, 1);
            userDeviceState5.Name = "userDeviceState5";
            userDeviceState5.RectColor = Color.Transparent;
            userDeviceState5.Size = new Size(258, 60);
            userDeviceState5.State = false;
            userDeviceState5.TabIndex = 1;
            userDeviceState5.Text = "userDeviceState1";
            userDeviceState5.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState5.VariableName = "陶化排风机运行状态";
            // 
            // userVarCurrentValue3
            // 
            userVarCurrentValue3.DeviceVarName = "粗洗喷淋泵压力值";
            userVarCurrentValue3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue3.Location = new Point(130, 92);
            userVarCurrentValue3.MinimumSize = new Size(1, 1);
            userVarCurrentValue3.Name = "userVarCurrentValue3";
            userVarCurrentValue3.Size = new Size(406, 44);
            userVarCurrentValue3.TabIndex = 2;
            userVarCurrentValue3.Text = "userVarCurrentValue1";
            userVarCurrentValue3.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue3.Unit = "Mpa";
            userVarCurrentValue3.VariableName = "粗洗喷淋泵压力值";
            userVarCurrentValue3.VarValue = 0F;
            // 
            // userAlarmState4
            // 
            userAlarmState4.DeviceName = "陶化喷淋泵过载报警";
            userAlarmState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState4.Location = new Point(531, 36);
            userAlarmState4.MinimumSize = new Size(1, 1);
            userAlarmState4.Name = "userAlarmState4";
            userAlarmState4.RectColor = Color.Transparent;
            userAlarmState4.Size = new Size(269, 60);
            userAlarmState4.State = true;
            userAlarmState4.TabIndex = 1;
            userAlarmState4.Text = "userAlarmState1";
            userAlarmState4.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState4.VariableName = "陶化喷淋泵过载报警";
            // 
            // userAlarmState5
            // 
            userAlarmState5.DeviceName = "陶化低液位报警";
            userAlarmState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState5.Location = new Point(784, 36);
            userAlarmState5.MinimumSize = new Size(1, 1);
            userAlarmState5.Name = "userAlarmState5";
            userAlarmState5.RectColor = Color.Transparent;
            userAlarmState5.Size = new Size(269, 60);
            userAlarmState5.State = true;
            userAlarmState5.TabIndex = 1;
            userAlarmState5.Text = "userAlarmState1";
            userAlarmState5.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState5.VariableName = "陶化低液位报警";
            // 
            // userDeviceState3
            // 
            userDeviceState3.DeviceRunName = "陶化喷淋泵运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState3.Location = new Point(3, 36);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(260, 60);
            userDeviceState3.State = false;
            userDeviceState3.TabIndex = 0;
            userDeviceState3.Text = "userDeviceState1";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "陶化喷淋泵运行状态";
            // 
            // PageEquipmentMonitor1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor1";
            Symbol = 57397;
            Text = "设备监控1";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserDeviceState userDeviceState2;
        private UserDeviceState userDeviceState1;
        private UserVarCurrentValue userVarCurrentValue2;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserAlarmState userAlarmState1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserVarCurrentValue userVarCurrentValue4;
        private UserAlarmState userAlarmState2;
        private UserDeviceState userDeviceState4;
        private UserAlarmState userAlarmState3;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private UserDeviceState userDeviceState5;
        private UserVarCurrentValue userVarCurrentValue3;
        private UserAlarmState userAlarmState4;
        private UserAlarmState userAlarmState5;
        private UserDeviceState userDeviceState3;
        private UserVarCurrentValue userVarCurrentValue5;
    }
}