namespace Ya.SprayProcessSCADASystem
{
    partial class PageTotalEquipmentControl
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
            btn_DryRun = new UserCounterButton();
            btn_AlarmReset = new Sunny.UI.UISymbolButton();
            btn_MachineReset = new Sunny.UI.UISymbolButton();
            btn_Stop = new Sunny.UI.UISymbolButton();
            btn_Start = new Sunny.UI.UISymbolButton();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            device_TZ = new UserDeviceUnitControl();
            device_CX = new UserDeviceUnitControl();
            device_TH = new UserDeviceUnitControl();
            device_JX = new UserDeviceUnitControl();
            device_SFL = new UserDeviceUnitControl();
            device_LQS = new UserDeviceUnitControl();
            device_GHL = new UserDeviceUnitControl();
            device_SSJ = new UserDeviceUnitControl();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            txt_Log = new Sunny.UI.UITextBox();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(btn_DryRun);
            uiTitlePanel1.Controls.Add(btn_AlarmReset);
            uiTitlePanel1.Controls.Add(btn_MachineReset);
            uiTitlePanel1.Controls.Add(btn_Stop);
            uiTitlePanel1.Controls.Add(btn_Start);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(7, 4);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1065, 157);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "产线总控制";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btn_DryRun
            // 
            btn_DryRun.BackColor = Color.Transparent;
            btn_DryRun.ButtonName = "空运行";
            btn_DryRun.CounterButtonState = false;
            btn_DryRun.CounterButtonSymbol = 61452;
            btn_DryRun.FillColor = Color.Transparent;
            btn_DryRun.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DryRun.Location = new Point(852, 54);
            btn_DryRun.MinimumSize = new Size(1, 1);
            btn_DryRun.Name = "btn_DryRun";
            btn_DryRun.Radius = 10;
            btn_DryRun.RectColor = Color.Transparent;
            btn_DryRun.Size = new Size(184, 84);
            btn_DryRun.TabIndex = 1;
            btn_DryRun.Text = "userCounterButton1";
            btn_DryRun.TextAlignment = ContentAlignment.MiddleCenter;
            btn_DryRun.VariableName = "";
            // 
            // btn_AlarmReset
            // 
            btn_AlarmReset.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AlarmReset.Location = new Point(644, 54);
            btn_AlarmReset.MinimumSize = new Size(1, 1);
            btn_AlarmReset.Name = "btn_AlarmReset";
            btn_AlarmReset.Radius = 10;
            btn_AlarmReset.Size = new Size(181, 84);
            btn_AlarmReset.Symbol = 61473;
            btn_AlarmReset.SymbolSize = 55;
            btn_AlarmReset.TabIndex = 0;
            btn_AlarmReset.TagString = "报警复位";
            btn_AlarmReset.Text = "报警复位";
            btn_AlarmReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // btn_MachineReset
            // 
            btn_MachineReset.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MachineReset.Location = new Point(436, 54);
            btn_MachineReset.MinimumSize = new Size(1, 1);
            btn_MachineReset.Name = "btn_MachineReset";
            btn_MachineReset.Radius = 10;
            btn_MachineReset.Size = new Size(181, 84);
            btn_MachineReset.Symbol = 61473;
            btn_MachineReset.SymbolSize = 55;
            btn_MachineReset.TabIndex = 0;
            btn_MachineReset.TagString = "机械复位";
            btn_MachineReset.Text = "机械复位";
            btn_MachineReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Stop.Location = new Point(228, 54);
            btn_Stop.MinimumSize = new Size(1, 1);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Radius = 10;
            btn_Stop.Size = new Size(181, 84);
            btn_Stop.Symbol = 62093;
            btn_Stop.SymbolSize = 55;
            btn_Stop.TabIndex = 0;
            btn_Stop.TagString = "总停止";
            btn_Stop.Text = "总停止";
            btn_Stop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("微软雅黑", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Start.Location = new Point(20, 54);
            btn_Start.MinimumSize = new Size(1, 1);
            btn_Start.Name = "btn_Start";
            btn_Start.Radius = 10;
            btn_Start.Size = new Size(181, 84);
            btn_Start.Symbol = 561649;
            btn_Start.SymbolSize = 55;
            btn_Start.TabIndex = 0;
            btn_Start.Text = "总启动";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(device_SSJ);
            uiTitlePanel2.Controls.Add(device_JX);
            uiTitlePanel2.Controls.Add(device_GHL);
            uiTitlePanel2.Controls.Add(device_TH);
            uiTitlePanel2.Controls.Add(device_LQS);
            uiTitlePanel2.Controls.Add(device_CX);
            uiTitlePanel2.Controls.Add(device_SFL);
            uiTitlePanel2.Controls.Add(device_TZ);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(7, 169);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(602, 374);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "产线总控制";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_TZ
            // 
            device_TZ.CloseVariableName = "脱脂工位关";
            device_TZ.EquimentUnitName = "脱脂工位";
            device_TZ.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_TZ.Location = new Point(29, 49);
            device_TZ.MinimumSize = new Size(1, 1);
            device_TZ.Name = "device_TZ";
            device_TZ.OpenVariableName = "脱脂工位开";
            device_TZ.RectColor = Color.Transparent;
            device_TZ.Size = new Size(250, 60);
            device_TZ.State = false;
            device_TZ.TabIndex = 0;
            device_TZ.Text = "userDeviceUnitControl1";
            device_TZ.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_CX
            // 
            device_CX.CloseVariableName = "粗洗工位关";
            device_CX.EquimentUnitName = "粗洗工位";
            device_CX.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_CX.Location = new Point(29, 131);
            device_CX.MinimumSize = new Size(1, 1);
            device_CX.Name = "device_CX";
            device_CX.OpenVariableName = "粗洗工位开";
            device_CX.RectColor = Color.Transparent;
            device_CX.Size = new Size(250, 60);
            device_CX.State = false;
            device_CX.TabIndex = 1;
            device_CX.Text = "userDeviceUnitControl2";
            device_CX.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_TH
            // 
            device_TH.CloseVariableName = "陶化工位开";
            device_TH.EquimentUnitName = "陶化工位";
            device_TH.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_TH.Location = new Point(29, 213);
            device_TH.MinimumSize = new Size(1, 1);
            device_TH.Name = "device_TH";
            device_TH.OpenVariableName = "陶化工位关";
            device_TH.RectColor = Color.Transparent;
            device_TH.Size = new Size(250, 60);
            device_TH.State = false;
            device_TH.TabIndex = 2;
            device_TH.Text = "userDeviceUnitControl3";
            device_TH.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_JX
            // 
            device_JX.CloseVariableName = "精洗工位开";
            device_JX.EquimentUnitName = "精洗工位";
            device_JX.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_JX.Location = new Point(29, 295);
            device_JX.MinimumSize = new Size(1, 1);
            device_JX.Name = "device_JX";
            device_JX.OpenVariableName = "精洗工位关";
            device_JX.RectColor = Color.Transparent;
            device_JX.Size = new Size(250, 60);
            device_JX.State = false;
            device_JX.TabIndex = 3;
            device_JX.Text = "userDeviceUnitControl4";
            device_JX.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_SFL
            // 
            device_SFL.CloseVariableName = "水分炉工位开";
            device_SFL.EquimentUnitName = "水分炉工位";
            device_SFL.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_SFL.Location = new Point(306, 49);
            device_SFL.MinimumSize = new Size(1, 1);
            device_SFL.Name = "device_SFL";
            device_SFL.OpenVariableName = "水分炉工位关";
            device_SFL.RectColor = Color.Transparent;
            device_SFL.Size = new Size(250, 60);
            device_SFL.State = false;
            device_SFL.TabIndex = 0;
            device_SFL.Text = "userDeviceUnitControl1";
            device_SFL.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_LQS
            // 
            device_LQS.CloseVariableName = "冷却室工位开";
            device_LQS.EquimentUnitName = "冷却室工位";
            device_LQS.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_LQS.Location = new Point(306, 131);
            device_LQS.MinimumSize = new Size(1, 1);
            device_LQS.Name = "device_LQS";
            device_LQS.OpenVariableName = "冷却室工位关";
            device_LQS.RectColor = Color.Transparent;
            device_LQS.Size = new Size(250, 60);
            device_LQS.State = false;
            device_LQS.TabIndex = 1;
            device_LQS.Text = "userDeviceUnitControl2";
            device_LQS.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_GHL
            // 
            device_GHL.CloseVariableName = "固化炉工位开";
            device_GHL.EquimentUnitName = "固化炉工位";
            device_GHL.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_GHL.Location = new Point(306, 213);
            device_GHL.MinimumSize = new Size(1, 1);
            device_GHL.Name = "device_GHL";
            device_GHL.OpenVariableName = "固化炉工位关";
            device_GHL.RectColor = Color.Transparent;
            device_GHL.Size = new Size(250, 60);
            device_GHL.State = false;
            device_GHL.TabIndex = 2;
            device_GHL.Text = "userDeviceUnitControl3";
            device_GHL.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // device_SSJ
            // 
            device_SSJ.CloseVariableName = "输送机工位关";
            device_SSJ.EquimentUnitName = "输送机工位";
            device_SSJ.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            device_SSJ.Location = new Point(306, 295);
            device_SSJ.MinimumSize = new Size(1, 1);
            device_SSJ.Name = "device_SSJ";
            device_SSJ.OpenVariableName = "输送机工位开";
            device_SSJ.RectColor = Color.Transparent;
            device_SSJ.Size = new Size(250, 60);
            device_SSJ.State = false;
            device_SSJ.TabIndex = 3;
            device_SSJ.Text = "userDeviceUnitControl4";
            device_SSJ.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(txt_Log);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.Location = new Point(617, 169);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(455, 374);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "日志栏";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_Log
            // 
            txt_Log.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Log.Location = new Point(4, 45);
            txt_Log.Margin = new Padding(4, 5, 4, 5);
            txt_Log.MinimumSize = new Size(1, 16);
            txt_Log.Multiline = true;
            txt_Log.Name = "txt_Log";
            txt_Log.Padding = new Padding(5);
            txt_Log.ShowText = false;
            txt_Log.Size = new Size(447, 321);
            txt_Log.TabIndex = 0;
            txt_Log.TextAlignment = ContentAlignment.MiddleLeft;
            txt_Log.Watermark = "";
            // 
            // PageTotalEquipmentControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageTotalEquipmentControl";
            Symbol = 57397;
            Text = "设备总控";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_AlarmReset;
        private Sunny.UI.UISymbolButton btn_MachineReset;
        private Sunny.UI.UISymbolButton btn_Stop;
        private Sunny.UI.UISymbolButton btn_Start;
        private UserCounterButton btn_DryRun;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserDeviceUnitControl device_TZ;
        private UserDeviceUnitControl device_SSJ;
        private UserDeviceUnitControl device_JX;
        private UserDeviceUnitControl device_GHL;
        private UserDeviceUnitControl device_TH;
        private UserDeviceUnitControl device_LQS;
        private UserDeviceUnitControl device_CX;
        private UserDeviceUnitControl device_SFL;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UITextBox txt_Log;
    }
}