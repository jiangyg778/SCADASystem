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
    // 控制模块
    public partial class PageTotalEquipmentControl : UIPage, ISingletonSelfDependency
    {
        public PageTotalEquipmentControl()
        {
            InitializeComponent();
        }

        private void btn_Control_common_Click(object sender, EventArgs e)
        {
            UISymbolButton btn = (UISymbolButton)sender;
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowError("请先链接西门子PLC");
                return;
            }
            if (Globals.PlcWrite(btn.TagString, true))
            {
                UIMessageTip.ShowOk("写入成功");
            }
            else
            {
                UIMessageTip.ShowError($"写入{btn.TagString}失败");}
        }
    }
}
