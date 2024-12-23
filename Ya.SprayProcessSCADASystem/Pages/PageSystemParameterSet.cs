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

namespace Ya.SprayProcessSCADASystem
{
    public partial class PageSystemParameterSet : UIPage, ISingletonSelfDependency
    {
        public PageSystemParameterSet()
        {
            InitializeComponent();
            this.Load += GetPageSystemParameterSet_Load;
        }

        private void GetPageSystemParameterSet_Load(object? sender, EventArgs e)
        {
            InitSystemParameter();
        }

        private void InitSystemParameter()
        {
            // 初始化系统参数设置
            this.txt_PLCVarAddressPath.Text = Globals.PlcVarConfigPath;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if(Globals.IniFile.Write("PLC变量", "变量表地址", this.txt_PLCVarAddressPath.Text))
            {
                UIMessageTip.ShowOk("保存成功");
            }
            else
            {
               UIMessageTip.ShowWarning("保存失败");
            }
        }
    }
}
