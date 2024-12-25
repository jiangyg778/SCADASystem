using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ya.BLL;
using Ya.Helper;

namespace Ya.SprayProcessSCADASystem
{
    public partial class PageUserManage : UIPage, ISingletonSelfDependency

    {

        // 用户页面
        private readonly UserManager _userManager;
        public PageUserManage(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
            this.cb_Auth.Items.AddRange(Enum.GetNames(typeof(SystemEnums.UserRole)));
            this.cb_Auth.SelectedIndex = -1;
            this.Load += PageUserManage_Load;
        }

        private async void PageUserManage_Load(object? sender, EventArgs e)
        {
            await LoadData();
        }

        private async void btn_AddUser_Click(object sender, EventArgs e)
        {
            //验证
            if (!VaildInput())
            {
                return;
            }
            //添加用户
            var result = await _userManager.AddUserAsync(new UserAddDto()
            {
                UserName = this.txt_UserName.Text,
                UserPassword = this.txt_Password.Text,
                Role = this.cb_Auth.SelectedItem.ToString()
            });
            if (result.Status == SystemEnums.Result.Success)
            {

                UIMessageTip.ShowOk("添加成功");
                LogExtension.ShowMessage($"添加用户{this.txt_UserName.Text}成功", Microsoft.Extensions.Logging.LogLevel.Information);
                //刷新datagridview
                await LoadData();

              
            }
            else
            {
                UIMessageTip.ShowError(result.Msg);
                LogExtension.ShowMessage($"添加用户{this.txt_UserName.Text}失败", Microsoft.Extensions.Logging.LogLevel.Error);
            }

          
        }
        private async Task LoadData()
        {
            var res = await _userManager.GetUserListAsync();
            if (res.Status == SystemEnums.Result.Success)
            {
                this.dgv_User.DataSource = res.Data;
                this.dgv_User.Refresh();
            }
        }

        private bool VaildInput()
        {
            if (string.IsNullOrEmpty(this.txt_UserName.Text))
            {
                UIMessageTip.ShowWarning("用户名不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(this.txt_Password.Text))
            {
                UIMessageTip.ShowWarning("密码不能为空");
                return false;

            }
            if (string.IsNullOrEmpty(this.txt_EnterPassword.Text))
            {
                UIMessageTip.ShowWarning("确认密码不能为空");
                return false;
            }
            if (this.txt_Password.Text != this.txt_EnterPassword.Text)
            {
                UIMessageTip.ShowWarning("两次密码不一致");
                return false;
            }
            if (this.cb_Auth.SelectedIndex == -1)
            {
                UIMessageTip.ShowWarning("请选择权限");
                return false;

            }
            return true;
        }

        private void dgv_User_SelectIndexChange(object sender, int index)
        {
            var row = this.dgv_User.Rows[index];
            this.txt_UserName.Text = row.Cells["UserName"].Value.ToString();
            this.txt_Password.Text = row.Cells["UserPassword"].Value.ToString();
            this.txt_EnterPassword.Text = row.Cells["UserPassword"].Value.ToString();
            this.cb_Auth.SelectedItem = row.Cells["Role"].Value.ToString();

        }
    }
}
