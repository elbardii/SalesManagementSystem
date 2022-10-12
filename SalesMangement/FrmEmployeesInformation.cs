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
    public partial class FrmEmployeesInformation : MaterialForm
    {
        public FrmEmployeesInformation()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        /// <summary>
        ///AutoNumber
        ///A function that adds a new ID in the database
        ///and increments 1 automatically in each operation
        ///Clear the text box again after each operation
        ///Cancel buttons and activate them when needed
        ///focus on textbox Name Employee
        /// </summary>
        private void AutoNumber()
        {
            dt.Clear();
            dt = db.ReadData("select max(Emp_ID) from Employees", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtIdEmp.Text = "1";
            }
            else
            {
                txtIdEmp.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            //TxtIdCus.Clear();
            txtNameEmp.Clear();
            txtPhoneEmp.Clear();
            txtAddressEmp.Clear();
            txtSalary.Clear();
            txtNational.Clear();
            TxtNoteEmp.Clear();
            DateDue.Text = DateTime.Now.ToShortDateString();
            //focus on textbox Name Customer
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        /* Show
         * A function that displays data from the database
        */
        int Row;
        private void show()
        {
            dt.Clear();
            dt = db.ReadData("select * from Employees", "");
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //first line of database Employees
                    txtIdEmp.Text      = dt.Rows[Row][0].ToString();
                    txtNameEmp.Text    = dt.Rows[Row][1].ToString();
                    txtPhoneEmp.Text   = dt.Rows[Row][2].ToString();
                    txtAddressEmp.Text = dt.Rows[Row][3].ToString();
                    txtSalary.Text     = dt.Rows[Row][4].ToString();
                    //date format problem
                    this.Text = dt.Rows[Row][5].ToString();
                    DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DateDue.Value = date;
                    txtNational.Text = dt.Rows[Row][6].ToString();

                }
                catch (Exception)
                {

                    
                }
            }
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
        }
        //A function that checks if important textBox have a value
        //programming high level : if _ else if _ else ....
        private bool check()
        {
            if (txtIdEmp.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Employee number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtNameEmp.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Employee Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtPhoneEmp.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Employee Phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtAddressEmp.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Employee Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtNational.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtSalary.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee Salary ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
        private void FrmEmployeesInformation_Load(object sender, EventArgs e)
        {
            DateDue.Text = DateTime.Now.ToShortDateString();
            AutoNumber();
        }
        //BUTTON : New  
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //BUTTON : Add Employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(check() == false)
            {
                string date = DateDue.Value.ToString("dd/MM/yyy");
                db.ExecuteData("insert into Employees values (" + txtIdEmp.Text + ", N'" + txtNameEmp.Text + "',N'" + txtPhoneEmp.Text + "',N'" + txtAddressEmp.Text + "',"+txtSalary.Text+",N'"+date+"', N'"+txtNational.Text+ "', N'" + TxtNoteEmp.Text + "' ) ", "done successfully");
                AutoNumber();
            }
        }
        //BUTTON : Save 
        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = DateDue.Value.ToString("dd/MM/yyy");
            db.ExecuteData("update Employees set Emp_Name = N'" + txtNameEmp.Text + "', Emp_Phone =N'" + txtPhoneEmp.Text + "'," +
                  " Emp_Address = N'" + txtAddressEmp.Text + "', Emp_Salary = N'" + txtSalary.Text + "' , Emp_Date = N'"+ date + "' , Emp_nationalID = N'"+txtNational.Text+ "' , Emp_Notes = N'"+TxtNoteEmp.Text+ "' where Emp_ID = " + txtIdEmp.Text + "", "Data has been modified successfully");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + txtNameEmp.Text + " Employee data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Employees where Emp_ID = " + txtIdEmp.Text + " ", "Customer data has been deleted");

                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete all Emoloyees data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Employees ", "All customer data has been deleted");
                AutoNumber();
            }
        }
        //BUTTON : First 
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }
        //BUTTON  : Previous 
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Emp_Id) from Employees", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                show();
            }
            else
            {
                Row--;
                show();
            }
        }
        //BUTTON : Next
        private void btnNext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Emp_ID) from Employees", "");
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
            dt = db.ReadData("select count(Emp_ID) from Employees", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable tblSearsh = new DataTable();
                tblSearsh.Clear();
                tblSearsh = db.ReadData("select * from Employees where Emp_Name = N'" + txtSearch.Text + "' ", "");

                try
                {
                    txtIdEmp.Text      = tblSearsh.Rows[0][0].ToString();
                    txtNameEmp.Text    = tblSearsh.Rows[0][1].ToString();
                    txtPhoneEmp.Text   = tblSearsh.Rows[0][2].ToString();
                    txtAddressEmp.Text = tblSearsh.Rows[0][3].ToString();
                    txtSalary.Text     = tblSearsh.Rows[0][4].ToString();

                }
                catch (Exception)
                {

                }
                //Cancel buttons and activate them when needed
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;

            }
        }
    }
}
