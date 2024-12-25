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
    public partial class FrmLogin : UILoginForm, ISingletonSelfDependency
    {

        private readonly UserManager _userManager;
        public FrmLogin(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }

        private async void FrmLogin_ButtonLoginClick(object sender, EventArgs e)
        {
            // 登录
            var result = await _userManager.LoginAsync(new UserLoginDto() { UserName = UserName, UserPassword = Password });
            if (result.Status == SystemEnums.Result.Success)
            {
                // 登录成功
                IsLogin = true;
                this.ShowSuccessTip("登录成功");
                Close();
            }else
            {
                // 登录失败
                this.ShowErrorTip(result.Msg);
            }
        }

    }
}
