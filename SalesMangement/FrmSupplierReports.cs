using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SalesMangement
{
    public partial class FrmSupplierReports : MaterialForm
    {
        public FrmSupplierReports()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }

        Database db = new Database();
        DataTable dt = new DataTable();

        //TOTAL: A function that sums  sum of the price
        private void Total()
        {
            decimal Total = 0;
            for (int i = 0; i <= DgvSupRep.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvSupRep.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = Math.Round(Total, 2).ToString();
        }
        //COMBOBOX : Suppliers 
        private void FillSuppliers()
        {
            CbxSupRep.DataSource = db.ReadData("select * from Suppliers ", "");
            CbxSupRep.DisplayMember = "Sup_Name";
            CbxSupRep.ValueMember = "Sup_ID";
        }

        private void FrmSupplierReports_Load(object sender, EventArgs e)
        {

            try
            {
                FillSuppliers();
            }
            catch (Exception)
            {

              
            }
            CbxSupRep.SelectedIndex = -1;
            DateTimeSup.Text = DateTime.Now.ToString();
            dt.Clear();
            dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Price_Total as 'Price ', [Date] as  'Invoice Date' FROM dbo.Supplier_Report, Suppliers where   Suppliers.Sup_ID =  Supplier_Report.Sup_ID", "");
            DgvSupRep.DataSource = dt;
            Total();
           
        }
        //BUTTON :  Delete All Supplier Report an database
        private void btnDeleteAllRep_Click(object sender, EventArgs e)
        {
            if(DgvSupRep.Rows.Count >= 1)
            {
                if (MessageBox.Show("Are you sure to delete all Supplier Report data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(rbtnSpSup.Checked == true)
                    {
                        db.ExecuteData("Delete from Supplier_Report Where Sup_ID = "+CbxSupRep.SelectedValue+"", "All Supplier Report data has been deleted");
                        FrmSupplierReports_Load(null,null);
                    }
                    else 
                    {
                        MessageBox.Show("Please Select  Name Of  Supplier", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }

                }     
            }
        }
        //BUTTON : Searsh
        private void btnSearsh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (rbtnAllSup.Checked == true)
            {
                dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Price_Total as ' Total  Price ', [Date] as  'Invoice Date' FROM dbo.Supplier_Report, Suppliers where   Suppliers.Sup_ID =  Supplier_Report.Sup_ID ", "");

            }

            else if (rbtnSpSup.Checked == true)
            {

                dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Price_Total as ' Total  Price ', [Date] as  'Invoice Date' FROM dbo.Supplier_Report, Suppliers where   Suppliers.Sup_ID =  Supplier_Report.Sup_ID and Suppliers.Sup_Name = '" + txtSearsh.Text + "'", "");

            }
            DgvSupRep.DataSource = dt;
            Total();
        }
        //ENTER 
        private void txtSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
