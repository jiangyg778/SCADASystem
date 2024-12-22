namespace Ya.SprayProcessSCADASystem.Pages
{
    partial class PageEquipmentMonitor3
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
            userAlarmState2 = new UserAlarmState();
            userAlarmState3 = new UserAlarmState();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userAlarmState5 = new UserAlarmState();
            userAlarmState6 = new UserAlarmState();
            userDeviceState4 = new UserDeviceState();
            userDeviceState3 = new UserDeviceState();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userAlarmState3);
            uiTitlePanel1.Controls.Add(userAlarmState2);
            uiTitlePanel1.Controls.Add(userVarCurrentValue1);
            uiTitlePanel1.Controls.Add(userAlarmState1);
            uiTitlePanel1.Controls.Add(userDeviceState2);
            uiTitlePanel1.Controls.Add(userDeviceState1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.ImeMode = ImeMode.NoControl;
            uiTitlePanel1.Location = new Point(9, 7);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1059, 167);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "固化炉工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceState1
            // 
            userDeviceState1.DeviceRunName = "固化炉变频器运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState1.Location = new Point(12, 36);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(325, 60);
            userDeviceState1.State = false;
            userDeviceState1.TabIndex = 0;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "固化炉变频器运行状态";
            // 
            // userDeviceState2
            // 
            userDeviceState2.DeviceRunName = "固化炉炉口风帘风机运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState2.Location = new Point(363, 36);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(350, 60);
            userDeviceState2.State = false;
            userDeviceState2.TabIndex = 1;
            userDeviceState2.Text = "userDeviceState2";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "固化炉炉口风帘风机运行状态";
            // 
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "固化炉煤气泄漏报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState1.Location = new Point(745, 36);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.RectColor = Color.Transparent;
            userAlarmState1.Size = new Size(263, 60);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 2;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "固化炉煤气泄漏报警";
            // 
            // userVarCurrentValue1
            // 
            userVarCurrentValue1.DeviceVarName = "固化炉测量温度";
            userVarCurrentValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue1.Location = new Point(12, 105);
            userVarCurrentValue1.MinimumSize = new Size(1, 1);
            userVarCurrentValue1.Name = "userVarCurrentValue1";
            userVarCurrentValue1.Size = new Size(448, 47);
            userVarCurrentValue1.TabIndex = 3;
            userVarCurrentValue1.Text = "userVarCurrentValue1";
            userVarCurrentValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue1.Unit = "℃";
            userVarCurrentValue1.VariableName = "固化炉测量温度";
            userVarCurrentValue1.VarValue = 0F;
            // 
            // userAlarmState2
            // 
            userAlarmState2.DeviceName = "固化炉燃烧机报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState2.Location = new Point(463, 102);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.RectColor = Color.Transparent;
            userAlarmState2.Size = new Size(263, 60);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 4;
            userAlarmState2.Text = "userAlarmState2";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "固化炉燃烧机报警";
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "固化炉温度报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState3.Location = new Point(745, 102);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.RectColor = Color.Transparent;
            userAlarmState3.Size = new Size(263, 60);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 5;
            userAlarmState3.Text = "userAlarmState3";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "固化炉温度报警";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userDeviceState3);
            uiTitlePanel2.Controls.Add(userAlarmState5);
            uiTitlePanel2.Controls.Add(userAlarmState6);
            uiTitlePanel2.Controls.Add(userDeviceState4);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.ImeMode = ImeMode.NoControl;
            uiTitlePanel2.Location = new Point(9, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1059, 167);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "输送机工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState5
            // 
            userAlarmState5.DeviceName = "输送机行程报警";
            userAlarmState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState5.Location = new Point(463, 102);
            userAlarmState5.MinimumSize = new Size(1, 1);
            userAlarmState5.Name = "userAlarmState5";
            userAlarmState5.RectColor = Color.Transparent;
            userAlarmState5.Size = new Size(289, 60);
            userAlarmState5.State = true;
            userAlarmState5.TabIndex = 4;
            userAlarmState5.Text = "userAlarmState5";
            userAlarmState5.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState5.VariableName = "输送机行程报警";
            // 
            // userAlarmState6
            // 
            userAlarmState6.DeviceName = "输送机变频器故障报警";
            userAlarmState6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState6.Location = new Point(463, 36);
            userAlarmState6.MinimumSize = new Size(1, 1);
            userAlarmState6.Name = "userAlarmState6";
            userAlarmState6.RectColor = Color.Transparent;
            userAlarmState6.Size = new Size(289, 60);
            userAlarmState6.State = true;
            userAlarmState6.TabIndex = 2;
            userAlarmState6.Text = "userAlarmState6";
            userAlarmState6.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState6.VariableName = "输送机变频器故障报警";
            // 
            // userDeviceState4
            // 
            userDeviceState4.DeviceRunName = "输送机变频器电源状态";
            userDeviceState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState4.Location = new Point(12, 36);
            userDeviceState4.MinimumSize = new Size(1, 1);
            userDeviceState4.Name = "userDeviceState4";
            userDeviceState4.RectColor = Color.Transparent;
            userDeviceState4.Size = new Size(325, 60);
            userDeviceState4.State = false;
            userDeviceState4.TabIndex = 0;
            userDeviceState4.Text = "userDeviceState4";
            userDeviceState4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState4.VariableName = "输送机变频器电源状态";
            // 
            // userDeviceState3
            // 
            userDeviceState3.DeviceRunName = "输送机变频器运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState3.Location = new Point(12, 102);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(325, 60);
            userDeviceState3.State = false;
            userDeviceState3.TabIndex = 5;
            userDeviceState3.Text = "userDeviceState3";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "输送机变频器运行状态";
            // 
            // PageEquipmentMonitor3
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor3";
            Text = "PageEquipmentMonitor3";
            Initialize += PageEquipmentMonitor3_Initialize;
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserAlarmState userAlarmState3;
        private UserAlarmState userAlarmState2;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserAlarmState userAlarmState1;
        private UserDeviceState userDeviceState2;
        private UserDeviceState userDeviceState1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserDeviceState userDeviceState3;
        private UserAlarmState userAlarmState5;
        private UserAlarmState userAlarmState6;
        private UserDeviceState userDeviceState4;
    }
}