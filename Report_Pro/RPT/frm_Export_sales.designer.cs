namespace Report_Pro.RPT
{
    partial class frm_Export_sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totSales = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.radioBtn3 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoReturn = new System.Windows.Forms.RadioButton();
            this.rdoZeiroTaxRatio = new System.Windows.Forms.RadioButton();
            this.rdoMainTaxRatio = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashCustomer1 = new Report_Pro.MyControls.CashCustomer();
            this.UC_PayType = new Report_Pro.MyControls.UC_PayType();
            this.UC_Branch = new Report_Pro.MyControls.UC_Branch();
            this.UC_Acc = new Report_Pro.MyControls.UC_Acc();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headLbl
            // 
            this.headLbl.Size = new System.Drawing.Size(987, 35);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.totSales);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 51);
            this.panel1.TabIndex = 3;
            // 
            // totSales
            // 
            this.totSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totSales.Location = new System.Drawing.Point(243, 12);
            this.totSales.Name = "totSales";
            this.totSales.Size = new System.Drawing.Size(137, 31);
            this.totSales.TabIndex = 11;
            this.totSales.Text = "اجمالي المبيعات";
            this.totSales.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(386, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 31);
            this.button4.TabIndex = 10;
            this.button4.Text = "مبيعات عميل نقدي";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(529, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "تقرير مردود فترات سابقه";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(672, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "تقرير مبيعات 5%";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(877, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "خيارات";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Report.Location = new System.Drawing.Point(781, 12);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(90, 31);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.Text = "تقرير الصادرات";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // radioBtn3
            // 
            this.radioBtn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtn3.AutoSize = true;
            this.radioBtn3.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn3.Location = new System.Drawing.Point(288, 163);
            this.radioBtn3.Name = "radioBtn3";
            this.radioBtn3.Size = new System.Drawing.Size(102, 17);
            this.radioBtn3.TabIndex = 274;
            this.radioBtn3.Text = "Without Custom";
            this.radioBtn3.UseVisualStyleBackColor = false;
            // 
            // radioBtn2
            // 
            this.radioBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn2.Location = new System.Drawing.Point(288, 141);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(89, 17);
            this.radioBtn2.TabIndex = 273;
            this.radioBtn2.Text = "With Custom ";
            this.radioBtn2.UseVisualStyleBackColor = false;
            // 
            // radioBtn1
            // 
            this.radioBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn1.Checked = true;
            this.radioBtn1.Location = new System.Drawing.Point(288, 119);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(36, 17);
            this.radioBtn1.TabIndex = 272;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "All";
            this.radioBtn1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dTP2
            // 
            this.dTP2.Location = new System.Drawing.Point(88, 146);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(104, 20);
            this.dTP2.TabIndex = 1;
            // 
            // dTP1
            // 
            this.dTP1.Location = new System.Drawing.Point(88, 121);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(104, 20);
            this.dTP1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 148);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(987, 290);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.ToolPanelWidth = 257;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.cashCustomer1);
            this.groupPanel1.Controls.Add(this.UC_PayType);
            this.groupPanel1.Controls.Add(this.UC_Branch);
            this.groupPanel1.Controls.Add(this.UC_Acc);
            this.groupPanel1.Controls.Add(this.radioBtn3);
            this.groupPanel1.Controls.Add(this.radioBtn2);
            this.groupPanel1.Controls.Add(this.radioBtn1);
            this.groupPanel1.Controls.Add(this.dTP1);
            this.groupPanel1.Controls.Add(this.dTP2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 148);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(987, 216);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 306;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoReturn);
            this.groupBox1.Controls.Add(this.rdoZeiroTaxRatio);
            this.groupBox1.Controls.Add(this.rdoMainTaxRatio);
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Location = new System.Drawing.Point(655, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 322;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Type";
            // 
            // rdoReturn
            // 
            this.rdoReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoReturn.AutoSize = true;
            this.rdoReturn.BackColor = System.Drawing.Color.Transparent;
            this.rdoReturn.Location = new System.Drawing.Point(10, 103);
            this.rdoReturn.Name = "rdoReturn";
            this.rdoReturn.Size = new System.Drawing.Size(172, 17);
            this.rdoReturn.TabIndex = 278;
            this.rdoReturn.Text = "Returns From Previous Periods";
            this.rdoReturn.UseVisualStyleBackColor = false;
            // 
            // rdoZeiroTaxRatio
            // 
            this.rdoZeiroTaxRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoZeiroTaxRatio.AutoSize = true;
            this.rdoZeiroTaxRatio.BackColor = System.Drawing.Color.Transparent;
            this.rdoZeiroTaxRatio.Location = new System.Drawing.Point(10, 78);
            this.rdoZeiroTaxRatio.Name = "rdoZeiroTaxRatio";
            this.rdoZeiroTaxRatio.Size = new System.Drawing.Size(98, 17);
            this.rdoZeiroTaxRatio.TabIndex = 277;
            this.rdoZeiroTaxRatio.Text = "Zeiro Tax Ratio";
            this.rdoZeiroTaxRatio.UseVisualStyleBackColor = false;
            // 
            // rdoMainTaxRatio
            // 
            this.rdoMainTaxRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoMainTaxRatio.AutoSize = true;
            this.rdoMainTaxRatio.BackColor = System.Drawing.Color.Transparent;
            this.rdoMainTaxRatio.Location = new System.Drawing.Point(10, 53);
            this.rdoMainTaxRatio.Name = "rdoMainTaxRatio";
            this.rdoMainTaxRatio.Size = new System.Drawing.Size(96, 17);
            this.rdoMainTaxRatio.TabIndex = 276;
            this.rdoMainTaxRatio.Text = "Main Tax Ratio";
            this.rdoMainTaxRatio.UseVisualStyleBackColor = false;
            // 
            // rdoAll
            // 
            this.rdoAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAll.AutoSize = true;
            this.rdoAll.BackColor = System.Drawing.Color.Transparent;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(10, 28);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(36, 17);
            this.rdoAll.TabIndex = 275;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(9, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 320;
            this.label5.Text = "Payment Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 321;
            this.label6.Text = "Cash Client";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 318;
            this.label3.Text = "Branch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 319;
            this.label4.Text = "Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashCustomer1
            // 
            this.cashCustomer1.BackColor = System.Drawing.Color.Transparent;
            this.cashCustomer1.Location = new System.Drawing.Point(88, 96);
            this.cashCustomer1.Margin = new System.Windows.Forms.Padding(0);
            this.cashCustomer1.Name = "cashCustomer1";
            this.cashCustomer1.Size = new System.Drawing.Size(326, 20);
            this.cashCustomer1.TabIndex = 316;
            // 
            // UC_PayType
            // 
            this.UC_PayType.Location = new System.Drawing.Point(88, 71);
            this.UC_PayType.Margin = new System.Windows.Forms.Padding(0);
            this.UC_PayType.Name = "UC_PayType";
            this.UC_PayType.Size = new System.Drawing.Size(428, 20);
            this.UC_PayType.TabIndex = 315;
            // 
            // UC_Branch
            // 
            this.UC_Branch.BackColor = System.Drawing.Color.Transparent;
            this.UC_Branch.Cursor = System.Windows.Forms.Cursors.Default;
            this.UC_Branch.Location = new System.Drawing.Point(88, 19);
            this.UC_Branch.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Branch.Name = "UC_Branch";
            this.UC_Branch.Size = new System.Drawing.Size(428, 20);
            this.UC_Branch.TabIndex = 314;
            // 
            // UC_Acc
            // 
            this.UC_Acc.BackColor = System.Drawing.Color.Transparent;
            this.UC_Acc.Location = new System.Drawing.Point(88, 44);
            this.UC_Acc.Margin = new System.Windows.Forms.Padding(0);
            this.UC_Acc.Name = "UC_Acc";
            this.UC_Acc.Size = new System.Drawing.Size(428, 20);
            this.UC_Acc.TabIndex = 306;
            // 
            // frm_Export_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 438);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Export_sales";
            this.Text = "مبيعات الضريبة";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.DateTimePicker dTP1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton radioBtn3;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.UC_Acc UC_Acc;
        private MyControls.UC_PayType UC_PayType;
        private MyControls.UC_Branch UC_Branch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private MyControls.CashCustomer cashCustomer1;
        private System.Windows.Forms.Button totSales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoReturn;
        private System.Windows.Forms.RadioButton rdoZeiroTaxRatio;
        private System.Windows.Forms.RadioButton rdoMainTaxRatio;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}