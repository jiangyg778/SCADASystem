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
    public partial class UserCounterButton : UIUserControl
    {

        private UIStyle Style;
        private Color defaultFillColor;
        private Color defaultRectColor;

        private string buttonName = "空运行";
        [Browsable(true)] //属性暴露出来,可以在设计器中设置
        [Category("自定义属性")] //属性分类-自定义属性
        [Description("按钮名称")] //属性描述 非必须
        public string ButtonName
        {
            get { return buttonName; }
            set
            {
                buttonName = value;
                this.btn_Counter.Text = buttonName;
            }
        }

        private int counterButtonSymbol = 61452;
        [Browsable(true)] //属性暴露出来,可以在设计器中设置
        [Category("自定义属性")] //属性分类-自定义属性
        [Description("按钮图标")] //属性描述 非必须
        public int CounterButtonSymbol
        {
            get { return counterButtonSymbol; }
            set
            {
                counterButtonSymbol = value;
                this.btn_Counter.Symbol = counterButtonSymbol;
            }
        }

        private bool counterButtonState;
        [Browsable(true)] //属性暴露出来,可以在设计器中设置
        [Category("自定义属性")] //属性分类-自定义属性
        [Description("按钮状态")] //属性描述 非必须
        public bool CounterButtonState
        {
            get { return counterButtonState; }
            set
            {
                counterButtonState = value;
                if (counterButtonState)
                {
                    this.btn_Counter.FillColor = this.btn_Counter.FillPressColor; //按下时的颜色
                    this.btn_Counter.RectColor = this.btn_Counter.RectPressColor; //按下时的边框颜色
                }
                else
                {
                    if (this.btn_Counter.Style != Style)
                    {
                        this.btn_Counter.Style = Style;
                    }
                    else
                    {
                        this.btn_Counter.FillColor = defaultFillColor; //默认颜色
                        this.btn_Counter.RectColor = defaultRectColor; //默认边框颜色
                    }
                }
            }
        }

        private string variableName = "";
        [Browsable(true)] //属性暴露出来,可以在设计器中设置
        [Category("自定义属性")] //属性分类-自定义属性
        [Description("获取变量名称")] //属性描述 非必须
        public string VariableName
        {
            get { return variableName = ""; }
            set { variableName =  value; }
        }


        public UserCounterButton()
        {
            InitializeComponent();
            this.Load += UserCounterButton_Load;
        }

        private void UserCounterButton_Load(object? sender, EventArgs e)
        {
            UIExtension.SetStyleManger = SetStyle;
        }

        private void SetStyle(UIStyleManager manager)
        {
            this.btn_Counter.Style = manager.Style;
            Style = manager.Style;
            defaultFillColor = this.btn_Counter.FillColor;
            defaultRectColor = this.btn_Counter.RectColor;

        }

        public event EventHandler CounterButtonClick;
        private void btn_Counter_Click(object sender, EventArgs e)
        {
            CounterButtonClick?.Invoke(this, e);
        }
    }
}
