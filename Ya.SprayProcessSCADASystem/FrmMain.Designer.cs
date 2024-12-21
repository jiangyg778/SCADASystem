namespace Ya.SprayProcessSCADASystem
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Location = new Point(195, 664);
            Footer.Size = new Size(1085, 56);
            // 
            // Aside
            // 
            Aside.Location = new Point(0, 115);
            Aside.Size = new Size(195, 605);
            // 
            // Header
            // 
            Header.Location = new Point(0, 0);
            Header.Size = new Size(1280, 115);
            // 
            // FrmMain
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            Name = "FrmMain";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "Form1";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            ResumeLayout(false);
        }

        #endregion
    }
}
