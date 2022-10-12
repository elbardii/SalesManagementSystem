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
    public partial class FrmPermissionSuppliers : MaterialForm
    {
        public FrmPermissionSuppliers()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db  = new Database();
        DataTable dtSuppliers = new DataTable();
        private void FillUser()
        {
            cbxChooseUsername.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsername.DisplayMember = "UserName";
            cbxChooseUsername.ValueMember = "User_ID";
        }
        //BUTTON : close form 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FrmPermissionSuppliers_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null,null);
        }

        //COMMITTED
        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtSuppliers.Clear();
                dtSuppliers = db.ReadData("select * from Users_Suppliers Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtSuppliers.Rows.Count >= 1)
                {
                    //===================Suppliers Data
                    if (Convert.ToInt32(dtSuppliers.Rows[0][1]) == 1)
                    {
                        CheckboxSuppliersData.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSuppliers.Rows[0][1]) == 0)
                    {
                        CheckboxSuppliersData.Checked = false;
                    }

                    //===================Suppliers Accounts
                    if (Convert.ToInt32(dtSuppliers.Rows[0][1]) == 1)
                    {
                        CheckboxSuppliersAccounts.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSuppliers.Rows[0][1]) == 0)
                    {
                        CheckboxSuppliersAccounts.Checked = false;
                    }
                    //=====================Suppliers Reports
                    if (Convert.ToInt32(dtSuppliers.Rows[0][3]) == 1)
                    {
                        CheckboxSuppliersReports.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSuppliers.Rows[0][3]) == 0)
                    {
                        CheckboxSuppliersReports.Checked = false;
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
                int SupplierData = 0, SupplierAccounts = 0, SupplierReports = 0;
                //=============Customer Data
                if (CheckboxSuppliersData.Checked)
                    SupplierData = 1;
                else
                    SupplierData = 0;
                //=============Customer Accounts
                if (CheckboxSuppliersAccounts.Checked)
                    SupplierAccounts = 1;
                else
                    SupplierAccounts = 0;
                //=============Customers Reports
                if (CheckboxSuppliersReports.Checked)
                    SupplierReports = 1;
                else
                    SupplierReports = 0;
                db.ExecuteData("Update Users_Suppliers Set User_SuppliersData = " + SupplierData + ", User_SuppliersAccounts = " + SupplierAccounts + ",User_SuppliersReports = " + SupplierReports + " Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
