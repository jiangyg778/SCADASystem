namespace Ya.SprayProcessSCADASystem
{
    partial class PageSystemParameterSet
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
            txt_Port = new Sunny.UI.UITextBox();
            txt_IPAddress = new Sunny.UI.UIIPTextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            txt_SoftTime = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            txt_SoftwareVersion = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            rbg_Save = new Sunny.UI.UIRadioButtonGroup();
            txt_DirePath = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            btn_Save = new Sunny.UI.UIButton();
            lable11 = new Sunny.UI.UILabel();
            txt_Rack = new Sunny.UI.UILabel();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiLabel8 = new Sunny.UI.UILabel();
            this.txt_Slot = new Sunny.UI.UITextBox();
            uiLabel9 = new Sunny.UI.UILabel();
            this.txt_ConnectTimeOut = new Sunny.UI.UITextBox();
            uiLabel10 = new Sunny.UI.UILabel();
            this.txt_ReadTimeInterval = new Sunny.UI.UITextBox();
            this.txt_ReConnectTimeInterval = new Sunny.UI.UILabel();
            uiTextBox6 = new Sunny.UI.UITextBox();
            cb_CPUType = new Sunny.UI.UIComboBox();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(cb_CPUType);
            uiTitlePanel1.Controls.Add(uiTextBox6);
            uiTitlePanel1.Controls.Add(this.txt_ReadTimeInterval);
            uiTitlePanel1.Controls.Add(this.txt_ConnectTimeOut);
            uiTitlePanel1.Controls.Add(this.txt_Slot);
            uiTitlePanel1.Controls.Add(uiTextBox2);
            uiTitlePanel1.Controls.Add(txt_Port);
            uiTitlePanel1.Controls.Add(txt_IPAddress);
            uiTitlePanel1.Controls.Add(this.txt_ReConnectTimeInterval);
            uiTitlePanel1.Controls.Add(uiLabel10);
            uiTitlePanel1.Controls.Add(uiLabel9);
            uiTitlePanel1.Controls.Add(uiLabel8);
            uiTitlePanel1.Controls.Add(txt_Rack);
            uiTitlePanel1.Controls.Add(lable11);
            uiTitlePanel1.Controls.Add(uiLabel2);
            uiTitlePanel1.Controls.Add(uiLabel1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(13, 14);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(543, 310);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "PLC参数";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_Port
            // 
            txt_Port.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Port.Location = new Point(83, 100);
            txt_Port.Margin = new Padding(4, 5, 4, 5);
            txt_Port.MinimumSize = new Size(1, 16);
            txt_Port.Name = "txt_Port";
            txt_Port.Padding = new Padding(5);
            txt_Port.ShowText = false;
            txt_Port.Size = new Size(150, 29);
            txt_Port.TabIndex = 2;
            txt_Port.TextAlignment = ContentAlignment.MiddleLeft;
            txt_Port.Watermark = "";
            // 
            // txt_IPAddress
            // 
            txt_IPAddress.FillColor2 = Color.FromArgb(235, 243, 255);
            txt_IPAddress.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_IPAddress.Location = new Point(83, 46);
            txt_IPAddress.Margin = new Padding(4, 5, 4, 5);
            txt_IPAddress.MinimumSize = new Size(1, 1);
            txt_IPAddress.Name = "txt_IPAddress";
            txt_IPAddress.Padding = new Padding(1);
            txt_IPAddress.ShowText = false;
            txt_IPAddress.Size = new Size(150, 29);
            txt_IPAddress.TabIndex = 1;
            txt_IPAddress.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(14, 104);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.TabIndex = 0;
            uiLabel2.Text = "端口号";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(14, 49);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Ip地址";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(txt_SoftTime);
            uiTitlePanel2.Controls.Add(uiLabel5);
            uiTitlePanel2.Controls.Add(txt_SoftwareVersion);
            uiTitlePanel2.Controls.Add(uiLabel4);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(13, 334);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(543, 173);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "软件参数";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_SoftTime
            // 
            txt_SoftTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoftTime.Location = new Point(112, 102);
            txt_SoftTime.Margin = new Padding(4, 5, 4, 5);
            txt_SoftTime.MinimumSize = new Size(1, 16);
            txt_SoftTime.Name = "txt_SoftTime";
            txt_SoftTime.Padding = new Padding(5);
            txt_SoftTime.ShowText = false;
            txt_SoftTime.Size = new Size(150, 29);
            txt_SoftTime.TabIndex = 5;
            txt_SoftTime.TextAlignment = ContentAlignment.MiddleLeft;
            txt_SoftTime.Watermark = "";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(14, 108);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(100, 23);
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "软件试用时间";
            // 
            // txt_SoftwareVersion
            // 
            txt_SoftwareVersion.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SoftwareVersion.Location = new Point(112, 49);
            txt_SoftwareVersion.Margin = new Padding(4, 5, 4, 5);
            txt_SoftwareVersion.MinimumSize = new Size(1, 16);
            txt_SoftwareVersion.Name = "txt_SoftwareVersion";
            txt_SoftwareVersion.Padding = new Padding(5);
            txt_SoftwareVersion.ShowText = false;
            txt_SoftwareVersion.Size = new Size(150, 29);
            txt_SoftwareVersion.TabIndex = 3;
            txt_SoftwareVersion.TextAlignment = ContentAlignment.MiddleLeft;
            txt_SoftwareVersion.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(14, 55);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(100, 23);
            uiLabel4.TabIndex = 0;
            uiLabel4.Text = "软件版本";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(rbg_Save);
            uiTitlePanel3.Controls.Add(txt_DirePath);
            uiTitlePanel3.Controls.Add(uiLabel6);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.Location = new Point(579, 14);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(480, 310);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "定时清理Log";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // rbg_Save
            // 
            rbg_Save.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbg_Save.Items.AddRange(new object[] { "不清理", "3天", "7天", "15天", "30天", "60天" });
            rbg_Save.Location = new Point(20, 80);
            rbg_Save.Margin = new Padding(4, 5, 4, 5);
            rbg_Save.MinimumSize = new Size(1, 1);
            rbg_Save.Name = "rbg_Save";
            rbg_Save.Padding = new Padding(0, 32, 0, 0);
            rbg_Save.Size = new Size(369, 217);
            rbg_Save.TabIndex = 5;
            rbg_Save.Text = "定期清理";
            rbg_Save.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // txt_DirePath
            // 
            txt_DirePath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DirePath.Location = new Point(115, 46);
            txt_DirePath.Margin = new Padding(4, 5, 4, 5);
            txt_DirePath.MinimumSize = new Size(1, 16);
            txt_DirePath.Name = "txt_DirePath";
            txt_DirePath.Padding = new Padding(5);
            txt_DirePath.ShowText = false;
            txt_DirePath.Size = new Size(293, 29);
            txt_DirePath.TabIndex = 4;
            txt_DirePath.TextAlignment = ContentAlignment.MiddleLeft;
            txt_DirePath.Watermark = "";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(20, 52);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(100, 23);
            uiLabel6.TabIndex = 1;
            uiLabel6.Text = "文件夹路径";
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Location = new Point(678, 383);
            btn_Save.MinimumSize = new Size(1, 1);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(290, 102);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "保存";
            // 
            // lable11
            // 
            lable11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lable11.ForeColor = Color.FromArgb(48, 48, 48);
            lable11.Location = new Point(14, 156);
            lable11.Name = "lable11";
            lable11.Size = new Size(100, 23);
            lable11.TabIndex = 0;
            lable11.Text = "CPU类型";
            // 
            // txt_Rack
            // 
            txt_Rack.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Rack.ForeColor = Color.FromArgb(48, 48, 48);
            txt_Rack.Location = new Point(14, 214);
            txt_Rack.Name = "txt_Rack";
            txt_Rack.Size = new Size(100, 23);
            txt_Rack.TabIndex = 0;
            txt_Rack.Text = "机架号";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox2.Location = new Point(83, 210);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(150, 29);
            uiTextBox2.TabIndex = 2;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Location = new Point(14, 274);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(100, 23);
            uiLabel8.TabIndex = 0;
            uiLabel8.Text = "插槽号";
            // 
            // txt_Slot
            // 
            this.txt_Slot.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.txt_Slot.Location = new Point(83, 270);
            this.txt_Slot.Margin = new Padding(4, 5, 4, 5);
            this.txt_Slot.MinimumSize = new Size(1, 16);
            this.txt_Slot.Name = "txt_Slot";
            this.txt_Slot.Padding = new Padding(5);
            this.txt_Slot.ShowText = false;
            this.txt_Slot.Size = new Size(150, 29);
            this.txt_Slot.TabIndex = 2;
            this.txt_Slot.TextAlignment = ContentAlignment.MiddleLeft;
            this.txt_Slot.Watermark = "";
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.Location = new Point(274, 52);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(100, 23);
            uiLabel9.TabIndex = 0;
            uiLabel9.Text = "PLC连接超时";
            // 
            // txt_ConnectTimeOut
            // 
            this.txt_ConnectTimeOut.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.txt_ConnectTimeOut.Location = new Point(368, 48);
            this.txt_ConnectTimeOut.Margin = new Padding(4, 5, 4, 5);
            this.txt_ConnectTimeOut.MinimumSize = new Size(1, 16);
            this.txt_ConnectTimeOut.Name = "txt_ConnectTimeOut";
            this.txt_ConnectTimeOut.Padding = new Padding(5);
            this.txt_ConnectTimeOut.ShowText = false;
            this.txt_ConnectTimeOut.Size = new Size(150, 29);
            this.txt_ConnectTimeOut.TabIndex = 2;
            this.txt_ConnectTimeOut.TextAlignment = ContentAlignment.MiddleLeft;
            this.txt_ConnectTimeOut.Watermark = "";
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel10.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel10.Location = new Point(274, 104);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(100, 23);
            uiLabel10.TabIndex = 0;
            uiLabel10.Text = "读取超时";
            // 
            // txt_ReadTimeInterval
            // 
            this.txt_ReadTimeInterval.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.txt_ReadTimeInterval.Location = new Point(368, 100);
            this.txt_ReadTimeInterval.Margin = new Padding(4, 5, 4, 5);
            this.txt_ReadTimeInterval.MinimumSize = new Size(1, 16);
            this.txt_ReadTimeInterval.Name = "txt_ReadTimeInterval";
            this.txt_ReadTimeInterval.Padding = new Padding(5);
            this.txt_ReadTimeInterval.ShowText = false;
            this.txt_ReadTimeInterval.Size = new Size(150, 29);
            this.txt_ReadTimeInterval.TabIndex = 2;
            this.txt_ReadTimeInterval.TextAlignment = ContentAlignment.MiddleLeft;
            this.txt_ReadTimeInterval.Watermark = "";
            // 
            // txt_ReConnectTimeInterval
            // 
            this.txt_ReConnectTimeInterval.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.txt_ReConnectTimeInterval.ForeColor = Color.FromArgb(48, 48, 48);
            this.txt_ReConnectTimeInterval.Location = new Point(274, 156);
            this.txt_ReConnectTimeInterval.Name = "txt_ReConnectTimeInterval";
            this.txt_ReConnectTimeInterval.Size = new Size(100, 23);
            this.txt_ReConnectTimeInterval.TabIndex = 0;
            this.txt_ReConnectTimeInterval.Text = "重连时间";
            // 
            // uiTextBox6
            // 
            uiTextBox6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox6.Location = new Point(368, 152);
            uiTextBox6.Margin = new Padding(4, 5, 4, 5);
            uiTextBox6.MinimumSize = new Size(1, 16);
            uiTextBox6.Name = "uiTextBox6";
            uiTextBox6.Padding = new Padding(5);
            uiTextBox6.ShowText = false;
            uiTextBox6.Size = new Size(150, 29);
            uiTextBox6.TabIndex = 2;
            uiTextBox6.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox6.Watermark = "";
            // 
            // cb_CPUType
            // 
            cb_CPUType.DataSource = null;
            cb_CPUType.FillColor = Color.White;
            cb_CPUType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_CPUType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cb_CPUType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cb_CPUType.Location = new Point(83, 150);
            cb_CPUType.Margin = new Padding(4, 5, 4, 5);
            cb_CPUType.MinimumSize = new Size(63, 0);
            cb_CPUType.Name = "cb_CPUType";
            cb_CPUType.Padding = new Padding(0, 0, 30, 2);
            cb_CPUType.Size = new Size(150, 29);
            cb_CPUType.SymbolSize = 24;
            cb_CPUType.TabIndex = 3;
            cb_CPUType.TextAlignment = ContentAlignment.MiddleLeft;
            cb_CPUType.Watermark = "";
            // 
            // PageSystemParameterSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(btn_Save);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageSystemParameterSet";
            Symbol = 559577;
            Text = "参数管理";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_Port;
        private Sunny.UI.UIIPTextBox txt_IPAddress;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel txt_Rack;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox lable11;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITextBox txt_SoftwareVersion;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txt_SoftTime;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UIRadioButtonGroup rbg_Save;
        private Sunny.UI.UITextBox txt_DirePath;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btn_Save;
        private Sunny.UI.UITextBox uiTextBox6;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel cb_CPUType;
        private Sunny.UI.UIComboBox cb_CPUType;
    }
}