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
    public partial class FrmPermissionCustomers : MaterialForm
    {
        public FrmPermissionCustomers()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dtCustomers = new DataTable();
        private void FillUser()
        {
            cbxChooseUsername.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsername.DisplayMember = "UserName";
            cbxChooseUsername.ValueMember = "User_ID";
        }

        //BUTTON : Close form
        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void FrmPermissionCustomers_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null, null);
        }
        //BUTTON : Save User
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerData = 0, CustomerAccounts = 0, CustomersReports = 0;
                //=============Customer Data
                if (CheckboxCustomerData.Checked)
                    CustomerData = 1;
                else
                    CustomerData = 0;
                //=============Customer Accounts
                if (CheckboxCustomerAccounts.Checked)
                    CustomerAccounts = 1;
                else
                    CustomerAccounts = 0;
                //=============Customers Reports
                if (CheckboxCustomerReports.Checked)
                    CustomersReports = 1;
                else
                    CustomersReports = 0;
                db.ExecuteData("Update Users_Customers Set User_CustomerData = " + CustomerData + ", User_CustomerAccounts = " + CustomerAccounts + ",User_CustomersReports = " + CustomersReports + " Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
      
        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtCustomers.Clear();
                dtCustomers = db.ReadData("select * from Users_Customers Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtCustomers.Rows.Count >= 1)
                {
                    //===================Customer Data
                    if (Convert.ToInt32(dtCustomers.Rows[0][1]) == 1)
                    {
                        CheckboxCustomerData.Checked = true;
                    }
                    else if (Convert.ToInt32(dtCustomers.Rows[0][1]) == 0)
                    {
                        CheckboxCustomerData.Checked = false;
                    }

                    //===================Customer Accounts
                    if (Convert.ToInt32(dtCustomers.Rows[0][2]) == 1)
                    {
                        CheckboxCustomerAccounts.Checked = true;
                    }
                    else if (Convert.ToInt32(dtCustomers.Rows[0][2]) == 0)
                    {
                        CheckboxCustomerAccounts.Checked = false;
                    }
                    //=====================CustomerReports
                    if (Convert.ToInt32(dtCustomers.Rows[0][3]) == 1)
                    {
                        CheckboxCustomerReports.Checked = true;
                    }
                    else if (Convert.ToInt32(dtCustomers.Rows[0][3]) == 0)
                    {
                        CheckboxCustomerReports.Checked = false;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
