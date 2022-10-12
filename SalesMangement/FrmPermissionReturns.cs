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
    public partial class FrmPermissionReturns : MaterialForm
    {
        public FrmPermissionReturns()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dtReturn = new DataTable();

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

        private void FrmPermissionReturns_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null,null);
        }
        //COMMITTED
        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtReturn.Clear();
                dtReturn = db.ReadData("select * from Users_Returns Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtReturn.Rows.Count >= 1)
                {
                    //===================Returns Management
                    if (Convert.ToInt32(dtReturn.Rows[0][1]) == 1)
                    {
                        CheckboxReturnsManagement.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReturn.Rows[0][1]) == 0)
                    {
                        CheckboxReturnsManagement.Checked = false;
                    }
                    //===================Returns  Report
                    if (Convert.ToInt32(dtReturn.Rows[0][2]) == 1)
                    {
                        CheckboxReturnsReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtReturn.Rows[0][2]) == 0)
                    {
                        CheckboxReturnsReport.Checked = false;
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
                int ReturnsManagement = 0, ReturnsReport = 0;
                //=============Returns  Management
                if (CheckboxReturnsManagement.Checked)
                    ReturnsManagement = 1;
                else
                    ReturnsManagement = 0;
                //=============Returns Report
                if (CheckboxReturnsReport.Checked)
                    ReturnsReport = 1;
                else
                    ReturnsReport = 0;
                db.ExecuteData("Update Users_Returns Set User_ReturnsManagement = " + ReturnsManagement + ", User_ReturnsReport = " + ReturnsReport  + " Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
