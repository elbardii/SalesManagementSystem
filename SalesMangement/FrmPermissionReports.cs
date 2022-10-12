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
    public partial class FrmPermissionReports : MaterialForm
    {
        public FrmPermissionReports()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }

        Database db = new Database();
        DataTable dtReports = new DataTable();

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

        private void FrmPermissionReports_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null, null);
        }

        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                dtReports.Clear();
                dtReports = db.ReadData("select * from Users_Reports Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtReports.Rows.Count >= 1)
                {
                    //=================== Customers Reports
                    if (Convert.ToInt32(dtReports.Rows[0][1]) == 1)
                    {
                        CheckboxCustomerReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReports.Rows[0][1]) == 0)
                    {
                        CheckboxCustomerReport.Checked = false;
                    }
                    //=================== Suppliers Reports
                    if (Convert.ToInt32(dtReports.Rows[0][2]) == 1)
                    {
                        CheckboxSuppliersReports.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReports.Rows[0][2]) == 0)
                    {
                        CheckboxSuppliersReports.Checked = false;
                    }
                    //=================== Sales Reports
                    if (Convert.ToInt32(dtReports.Rows[0][3]) == 1)
                    {
                        CheckboxSalesReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReports.Rows[0][3]) == 0)
                    {
                        CheckboxSalesReport.Checked = false;
                    }
                    //=================== Purchase Reports
                    if (Convert.ToInt32(dtReports.Rows[0][4]) == 1)
                    {
                        CheckboxPurchaseReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReports.Rows[0][4]) == 0)
                    {
                        CheckboxPurchaseReport.Checked = false;
                    }
                    //=================== Returns Reports
                    if (Convert.ToInt32(dtReports.Rows[0][5]) == 1)
                    {
                        CheckboxReturnsReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReports.Rows[0][5]) == 0)
                    {
                        CheckboxReturnsReport.Checked = false;
                    }
                    //=================== Expense Report
                    if (Convert.ToInt32(dtReports.Rows[0][6]) == 1)
                    {
                        CheckboxExpenseReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReports.Rows[0][6]) == 0)
                    {
                        CheckboxExpenseReport.Checked = false;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Save Users
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomersReports = 0, SuppliersReports = 0, SalesReports = 0, PurchaseReports = 0, ReturnsReports = 0, ExpenseReport = 0;
                //=============Customers Reports
                if (CheckboxCustomerReport.Checked)
                    CustomersReports = 1;
                else
                    CustomersReports = 0;
                //=============Suppliers Reports
                if (CheckboxSuppliersReports.Checked)
                    SuppliersReports = 1;
                else
                    SuppliersReports = 0;
                //=============Sales Reports
                if (CheckboxSalesReport.Checked)
                    SalesReports = 1;
                else
                    SalesReports = 0;
                //=============Purchase Reports
                if (CheckboxPurchaseReport.Checked)
                    PurchaseReports = 1;
                else
                    PurchaseReports = 0;
                //=============Returns Reports
                if (CheckboxReturnsReport.Checked)
                    ReturnsReports = 1;
                else
                    ReturnsReports = 0;
                //=============Expense Report
                if (CheckboxExpenseReport.Checked)
                    ExpenseReport = 1;
                else
                    ExpenseReport = 0;
                db.ExecuteData("Update Users_Reports Set User_CustomersReports = " + CustomersReports + ", User_SuppliersReports = " + SuppliersReports + ",User_SalesReports = " + SalesReports + ", User_PurchaseReports = "+PurchaseReports+ ",User_ReturnsReports = "+ReturnsReports+ ", User_ExpenseReports = "+ ExpenseReport + "  Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
