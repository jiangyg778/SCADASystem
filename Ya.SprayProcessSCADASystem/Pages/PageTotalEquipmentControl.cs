using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.Logging;
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
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace Ya.SprayProcessSCADASystem
{
    // 控制模块
    public partial class PageTotalEquipmentControl : UIPage, ISingletonSelfDependency
    {
        private readonly ILogger<FrmMain> _logger;

        public PageTotalEquipmentControl(ILogger<FrmMain> logger)
        {
            InitializeComponent();
            _logger = logger;
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
                ShowLog($"写入{btn.TagString}成功");
            }
            else
            {
                UIMessageTip.ShowError($"写入{btn.TagString}失败");
                ShowLog($"写入{btn.TagString}失败");
            }
        }

        private void btn_DryRun_ClickEvent(object sender, EventArgs e)
        {
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowError("请先链接西门子PLC");
                return;
            }
            if (Globals.PlcWrite(this.btn_DryRun.VariableName, !this.btn_DryRun.CounterButtonState))
            {
                this.btn_DryRun.CounterButtonState = !this.btn_DryRun.CounterButtonState;
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{this.btn_DryRun.VariableName}成功");
            }
            else
            {
                UIMessageTip.ShowError($"写入失败");
                ShowLog($"写入{this.btn_DryRun.VariableName}失败");
            }
        }

        private void device_TZ_ClickEvent(object sender, EventArgs e)
        {
            UserDeviceUnitControl userDeviceUnitControl = (UserDeviceUnitControl)sender;
            if (!Globals.SiemensClient.Connected)
            {
                userDeviceUnitControl.State = false;
                UIMessageTip.ShowError("请先链接西门子PLC");
                return;
            }
            bool state = userDeviceUnitControl.State;
            string variableName = state ? userDeviceUnitControl.CloseVariableName : userDeviceUnitControl.OpenVariableName;
            if (Globals.PlcWrite(variableName, state))
            {
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{this.btn_DryRun.VariableName}成功");

            }
            else
            {
                UIMessageTip.ShowError($"写入失败");
                ShowLog($"写入{this.btn_DryRun.VariableName}失败");
            }
        }

        //日志
        private void ShowLog(string log, LogLevel logLevel = LogLevel.Information)
        {
            this.txt_Log.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {log} {Environment.NewLine}");
            switch (logLevel)
            {
                case LogLevel.Information:
                    _logger.LogInformation(log);
                    break;
                case LogLevel.Warning:
                    _logger.LogWarning(log);
                    break;
                case LogLevel.Error:
                    _logger.LogError(log);
                    break;
            }
        }
    }
}
