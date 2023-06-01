using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Project : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string btntype = "0";
        string btntype_1 = "0";
        Int32 m;
        Int32 m_1;
        public frm_Project()
        {
            InitializeComponent();
        }

        private void frm_Projects_Load(object sender, EventArgs e)
        {
            cmb_Category.DataSource = dal.getDataTabl_1(@"SELECT ID, descr, descr_E FROM projects_Category");
            cmb_Priority.DataSource = dal.getDataTabl_1(@"SELECT ID, descr, descr_E FROM projects_Priority");
            cmb_Status.DataSource = dal.getDataTabl_1(@"SELECT ID, descr, descr_E FROM projects_Status");

            cmb_Category.ValueMember = "ID";
            cmb_Priority.ValueMember = "ID";
            cmb_Status.ValueMember = "ID";
            if (Properties.Settings.Default.lungh == "0")
            {
                cmb_Category.DisplayMember = "descr";
                cmb_Priority.DisplayMember = "descr";
                cmb_Status.DisplayMember = "descr";
            }
            else
            {
                cmb_Category.DisplayMember = "descr_E";
                cmb_Priority.DisplayMember = "descr_E";
                cmb_Status.DisplayMember = "descr_E";
            }

            txt_project_ID.Text = _ser().ToString();

            txt_unit.DataSource = dal.getDataTabl_1(@"SELECT Wh_Unit,unit_Description,unit_Description_E FROM Wh_Unit");
            txt_unit.ValueMember = "Wh_Unit";
            if (Properties.Settings.Default.lungh == "0")
            {
                txt_unit.DisplayMember = "unit_Description";
            }
            else
            {
                txt_unit.DisplayMember = "unit_Description_E";
            }
            txt_unit.SelectedIndex = -1;

            //txt_item_p.txt_projectNo.Text = txt_project_ID.Text;
            get_item_id();
        }

        private int _ser()
        {
            
           int  serNo = dal.GetCell_1(@"SELECT isnull(max(CAST(PROJ_CODE AS int))+1,1) FROM Projects").ToString().ParseInt(0);
            return serNo;
        }
        

        private void BSave_Click(object sender, EventArgs e)
        {
           if(txt_project_ID.Text.Trim()!= string.Empty && txt_Name.Text.Trim() != string.Empty)
                if(dal.getDataTabl_1("select PROJ_CODE from Projects where PROJ_CODE='" + txt_project_ID.Text + "'").Rows.Count > 0)
                {
                dal.Execute_1(@"Update Projects set 
                PROJ_CODE ='" + txt_project_ID.Text + "',PROJ_name ='" + txt_Name.Text + "',PROJ_E_NAME ='" + txt_Name_E.Text + "',OINER_NOTES ='" + txt_Owner.Text + "',OINER_NOTES_E ='" + txt_Owner_E.Text + "',Category ='" + Convert.ToString(cmb_Category.SelectedValue) +
                "',P_Priority ='" + Convert.ToString(cmb_Priority.SelectedValue) + "',P_Status='" + Convert.ToString(cmb_Status.SelectedValue) + "',Start_Date ='" + start_Date.Value.ToString("yyyy-MM-dd") +
                "',End_Date ='" + end_Date.Value.ToString("yyyy-MM-dd") + "',Budget ='" + txt_Budget.Value + "',Budget_in_Days ='" + txt_BudgetDays.Value + "',Notes ='" + txt_Note.Text +
                "',DP_Acc = '"+txt_DP_Acc.ID.Text+ "',Project_Amount='"+txt_Amount.Value+"',DP_Ratio = '" + txt_DP_Ratio.Value+ "',DP_Amount='"+txt_DP_Amount.Value+ "'  where PROJ_CODE ='" + txt_project_ID.Text + "' ");

                }
                else

            {
                dal.Execute_1(@"INSERT INTO Projects (PROJ_CODE,PROJ_name,PROJ_E_NAME,OINER_NOTES,OINER_NOTES_E,Category,P_Priority,P_Status,
                Start_Date,End_Date,Budget_in_Days,Budget,Notes,DP_Acc,Project_Amount,DP_Ratio,DP_Amount)
                Values ('" + txt_project_ID.Text +"','"+ txt_Name.Text + "','" + txt_Name_E.Text + "','" + txt_Owner.Text + "','" + txt_Owner_E.Text + "','" + Convert.ToString(cmb_Category.SelectedValue) + 
                "','" +Convert.ToString(cmb_Priority.SelectedValue) + "','" + Convert.ToString(cmb_Status.SelectedValue) + "','"+start_Date.Value.ToString("yyyy-MM-dd")+ 
                "','" + end_Date.Value.ToString("yyyy-MM-dd") + "','" + txt_BudgetDays.Value + "','" + txt_Budget.Value + "','" + txt_Note.Text + "','" + txt_DP_Acc.ID.Text + 
                "','"+txt_Amount.Value+"','" + txt_DP_Ratio.Value + "','"+txt_DP_Amount.Value+"') ");
            }
        }

        private void txt_Name_E_Enter(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void txt_Name_E_Leave(object sender, EventArgs e)
        {
            CultureInfo ar = new CultureInfo("ar-sa");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
        }

        private void txt_Owner_E_Leave(object sender, EventArgs e)
        {
            CultureInfo ar = new CultureInfo("ar-sa");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(ar);
        }

        private void txt_Owner_E_Enter(object sender, EventArgs e)
        {
            CultureInfo en = new CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(en);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            dal.ClearTextBoxes(this);
            tabControl1.SelectedTabIndex = 0;
            txt_project_ID.Text = _ser().ToString();
            txt_Name.Focus();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };

            func(Controls);
            // txtCoId.Text = Properties.Settings.Default.CoId;
            //BranchId.Text = Properties.Settings.Default.BranchId;
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            PL.frmSerch frm = new PL.frmSerch();
            frm.lblHead.Text = "Enter Sanad No.";
            frm.ShowDialog();
            if (frm.Close_Type == 1)
            {
                DataTable dt_Pro = dal.getDataTabl_1(@"SELECT PROJ_CODE,PROJ_name,PROJ_E_NAME,OINER_NOTES,
                OINER_NOTES_E,Category,P_Priority,P_Status,Start_Date,End_Date,Budget_in_Days,Budget,
                Notes,DP_Acc,Project_Amount,DP_Ratio,DP_Amount
                FROM Projects where PROJ_CODE='" + frm.txtSearch.t.Text + "'");

                if (dt_Pro.Rows.Count > 0)
                {
                    txt_project_ID.Text = dt_Pro.Rows[0]["PROJ_CODE"].ToString();
                    txt_Name.Text = dt_Pro.Rows[0]["PROJ_name"].ToString();
                    txt_Name_E.Text = dt_Pro.Rows[0]["PROJ_E_NAME"].ToString();
                    txt_Owner.Text = dt_Pro.Rows[0]["OINER_NOTES"].ToString();
                    txt_Owner_E.Text = dt_Pro.Rows[0]["OINER_NOTES_E"].ToString();
                    cmb_Category.SelectedValue = dt_Pro.Rows[0]["Category"].ToString();
                    cmb_Priority.SelectedValue = dt_Pro.Rows[0]["P_Priority"].ToString();
                    cmb_Status.SelectedValue = dt_Pro.Rows[0]["P_Status"].ToString();
                    start_Date.Text = dt_Pro.Rows[0]["Start_Date"].ToString();
                    end_Date.Text = dt_Pro.Rows[0]["End_Date"].ToString();
                    txt_Budget.Text = dt_Pro.Rows[0]["Budget"].ToString().ToDecimal().ToString("N0");
                    txt_BudgetDays.Text = dt_Pro.Rows[0]["Budget_in_Days"].ToString().ParseInt(0).ToString();
                    txt_Note.Text = dt_Pro.Rows[0]["Notes"].ToString();
                    txt_DP_Acc.ID.Text = dt_Pro.Rows[0]["DP_Acc"].ToString();
                    txt_Amount.Text = dt_Pro.Rows[0]["Project_Amount"].ToString().ToDecimal().ToString("N0");
                    txt_DP_Ratio.Text = dt_Pro.Rows[0]["DP_Ratio"].ToString();
                    txt_DP_Amount.Text = dt_Pro.Rows[0]["DP_Amount"].ToString().ToDecimal().ToString("N0");
                    //Get_PItems(frm.txtSearch.t.Text);
                    //Get_MainItems(frm.txtSearch.t.Text);
                }
            }
        }

        private void Get_PItems(string _id)
        {
            DataTable dt_PItems = dal.getDataTabl_1(@"SELECT A.Item_Id,A.P_Id,A.item_no,
                A.P_Description,A.Unit,A.Qty,A.Price,A.total_amount,A.Notes,M.descr,
                M.Descr_eng,B.unit_Description,B.unit_Description_E
                FROM Project_Items as A 
                inner join Wh_Unit As B on B.Wh_Unit=A.Unit
                inner join wh_main_master As M on A.Item_No=M.item_no where P_Id = '" + _id+"'");
            if (dt_PItems.Rows.Count > 0)
            {
                dgv_p.Rows.Clear();




                for (int i = 0; i < dt_PItems.Rows.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dgv_p);
                    newRow.Cells[0].Value = dt_PItems.Rows[i]["Item_Id"];
                    newRow.Cells[1].Value = dt_PItems.Rows[i]["item_No"];
                    if (Properties.Settings.Default.lungh == "0")
                    {
                    newRow.Cells[2].Value = dt_PItems.Rows[i]["descr"];
                    newRow.Cells[4].Value = dt_PItems.Rows[i]["unit_Description"];
                    }
                    else
                    {
                        newRow.Cells[2].Value = dt_PItems.Rows[i]["Descr_eng"];
                        newRow.Cells[4].Value = dt_PItems.Rows[i]["unit_Description_E"];
                    }
                    newRow.Cells[3].Value = dt_PItems.Rows[i]["P_Description"];
                    newRow.Cells[5].Value = dt_PItems.Rows[i]["Qty"];
                    newRow.Cells[6].Value = dt_PItems.Rows[i]["Price"];
                    newRow.Cells[7].Value = dt_PItems.Rows[i]["total_amount"];
                    newRow.Cells[8].Value = dt_PItems.Rows[i]["Notes"];
                    newRow.Cells[9].Value = dt_PItems.Rows[i]["Unit"];
                    dgv_p.Rows.Add(newRow);
                   
                }

                get_item_id();
              
            }
        }

        private void Get_MainItems(string _id)
        {
            DataTable dt_MainItems = dal.getDataTabl_1(@"SELECT A.item_No,A.item_Description,A.item_Description_E,A.item_Notes,M.descr,M.Descr_eng,M.Unit,B.unit_Description,B.unit_Description_E
            FROM Main_Project_Items as A
            Inner Join wh_main_master as M on M.item_no = A.item_no
            LEFT join Wh_Unit as B on M.Unit =B.Wh_Unit
            where  Project_No= '" + _id + "'");
            if (dt_MainItems.Rows.Count > 0)
            {
                dgv_m.Rows.Clear();
                


                    
                    for (int i = 0; i < dt_MainItems.Rows.Count; i++)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dgv_m);
                    newRow.Cells[0].Value = dt_MainItems.Rows[i]["item_No"];
                    newRow.Cells[1].Value = dt_MainItems.Rows[i]["descr"];
                    newRow.Cells[2].Value = dt_MainItems.Rows[i]["item_Description"];
                    newRow.Cells[3].Value = dt_MainItems.Rows[i]["item_Description_E"];
                    newRow.Cells[4].Value = dt_MainItems.Rows[i]["item_Notes"];
                    dgv_m.Rows.Add(newRow);
                    }
                }
            
        }


        private void doubleInput1_ValueChanged(object sender, EventArgs e)
        {
            txt_DP_Amount.Value = txt_Amount.Value * txt_DP_Ratio.Value / 100;
        }

        private void txt_DP_Ratio_ValueChanged(object sender, EventArgs e)
        {
            txt_DP_Amount.Value = txt_Amount.Value * txt_DP_Ratio.Value / 100;

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateProjectItems_Click(object sender, EventArgs e)
        {
            dal.open();
            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;
            //try
            //{

                cmd.CommandText = @"delete FROM Project_Items where P_Id = '" + txt_project_ID.Text + "'";
                cmd.ExecuteNonQuery();


                for (int i = 0; i <= dgv_p.Rows.Count - 1; i++)
                {
                    DataGridViewRow DgRow = dgv_p.Rows[i];
                    if (DgRow.Cells[0].Value != null && DgRow.Cells[2].Value != null)
                    {
                        cmd.CommandText = @"INSERT INTO Project_Items (Item_Id, P_Id , Item_No , P_Description , Unit , Qty , Price , total_amount , Notes)
                                VALUES ('" + DgRow.Cells[0].Value.ToString() +"','" + txt_project_ID.Text + "','" + DgRow.Cells[1].Value.ToString() + "' ,'" + DgRow.Cells[3].Value.ToString() + "','" + DgRow.Cells[9].Value.ToString() + "','" + DgRow.Cells[5].Value.ToString() + "','" + DgRow.Cells[6].Value.ToString() + "','" + DgRow.Cells[7].Value.ToString() + "','" + DgRow.Cells[8].Value.ToString() + "')";
                                      cmd.ExecuteNonQuery();
                    }
                }




                //    foreach (Controls.P_Item_Row r in p_Grid1.flowLayoutPanel1.Controls)
                //{

                //    if (txt_ID.Text != string.Empty && r.txt_id.Text != string.Empty && r.txt_desc.Text != string.Empty && r.txt_unit.SelectedIndex > -1 && r.txt_qty.Value > 0 && r.txt_price.Value > 0)
                //    {

                //                cmd.CommandText = @"INSERT INTO Project_Items (Item_Id,P_Id,item_No,P_Description,Unit,Qty,Price,Notes)
                //                VALUES ('" + r.txt_id.Text + "','" + txt_ID.Text + "','"+r.txt_itemNo.Text+"' ,'" + r.txt_desc.Text + "','" + Convert.ToString(r.txt_unit.SelectedValue) + "','" + r.txt_qty.Value + "','" + r.txt_price.Value + "','" + r.txt_note.Text + "')";
                //                cmd.ExecuteNonQuery();
                //    }
                //}
                trans.Commit();
                MessageBox.Show("Data was saved ---- تم حفظ البيانات ",  "Save --- حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}


            //catch (Exception ex)
            //{
            //    trans.Rollback();
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    dal.sqlconn1.Close();
            //}

        }

        private void tabControlPanel3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dal.open();
            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;
            try
            {

                cmd.CommandText = @"delete FROM Main_Project_Items where Project_No = '" + txt_project_ID.Text + "'";
                cmd.ExecuteNonQuery();

                for (int i = 0; i <= dgv_m.Rows.Count - 1; i++)
                {
                    DataGridViewRow DgRow = dgv_m.Rows[i];
                    if (DgRow.Cells[0].Value != null && DgRow.Cells[2].Value == null)
                    {
                        MessageBox.Show("Check data completeness ---- تأكد من اكمال البيانات ", "error --- خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (DgRow.Cells[0].Value != null && DgRow.Cells[2].Value != null)
                        {
                            cmd.CommandText = @"INSERT INTO Main_Project_Items (item_No,item_Description,item_Description_E,item_Notes,Project_No)
                        VALUES ('" + DgRow.Cells[0].Value + "','" + DgRow.Cells[2].Value + "','" + DgRow.Cells[3].Value + "' ,'" + DgRow.Cells[4].Value + "','" + txt_project_ID.Text + "')";
                            cmd.ExecuteNonQuery();

                        }
                    }
                }


                        trans.Commit();
                MessageBox.Show("Data was saved ---- تم حفظ البيانات ", "Save --- حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dal.sqlconn_1.Close();
            }

        }

        private void p_Main_Grid1_KeyDown(object sender, KeyEventArgs e)
        {

        }

       

        private void tabControlPanel3_Click_1(object sender, EventArgs e)
        {
          
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btntype == "0")
            {
                string _itemNo   = txt_item.ID.Text;
                string _itemName = txt_item.Desc.Text;
                string _desc     = txt_desc.Text;
                string _descE    = txt_descE.Text;
                string _note     = txt_m_note.Text;
                string[] row = { _itemNo, _itemName, _desc, _descE, _note };
                dgv_m.Rows.Add(row);
            }
            else
            {
                dgv_m.Rows[m].Cells[0].Value = txt_item.ID.Text;
                dgv_m.Rows[m].Cells[1].Value = txt_item.Desc.Text;
                dgv_m.Rows[m].Cells[2].Value = txt_desc.Text;
                dgv_m.Rows[m].Cells[3].Value = txt_descE.Text;
                dgv_m.Rows[m].Cells[4].Value = txt_m_note.Text;

            }
            btntype = "0";

            txt_item.ID.Clear();
            txt_item.Desc.Clear();
            txt_desc.Clear();
            txt_descE.Clear();
            txt_m_note.Clear();
            txt_item.ID.Focus();



        }

    private void dgv_m_DoubleClick(object sender, EventArgs e)
        {
            btntype = "1";
            m = dgv_m.CurrentRow.Index;
            try
            {
                txt_item.ID.Text   = dgv_m.CurrentRow.Cells[0].Value.ToString();
                //txt_item.Desc.Text
                txt_desc.Text      = dgv_m.CurrentRow.Cells[2].Value.ToString();
                txt_descE.Text     = dgv_m.CurrentRow.Cells[3].Value.ToString();
                txt_m_note.Text    = dgv_m.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }

            }

        private void btnAdd_1_Click(object sender, EventArgs e)
        {
            if (btntype_1 == "0")
            {
                string _item_id    = txt_Item_Id.Text;
                //string _itemNo_p   = txt_item_p.ID.Text;
                //string _itemName_p = txt_item_p.Desc.Text;
                string _desc_p     = txt_description_p.Text;
                string _unit_p     = txt_unit.Text;
                double _qty        = txt_Qty.Value;
                double _unitPrice  = txt_unitPrice.Value;
                double _Amount     = txt_totalAmount.Value;
                string _note_p     = txt_m_note.Text;
                string _unit_id    = txt_unit.SelectedValue.ToString();
             //   string[] row = { _item_id,_itemNo_p, _itemName_p, _desc_p, _unit_p, _qty.ToString(), _unitPrice.ToString(), _Amount.ToString(), _note_p, _unit_id };
              //  dgv_p.Rows.Add(row);
            }
            else
            {
                dgv_p.Rows[m_1].Cells[0].Value = txt_Item_Id.Text;
               // dgv_p.Rows[m_1].Cells[1].Value = txt_item_p.ID.Text;
              //  dgv_p.Rows[m_1].Cells[2].Value = txt_item_p.Desc.Text;
                dgv_p.Rows[m_1].Cells[3].Value = txt_description_p.Text;
                dgv_p.Rows[m_1].Cells[4].Value = txt_unit.Text;
                dgv_p.Rows[m_1].Cells[5].Value = txt_Qty.Value;
                dgv_p.Rows[m_1].Cells[6].Value = txt_unitPrice.Value;
                dgv_p.Rows[m_1].Cells[7].Value = txt_totalAmount.Value;
                dgv_p.Rows[m_1].Cells[8].Value = txt_m_note.Text;
                dgv_p.Rows[m_1].Cells[9].Value = txt_unit.SelectedValue.ToString();

            }
           
            btntype_1 = "0";
            //dal.ClearTextBoxes(this);
            txt_Item_Id.Clear();
            //txt_item_p.ID.Clear();
            txt_description_p.Clear();
            txt_Qty.Value=0;
            txt_unitPrice.Value=0;
            txt_m_note.Clear();
            txt_unit.SelectedValue = -1;
            get_item_id();
            //txt_item_p.ID.Focus();

        }

        private void get_item_id()
        {
            int max = 0;
            if(dgv_p.Rows.Count == 0)
            {
                txt_Item_Id.Text = "1";
            }
            else
            {
            for (int i = 0; i <= dgv_p.Rows.Count - 1; i++)
            {
                if (max < int.Parse(dgv_p.Rows[i].Cells[0].Value.ToString()))
                {
                    max = int.Parse(dgv_p.Rows[i].Cells[0].Value.ToString());
                }
            }

            txt_Item_Id.Text = (max+1).ToString();
            }


        }

        private void dgv_p_DoubleClick(object sender, EventArgs e)
        {
            btntype_1 = "1";
            m_1 = dgv_p.CurrentRow.Index;
            try
            {
                txt_Item_Id.Text = dgv_p.CurrentRow.Cells[0].Value.ToString();
                //txt_item_p.ID.Text          = dgv_p.CurrentRow.Cells[1].Value.ToString();
              //  txt_item_p.Desc.Text        = dgv_p.CurrentRow.Cells[0].Value.ToString();
                txt_description_p.Text      = dgv_p.CurrentRow.Cells[3].Value.ToString();
                txt_unit.SelectedValue      = dgv_p.CurrentRow.Cells[9].Value.ToString();
                txt_Qty.Value               = Convert.ToDouble(dgv_p.CurrentRow.Cells[5].Value);
                txt_unitPrice.Value = Convert.ToDouble(dgv_p.CurrentRow.Cells[6].Value);
                txt_totalAmount.Value = Convert.ToDouble(dgv_p.CurrentRow.Cells[7].Value);
                txt_m_note.Text             = dgv_p.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {

            }


        }

        private void frmProjectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txt_Qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_Qty_KeyUp(object sender, KeyEventArgs e)
        {
            txt_totalAmount.Value = txt_Qty.Value * txt_unitPrice.Value;
        }

        private void txt_unitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            txt_totalAmount.Value = txt_Qty.Value * txt_unitPrice.Value;
        }

        private void txt_Note_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Item_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            //txt_item_p.txt_projectNo.Text = txt_project_ID.Text;
        }

        private void txt_item_p_Load(object sender, EventArgs e)
        {
        //    txt_unit.SelectedValue = txt_item_p.txt_Unit.Text;
        }

        private void txt_item_p_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_description_p.Focus();
            }

        }

        private void txt_description_p_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Qty.Value > 0)
            {
                txt_unitPrice.Focus();
            }
        }

        private void txt_unitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_unitPrice.Value > 0)
            {
                btnAdd_1.Focus();
            }
        }

        private void txt_item_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_desc.Focus();
            }
        }

        private void txt_desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_descE.Focus();
            }
        }

        private void txt_descE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_m_note.Focus();
            }
        }

        private void txt_m_note_KeyDown(object sender, KeyEventArgs e)
        {
            btnAdd.Focus();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
