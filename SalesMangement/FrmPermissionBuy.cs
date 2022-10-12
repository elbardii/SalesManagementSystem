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
    public partial class FrmPermissionBuy : MaterialForm
    {
        public FrmPermissionBuy()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }

        Database db = new Database();
        DataTable dtBuy = new DataTable();

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

        private void FrmPermissionBuy_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null, null);
        }

        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtBuy.Clear();
                dtBuy = db.ReadData("select * from Users_Purchasing Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtBuy.Rows.Count >= 1)
                {
                    //===================Purchasing Management
                    if (Convert.ToInt32(dtBuy.Rows[0][1]) == 1)
                    {
                        CheckboxPurchasingManagement.Checked = true;
                    }
                    else if (Convert.ToInt32(dtBuy.Rows[0][1]) == 0)
                    {
                        CheckboxPurchasingManagement.Checked = false;
                    }

                    //===================Purchasing Report
                    if (Convert.ToInt32(dtBuy.Rows[0][2]) == 1)
                    {
                        CheckboxPurchaseReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtBuy.Rows[0][2]) == 0)
                    {
                        CheckboxPurchaseReport.Checked = false;
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
                int PurchasingManagement = 0, PurchasingReport = 0;
                //=============Purchasing Management
                if (CheckboxPurchasingManagement.Checked)
                    PurchasingManagement = 1;
                else
                    PurchasingManagement = 0;
                //=============Purchasing Report
                if (CheckboxPurchaseReport.Checked)
                    PurchasingReport = 1;
                else
                    PurchasingReport = 0;
               
               
                db.ExecuteData("Update Users_Purchasing Set User_PurchasingManagement = " + PurchasingManagement + ", User_PurchasingReports = " + PurchasingReport + " Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
