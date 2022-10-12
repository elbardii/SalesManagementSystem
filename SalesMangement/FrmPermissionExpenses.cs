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
    public partial class FrmPermissionExpenses : MaterialForm
    {
        public FrmPermissionExpenses()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }

        Database db = new Database();
        DataTable dtExpenses = new DataTable();

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

        private void FrmPermissionExpenses_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null,null);
        }

        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtExpenses.Clear();
                dtExpenses = db.ReadData("select * from Users_Expenses Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtExpenses.Rows.Count >= 1)
                {
                    //===================Expenses Type
                    if (Convert.ToInt32(dtExpenses.Rows[0][1]) == 1)
                    {
                        CheckboxExpensesType.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][1]) == 0)
                    {
                        CheckboxExpensesType.Checked = false;
                    }
                    //=================== Expense Management
                    if (Convert.ToInt32(dtExpenses.Rows[0][2]) == 1)
                    {
                        CheckboxExpenseManagement.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][2]) == 0)
                    {
                        CheckboxExpenseManagement.Checked = false;
                    }
                    //=================== Expenses Reports
                    if (Convert.ToInt32(dtExpenses.Rows[0][3]) == 1)
                    {
                        CheckboxExpensesReports.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][3]) == 0)
                    {
                        CheckboxExpensesReports.Checked = false;
                    }
                    //===================Receipt Voucher
                    if (Convert.ToInt32(dtExpenses.Rows[0][4]) == 1)
                    {
                        CheckboxReceiptVoucher.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][4]) == 0)
                    {
                        CheckboxReceiptVoucher.Checked = false;
                    }
                    //=================== Receipt 
                    if (Convert.ToInt32(dtExpenses.Rows[0][5]) == 1)
                    {
                        CheckboxReceipt.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][5]) == 0)
                    {
                        CheckboxReceipt.Checked = false;
                    }
                    //=================== Bond Report
                    if (Convert.ToInt32(dtExpenses.Rows[0][6]) == 1)
                    {
                        CheckboxBondReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][6]) == 0)
                    {
                        CheckboxBondReport.Checked = false;
                    }
                    //=================== Tax Declaration
                    if (Convert.ToInt32(dtExpenses.Rows[0][7]) == 1)
                    {
                        CheckboxTaxDeclaration.Checked = true;
                    }
                    else if (Convert.ToInt32(dtExpenses.Rows[0][7]) == 0)
                    {
                        CheckboxTaxDeclaration.Checked = false;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Save
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int ExpensesType = 0, ExpenseManagement = 0, ExpensesReports = 0, ReceiptVoucher = 0, Receipt = 0, BondReport = 0;
                //=============Expenses Type
                if (CheckboxExpensesType.Checked)
                    ExpensesType = 1;
                else
                    ExpensesType = 0;
                //=============Expense Management
                if (CheckboxExpenseManagement.Checked)
                    ExpenseManagement = 1;
                else
                    ExpenseManagement = 0;
                //=============Expenses Reports
                if (CheckboxExpensesReports.Checked)
                    ExpensesReports = 1;
                else
                    ExpensesReports = 0;
                //=============Receipt Voucher
                if (CheckboxReceiptVoucher.Checked)
                    ReceiptVoucher = 1;
                else
                    ReceiptVoucher = 0;
                //=============Receipt
                if (CheckboxReceipt.Checked)
                    Receipt = 1;
                else
                    Receipt = 0;
                //=============Bond Report
                if (CheckboxBondReport.Checked)
                    BondReport = 1;
                else
                    BondReport = 0;
                db.ExecuteData("Update Users_Expenses Set User_ExpensesType = " + ExpensesType + ", User_ExpenseManagement = " + ExpenseManagement + ",User_ExpensesReports = " + ExpensesReports + ", User_ReceiptVoucher = " + ReceiptVoucher + ",User_Receipt = " + Receipt + ", User_BondReport = " + BondReport + "  Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
