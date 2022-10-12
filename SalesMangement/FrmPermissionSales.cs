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
    public partial class FrmPermissionSales : MaterialForm
    {
        public FrmPermissionSales()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dtSales = new DataTable();

        private void FillUser()
        {
            cbxChooseUsername.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsername.DisplayMember = "UserName";
            cbxChooseUsername.ValueMember = "User_ID";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPermissionSales_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null,null);  
        }

        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtSales.Clear();
                dtSales = db.ReadData("select * from Users_Sales Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtSales.Rows.Count >= 1)
                {
                    //===================Sales Management
                    if (Convert.ToInt32(dtSales.Rows[0][1]) == 1)
                    {
                        CheckboxSalesManagement.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSales.Rows[0][1]) == 0)
                    {
                        CheckboxSalesManagement.Checked = false;
                    }

                    //===================Sales Profit Report
                    if (Convert.ToInt32(dtSales.Rows[0][2]) == 1)
                    {
                        CheckboxSalesProfitReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSales.Rows[0][2]) == 0)
                    {
                        CheckboxSalesProfitReport.Checked = false;
                    }
                    //=====================Sales Report
                    if (Convert.ToInt32(dtSales.Rows[0][3]) == 1)
                    {
                        CheckboxSalesReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSales.Rows[0][3]) == 0)
                    {
                        CheckboxSalesReport.Checked = false;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Save User 
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int SalesManagement = 0, SalesProfit = 0, SalesReport = 0;
                //=============Sales Management
                if (CheckboxSalesManagement.Checked)
                    SalesManagement = 1;
                else
                    SalesManagement = 0;
                //=============Sales Profit Report
                if (CheckboxSalesProfitReport.Checked)
                    SalesProfit = 1;
                else
                    SalesProfit = 0;
                //=============Sales Report
                if (CheckboxSalesReport.Checked)
                    SalesReport = 1;
                else
                    SalesReport = 0;
                db.ExecuteData("Update Users_Sales Set User_SalesManagement = " + SalesManagement + ", User_Sales_Profit = " + SalesProfit + ",User_Sales_Report = " + SalesReport + " Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
