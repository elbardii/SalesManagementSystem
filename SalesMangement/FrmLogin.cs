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
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserName.Focus();
            txtPassword.Clear();

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(null, null);
            }
        }
        private bool Trial()
        {
            int countnum1 = Properties.Settings.Default.Trial;
            int countnum2 = countnum1 + 1;
            Properties.Settings.Default.Trial = countnum2;
            Properties.Settings.Default.Save();

            if(countnum2 >= 4)
            {
                MessageBox.Show("This is a trial version that has expired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                int num = 5 - countnum2;
                MessageBox.Show("This is a trial version and you have the remaining number of  " + num + " times", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }
        private void check()
        {
            DataTable dt = new DataTable();
            dt = db.ReadData("select from ", "");
        }
        string Activation = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Activation = Properties.Settings.Default.Activation;
            if (Activation == "NO")
            {
                FrmActivation frmActivation = new FrmActivation();
                frmActivation.ShowDialog();
            }
            else
            {
                dt.Clear();
                if (rtnAdministrator.Checked)
                    dt = db.ReadData("select * from Users Where UserName = N'" + txtUserName.Text + "' and User_Password = N'" + txtPassword.Text + "' and User_Type = N'Administrator'", "");
                else if (rtnEmployee.Checked)
                    dt = db.ReadData("select * from Users Where UserName = N'" + txtUserName.Text + "' and User_Password = N'" + txtPassword.Text + "' and User_Type = N'Normal User'", "");
                if (dt.Rows.Count <= 0)
                {
                    DataTable dtSafe = new DataTable();
                    dtSafe = db.ReadData("select * from Safe_Data ", "");
                    if (dtSafe.Rows.Count <= 0)
                    {
                        db.ExecuteData("insert into Safe_Data Values (1 , N'Main Safe')", "");
                    }
                    db.ExecuteData("insert into Users Values (1 , N'Admin' , N'AdminAdmin' , N'Administrator' , 1 , 0 )", "");
                    db.ExecuteData("insert into Users_Settings Values (1,1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Customers Values (1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Suppliers Values (1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Purchasing Values (1,1,1)", "");
                    db.ExecuteData("insert into Users_Sales Values (1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Returns Values (1,1,1)", "");
                    db.ExecuteData("insert into Users_Reports Values (1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Expenses Values (1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Backups Values (1,1,1)", "");
                    db.ExecuteData("insert into Users_SafeBank Values (1,1,1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Employees Values (1,1,1,1,1,1,1,1)", "");
                    dt.Clear();
                    if (rtnAdministrator.Checked)
                        dt = db.ReadData("select * from Users Where UserName = N'" + txtUserName.Text + "' and User_Password = N'" + txtPassword.Text + "' and User_Type = N'Administrator'", "");
                    else if (rtnEmployee.Checked)
                        dt = db.ReadData("select * from Users Where UserName = N'" + txtUserName.Text + "' and User_Password = N'" + txtPassword.Text + "' and User_Type = N'Normal User'", "");

                }
                if (dt.Rows.Count >= 1)
                {
                    //bool check;
                    //check = Trial();
                    //if (check == false)
                    //{
                    //    return;
                    //}
                    Properties.Settings.Default.UserName = txtUserName.Text;
                    Properties.Settings.Default.Safe_ID = Convert.ToInt32(dt.Rows[0][4]);
                    Properties.Settings.Default.Save();
                    this.Hide();
                    FrmDashboard frmDashboard = new FrmDashboard();
                    frmDashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Passwords", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
