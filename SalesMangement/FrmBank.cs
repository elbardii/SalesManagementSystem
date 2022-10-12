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
    public partial class FrmBank : MaterialForm
    {
        public FrmBank()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();

        //FORM : ADD MONEY IN BANK
        // loadingScreen : Reload the page again
        private void loadingScreen()
        {
            dt.Clear();
            dt = db.ReadData("select * from Bank ", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Bank Values (0) ", "");
                dt = db.ReadData("select * from Bank ", "");
            }
            if (Convert.ToDecimal(dt.Rows[0][0]) <= 0)
            {
                txtCurrentBalance.Text = "0 DH";
            }
            else if (Convert.ToDecimal(dt.Rows[0][0]) >= 1)
            {
                txtCurrentBalance.Text = (dt.Rows[0][0]).ToString() + "DH";
            }

            NudAddBalance.Value = 0;
            txtDeposName.Clear();
            TxtNoteAMoney.Clear();
            DateDespoAMoney.Text = DateTime.Now.ToShortDateString();


        }

        //FORM : Withdraw in bank 
        private void loadingScreenW()
        {
            dt.Clear();
            dt = db.ReadData("select * from Bank ", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Bank Values (0) ", "");
                dt = db.ReadData("select * from Bank ", "");
            }
            if (Convert.ToDecimal(dt.Rows[0][0]) <= 0)
            {
                txtBalanceWMoney.Text = "0 DH";
            }
            else if (Convert.ToDecimal(dt.Rows[0][0]) >= 1)
            {
                txtBalanceWMoney.Text = (dt.Rows[0][0]).ToString() + "DH";
            }

            NubAddBalanceWMoney.Value = 0;
            txtDeposNWMoney.Clear();
            txtNoteWMoney.Clear();
            DateWMoney.Text = DateTime.Now.ToShortDateString();


        }

        private void FrmBank_Load(object sender, EventArgs e)
        {
            try
            {
                //FORM : add money in bank 
                loadingScreen();
                //FROM : withdraw money in bank 
                loadingScreenW();
                DateFromR.Text = DateTime.Now.ToShortDateString();
                DateToR.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception)
            {


            }

        }
        //FORM :  Add  Money 
        //BUTTON : Add Money in Bank
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
                string DateAMoney = DateDespoAMoney.Value.ToString("dd/MM/yyyy");
                if (txtDeposName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the name of the depositor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (NudAddBalance.Value <= 0)
                {
                    MessageBox.Show("Deposit amount must be greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                db.ExecuteData("update Bank set Money = Money + " + NudAddBalance.Value + " ", "");
                db.ExecuteData("insert into Bank_insert (Money ,Date ,Depositor_Name , Type, Reason ) Values (" + NudAddBalance.Value + ", '" + DateAMoney  + "','" + txtDeposName.Text + "' , N'Extra credit' , N'" + TxtNoteAMoney.Text + "')  ", "Deposited Successfully");
                loadingScreen();
            
        }

        //FORM : Withdraw Money

        private void btnWithdrow_Click(object sender, EventArgs e)
        {
           
                string Date = DateWMoney.Value.ToString("dd/MM/yyyy");
                if (txtDeposNWMoney.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the name of the draw", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (NubAddBalanceWMoney.Value < 0)
                {
                    MessageBox.Show("Withdrawal amount must be greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //The first method is to check the amount withdrawn less than the amount in the locker
                //if (NubAddBalanceWMoney.Value > Convert.ToDecimal(txtBalanceWMoney.Text))
                //{
                //    MessageBox.Show("It is not possible to withdraw an amount greater than what is in the locker", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return ;
                //}
                //The second method is to check the amount withdrawn less than the amount in the locker
                dt.Clear();
                dt = db.ReadData("select * from Bank ", "");
                if (NubAddBalanceWMoney.Value > Convert.ToDecimal(dt.Rows[0][0]))
                {
                    MessageBox.Show("It is not possible to withdraw an amount greater than what is in the locker", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.ExecuteData("update Bank set Money = Money - " + NubAddBalanceWMoney.Value + " ", "");
                db.ExecuteData("insert into Bank_Withdraw (Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + NubAddBalanceWMoney.Value + ",N'" + Date + "' , N'" + txtDeposNWMoney.Text + "', N'manual pull', N'" + txtNoteWMoney.Text + "')  ", "Deposited Successfully");
                loadingScreenW();
        }
        //FORM : Report 
        //BUTTON : Delete 
        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToR.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from Bank_insert where CONVERT(Date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
            btnSearchR_Click(null, null);
        }
        //BUTTON : Search 
        private void btnSearchR_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToR.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            dt = db.ReadData("SELECT [Order_ID] as 'Number Order',[Money],[Date] ,[Depositor_Name],[Type],[Reason]FROM [dbo].[Bank_insert] Where  CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
            if (dt.Rows.Count >= 1)
            {
                DgvR.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][1]);
                }
                //function that returns 2 numbers after the comma
                txtTotalR.Text = $"{Math.Round(Sum, 2).ToString()} DH";
            }
            else
            {
                txtTotalR.Text = "0 DH";
            }
        }
        //BUTTON : Search 
        private void btnSearchRW_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRW.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRW.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            dt = db.ReadData(" SELECT [Order_ID] as 'Number Order' ,[Safe_Money] as 'Money',[Date] ,[Depositor_Name] as 'Depositors Name',[Type],[Reason]FROM [dbo].[Bank_Withdraw] Where  CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
            if (dt.Rows.Count >= 1)
            {
                DgvRW.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][1]);
                }
                //function that returns 2 numbers after the comma
                txtTotalRW.Text = $"{Math.Round(Sum, 2).ToString()} DH";
            }
            else
            {
                txtTotalRW.Text = "0 DH";
            }

        }
        //BUTTON : Delete
        private void btnDeleteRW_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRW.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRW.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from Bank_Withdraw where CONVERT(Date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
            btnSearchRW_Click(null, null);
        }
    }
}
