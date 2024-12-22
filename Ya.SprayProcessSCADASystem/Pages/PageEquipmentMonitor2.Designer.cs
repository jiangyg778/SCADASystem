namespace Ya.SprayProcessSCADASystem.Pages
{
    partial class PageEquipmentMonitor2
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
            userAlarmState5 = new UserAlarmState();
            userAlarmState6 = new UserAlarmState();
            userAlarmState4 = new UserAlarmState();
            userAlarmState2 = new UserAlarmState();
            userVarCurrentValue1 = new UserVarCurrentValue();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue2 = new UserVarCurrentValue();
            userDeviceState2 = new UserDeviceState();
            userDeviceState3 = new UserDeviceState();
            userAlarmState1 = new UserAlarmState();
            userAlarmState3 = new UserAlarmState();
            userAlarmState7 = new UserAlarmState();
            userAlarmState8 = new UserAlarmState();
            userAlarmState9 = new UserAlarmState();
            userAlarmState10 = new UserAlarmState();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            userAlarmState15 = new UserAlarmState();
            userAlarmState16 = new UserAlarmState();
            userDeviceState5 = new UserDeviceState();
            uiTitlePanel1.SuspendLayout();
            userAlarmState5.SuspendLayout();
            userAlarmState2.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            userAlarmState1.SuspendLayout();
            userAlarmState7.SuspendLayout();
            userAlarmState9.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            userAlarmState15.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userVarCurrentValue1);
            uiTitlePanel1.Controls.Add(userAlarmState5);
            uiTitlePanel1.Controls.Add(userAlarmState2);
            uiTitlePanel1.Controls.Add(userDeviceState1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(9, 7);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1059, 167);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "精洗工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceState1
            // 
            userDeviceState1.DeviceRunName = "精洗洗喷淋泵运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState1.Location = new Point(12, 36);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(297, 60);
            userDeviceState1.State = false;
            userDeviceState1.TabIndex = 0;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "精洗洗喷淋泵运行状态";
            // 
            // userAlarmState5
            // 
            userAlarmState5.Controls.Add(userAlarmState6);
            userAlarmState5.DeviceName = "精洗喷淋泵过载报警";
            userAlarmState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState5.Location = new Point(761, 36);
            userAlarmState5.MinimumSize = new Size(1, 1);
            userAlarmState5.Name = "userAlarmState5";
            userAlarmState5.RectColor = Color.Transparent;
            userAlarmState5.Size = new Size(270, 60);
            userAlarmState5.State = true;
            userAlarmState5.TabIndex = 1;
            userAlarmState5.Text = "userAlarmState1";
            userAlarmState5.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState5.VariableName = "精洗喷淋泵过载报警";
            // 
            // userAlarmState6
            // 
            userAlarmState6.DeviceName = "精洗低液位报警";
            userAlarmState6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState6.Location = new Point(207, 38);
            userAlarmState6.MinimumSize = new Size(1, 1);
            userAlarmState6.Name = "userAlarmState6";
            userAlarmState6.RectColor = Color.Transparent;
            userAlarmState6.Size = new Size(269, 60);
            userAlarmState6.State = true;
            userAlarmState6.TabIndex = 2;
            userAlarmState6.Text = "userAlarmState1";
            userAlarmState6.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState6.VariableName = "精洗低液位报警";
            // 
            // userAlarmState4
            // 
            userAlarmState4.DeviceName = "精洗低液位报警";
            userAlarmState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState4.Location = new Point(207, 38);
            userAlarmState4.MinimumSize = new Size(1, 1);
            userAlarmState4.Name = "userAlarmState4";
            userAlarmState4.RectColor = Color.Transparent;
            userAlarmState4.Size = new Size(269, 60);
            userAlarmState4.State = true;
            userAlarmState4.TabIndex = 2;
            userAlarmState4.Text = "userAlarmState1";
            userAlarmState4.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState4.VariableName = "精洗低液位报警";
            // 
            // userAlarmState2
            // 
            userAlarmState2.Controls.Add(userAlarmState4);
            userAlarmState2.DeviceName = "精洗低液位报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState2.Location = new Point(407, 36);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.RectColor = Color.Transparent;
            userAlarmState2.Size = new Size(269, 60);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 1;
            userAlarmState2.Text = "userAlarmState1";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "精洗低液位报警";
            // 
            // userVarCurrentValue1
            // 
            userVarCurrentValue1.DeviceVarName = "精洗喷淋泵压力值";
            userVarCurrentValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue1.Location = new Point(328, 102);
            userVarCurrentValue1.MinimumSize = new Size(1, 1);
            userVarCurrentValue1.Name = "userVarCurrentValue1";
            userVarCurrentValue1.Size = new Size(401, 47);
            userVarCurrentValue1.TabIndex = 2;
            userVarCurrentValue1.Text = "userVarCurrentValue1";
            userVarCurrentValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue1.Unit = "Mpa";
            userVarCurrentValue1.VariableName = "精洗喷淋泵压力值";
            userVarCurrentValue1.VarValue = 0F;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userAlarmState9);
            uiTitlePanel2.Controls.Add(userAlarmState7);
            uiTitlePanel2.Controls.Add(userAlarmState1);
            uiTitlePanel2.Controls.Add(userDeviceState3);
            uiTitlePanel2.Controls.Add(userVarCurrentValue2);
            uiTitlePanel2.Controls.Add(userDeviceState2);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(9, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1059, 167);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "精洗工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue2
            // 
            userVarCurrentValue2.DeviceVarName = "水分炉测量温度";
            userVarCurrentValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue2.Location = new Point(28, 110);
            userVarCurrentValue2.MinimumSize = new Size(1, 1);
            userVarCurrentValue2.Name = "userVarCurrentValue2";
            userVarCurrentValue2.Size = new Size(392, 44);
            userVarCurrentValue2.TabIndex = 2;
            userVarCurrentValue2.Text = "userVarCurrentValue2";
            userVarCurrentValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue2.Unit = "℃";
            userVarCurrentValue2.VariableName = "水分炉测量温度";
            userVarCurrentValue2.VarValue = 0F;
            // 
            // userDeviceState2
            // 
            userDeviceState2.DeviceRunName = "水分炉变频器运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState2.Location = new Point(12, 36);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(297, 60);
            userDeviceState2.State = false;
            userDeviceState2.TabIndex = 0;
            userDeviceState2.Text = "userDeviceState2";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "水分炉变频器运行状态";
            // 
            // userDeviceState3
            // 
            userDeviceState3.DeviceRunName = "水分炉炉口风帘风机运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState3.Location = new Point(372, 36);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(346, 60);
            userDeviceState3.State = false;
            userDeviceState3.TabIndex = 3;
            userDeviceState3.Text = "userDeviceState3";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "水分炉炉口风帘风机运行状态";
            // 
            // userAlarmState1
            // 
            userAlarmState1.Controls.Add(userAlarmState3);
            userAlarmState1.DeviceName = "水分炉温度报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState1.Location = new Point(781, 36);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.RectColor = Color.Transparent;
            userAlarmState1.Size = new Size(250, 60);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 4;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "水分炉温度报警";
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "精洗低液位报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState3.Location = new Point(207, 38);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.RectColor = Color.Transparent;
            userAlarmState3.Size = new Size(269, 60);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 2;
            userAlarmState3.Text = "userAlarmState1";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "精洗低液位报警";
            // 
            // userAlarmState7
            // 
            userAlarmState7.Controls.Add(userAlarmState8);
            userAlarmState7.DeviceName = "水分炉燃烧机报警";
            userAlarmState7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState7.Location = new Point(465, 102);
            userAlarmState7.MinimumSize = new Size(1, 1);
            userAlarmState7.Name = "userAlarmState7";
            userAlarmState7.RectColor = Color.Transparent;
            userAlarmState7.Size = new Size(250, 60);
            userAlarmState7.State = true;
            userAlarmState7.TabIndex = 5;
            userAlarmState7.Text = "userAlarmState7";
            userAlarmState7.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState7.VariableName = "水分炉燃烧机报警";
            // 
            // userAlarmState8
            // 
            userAlarmState8.DeviceName = "精洗低液位报警";
            userAlarmState8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState8.Location = new Point(207, 38);
            userAlarmState8.MinimumSize = new Size(1, 1);
            userAlarmState8.Name = "userAlarmState8";
            userAlarmState8.RectColor = Color.Transparent;
            userAlarmState8.Size = new Size(269, 60);
            userAlarmState8.State = true;
            userAlarmState8.TabIndex = 2;
            userAlarmState8.Text = "userAlarmState1";
            userAlarmState8.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState8.VariableName = "精洗低液位报警";
            // 
            // userAlarmState9
            // 
            userAlarmState9.Controls.Add(userAlarmState10);
            userAlarmState9.DeviceName = "水分炉煤气泄漏报警";
            userAlarmState9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState9.Location = new Point(760, 102);
            userAlarmState9.MinimumSize = new Size(1, 1);
            userAlarmState9.Name = "userAlarmState9";
            userAlarmState9.RectColor = Color.Transparent;
            userAlarmState9.Size = new Size(270, 60);
            userAlarmState9.State = true;
            userAlarmState9.TabIndex = 5;
            userAlarmState9.Text = "userAlarmState9";
            userAlarmState9.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState9.VariableName = "水分炉煤气泄漏报警";
            // 
            // userAlarmState10
            // 
            userAlarmState10.DeviceName = "精洗低液位报警";
            userAlarmState10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState10.Location = new Point(207, 38);
            userAlarmState10.MinimumSize = new Size(1, 1);
            userAlarmState10.Name = "userAlarmState10";
            userAlarmState10.RectColor = Color.Transparent;
            userAlarmState10.Size = new Size(269, 60);
            userAlarmState10.State = true;
            userAlarmState10.TabIndex = 2;
            userAlarmState10.Text = "userAlarmState1";
            userAlarmState10.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState10.VariableName = "精洗低液位报警";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(userAlarmState15);
            uiTitlePanel3.Controls.Add(userDeviceState5);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.Location = new Point(9, 371);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(1059, 167);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "冷却室工位";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState15
            // 
            userAlarmState15.Controls.Add(userAlarmState16);
            userAlarmState15.DeviceName = "冷却室离心风机过载报警";
            userAlarmState15.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState15.Location = new Point(650, 79);
            userAlarmState15.MinimumSize = new Size(1, 1);
            userAlarmState15.Name = "userAlarmState15";
            userAlarmState15.RectColor = Color.Transparent;
            userAlarmState15.Size = new Size(307, 60);
            userAlarmState15.State = true;
            userAlarmState15.TabIndex = 4;
            userAlarmState15.Text = "userAlarmState15";
            userAlarmState15.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState15.VariableName = "冷却室离心风机过载报警";
            // 
            // userAlarmState16
            // 
            userAlarmState16.DeviceName = "精洗低液位报警";
            userAlarmState16.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState16.Location = new Point(207, 38);
            userAlarmState16.MinimumSize = new Size(1, 1);
            userAlarmState16.Name = "userAlarmState16";
            userAlarmState16.RectColor = Color.Transparent;
            userAlarmState16.Size = new Size(269, 60);
            userAlarmState16.State = true;
            userAlarmState16.TabIndex = 2;
            userAlarmState16.Text = "userAlarmState1";
            userAlarmState16.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState16.VariableName = "精洗低液位报警";
            // 
            // userDeviceState5
            // 
            userDeviceState5.DeviceRunName = "冷却室离心风机运行状态";
            userDeviceState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState5.Location = new Point(57, 79);
            userDeviceState5.MinimumSize = new Size(1, 1);
            userDeviceState5.Name = "userDeviceState5";
            userDeviceState5.RectColor = Color.Transparent;
            userDeviceState5.Size = new Size(346, 60);
            userDeviceState5.State = false;
            userDeviceState5.TabIndex = 0;
            userDeviceState5.Text = "userDeviceState5";
            userDeviceState5.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState5.VariableName = "冷却室离心风机运行状态";
            // 
            // PageEquipmentMonitor2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor2";
            Text = "PageEquipmentMonitor2";
            uiTitlePanel1.ResumeLayout(false);
            userAlarmState5.ResumeLayout(false);
            userAlarmState2.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            userAlarmState1.ResumeLayout(false);
            userAlarmState7.ResumeLayout(false);
            userAlarmState9.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            userAlarmState15.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserDeviceState userDeviceState1;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserAlarmState userAlarmState5;
        private UserAlarmState userAlarmState6;
        private UserAlarmState userAlarmState2;
        private UserAlarmState userAlarmState4;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserAlarmState userAlarmState1;
        private UserAlarmState userAlarmState3;
        private UserDeviceState userDeviceState3;
        private UserVarCurrentValue userVarCurrentValue2;
        private UserDeviceState userDeviceState2;
        private UserAlarmState userAlarmState9;
        private UserAlarmState userAlarmState10;
        private UserAlarmState userAlarmState7;
        private UserAlarmState userAlarmState8;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private UserAlarmState userAlarmState15;
        private UserAlarmState userAlarmState16;
        private UserDeviceState userDeviceState5;
    }
}