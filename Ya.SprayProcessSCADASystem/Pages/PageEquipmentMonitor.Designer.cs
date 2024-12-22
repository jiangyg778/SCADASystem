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
            userCounterButton1 = new UserCounterButton();
            userDeviceUnitControl1 = new UserDeviceUnitControl();
            SuspendLayout();
            // 
            // userCounterButton1
            // 
            userCounterButton1.BackColor = Color.Transparent;
            userCounterButton1.ButtonName = "你好啊";
            userCounterButton1.CounterButtonState = false;
            userCounterButton1.CounterButtonSymbol = 61452;
            userCounterButton1.FillColor = Color.Transparent;
            userCounterButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userCounterButton1.Location = new Point(214, 189);
            userCounterButton1.MinimumSize = new Size(1, 1);
            userCounterButton1.Name = "userCounterButton1";
            userCounterButton1.RectColor = Color.Transparent;
            userCounterButton1.Size = new Size(190, 90);
            userCounterButton1.TabIndex = 0;
            userCounterButton1.Text = "userCounterButton1";
            userCounterButton1.TextAlignment = ContentAlignment.MiddleCenter;
            userCounterButton1.VariableName = "";
            // 
            // userDeviceUnitControl1
            // 
            userDeviceUnitControl1.CloeseVariableName = "";
            userDeviceUnitControl1.EquimentUnitName = "设备单元";
            userDeviceUnitControl1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceUnitControl1.Location = new Point(453, 265);
            userDeviceUnitControl1.MinimumSize = new Size(1, 1);
            userDeviceUnitControl1.Name = "userDeviceUnitControl1";
            userDeviceUnitControl1.OpenVariableName = "";
            userDeviceUnitControl1.RectColor = Color.Transparent;
            userDeviceUnitControl1.Size = new Size(250, 60);
            userDeviceUnitControl1.State = false;
            userDeviceUnitControl1.TabIndex = 1;
            userDeviceUnitControl1.Text = "userDeviceUnitControl1";
            userDeviceUnitControl1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl1.ClickEvent += userDeviceUnitControl1_ClickEvent;
            // 
            // PageEquipmentMonitor
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(userDeviceUnitControl1);
            Controls.Add(userCounterButton1);
            Name = "PageEquipmentMonitor";
            Symbol = 57397;
            Text = "设备监控";
            ResumeLayout(false);
        }

        #endregion

        private UserCounterButton userCounterButton1;
        private UserDeviceUnitControl userDeviceUnitControl1;
    }
}