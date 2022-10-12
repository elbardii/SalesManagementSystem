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
    public partial class FrmPermissionBackup : MaterialForm
    {
        public FrmPermissionBackup()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }

        Database db = new Database();
        DataTable dtBackup = new DataTable();

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

        private void FrmPermissionBackup_Load(object sender, EventArgs e)
        {
            FillUser();
            cbxChooseUsername_SelectionChangeCommitted(null,null);
        }

        private void cbxChooseUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtBackup.Clear();
                dtBackup = db.ReadData("select * from Users_Backups Where User_ID = " + cbxChooseUsername.SelectedValue + " ", "");
                if (dtBackup.Rows.Count >= 1)
                {
                    //===================Take a Backup
                    if (Convert.ToInt32(dtBackup.Rows[0][1]) == 1)
                    {
                        CheckboxTakeBackup.Checked = true;
                    }
                    else if (Convert.ToInt32(dtBackup.Rows[0][1]) == 0)
                    {
                        CheckboxTakeBackup.Checked = false;
                    }
                    //=================== restore Backup
                    if (Convert.ToInt32(dtBackup.Rows[0][2]) == 1)
                    {
                        CheckboxRestoreBackups.Checked = true;
                    }
                    else if (Convert.ToInt32(dtBackup.Rows[0][2]) == 0)
                    {
                        CheckboxRestoreBackups.Checked = false;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        //BUTTON : save user
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int TakeBackup = 0, RestoreBackups = 0;
                //=============Take BackUps
                if (CheckboxTakeBackup.Checked)
                    TakeBackup = 1;
                else
                    TakeBackup = 0;
                //=============Restore Backups
                if (CheckboxRestoreBackups.Checked)
                    RestoreBackups = 1;
                else
                    RestoreBackups = 0;

                db.ExecuteData("Update Users_Backups Set User_TakeBackups = " + TakeBackup + ", User_RestoreBackups = " + RestoreBackups + " Where User_ID = " + cbxChooseUsername.SelectedValue + "", "Edited Successfully");
                cbxChooseUsername.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}
