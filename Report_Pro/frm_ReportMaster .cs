using DevExpress.XtraEditors;
using Report_Pro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro
{
    public partial class frm_ReportMaster : XtraForm
    {
       bool IsNew;

        public static string ErrorText
        {
            get
            {
                return "هذا الحقل مطلوب";
            }
        }

        public frm_ReportMaster()
        {
            InitializeComponent();
        }


        private void frm_Master_Load(object sender, EventArgs e)
        {
        
        }


       
        public virtual void Report()
        {

        }

        public virtual void preview()
        {

        }

        public int canEdit=1 ;

        public virtual void CloseForm(Form frm)
        {
            frm.Close();
        }
        public virtual void MaxForm(Form frm)
        {
            if (frm.WindowState == FormWindowState.Normal)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.WindowState = FormWindowState.Normal;
            }
        }
        public virtual void MinForm(Form frm)
        {
            frm.WindowState=FormWindowState.Minimized;
        }



        public virtual void Option()
        {

        }

        public virtual void RefreshData()
        {

        }
        public virtual bool IsDataVailde()
        {
            return true;
        }



 

        private void btn_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (CheckActionAuthorization(this.Name, Master.Actions.Print))
            //    Print();
        }

        


        public static bool CheckActionAuthorization(string formName, Master.Actions actions, DAL.wh_USER user = null)
        {
            if (user == null)
                user = Session.User;

            if (user.CAN_GIVE_PERM == (byte)Master.UserType.Admin)
                return true;
            else
            {
                var screen = Session.ScreensAccesses.SingleOrDefault(x => x.ScreenName == formName);
                bool flag = true;
                if (screen != null)
                {
                    switch (actions)
                    {
                        case Master.Actions.Add:
                            flag = screen.CanAdd;
                            break;
                        case Master.Actions.Edit:
                            flag = screen.CanEdit;

                            break;
                        case Master.Actions.Delete:
                            flag = screen.CanDelete;

                            break;
                        case Master.Actions.Print:
                            flag = screen.CanPrint;

                            break;
                        default:
                            break;
                    }
                }
                if (flag == false)
                {
                    XtraMessageBox.Show(
         text: "غير مصرح لك ",
         caption: "",
         icon: MessageBoxIcon.Error,
         buttons: MessageBoxButtons.OK
         );
                }
                return flag;
            }


        }





        private void frm_Master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                Report();
            }
            if (e.KeyCode == Keys.F1)
            {
                Option();
            }
         
        }


       

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportMaster));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Max = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Min = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btn_Option1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Report1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_preview1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_preview = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbLanguh = new System.Windows.Forms.ToolStripComboBox();
            this.headLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_close,
            this.btn_Max,
            this.btn_Min,
            this.skinDropDownButtonItem1,
            this.btn_Option1,
            this.btn_Report1,
            this.btn_preview1,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 17;
            // 
            // barDockControlTop
            // 
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_close.Id = 4;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_close.ImageOptions.ImageIndex")));
            this.btn_close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.LargeImage")));
            this.btn_close.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_close.ImageOptions.LargeImageIndex")));
            this.btn_close.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_close.ImageOptions.SvgImage")));
            this.btn_close.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red;
            this.btn_close.ItemAppearance.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("btn_close.ItemAppearance.Hovered.Font")));
            this.btn_close.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_close.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_close.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_close.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_close.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("btn_close.ItemAppearance.Normal.Font")));
            this.btn_close.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_close.Name = "btn_close";
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
            // 
            // btn_Max
            // 
            resources.ApplyResources(this.btn_Max, "btn_Max");
            this.btn_Max.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Max.Id = 6;
            this.btn_Max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.ImageOptions.Image")));
            this.btn_Max.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Max.ImageOptions.ImageIndex")));
            this.btn_Max.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Max.ImageOptions.LargeImage")));
            this.btn_Max.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Max.ImageOptions.LargeImageIndex")));
            this.btn_Max.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Max.ImageOptions.SvgImage")));
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Max_ItemClick);
            // 
            // btn_Min
            // 
            resources.ApplyResources(this.btn_Min, "btn_Min");
            this.btn_Min.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_Min.Id = 7;
            this.btn_Min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.ImageOptions.Image")));
            this.btn_Min.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Min.ImageOptions.ImageIndex")));
            this.btn_Min.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Min.ImageOptions.LargeImage")));
            this.btn_Min.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Min.ImageOptions.LargeImageIndex")));
            this.btn_Min.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Min.ImageOptions.SvgImage")));
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Min.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Min_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            resources.ApplyResources(this.skinDropDownButtonItem1, "skinDropDownButtonItem1");
            this.skinDropDownButtonItem1.Id = 8;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // btn_Option1
            // 
            resources.ApplyResources(this.btn_Option1, "btn_Option1");
            this.btn_Option1.Id = 9;
            this.btn_Option1.ImageOptions.Image = global::Report_Pro.Properties.Resources.optionspivottable_16x16;
            this.btn_Option1.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Option1.ImageOptions.ImageIndex")));
            this.btn_Option1.ImageOptions.LargeImage = global::Report_Pro.Properties.Resources.optionspivottable_32x32;
            this.btn_Option1.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Option1.ImageOptions.LargeImageIndex")));
            this.btn_Option1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Option1.ImageOptions.SvgImage")));
            this.btn_Option1.Name = "btn_Option1";
            this.btn_Option1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Option1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Option_ItemClick);
            // 
            // btn_Report1
            // 
            resources.ApplyResources(this.btn_Report1, "btn_Report1");
            this.btn_Report1.Id = 14;
            this.btn_Report1.ImageOptions.Image = global::Report_Pro.Properties.Resources.report_16x16;
            this.btn_Report1.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_Report1.ImageOptions.ImageIndex")));
            this.btn_Report1.ImageOptions.LargeImage = global::Report_Pro.Properties.Resources.report_32x32;
            this.btn_Report1.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_Report1.ImageOptions.LargeImageIndex")));
            this.btn_Report1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Report1.ImageOptions.SvgImage")));
            this.btn_Report1.Name = "btn_Report1";
            this.btn_Report1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Report1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Report_ItemClick);
            // 
            // btn_preview1
            // 
            resources.ApplyResources(this.btn_preview1, "btn_preview1");
            this.btn_preview1.Id = 15;
            this.btn_preview1.ImageOptions.Image = global::Report_Pro.Properties.Resources.printpreview_16x16;
            this.btn_preview1.ImageOptions.ImageIndex = ((int)(resources.GetObject("btn_preview1.ImageOptions.ImageIndex")));
            this.btn_preview1.ImageOptions.LargeImage = global::Report_Pro.Properties.Resources.printpreview_32x32;
            this.btn_preview1.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("btn_preview1.ImageOptions.LargeImageIndex")));
            this.btn_preview1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_preview1.ImageOptions.SvgImage")));
            this.btn_preview1.Name = "btn_preview1";
            this.btn_preview1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_preview1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_preview_ItemClick);
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.Image = global::Report_Pro.Properties.Resources.doublelast_16x16;
            this.barButtonItem1.ImageOptions.ImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.ImageIndex")));
            this.barButtonItem1.ImageOptions.LargeImage = global::Report_Pro.Properties.Resources.doublelast_32x32;
            this.barButtonItem1.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.LargeImageIndex")));
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.headLbl);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Option,
            this.btn_preview,
            this.btn_Report,
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2,
            this.cmbLanguh});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // btn_Option
            // 
            resources.ApplyResources(this.btn_Option, "btn_Option");
            this.btn_Option.Image = global::Report_Pro.Properties.Resources.optionspivottable_32x32;
            this.btn_Option.Name = "btn_Option";
            this.btn_Option.Click += new System.EventHandler(this.btn_Option_Click);
            // 
            // btn_preview
            // 
            resources.ApplyResources(this.btn_preview, "btn_preview");
            this.btn_preview.Image = global::Report_Pro.Properties.Resources.printpreview_32x32;
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_Report
            // 
            resources.ApplyResources(this.btn_Report, "btn_Report");
            this.btn_Report.Image = global::Report_Pro.Properties.Resources.report_32x32;
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // xToolStripMenuItem
            // 
            resources.ApplyResources(this.xToolStripMenuItem, "xToolStripMenuItem");
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xToolStripMenuItem.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem1
            // 
            resources.ApplyResources(this.xToolStripMenuItem1, "xToolStripMenuItem1");
            this.xToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xToolStripMenuItem1.Image = global::Report_Pro.Properties.Resources.selectall_32x321;
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // xToolStripMenuItem2
            // 
            resources.ApplyResources(this.xToolStripMenuItem2, "xToolStripMenuItem2");
            this.xToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xToolStripMenuItem2.Image = global::Report_Pro.Properties.Resources.remove_32x321;
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Click += new System.EventHandler(this.xToolStripMenuItem2_Click);
            // 
            // cmbLanguh
            // 
            resources.ApplyResources(this.cmbLanguh, "cmbLanguh");
            this.cmbLanguh.Items.AddRange(new object[] {
            resources.GetString("cmbLanguh.Items"),
            resources.GetString("cmbLanguh.Items1")});
            this.cmbLanguh.Name = "cmbLanguh";
            // 
            // headLbl
            // 
            resources.ApplyResources(this.headLbl, "headLbl");
            this.headLbl.BackColor = System.Drawing.SystemColors.Info;
            this.headLbl.Name = "headLbl";
            this.headLbl.Click += new System.EventHandler(this.headLbl_Click);
            // 
            // frm_ReportMaster
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_ReportMaster";
            this.Load += new System.EventHandler(this.frm_ReportMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm(this);
        }

       

        private void btn_Max_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaxForm(this);
        }

        private void btn_Min_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MinForm(this);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       }

       

     

        private void frm_ReportMaster_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lungh == "0")
            {
                cmbLanguh.SelectedIndex = 1;
            }
            else
            {

                cmbLanguh.SelectedIndex = 0;
                
            }
        }

        private void btn_Option_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Option();
        }

        private void btn_preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckActionAuthorization(this.Name, Master.Actions.Print))
              
            preview();
        }

        private void btn_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (CheckActionAuthorization(this.Name, Master.Actions.Print))
               
                Report();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Option_Click(object sender, EventArgs e)
        {
            Option();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

            if (CheckActionAuthorization(this.Name, Master.Actions.Print))

                Report();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (CheckActionAuthorization(this.Name, Master.Actions.Print))

                preview();
        }

        private void headLbl_Click(object sender, EventArgs e)
        {

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm(this);
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaxForm(this);
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MinForm(this);
        }
    }
    }

