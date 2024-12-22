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
            btn_Start = new Sunny.UI.UISymbolButton();
            btn_Stop = new Sunny.UI.UISymbolButton();
            btn_MachineReset = new Sunny.UI.UISymbolButton();
            btn_AlarmReset = new Sunny.UI.UISymbolButton();
            btn_DryRun = new UserCounterButton();
            uiTitlePanel1.SuspendLayout();
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
            btn_Start.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            // PageTotalEquipmentControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel1);
            Name = "PageTotalEquipmentControl";
            Symbol = 57397;
            Text = "设备总控";
            uiTitlePanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_AlarmReset;
        private Sunny.UI.UISymbolButton btn_MachineReset;
        private Sunny.UI.UISymbolButton btn_Stop;
        private Sunny.UI.UISymbolButton btn_Start;
        private UserCounterButton btn_DryRun;
    }
}