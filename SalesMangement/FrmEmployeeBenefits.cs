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
    public partial class FrmEmployeeBenefits : MaterialForm
    {
        public FrmEmployeeBenefits()
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
            dt = db.ReadData("select max(Order_ID) from Employee_BorrowMoney", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtOperationNumber.Text = "1";
            }
            else
            {
                TxtOperationNumber.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            NumAmount.Value = 1;
            //Clear the text box again after each operation
            txtPersonName.Clear();
            txtCreditorName.Clear();
            TxtNote.Clear();
            Dateborrow.Text = DateTime.Now.ToShortDateString();
            DueDate.Text = DateTime.Now.ToShortDateString();
            RadioBEmploye_CheckedChanged(null, null);
            try
            {
                cbxChooseEmployee.SelectedIndex = 0;
            }
            catch (Exception)
            {


            }

        }
        
        private void FillEmployees()
        {
            cbxChooseEmployee.DataSource = db.ReadData("select * from Employees ", "");
            cbxChooseEmployee.DisplayMember = "Emp_Name";
            cbxChooseEmployee.ValueMember = "Emp_ID";
            cbxEmployees.DataSource = db.ReadData("select * from Employees", "");
            cbxEmployees.DisplayMember = "Emp_Name";
            cbxEmployees.ValueMember = "Emp_ID";
        }
        //BUTTON : Form Money 
        private void btnEmployeeWithdrawals_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_MonthlyWithdrawals From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmEmployeeMoney frmEmployeeMoney = new FrmEmployeeMoney();
            frmEmployeeMoney.ShowDialog();
        }
        //Number Safe 
        int Safe_ID = 0;
        int User_ID = 0;
        private void FrmEmployeeBenefits_Load(object sender, EventArgs e)
        {
           
           dateExchange.Text = DateTime.Now.ToShortDateString();
           dateDue.Text = DateTime.Now.ToShortDateString();


            try
            {
                //FORM : Employee Borrowing
                AutoNumber();
                FillEmployees();
                //FORM : Employees Salaries
                AutoNumberEmpSal();            
                User_ID = Convert.ToInt32(db.ReadData("select * from Users Where UserName = N'" + Properties.Settings.Default.UserName + "'", "").Rows[0][0]);              
            }
            catch (Exception)
            {

              
            }
            Safe_ID = Properties.Settings.Default.Safe_ID; 
            cbxEmployees_SelectionChangeCommitted(null, null);





        }
        //RADIO BUTTON : Normal Person 
        private void RadioBNormalPerson_CheckedChanged(object sender, EventArgs e)
        {
            cbxChooseEmployee.Enabled = false;
            txtPersonName.Enabled = true;

        }
        //RADIO BUTTON : Employees
        private void RadioBEmploye_CheckedChanged(object sender, EventArgs e)
        {
            cbxChooseEmployee.Enabled = true;
            txtPersonName.Enabled = false;
        }
        //BUTTON : Save Date in  table Employee_BorrowMoney
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxChooseEmployee.Items.Count <= 0 )
            {
                MessageBox.Show(" Please select an employee ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (NumAmount.Value <= 0)
            {
                MessageBox.Show(" Please enter the price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string DateBorrow = Dateborrow.Value.ToString("dd/MM/yyy");
            string DateDue = DueDate.Value.ToString("dd/MM/yyy");
            string Date = DueDate.Value.ToString("dd/MM/yyy");
            string name = "";
            if(RadioBEmploye.Checked == true)
            {
                name = cbxChooseEmployee.Text;
            }

            else
            {
                if(txtPersonName.Text == String.Empty)
                {
                    MessageBox.Show(" Please enter Person Name  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                name = txtPersonName.Text;
            }

            decimal Safe_Money = 0;
            dt.Clear();
            dt = db.ReadData("Select * from Safe where Safe_ID = "+Safe_ID+"", "");
            Safe_Money = Convert.ToDecimal(dt.Rows[0][1]);
            if(NumAmount.Value > Safe_Money)
            {
                MessageBox.Show(" The amount in the Safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (RadioBEmploye.Checked == true)
            {
                db.ExecuteData("insert into Employees_SalaryMinus (Emp_ID,Emp_Name,Emp_Date,Emp_Price,Emp_Pay) Values (" + cbxChooseEmployee.SelectedValue + ",N'" + name + "',N'" + DateBorrow + "'," + NumAmount.Value + ", 'NO')", "");

            }
            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + NumAmount.Value + ",N'" + Date + "' , N'" + txtCreditorName.Text + "', N'Borrows pull', N'" + TxtNote.Text + "')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - "+NumAmount.Value+ " Where Safe_ID = "+Safe_ID+"", "");
           db.ExecuteData("insert into Employee_BorrowMoney Values ("+TxtOperationNumber.Text+", N'"+txtCreditorName.Text+"', N'"+name+"', N'"+ DateBorrow + "', N'"+ DateDue + "', "+ NumAmount.Value+ ", N'"+TxtNote.Text+"') ", "Successfully");
            AutoNumber();
        }

        //FORM : Employees Salaries
        /// <summary>
        ///AutoNumber
        ///A function that adds a new ID in the database
        ///and increments 1 automatically in each operation
        ///Clear the text box again after each operation
        ///Cancel buttons and activate them when needed
        ///focus on textbox Name Employee
        /// </summary>
        private void AutoNumberEmpSal()
        {
            dt.Clear();
            dt = db.ReadData("select max(Order_ID) from Employees_Salaries ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtOpNumber.Text = "1";
            }
            else
            {
                txtOpNumber.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            txtNotes.Clear();
            dateExchange.Text = DateTime.Now.ToShortDateString();
            dateDue.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxEmployees.SelectedIndex = 0;
            }
            catch (Exception)
            {


            }

        }

        private void cbxEmployees_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Variables 
            decimal TotalBorrow = 0;
            
            try
            {
                dt.Clear();
                dt = db.ReadData("Select Emp_Salary, Emp_Date From Employees Where Emp_ID = " + cbxEmployees.SelectedValue+"", "");
                txtFullSalary.Text = Convert.ToDecimal(dt.Rows[0][0]).ToString(); 
                //date format problem
                this.Text = dt.Rows[0][1].ToString();
                DateTime DueDate = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dateDue.Value = DueDate;

                try
                {
                    
                    DataTable dtCkeck = new DataTable();
                    dtCkeck.Clear();
                    dtCkeck = db.ReadData("select * from Employees_SalaryMinus Where Emp_ID = "+cbxEmployees.SelectedValue+" And Emp_Pay = 'NO' ", "");
                    for (int i = 0; i <= dtCkeck.Rows.Count - 1; i++)
                    {
                        TotalBorrow += Convert.ToDecimal(dtCkeck.Rows[i][4]);
                    }
                    txtWithdrBorrow.Text = (Math.Round(TotalBorrow, 2)).ToString();
                  
                    txtNetSalary.Text =(Convert.ToDecimal(txtFullSalary.Text) - Convert.ToDecimal(txtWithdrBorrow.Text)).ToString();
                    

                   
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            { 
            }
        }

        private void PayBorrow()
        {
            DataTable dtPrice = new DataTable();
            dtPrice.Clear();
            dtPrice = db.ReadData(" select Emp_Price from Employees_SalaryMinus Where Emp_ID = "+cbxEmployees.SelectedValue+" ", "");
            decimal TotalSalary = Convert.ToDecimal( txtFullSalary.Text);
            for (int i = 0; i <= dtPrice.Rows.Count - 1 ; i++)
            {
                if(TotalSalary >=  Convert.ToDecimal( dtPrice.Rows[i][0]))
                {
                    db.ExecuteData("update Employees_SalaryMinus set Emp_Pay = 'YES' Where Emp_ID = "+cbxEmployees.SelectedValue+ " and Emp_Pay = 'NO' and Emp_Name =N'"+cbxEmployees.Text+ "' and Emp_Price = "+ Convert.ToDecimal(dtPrice.Rows[i][0]) + " ", "");
                    TotalSalary = TotalSalary - Convert.ToDecimal(dtPrice.Rows[i][0]);
                }
                cbxEmployees_SelectionChangeCommitted(null, null);



            }
        }
        private void btnSaveEmpSal_Click(object sender, EventArgs e)
        {
          


            string Date = dateDue.Value.ToString("dd/MM/yyyy");
            string ExchangeDate = dateExchange.Value.ToString("dd/MM/yyyy");
            if (cbxEmployees.Items.Count <= 0)
            {
                MessageBox.Show(" Please select an employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal Safe_Money = 0;
            dt.Clear();
            dt = db.ReadData("Select * from Safe where Safe_ID = " + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(dt.Rows[0][1]);
            
            if (Convert.ToDecimal( txtNetSalary.Text) > Safe_Money)
            {
                MessageBox.Show(" The amount in the Safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + NumAmount.Value + ",N'" + Date + "' , N'"+Properties.Settings.Default.UserName+"', N'Salaries', N'" + txtNotes.Text + "')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + txtNetSalary.Text + " Where Safe_ID = " + Safe_ID + "", "");
            db.ExecuteData("insert into Employees_Salaries Values ("+ txtOpNumber.Text+ ", "+cbxEmployees.SelectedValue+", "+txtFullSalary.Text+","+txtWithdrBorrow.Text+", "+txtNetSalary.Text+",N'"+ ExchangeDate + "', N'"+Date+"',N'"+txtNotes.Text+"')", "Successfully");
            try
            {
                PayBorrow();
            }
            catch (Exception)
            {
            }
            AutoNumberEmpSal();
        }
    }
}
