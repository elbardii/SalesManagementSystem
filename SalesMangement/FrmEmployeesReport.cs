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
    public partial class FrmEmployeesReport : MaterialForm

    {
        public FrmEmployeesReport()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        
        private void FillEmployees()
        {
            CbxEmpW.DataSource = db.ReadData("select * from Employees ", "");
            CbxEmpW.DisplayMember = "Emp_Name";
            CbxEmpW.ValueMember = "Emp_ID";
            CbxEmpS.DataSource = db.ReadData("select * from Employees", "");
            CbxEmpS.DisplayMember = "Emp_Name";
            CbxEmpS.ValueMember = "Emp_ID";
        }

        private void FrmEmployeesReport_Load(object sender, EventArgs e)
        {
            try
            {
                FillEmployees();
            }
            catch (Exception)
            {
            }
        }
        //Form : Withdrawal Report
        //BUTTON  : Searsh 
        private void btnSearshW_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRW.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRW.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if(rbtnAllEmpW.Checked)
            {
                dt = db.ReadData(" SELECT [Order_ID] as 'Number Order',Product.Pro_Name as 'Product',Employees.Emp_Name as 'Employee',[Date] as 'Date',[Quantity] FROM [dbo].[Employee_Withdrawals] , Employees ,Product  where Employee_Withdrawals.Emp_ID = Employees.Emp_ID  and Employee_Withdrawals.Pro_ID =  Product.Pro_Id  and CONVERT(date , Employee_Withdrawals.Date ,105) between  N'" + DateFrom + "' and N'" + DateTo + "'  ", "");

            }
            else
            {
                dt = db.ReadData(" SELECT [Order_ID] as 'Number Order',Product.Pro_Name as 'Product',Employees.Emp_Name as 'Employee',[Date] as 'Date',[Quantity] FROM [dbo].[Employee_Withdrawals] , Employees ,Product  where Employee_Withdrawals.Emp_ID = Employees.Emp_ID  and Employee_Withdrawals.Pro_ID =  Product.Pro_Id and   Employee_Withdrawals.Emp_ID = "+CbxEmpW.SelectedValue+" and CONVERT(date , Employee_Withdrawals.Date ,105) between  N'" + DateFrom + "' and N'" + DateTo + "'  ", "");
            }
            if (dt.Rows.Count >= 1)

            {
                DgvWithdrawal.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][4]);
                }
                //function that returns 2 numbers after the comma
                txtTotalW.Text = $"{Math.Round(Sum, 2) } QTY";
            }
            else
            {
                txtTotalW.Text = "0 QTY";
            }
        }
        //BUTTON : Delete 
        private void btnDeleteAllW_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRW.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRW.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from Employee_Withdrawals where CONVERT(date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
        }
        //Form : Credit Report
        //BUTTON :  Searsh 
        private void btnSearshB_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromB.Value.ToString("yyyy-MM-dd");
            DateTo = DateToB.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (rbtAllCredits.Checked)
            {
                dt = db.ReadData("SELECT [Order_ID] as 'Number Order',[Borrow_From] as 'Creditor',[Borrow_To] as 'Debtor',[Order_Date] as 'Borrow date',[Date_Reminder]  as ' Reminder Date' ,[Price] ,[Notes] FROM [dbo].[Employee_BorrowMoney]  Where CONVERT(date , Order_Date ,105) between  N'" + DateFrom + "' and N'" + DateTo + "'  ", "");
            }
            else
            {
                dt = db.ReadData("SELECT [Order_ID] as 'Number Order',[Borrow_From] as 'Creditor',[Borrow_To] as 'Debtor',[Order_Date] as 'Borrow date',[Date_Reminder]  as ' Reminder Date' ,[Price] ,[Notes] FROM [dbo].[Employee_BorrowMoney]  Where Borrow_From = N'"+ txtNamePB.Text + "'  and CONVERT(date , Order_Date ,105) between  N'" + DateFrom + "' and N'" + DateTo + "'  ", "");
            }
            if (dt.Rows.Count >= 1)

            {
                DgvCredit.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][5]);
                }
                //function that returns 2 numbers after the comma
                txtTotalB.Text = $"{Math.Round(Sum, 2)} DH";
            }
            else
            {
                txtTotalB.Text = "0 DH" ;
            }
        }
        //BUTTON : Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromB.Value.ToString("yyyy-MM-dd");
            DateTo = DateToB.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from Employee_BorrowMoney where CONVERT(date,[Date_Reminder],105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
        }

        //Salary Report
        //BUTTON Searsh
        private void btnSearshS_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRS.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRS.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (rbtnAllEmloyeesS.Checked)
            {
                dt = db.ReadData("SELECT [Order_ID] as 'Number Order',Employees.Emp_Name as 'Employee',[Total_Salary]  as 'Total Salary',[Total_Borrowing] as 'Total Borrowing',[Net_Salary] as 'Net Salary' ,[Exchange_Date] as 'Date Exchange',[Due_Date] as 'Due Date',[Notes]FROM [dbo].[Employees_Salaries], Employees where Employees_Salaries.Emp_ID = Employees.Emp_ID and CONVERT(date , Exchange_Date ,105) between  N'" + DateFrom + "' and N'" + DateTo + "'  ", "");
            }
            else
            {
                dt = db.ReadData("SELECT [Order_ID] as 'Number Order',Employees.Emp_Name as 'Employee',[Total_Salary]  as 'Total Salary',[Total_Borrowing] as 'Total Borrowing',[Net_Salary] as 'Net Salary' ,[Exchange_Date] as 'Date Exchange',[Due_Date] as 'Due Date',[Notes]FROM [dbo].[Employees_Salaries], Employees where Employees_Salaries.Emp_ID = Employees.Emp_ID and Employees.Emp_Name = N'"+CbxEmpS.Text+"' and CONVERT(date , Exchange_Date ,105) between  N'" + DateFrom + "' and N'" + DateTo + "'  ", "");
            }
            if (dt.Rows.Count >= 1)

            {


                DgvSalary.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][2]);
                }
                //function that returns 2 numbers after the comma
                txtTotalS.Text = $"{Math.Round(Sum, 2)} DH ";
            }
            else
            {
                txtTotalS.Text = "0 DH";
            }

        }
         //BUTTON : delete all 
        private void btnDeleteAllS_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRS.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRS.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from Employees_Salaries where CONVERT(date,[Exchange_Date],105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
        }
    }
}
