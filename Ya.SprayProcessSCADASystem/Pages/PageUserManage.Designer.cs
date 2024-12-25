namespace Ya.SprayProcessSCADASystem
{
    partial class PageUserManage
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            uiLabel1 = new Sunny.UI.UILabel();
            txt_UserName = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txt_Password = new Sunny.UI.UITextBox();
            uilabel4 = new Sunny.UI.UILabel();
            txt_EnterPassword = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            cb_Auth = new Sunny.UI.UIComboBox();
            btn_AddUser = new Sunny.UI.UISymbolButton();
            btn_updata = new Sunny.UI.UISymbolButton();
            btn_delete = new Sunny.UI.UISymbolButton();
            dgv_User = new Sunny.UI.UIDataGridView();
            id = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            UserPassword = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_User).BeginInit();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(23, 20);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(84, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "用户名称";
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserName.Location = new Point(105, 14);
            txt_UserName.Margin = new Padding(4, 5, 4, 5);
            txt_UserName.MinimumSize = new Size(1, 16);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Padding = new Padding(5);
            txt_UserName.ShowText = false;
            txt_UserName.Size = new Size(150, 29);
            txt_UserName.TabIndex = 1;
            txt_UserName.TextAlignment = ContentAlignment.MiddleLeft;
            txt_UserName.Watermark = "用户名称";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(23, 61);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(84, 23);
            uiLabel2.TabIndex = 0;
            uiLabel2.Text = "用户密码";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(105, 55);
            txt_Password.Margin = new Padding(4, 5, 4, 5);
            txt_Password.MinimumSize = new Size(1, 16);
            txt_Password.Name = "txt_Password";
            txt_Password.Padding = new Padding(5);
            txt_Password.ShowText = false;
            txt_Password.Size = new Size(150, 29);
            txt_Password.TabIndex = 1;
            txt_Password.TextAlignment = ContentAlignment.MiddleLeft;
            txt_Password.Watermark = "用户密码";
            // 
            // uilabel4
            // 
            uilabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uilabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uilabel4.Location = new Point(23, 154);
            uilabel4.Name = "uilabel4";
            uilabel4.Size = new Size(84, 23);
            uilabel4.TabIndex = 0;
            uilabel4.Text = "权限选择";
            // 
            // txt_EnterPassword
            // 
            txt_EnterPassword.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_EnterPassword.Location = new Point(105, 99);
            txt_EnterPassword.Margin = new Padding(4, 5, 4, 5);
            txt_EnterPassword.MinimumSize = new Size(1, 16);
            txt_EnterPassword.Name = "txt_EnterPassword";
            txt_EnterPassword.Padding = new Padding(5);
            txt_EnterPassword.ShowText = false;
            txt_EnterPassword.Size = new Size(150, 29);
            txt_EnterPassword.TabIndex = 1;
            txt_EnterPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txt_EnterPassword.Watermark = "确认密码";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(23, 105);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(84, 23);
            uiLabel5.TabIndex = 0;
            uiLabel5.Text = "确认密码";
            // 
            // cb_Auth
            // 
            cb_Auth.DataSource = null;
            cb_Auth.FillColor = Color.White;
            cb_Auth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Auth.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cb_Auth.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cb_Auth.Location = new Point(105, 150);
            cb_Auth.Margin = new Padding(4, 5, 4, 5);
            cb_Auth.MinimumSize = new Size(63, 0);
            cb_Auth.Name = "cb_Auth";
            cb_Auth.Padding = new Padding(0, 0, 30, 2);
            cb_Auth.Size = new Size(150, 29);
            cb_Auth.SymbolSize = 24;
            cb_Auth.TabIndex = 2;
            cb_Auth.TextAlignment = ContentAlignment.MiddleLeft;
            cb_Auth.Watermark = "权限选择";
            // 
            // btn_AddUser
            // 
            btn_AddUser.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddUser.Location = new Point(23, 216);
            btn_AddUser.MinimumSize = new Size(1, 1);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(232, 45);
            btn_AddUser.Symbol = 561285;
            btn_AddUser.TabIndex = 3;
            btn_AddUser.Text = "添加用户";
            btn_AddUser.Click += btn_AddUser_Click;
            // 
            // btn_updata
            // 
            btn_updata.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_updata.Location = new Point(23, 283);
            btn_updata.MinimumSize = new Size(1, 1);
            btn_updata.Name = "btn_updata";
            btn_updata.Size = new Size(232, 45);
            btn_updata.Symbol = 561285;
            btn_updata.TabIndex = 3;
            btn_updata.Text = "修改用户";
            btn_updata.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_updata.Click += btn_updata_ClickAsync;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(23, 344);
            btn_delete.MinimumSize = new Size(1, 1);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(232, 45);
            btn_delete.Symbol = 561285;
            btn_delete.TabIndex = 3;
            btn_delete.Text = "删除用户";
            btn_delete.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Click += btn_delete_ClickAsync;
            // 
            // dgv_User
            // 
            dgv_User.AllowUserToAddRows = false;
            dgv_User.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(235, 243, 255);
            dgv_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgv_User.BackgroundColor = Color.White;
            dgv_User.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle12.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_User.ColumnHeadersHeight = 32;
            dgv_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_User.Columns.AddRange(new DataGridViewColumn[] { id, UserName, UserPassword, Role });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgv_User.DefaultCellStyle = dataGridViewCellStyle13;
            dgv_User.EnableHeadersVisualStyles = false;
            dgv_User.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_User.GridColor = Color.FromArgb(80, 160, 255);
            dgv_User.Location = new Point(334, 14);
            dgv_User.Name = "dgv_User";
            dgv_User.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle14.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgv_User.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_User.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgv_User.RowTemplate.Height = 25;
            dgv_User.SelectedIndex = -1;
            dgv_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_User.Size = new Size(645, 507);
            dgv_User.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_User.TabIndex = 4;
            dgv_User.SelectIndexChange += dgv_User_SelectIndexChange;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "用户名";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 200;
            // 
            // UserPassword
            // 
            UserPassword.DataPropertyName = "UserPassword";
            UserPassword.HeaderText = "密码";
            UserPassword.Name = "UserPassword";
            UserPassword.ReadOnly = true;
            UserPassword.Width = 200;
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "角色";
            Role.Name = "Role";
            Role.ReadOnly = true;
            Role.Width = 200;
            // 
            // PageUserManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(dgv_User);
            Controls.Add(btn_delete);
            Controls.Add(btn_updata);
            Controls.Add(btn_AddUser);
            Controls.Add(cb_Auth);
            Controls.Add(txt_EnterPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(uiLabel5);
            Controls.Add(uilabel4);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Name = "PageUserManage";
            Symbol = 61447;
            Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)dgv_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_UserName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_Password;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uilabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txt_EnterPassword;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cb_Auth;
        private Sunny.UI.UISymbolButton btn_AddUser;
        private Sunny.UI.UISymbolButton btn_updata;
        private Sunny.UI.UISymbolButton btn_delete;
        private Sunny.UI.UIDataGridView dgv_User;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserPassword;
        private DataGridViewTextBoxColumn Role;
    }
}