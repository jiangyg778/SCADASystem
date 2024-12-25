namespace Ya.SprayProcessSCADASystem
{
    partial class FrmLogin
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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Text = "喷涂工艺SCADA";
            // 
            // lblSubText
            // 
            lblSubText.Location = new Point(378, 425);
            lblSubText.Text = "喷涂工艺v1.0";
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(750, 450);
            Name = "FrmLogin";
            SubText = "喷涂工艺v1.0";
            Text = "FrmLog";
            Title = "喷涂工艺SCADA";
            ButtonLoginClick += FrmLogin_ButtonLoginClick;
            ResumeLayout(false);
        }

        #endregion
    }
}