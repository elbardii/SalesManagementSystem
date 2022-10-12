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
    public partial class FrmAddNewUser : MaterialForm
    {
        public FrmAddNewUser()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        DataTable dtPermission = new DataTable();
        int Row;
        /// <summary>
        ///AutoNumberNSafe
        /// A function that adds a new ID in the database 
        ///and increments 1 automatically in each operation
        /// Clear the text box again after each operation
        /// Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumber()
        {
            dtPermission.Clear();
            dtPermission = db.ReadData("SELECT [User_ID] as 'ID',[UserName] AS 'User Name',[User_Type] as 'Type',[User_Profit] as 'Profit Rate'FROM [dbo].[Users]", "");
            DgvNewUser.DataSource = dtPermission;
            dt.Clear();
            dt = db.ReadData("select max(User_ID) from Users ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtIdUser.Text = "1";
            }
            else
            {
                txtIdUser.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            txtUsername.Clear();
            txtPassword.Clear();
            NumProfit.Value = 0;

            try
            {
                cbxType.SelectedIndex = 0;
                cbxDepositInSafe.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
           // FillUser();
            //focus on textbox Name type Expenses
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

        }
        /* showNSafe
         * A function that displays data from the database
        */
        private void show()
        {
            dt.Clear();
            dt = db.ReadData("select * from Users ", "");
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database Table  Safe_Data
                txtIdUser.Text = dt.Rows[Row][0].ToString();
                txtUsername.Text = dt.Rows[Row][1].ToString();
                txtPassword.Text = dt.Rows[Row][2].ToString();
                cbxType.Text = dt.Rows[Row][3].ToString();
                cbxDepositInSafe.SelectedValue = Convert.ToDecimal(dt.Rows[Row][4]);
                NumProfit.Value = Convert.ToDecimal(dt.Rows[Row][4]);
            }
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;

        }

        private bool check()
        {
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter  Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtPassword.Text.Length <= 7)
            {
                MessageBox.Show("Your password must be at least 8 characters.");
                return true;
            }

            else
            {
                return false;
            }
        }
        private void FillSafe()
        {
            cbxDepositInSafe.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxDepositInSafe.DisplayMember = "Safe_Name";
            cbxDepositInSafe.ValueMember = "Safe_ID";
        }

        private void FrmAddNewUser_Load(object sender, EventArgs e)
        {
            AutoNumber();
            FillSafe();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                db.ExecuteData("insert into Users values (" + txtIdUser.Text + ",N'" + txtUsername.Text + "' , N'" + txtPassword.Text + "', N'" + cbxType.Text + "', " + cbxDepositInSafe.SelectedValue + ", " + NumProfit.Value + ") ", "done successfully");
                db.ExecuteData("insert into Users_Settings Values (" + txtIdUser.Text + ", 0,0,0,0,0,0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Customers Values (" + txtIdUser.Text + ", 0,0,0)", "");
                db.ExecuteData("insert into Users_Suppliers Values (" + txtIdUser.Text + ", 0,0,0)", "");
                db.ExecuteData("insert into Users_Purchasing Values (" + txtIdUser.Text + ", 0,0)", "");
                db.ExecuteData("insert into Users_Sales Values (" + txtIdUser.Text + ", 0,0,0)", "");
                db.ExecuteData("insert into Users_Returns Values (" + txtIdUser.Text + ", 0,0)", "");
                db.ExecuteData("insert into Users_Expenses Values (" + txtIdUser.Text + ", 0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Backups Values (" + txtIdUser.Text + ", 0,0)", "");
                db.ExecuteData("insert into Users_SafeBank Values (" + txtIdUser.Text + ", 0,0,0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Employees Values (" + txtIdUser.Text + ",0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Reports Values (" + txtIdUser.Text + ",0,0,0,0,0,0)", "");




                AutoNumber();
            }
            else
            {
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update Users set UserName = N'" + txtUsername.Text + "' , User_Password =N'" + txtPassword.Text + "' ,  User_Type = N'" + cbxType.Text + "', Safe_ID = " + cbxDepositInSafe.SelectedValue + " , User_Profit = " + NumProfit.Value + " Where User_ID = " + txtIdUser.Text + " ", "Data has been modified successfully");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + txtUsername.Text + "  User data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Users where User_ID = " + txtIdUser.Text + " ", " User data has been deleted");
                db.ExecuteData("Delete from Users_Settings Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Customers Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Suppliers Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Purchasing Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Sales Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Returns Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Reports Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Expenses Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Backups Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_SafeBank Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Employees Where User_ID = " + txtIdUser.Text + "", "");



                DataTable dtUser = new DataTable();
                dtUser.Clear();
                dtUser = db.ReadData("select * from Users", "");
                if (dtUser.Rows.Count <= 0)
                {
                    db.ExecuteData("insert into Users Values (1 , N'Admin' , N'AdminAdmin' , N'Administrator' , 1 , 0 )", "");
                    db.ExecuteData("insert into Users_Settings Values (" + txtIdUser.Text + ", 1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Customers Values (" + txtIdUser.Text + ", 1,1,1)", "");
                    db.ExecuteData("insert into Users_Suppliers Values (" + txtIdUser.Text + ", 1,1,1)", "");
                    db.ExecuteData("insert into Users_Purchasing Values (" + txtIdUser.Text + ", 1,1)", "");
                    db.ExecuteData("insert into Users_Sales Values (" + txtIdUser.Text + ", 1,1,1)", "");
                    db.ExecuteData("insert into Users_Returns Values (" + txtIdUser.Text + ", 1,1)", "");
                    db.ExecuteData("insert into Users_Reports Values (" + txtIdUser.Text + ", 1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Expenses Values (" + txtIdUser.Text + ",1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Backups Values (" + txtIdUser.Text + ", 1,1)", "");
                    db.ExecuteData("insert into Users_SafeBank Values (" + txtIdUser.Text + ", 1,1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Employees Values (" + txtIdUser.Text + ", 1,1,1,1,1,1,1)", "");





                }
                AutoNumber();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(User_ID) from Users", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                show();
            }
            else
            {
                Row--;
                show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(User_ID) from Users", "");
            if (Convert.ToInt32(dt.Rows[0][0]) - 1 == Row)
            {
                Row = 0;
                show();
            }
            else
            {
                Row++;
                show();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select count(User_ID) from Users", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
        }
    }
}
