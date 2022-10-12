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
    public partial class FrmCustomerReports : MaterialForm
    {
        public FrmCustomerReports()
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
            for (int i = 0; i <= DgvCustRep.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvCustRep.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = Math.Round(Total, 2).ToString();
        }
        //COMBOBOX : Customers 
        private void FillCustomers()
        {
            CbxCustRep.DataSource = db.ReadData("select * from Customers ", "");
            CbxCustRep.DisplayMember = "Cust_Name";
            CbxCustRep.ValueMember = "Cust_ID";
        }

        private void FrmCustomerReports_Load(object sender, EventArgs e)
        {
            try
            {
                FillCustomers();
            }
            catch (Exception)
            {


            }
            CbxCustRep.SelectedIndex = -1;
            DateTimeSup.Text = DateTime.Now.ToString();
            dt.Clear();
            dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number ',[Cust_Name]  as 'Customer Name ',[Price_Total] as 'Total Price',[Date] as 'Invoice Date'FROM [dbo].[Customer_Report]", "");
            DgvCustRep.DataSource = dt;
            Total();
        }
        //BUTTON :  Delete All Customers Report an database
        private void btnDeleteAllRep_Click(object sender, EventArgs e)
        {
            if (DgvCustRep.Rows.Count >= 1)
            {
                if (MessageBox.Show("Are you sure to delete all Customers Report data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (rbtnSpCust.Checked == true)
                    {
                        db.ExecuteData("Delete from Customer_Report Where Cust_Name = '" + CbxCustRep.SelectedValue + "'", "All Customers Report data has been deleted");
                        FrmCustomerReports_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Please Select  Name Of  Customer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }
        }
        //BUTTON : Searsh
        private void btnSearsh_Click(object sender, EventArgs e)
        {

            dt.Clear();
            if (rbtnAllCust.Checked == true)
            {
                dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number ',[Cust_Name]  as 'Customer Name ',[Price_Total] as 'Total Price',[Date] as 'Invoice Date'FROM [dbo].[Customer_Report]", "");
            }

            else if (rbtnSpCust.Checked == true)
            {

                dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ',[Cust_Name]  as 'Customer Name ',[Price_Total] as 'Total Price',[Date] as 'Invoice Date'FROM [dbo].[Customer_Report] Where Cust_Name ='" + txtSearsh.Text + "'", "");

            }
            DgvCustRep.DataSource = dt;
            Total();
        }
    }
}