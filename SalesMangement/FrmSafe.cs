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
    public partial class FrmSafe : MaterialForm
    {
        public FrmSafe()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        int Row;
        /// <summary>
        ///AutoNumberNSafe
        /// A function that adds a new ID in the database 
        ///and increments 1 automatically in each operation
        /// Clear the text box again after each operation
        /// Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumberNSafe()
        {
            dt.Clear();
            dt = db.ReadData("select max(Safe_ID) from Safe_data ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtLockerNumber.Text = "1";
            }
            else
            {
                txtLockerNumber.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            txtNameSafe.Clear();
            //focus on textbox Name type Expenses
            //Cancel buttons and activate them when needed
            btnAddNSafe.Enabled = true;
            btnNewNSafe.Enabled = true;
            btnSaveNSafe.Enabled = false;
            btnDeleteNSafe.Enabled = false;
            btnDeleteAllNSafe.Enabled = false;
        }
        /* showNSafe
         * A function that displays data from the database
        */
        private void showNSafe()
        {
            dt.Clear();
            dt = db.ReadData("select * from Safe_Data ", "");
            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database Table  Safe_Data
                txtLockerNumber.Text = dt.Rows[Row][0].ToString();
                txtNameSafe.Text = dt.Rows[Row][1].ToString();
            }
            //Cancel buttons and activate them when needed
            btnAddNSafe.Enabled = false;
            btnNewNSafe.Enabled = true;
            btnSaveNSafe.Enabled = true;
            btnDeleteNSafe.Enabled = true;
            btnDeleteAllNSafe.Enabled = true;
        }
        //checkNSafe
        //A function that checks if important textBox have a value
        private bool checkNSafe()
        {
            if (txtLockerNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Safe number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtNameSafe.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Safe Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Reload the page again
        private void FrmSafe_Load(object sender, EventArgs e)
        {
            AutoNumberNSafe();

            try
            {
                loadingScreen();
                loadingScreenW();
                DateFromR.Text = DateTime.Now.ToShortDateString();
                DateToR.Text = DateTime.Now.ToShortDateString();



            }
            catch (Exception)
            {
            }
            DateDespoAMoney.Text = DateTime.Now.ToShortDateString();
        }
        //BUTTON ADD : add new Ssafe to  table Safe 
        private void btnAddNSafe_Click(object sender, EventArgs e)
        {
            if (checkNSafe() == false)
            {
                db.ExecuteData("insert into Safe_data values (" + txtLockerNumber.Text + ",N'" + txtNameSafe.Text + "') ", "done successfully");
                AutoNumberNSafe();
            }
            else
            {
                return;
            }
        }
        //BUTTON New : New Safe 
        private void btnNewNSafe_Click(object sender, EventArgs e)
        {
            AutoNumberNSafe();
        }
        //BUTTON SAVE : update table Safe
        private void btnSaveNSafe_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update Safe_Data set Safe_Name = N'" + txtNameSafe.Text + "' where Safe_ID = " + txtLockerNumber.Text + "", "Data has been modified successfully");
            AutoNumberNSafe();
        }
        //BUTTON DELETE : delete COLUMN of Table (Safe_Data)

        private void btnDeleteNSafe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + txtNameSafe.Text + "  Safe data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Safe_Data where Safe_ID = " + txtLockerNumber.Text + " ", " Safe data has been deleted");
                AutoNumberNSafe();
            }
        }
        //BUTTON DELETE ALL  : delete Table (Safe_Data) 
        private void btnDeleteAllNSafe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Safe data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Safe_Data ", "All Safe data has been deleted");
                AutoNumberNSafe();
            }
        }
        //BUTTON FIRST : first line on table Safe_Data 
        private void btnFirstNSafe_Click(object sender, EventArgs e)
        {
            Row = 0;
            showNSafe();
        }
        //BUTTON PREVIOUS : previous line on table Sate_Data 
        private void btnPreviousNSafe_Click(object sender, EventArgs e)
        {

            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Safe_ID) from Safe_Data", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                showNSafe();

            }
            else
            {
                Row--;
                showNSafe();
            }
        }
        //BUTTON NEXT : Next line on table Safe_Data
        private void btnNextNSafe_Click(object sender, EventArgs e)
        {

            dt.Clear();
            dt = db.ReadData("select Count(Safe_ID) from Safe_Data", "");
            if (Convert.ToInt32(dt.Rows[0][0]) - 1 == Row)
            {

                Row = 0;
                showNSafe();
            }
            else
            {
                Row++;
                showNSafe();
            }
        }
        //BUTTON LAST : last line on table Safe_Data
        private void btnLastNSafe_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select count(Safe_ID) from Safe_Data", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            showNSafe();
        }

        // FORM ADD MONEY 
        private void loadingScreen()
        {
            FillSafe();
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafeAMoney.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                txtCurrentBalance.Text = "0 DH";
            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                txtCurrentBalance.Text = (dt.Rows[0][1]).ToString() + "DH";
            }

            NudAddBalance.Value = 0;
            txtDeposName.Clear();
            TxtNoteAMoney.Clear();
            DateDespoAMoney.Text = DateTime.Now.ToShortDateString();

        }

        private void FillSafe()
        {
            cbxSafeAMoney.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxSafeAMoney.DisplayMember = "Safe_Name";
            cbxSafeAMoney.ValueMember = "Safe_ID";
        }

        private void cbxSafeAMoney_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");
                if (dt.Rows.Count <= 0)
                {
                    db.ExecuteData("insert into Safe Values (" + cbxSafeAMoney.SelectedValue + ", 0) ", "");
                    dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");

                }
                if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
                {
                    txtCurrentBalance.Text = "0 DH";
                }
                else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
                {
                    txtCurrentBalance.Text = (dt.Rows[0][1]).ToString() + "DH";
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            if (cbxSafeAMoney.Items.Count >= 1)
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
                db.ExecuteData("update Safe set Safe_Money = Safe_Money + " + NudAddBalance.Value + " Where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");
                db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafeAMoney.SelectedValue + ", " + NudAddBalance.Value + ",'" + DateAMoney + "' , N'" + txtDeposName.Text + "', N'Extra credit', N'" + TxtNoteAMoney.Text + "')  ", "Deposited Successfully");
                loadingScreen();
            }
        }

        private void txtLockerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox that only accepts numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //FROM : Withdraw Money
        private void loadingScreenW()
        {
            FillSafeW();
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafeAMoney.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeAMoney.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                txtBalanceWMoney.Text = "0 DH";
            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                txtBalanceWMoney.Text = (dt.Rows[0][1]).ToString() + "DH";
            }

            NubAddBalanceWMoney.Value = 0;
            txtDeposNWMoney.Clear();
            txtNoteWMoney.Clear();
            DateWMoney.Text = DateTime.Now.ToShortDateString();

        }

        private void FillSafeW()
        {
            cbxSafeWMoney.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxSafeWMoney.DisplayMember = "Safe_Name";
            cbxSafeWMoney.ValueMember = "Safe_ID";
        }
        //When any change in the Combobox is changed according to the amount in the locker
        private void cbxSafeWMoney_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeWMoney.SelectedValue + "", "");
                if (dt.Rows.Count <= 0)
                {
                    db.ExecuteData("insert into Safe Values (" + cbxSafeWMoney.SelectedValue + ", 0) ", "");
                    dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeWMoney.SelectedValue + "", "");

                }
                if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
                {
                    txtBalanceWMoney.Text = "0 DH";
                }
                else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
                {
                    txtBalanceWMoney.Text = (dt.Rows[0][1]).ToString() + "DH";
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnWithdrow_Click(object sender, EventArgs e)
        {
            if (cbxSafeWMoney.Items.Count >= 1)
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
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeWMoney.SelectedValue + "", "");
                if (NubAddBalanceWMoney.Value > Convert.ToDecimal(dt.Rows[0][1]))
                {
                    MessageBox.Show("It is not possible to withdraw an amount greater than what is in the locker", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.ExecuteData("update Safe set Safe_Money = Safe_Money - " + NubAddBalanceWMoney.Value + " Where Safe_ID = " + cbxSafeWMoney.SelectedValue + "", "");
                db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafeWMoney.SelectedValue + ", " + NubAddBalanceWMoney.Value + ",'" + Date + "' , N'" + txtDeposNWMoney.Text + "', N'manual pull', N'" + txtNoteWMoney.Text + "')  ", "Withdrawn successfully");
                loadingScreenW();
            }
        }
        //BUTTON : Search 
        private void btnSearchR_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToR.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            dt = db.ReadData("SELECT [Order_ID] as 'Number Order',Safe_Data.Safe_Name as 'Name Safe',[Safe_Money]  as 'Safe Money',[Date] as 'Date',[Depositor_Name] as 'Depositors Name',[Type] as 'Type',[Reason] as 'Reason'FROM [dbo].[Safe_insert], Safe_Data where Safe_Data.Safe_ID = Safe_insert.Safe_ID and CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
            if (dt.Rows.Count >= 1)
            {
                DgvR.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][2]);
                }
                //function that returns 2 numbers after the comma
                txtTotalR.Text = $"{Math.Round(Sum, 2)} DH";
            }
            else
            {
                txtTotalR.Text = "0 DH";
            }
        }
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
                db.ExecuteData("delete from Safe_insert where CONVERT(Date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
            btnSearchR_Click(null, null);
        }
        //FORM : Total withdrawals in the period
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
                db.ExecuteData("delete from Safe_Withdraw where CONVERT(Date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
            btnSearchRW_Click(null, null);
        }
        //BUTTON  : Search
        private void btnSearchRW_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRW.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRW.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            dt = db.ReadData(" SELECT [Order_ID] as 'Number Order' ,Safe_Data.Safe_Name as 'Name Safe',[Safe_Money] as 'Money' ,[Date] ,[Depositor_Name] as 'Depositors Name',[Type]  ,[Reason]FROM [dbo].[Safe_Withdraw] , Safe_Data where Safe_Data.Safe_ID = Safe_Withdraw.Safe_ID and CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
            if (dt.Rows.Count >= 1)
            {
                DgvRW.DataSource = dt;
                decimal Sum = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(dt.Rows[i][2]);
                }
                //function that returns 2 numbers after the comma
                txtTotalRW.Text = $"{Math.Round(Sum, 2)} DH";
            }
            else
            {
                txtTotalRW.Text = "0 DH";
            }
        }
    }
}
