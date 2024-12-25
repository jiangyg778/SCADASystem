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
    public partial class PageAuthManage : UIPage, ISingletonSelfDependency
    {
        // 权限页面
        private readonly AuthManager _authManager;
        public PageAuthManage(AuthManager authManager)
        {
            InitializeComponent();
            _authManager = authManager;
            this.Load += PageAuthManage_Load;
        }

        private async void PageAuthManage_Load(object? sender, EventArgs e)
        {
            await LoadAuthAsync(SystemEnums.UserRole.工程师, cbg_Engineer);
            await LoadAuthAsync(SystemEnums.UserRole.操作员, cbg_Operator);
            await LoadAuthAsync(SystemEnums.UserRole.访客, cbg_Visitor);
        }

        private async Task LoadAuthAsync(SystemEnums.UserRole role, UICheckBoxGroup cbg)
        {
            var res = await _authManager.GetAuthAsync(new QueryAuthDto() { Role = role.ToString() });
            if (res.Status == SystemEnums.Result.Success)
            {
                var auth = res.Data[0];
                List<int> list = new List<int>();
                if (auth.ControlModule)
                {
                    list.Add(0);
                }
                if (auth.MonitorModule)
                {
                    list.Add(1);
                }
                if (auth.ReportModule)
                {
                    list.Add(2);
                }
                if (auth.LogModule)
                {
                    list.Add(3);
                }
                if (auth.RecipeModule)
                {
                    list.Add(4);
                }
                if (auth.ChartModule)
                {
                    list.Add(5);
                }
                if (auth.ParamModule)
                {
                    list.Add(6);
                }
                cbg.SelectedIndexes = list;

            }
        }

        private async void btn_UpdateEngAuth_Click(object sender, EventArgs e)
        {
            await UpdateAuth(SystemEnums.UserRole.工程师, 1, cbg_Engineer);
        }

        private async void btn_UpdateOpAuth_Click(object sender, EventArgs e)
        {
            await UpdateAuth(SystemEnums.UserRole.操作员, 2, cbg_Operator);
        }

        private async void btn_UpdateVisitorAuth_Click(object sender, EventArgs e)
        {
            await UpdateAuth(SystemEnums.UserRole.访客, 3, cbg_Visitor);
        }

        private async Task UpdateAuth(SystemEnums.UserRole role, int id, UICheckBoxGroup cbg)
        {

            var authListInts = new List<int>();
            for (int i = 0; i < cbg.SelectedIndexes.Count; i++)
            {
                if (cbg.SelectedIndexes.Contains(i))
                {
                    authListInts.Add(i);
                }
            }
            var auth = new UpdateAuthDto()
            {
                Id = id,
                Role = role.ToString(),
                ControlModule = authListInts.Contains(0),
                MonitorModule = authListInts.Contains(1),
                ReportModule = authListInts.Contains(2),
                LogModule = authListInts.Contains(3),
                RecipeModule = authListInts.Contains(4),
                ChartModule = authListInts.Contains(5),
                ParamModule = authListInts.Contains(6)
            };
            var res = await _authManager.UpdateAuthAsync(auth);
            if (res.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("权限修改成功");
            }
            else
            {
                UIMessageTip.ShowError("权限修改失败");
            }

        }
    }
}
