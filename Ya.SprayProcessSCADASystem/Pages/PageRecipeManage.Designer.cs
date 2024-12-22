﻿namespace Ya.SprayProcessSCADASystem
{
    partial class PageRecipeManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            userSetValue1 = new UserSetValue();
            userSetValue2 = new UserSetValue();
            userSetValue3 = new UserSetValue();
            userSetValue4 = new UserSetValue();
            userSetValue5 = new UserSetValue();
            userSetValue6 = new UserSetValue();
            userSetValue7 = new UserSetValue();
            userSetValue10 = new UserSetValue();
            userSetValue11 = new UserSetValue();
            userSetValue12 = new UserSetValue();
            userSetValue15 = new UserSetValue();
            userSetValue16 = new UserSetValue();
            userSetValue14 = new UserSetValue();
            userSetValue13 = new UserSetValue();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            uiLabel1 = new Sunny.UI.UILabel();
            txt_ProductType = new Sunny.UI.UITextBox();
            btn_AddRecipe = new Sunny.UI.UISymbolButton();
            btn_DelRecipe = new Sunny.UI.UISymbolButton();
            btn_UpdateRecipe = new Sunny.UI.UISymbolButton();
            btn_QueryRecipe = new Sunny.UI.UISymbolButton();
            btn_ImportRecipe = new Sunny.UI.UISymbolButton();
            btn_ExportRecipe = new Sunny.UI.UISymbolButton();
            btn_DownloadRecipe = new Sunny.UI.UISymbolButton();
            dgv_Recipe = new Sunny.UI.UIDataGridView();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Recipe).BeginInit();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userSetValue10);
            uiTitlePanel1.Controls.Add(userSetValue11);
            uiTitlePanel1.Controls.Add(userSetValue12);
            uiTitlePanel1.Controls.Add(userSetValue13);
            uiTitlePanel1.Controls.Add(userSetValue14);
            uiTitlePanel1.Controls.Add(userSetValue15);
            uiTitlePanel1.Controls.Add(userSetValue16);
            uiTitlePanel1.Controls.Add(userSetValue7);
            uiTitlePanel1.Controls.Add(userSetValue6);
            uiTitlePanel1.Controls.Add(userSetValue5);
            uiTitlePanel1.Controls.Add(userSetValue4);
            uiTitlePanel1.Controls.Add(userSetValue3);
            uiTitlePanel1.Controls.Add(userSetValue2);
            uiTitlePanel1.Controls.Add(userSetValue1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(4, 2);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(810, 541);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "配方参数";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userSetValue1
            // 
            userSetValue1.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue1.DeviceVarName = "脱脂设定压力上限值";
            userSetValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue1.Location = new Point(18, 55);
            userSetValue1.MinimumSize = new Size(1, 1);
            userSetValue1.Name = "userSetValue1";
            userSetValue1.Size = new Size(347, 46);
            userSetValue1.TabIndex = 0;
            userSetValue1.Text = "userSetValue1";
            userSetValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue1.Unit = "Mpa";
            userSetValue1.VariableName = "脱脂设定压力上限值";
            userSetValue1.VarValue = "0";
            // 
            // userSetValue2
            // 
            userSetValue2.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue2.DeviceVarName = "脱脂设定压力下限值";
            userSetValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue2.Location = new Point(18, 125);
            userSetValue2.MinimumSize = new Size(1, 1);
            userSetValue2.Name = "userSetValue2";
            userSetValue2.Size = new Size(347, 46);
            userSetValue2.TabIndex = 0;
            userSetValue2.Text = "userSetValue1";
            userSetValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue2.Unit = "Mpa";
            userSetValue2.VariableName = "脱脂设定压力下限值";
            userSetValue2.VarValue = "0";
            // 
            // userSetValue3
            // 
            userSetValue3.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue3.DeviceVarName = "粗洗喷淋泵过载上限值";
            userSetValue3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue3.Location = new Point(18, 195);
            userSetValue3.MinimumSize = new Size(1, 1);
            userSetValue3.Name = "userSetValue3";
            userSetValue3.Size = new Size(347, 46);
            userSetValue3.TabIndex = 0;
            userSetValue3.Text = "userSetValue1";
            userSetValue3.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue3.Unit = "KW";
            userSetValue3.VariableName = "粗洗喷淋泵过载上限值";
            userSetValue3.VarValue = "0";
            // 
            // userSetValue4
            // 
            userSetValue4.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue4.DeviceVarName = "粗洗液位下限值";
            userSetValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue4.Location = new Point(18, 265);
            userSetValue4.MinimumSize = new Size(1, 1);
            userSetValue4.Name = "userSetValue4";
            userSetValue4.Size = new Size(347, 46);
            userSetValue4.TabIndex = 0;
            userSetValue4.Text = "userSetValue1";
            userSetValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue4.Unit = "m³";
            userSetValue4.VariableName = "粗洗液位下限值";
            userSetValue4.VarValue = "0";
            // 
            // userSetValue5
            // 
            userSetValue5.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue5.DeviceVarName = "陶化喷淋泵过载上限值";
            userSetValue5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue5.Location = new Point(18, 335);
            userSetValue5.MinimumSize = new Size(1, 1);
            userSetValue5.Name = "userSetValue5";
            userSetValue5.Size = new Size(347, 46);
            userSetValue5.TabIndex = 0;
            userSetValue5.Text = "userSetValue1";
            userSetValue5.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue5.Unit = "Mpa";
            userSetValue5.VariableName = "陶化喷淋泵过载上限值";
            userSetValue5.VarValue = "0";
            // 
            // userSetValue6
            // 
            userSetValue6.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue6.DeviceVarName = "精洗喷淋泵过载上限值";
            userSetValue6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue6.Location = new Point(18, 405);
            userSetValue6.MinimumSize = new Size(1, 1);
            userSetValue6.Name = "userSetValue6";
            userSetValue6.Size = new Size(347, 46);
            userSetValue6.TabIndex = 0;
            userSetValue6.Text = "userSetValue1";
            userSetValue6.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue6.Unit = "KW";
            userSetValue6.VariableName = "精洗喷淋泵过载上限值";
            userSetValue6.VarValue = "0";
            // 
            // userSetValue7
            // 
            userSetValue7.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue7.DeviceVarName = "精洗液位下限值";
            userSetValue7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue7.Location = new Point(18, 475);
            userSetValue7.MinimumSize = new Size(1, 1);
            userSetValue7.Name = "userSetValue7";
            userSetValue7.Size = new Size(347, 46);
            userSetValue7.TabIndex = 0;
            userSetValue7.Text = "userSetValue1";
            userSetValue7.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue7.Unit = "m³";
            userSetValue7.VariableName = "精洗液位下限值";
            userSetValue7.VarValue = "0";
            // 
            // userSetValue10
            // 
            userSetValue10.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue10.DeviceVarName = "固化炉温度下限值";
            userSetValue10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue10.Location = new Point(432, 335);
            userSetValue10.MinimumSize = new Size(1, 1);
            userSetValue10.Name = "userSetValue10";
            userSetValue10.Size = new Size(337, 46);
            userSetValue10.TabIndex = 2;
            userSetValue10.Text = "userSetValue1";
            userSetValue10.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue10.Unit = "℃";
            userSetValue10.VariableName = "固化炉温度下限值";
            userSetValue10.VarValue = "0";
            // 
            // userSetValue11
            // 
            userSetValue11.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue11.DeviceVarName = "固化炉温度上限值";
            userSetValue11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue11.Location = new Point(432, 265);
            userSetValue11.MinimumSize = new Size(1, 1);
            userSetValue11.Name = "userSetValue11";
            userSetValue11.Size = new Size(337, 46);
            userSetValue11.TabIndex = 3;
            userSetValue11.Text = "userSetValue1";
            userSetValue11.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue11.Unit = "℃";
            userSetValue11.VariableName = "固化炉温度上限值";
            userSetValue11.VarValue = "0";
            // 
            // userSetValue12
            // 
            userSetValue12.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue12.DeviceVarName = "离心风机过载上限值";
            userSetValue12.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue12.Location = new Point(432, 195);
            userSetValue12.MinimumSize = new Size(1, 1);
            userSetValue12.Name = "userSetValue12";
            userSetValue12.Size = new Size(337, 46);
            userSetValue12.TabIndex = 4;
            userSetValue12.Text = "userSetValue1";
            userSetValue12.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue12.Unit = "KW";
            userSetValue12.VariableName = "离心风机过载上限值";
            userSetValue12.VarValue = "0";
            // 
            // userSetValue15
            // 
            userSetValue15.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue15.DeviceVarName = "水分炉温度下限值";
            userSetValue15.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue15.Location = new Point(432, 125);
            userSetValue15.MinimumSize = new Size(1, 1);
            userSetValue15.Name = "userSetValue15";
            userSetValue15.Size = new Size(337, 46);
            userSetValue15.TabIndex = 7;
            userSetValue15.Text = "userSetValue1";
            userSetValue15.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue15.Unit = "℃";
            userSetValue15.VariableName = "水分炉温度下限值";
            userSetValue15.VarValue = "0";
            // 
            // userSetValue16
            // 
            userSetValue16.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue16.DeviceVarName = "水分炉温度上限值";
            userSetValue16.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue16.Location = new Point(432, 55);
            userSetValue16.MinimumSize = new Size(1, 1);
            userSetValue16.Name = "userSetValue16";
            userSetValue16.Size = new Size(337, 46);
            userSetValue16.TabIndex = 8;
            userSetValue16.Text = "userSetValue16";
            userSetValue16.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue16.Unit = "℃";
            userSetValue16.VariableName = "水分炉温度上限值";
            userSetValue16.VarValue = "0";
            // 
            // userSetValue14
            // 
            userSetValue14.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue14.DeviceVarName = "输送机设定速度";
            userSetValue14.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue14.Location = new Point(432, 405);
            userSetValue14.MinimumSize = new Size(1, 1);
            userSetValue14.Name = "userSetValue14";
            userSetValue14.Size = new Size(337, 46);
            userSetValue14.TabIndex = 6;
            userSetValue14.Text = "userSetValue1";
            userSetValue14.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue14.Unit = "m/s";
            userSetValue14.VariableName = "输送机设定速度";
            userSetValue14.VarValue = "0";
            // 
            // userSetValue13
            // 
            userSetValue13.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue13.DeviceVarName = "输送机设定频率";
            userSetValue13.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue13.Location = new Point(432, 475);
            userSetValue13.MinimumSize = new Size(1, 1);
            userSetValue13.Name = "userSetValue13";
            userSetValue13.Size = new Size(337, 46);
            userSetValue13.TabIndex = 5;
            userSetValue13.Text = "userSetValue1";
            userSetValue13.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue13.Unit = "HZ";
            userSetValue13.VariableName = "输送机设定频率";
            userSetValue13.VarValue = "0";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(dgv_Recipe);
            uiTitlePanel2.Controls.Add(btn_ExportRecipe);
            uiTitlePanel2.Controls.Add(btn_QueryRecipe);
            uiTitlePanel2.Controls.Add(btn_DelRecipe);
            uiTitlePanel2.Controls.Add(btn_DownloadRecipe);
            uiTitlePanel2.Controls.Add(btn_ImportRecipe);
            uiTitlePanel2.Controls.Add(btn_UpdateRecipe);
            uiTitlePanel2.Controls.Add(btn_AddRecipe);
            uiTitlePanel2.Controls.Add(txt_ProductType);
            uiTitlePanel2.Controls.Add(uiLabel1);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(812, 2);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(271, 541);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "配方控制台";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(9, 55);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "产品型号:";
            // 
            // txt_ProductType
            // 
            txt_ProductType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ProductType.Location = new Point(110, 52);
            txt_ProductType.Margin = new Padding(4, 5, 4, 5);
            txt_ProductType.MinimumSize = new Size(1, 16);
            txt_ProductType.Name = "txt_ProductType";
            txt_ProductType.Padding = new Padding(5);
            txt_ProductType.ShowText = false;
            txt_ProductType.Size = new Size(150, 32);
            txt_ProductType.TabIndex = 1;
            txt_ProductType.TextAlignment = ContentAlignment.MiddleLeft;
            txt_ProductType.Watermark = "";
            // 
            // btn_AddRecipe
            // 
            btn_AddRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddRecipe.Location = new Point(9, 92);
            btn_AddRecipe.MinimumSize = new Size(1, 1);
            btn_AddRecipe.Name = "btn_AddRecipe";
            btn_AddRecipe.Size = new Size(121, 50);
            btn_AddRecipe.Symbol = 557670;
            btn_AddRecipe.TabIndex = 2;
            btn_AddRecipe.Text = "添加配方";
            btn_AddRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // btn_DelRecipe
            // 
            btn_DelRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DelRecipe.Location = new Point(140, 92);
            btn_DelRecipe.MinimumSize = new Size(1, 1);
            btn_DelRecipe.Name = "btn_DelRecipe";
            btn_DelRecipe.Size = new Size(121, 50);
            btn_DelRecipe.Symbol = 362810;
            btn_DelRecipe.TabIndex = 2;
            btn_DelRecipe.Text = "删除配方";
            // 
            // btn_UpdateRecipe
            // 
            btn_UpdateRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateRecipe.Location = new Point(9, 148);
            btn_UpdateRecipe.MinimumSize = new Size(1, 1);
            btn_UpdateRecipe.Name = "btn_UpdateRecipe";
            btn_UpdateRecipe.Size = new Size(121, 50);
            btn_UpdateRecipe.Symbol = 558087;
            btn_UpdateRecipe.TabIndex = 2;
            btn_UpdateRecipe.Text = "修改配方";
            // 
            // btn_QueryRecipe
            // 
            btn_QueryRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QueryRecipe.Location = new Point(140, 148);
            btn_QueryRecipe.MinimumSize = new Size(1, 1);
            btn_QueryRecipe.Name = "btn_QueryRecipe";
            btn_QueryRecipe.Size = new Size(121, 50);
            btn_QueryRecipe.Symbol = 559520;
            btn_QueryRecipe.TabIndex = 2;
            btn_QueryRecipe.Text = "查询配方";
            // 
            // btn_ImportRecipe
            // 
            btn_ImportRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ImportRecipe.Location = new Point(9, 204);
            btn_ImportRecipe.MinimumSize = new Size(1, 1);
            btn_ImportRecipe.Name = "btn_ImportRecipe";
            btn_ImportRecipe.Size = new Size(121, 50);
            btn_ImportRecipe.Symbol = 362831;
            btn_ImportRecipe.TabIndex = 2;
            btn_ImportRecipe.Text = "导入配方";
            // 
            // btn_ExportRecipe
            // 
            btn_ExportRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ExportRecipe.Location = new Point(140, 204);
            btn_ExportRecipe.MinimumSize = new Size(1, 1);
            btn_ExportRecipe.Name = "btn_ExportRecipe";
            btn_ExportRecipe.Size = new Size(121, 50);
            btn_ExportRecipe.Symbol = 362831;
            btn_ExportRecipe.TabIndex = 2;
            btn_ExportRecipe.Text = "导出配方";
            // 
            // btn_DownloadRecipe
            // 
            btn_DownloadRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DownloadRecipe.Location = new Point(9, 260);
            btn_DownloadRecipe.MinimumSize = new Size(1, 1);
            btn_DownloadRecipe.Name = "btn_DownloadRecipe";
            btn_DownloadRecipe.Size = new Size(249, 50);
            btn_DownloadRecipe.Symbol = 61465;
            btn_DownloadRecipe.TabIndex = 2;
            btn_DownloadRecipe.Text = "下载配方";
            // 
            // dgv_Recipe
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgv_Recipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Recipe.BackgroundColor = Color.White;
            dgv_Recipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Recipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Recipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Recipe.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Recipe.EnableHeadersVisualStyles = false;
            dgv_Recipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_Recipe.GridColor = Color.FromArgb(80, 160, 255);
            dgv_Recipe.Location = new Point(9, 316);
            dgv_Recipe.Name = "dgv_Recipe";
            dgv_Recipe.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Recipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_Recipe.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Recipe.RowTemplate.Height = 25;
            dgv_Recipe.SelectedIndex = -1;
            dgv_Recipe.Size = new Size(249, 219);
            dgv_Recipe.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_Recipe.TabIndex = 3;
            // 
            // PageRecipeManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageRecipeManage";
            Symbol = 162333;
            Text = "配方管理";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Recipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserSetValue userSetValue10;
        private UserSetValue userSetValue11;
        private UserSetValue userSetValue12;
        private UserSetValue userSetValue15;
        private UserSetValue userSetValue16;
        private UserSetValue userSetValue7;
        private UserSetValue userSetValue6;
        private UserSetValue userSetValue5;
        private UserSetValue userSetValue4;
        private UserSetValue userSetValue3;
        private UserSetValue userSetValue2;
        private UserSetValue userSetValue1;
        private UserSetValue userSetValue13;
        private UserSetValue userSetValue14;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITextBox txt_ProductType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton btn_ExportRecipe;
        private Sunny.UI.UISymbolButton btn_QueryRecipe;
        private Sunny.UI.UISymbolButton btn_DelRecipe;
        private Sunny.UI.UISymbolButton btn_DownloadRecipe;
        private Sunny.UI.UISymbolButton btn_ImportRecipe;
        private Sunny.UI.UISymbolButton btn_UpdateRecipe;
        private Sunny.UI.UISymbolButton btn_AddRecipe;
        private Sunny.UI.UIDataGridView dgv_Recipe;
    }
}