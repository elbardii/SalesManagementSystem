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
    public partial class FrmTransfers : MaterialForm
    {
        public FrmTransfers()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
         //FORM : Transfers between lockers 
        //Combobox : From 
        private void FillSafe()
        {
            cbxSafeTFrom.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxSafeTFrom.DisplayMember = "Safe_Name";
            cbxSafeTFrom.ValueMember = "Safe_ID";
            //Combobox : To
            cbxSafeTTo.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxSafeTTo.DisplayMember = "Safe_Name";
            cbxSafeTTo.ValueMember = "Safe_ID";
        }




        private void loadingScreen()
        {
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTFrom.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafeTFrom.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTFrom.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                LabelBalanceFrom.Text = "0DH";
                LabelBalanceTo.Text = "0DH"
;
            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                LabelBalanceFrom.Text = $"{(dt.Rows[0][1]).ToString()} DH";
                LabelBalanceTo.Text = $"{(dt.Rows[0][1]).ToString()}DH";


            }
            //Clear Data 
            NubBalanceTTransfer.Value = 0;
            txtTransferName.Clear();
            txtNoteTransfer.Clear();
            DateTTransfer.Text = DateTime.Now.ToShortDateString();

        }

        //LOAD 
        private void FrmTransfers_Load(object sender, EventArgs e)
        {
           // SwitchSafeToBank.Checked = true;

            try
            {
                FillSafe();
                FillSafeBank();
                //From 
                loadingScreen();
                loadingScreenSafeBank();
                //Date Now 
                DateFromR.Text = DateTime.Now.ToShortDateString();
                DateToR.Text = DateTime.Now.ToShortDateString();
                DateFromRB.Text = DateTime.Now.ToShortDateString();
                DateToRB.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception)
            {
            }
        }
        //FORM :  between lockers 
        //method <loadingScreenFrom>
        //Load a page again and add credit to the vault from
        private void loadingScreenFrom()
        {
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTFrom.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafeTFrom.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTFrom.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                LabelBalanceFrom.Text = "0DH";
;            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                LabelBalanceFrom.Text = (dt.Rows[0][1]).ToString() + "DH";


            }
            //Clear Data 
            NubBalanceTTransfer.Value = 0;
            txtTransferName.Clear();
            txtNoteTransfer.Clear();
            DateTTransfer.Text = DateTime.Now.ToShortDateString();

        }

        //FORM :  between lockers 
        //method <loadingScreenTo>
        //Load a page again and add credit to the vault from
        private void loadingScreenTo()
        {
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTTo.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafeTTo.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTTo.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                LabelBalanceTo.Text = "0DH";
                
            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                LabelBalanceTo.Text = (dt.Rows[0][1]).ToString() + "DH";


            }
            //Clear Data 
            NubBalanceTTransfer.Value = 0;
            txtTransferName.Clear();
            txtNoteTransfer.Clear();
            DateTTransfer.Text = DateTime.Now.ToShortDateString();

        }

        // Change the length of the text box depending on what the user has 
        // selected and committed using the SelectionLength property.
        private void cbxSafeTFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadingScreenFrom();
        }

        // Change the length of the text box depending on what the user has 
        // selected and committed using the SelectionLength property.
        private void cbxSafeTTo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadingScreenTo();
        }
        //BUTTON : Transfer Money between Safes
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbxSafeTFrom.Items.Count <= 0)
                {
                    MessageBox.Show("Fill the tanks first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ( Convert.ToInt32( cbxSafeTFrom.SelectedValue) == Convert.ToInt32( cbxSafeTTo.SelectedValue) )
                {
                    MessageBox.Show("The balance cannot be transferred to the same safe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dt.Clear();
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafeTFrom.SelectedValue + "", "");
                if (NubBalanceTTransfer.Value > Convert.ToDecimal(dt.Rows[0][1]))
                {
                    MessageBox.Show("The balance in the safe is not enough to transfer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (txtTransferName.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                string Date = DateTTransfer.Value.ToString("dd/MM/yyyy");
                db.ExecuteData("update Safe set Safe_Money =Safe_Money - " + NubBalanceTTransfer.Value + " Where Safe_ID = " + cbxSafeTFrom.SelectedValue + " ", "");
                db.ExecuteData("update Safe set Safe_Money =Safe_Money + " + NubBalanceTTransfer.Value + " Where Safe_ID = " + cbxSafeTTo.SelectedValue + " ", "");
                db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafeTFrom.SelectedValue + ", " + NubBalanceTTransfer.Value + ",'" + Date + "' , N'" + txtTransferName.Text + "', N'Transfer to a safe', N'" + txtNoteTransfer.Text + "')  ", "");
                db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafeTFrom.SelectedValue + ", " + NubBalanceTTransfer.Value + ",'" + Date + "' , N'" + txtTransferName.Text + "', N'Transfer from safe', N'" + txtNoteTransfer.Text + "')  ", "");
                db.ExecuteData("insert into Safe_Transfer (Safe_Money ,Date ,From_ , To_, Transfer_Name,Reason ) Values ( " + NubBalanceTTransfer.Value + ",'" + Date + "' , N'" + cbxSafeTFrom.SelectedValue + "', N'" + cbxSafeTTo.SelectedValue + "', N'" + txtTransferName.Text + "',N'" + txtNoteTransfer.Text + "' )  ", "Transfer Successfully");
                loadingScreen();
            }
            catch (Exception)
            {

            }
        }

        //FORM :  between lockers and Bank 
        //Combobox : SafeBank  
        private void FillSafeBank()
        {
            cbxSafes.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxSafes.DisplayMember = "Safe_Name";
            cbxSafes.ValueMember = "Safe_ID";
        }
        //method <loadingScreenFrom>
        //Load a page again and add credit to the vault from
        private void loadingScreenSafeBank()
        {
            DataTable dtBank = new DataTable(); 
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafes.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafes.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafes.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                LabelSafeBalance.Text = "0 DH";
                
            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                LabelSafeBalance.Text =  $"{(dt.Rows[0][1]).ToString()} DH";
            }
            //Bank Balance
            dtBank = db.ReadData("select * from Bank ", "");
            if (Convert.ToDecimal(dt.Rows[0][0]) <= 0)
            {
                LabelBankBalance.Text = "0 DH";
            }
            else if (Convert.ToDecimal(dt.Rows[0][0]) >= 1)
            {
                LabelBankBalance.Text = $"{dtBank.Rows[0][0].ToString()} DH";
            }
            //Clear Data 
            NubBalanceBTransfer.Value = 0;
            txtTransferNameBank.Clear();
            DateBTransfer.Text = DateTime.Now.ToShortDateString();
        }

        private void cbxSafes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafes.SelectedValue + "", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Safe Values (" + cbxSafes.SelectedValue + ", 0) ", "");
                dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafes.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(dt.Rows[0][1]) <= 0)
            {
                LabelSafeBalance.Text = "0 DH";

            }
            else if (Convert.ToDecimal(dt.Rows[0][1]) >= 1)
            {
                LabelSafeBalance.Text =  $"{(dt.Rows[0][1]).ToString()} DH";
            }
        }
        //Transfer from bank to treasury
        private void SafeToBank()
        {
            string Date = DateTTransfer.Value.ToString("dd/MM/yyyy");

            dt.Clear();
            dt = db.ReadData("select * from Safe where Safe_ID = " + cbxSafes.SelectedValue + "", "");
            if (NubBalanceBTransfer.Value > Convert.ToDecimal(dt.Rows[0][1]))
            {
                MessageBox.Show("The balance in the safe is not enough to transfer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.ExecuteData("update Safe set Safe_Money =Safe_Money - " + NubBalanceBTransfer.Value + " Where Safe_ID = " + cbxSafes.SelectedValue + " ", "");
            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafes.SelectedValue + ", " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'" + txtTransferNameBank.Text + "', N'Transfer to a Bank', N'There is no reason')  ", "");
            db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafes.SelectedValue + ", " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'" + txtTransferNameBank.Text + "', N'Transfer from Bank', N'There is no reason')  ", "");
            db.ExecuteData("insert into Bank_insert (Money ,Date ,Depositor_Name , Type, Reason ) Values ( " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'" + txtTransferNameBank.Text + "', N'Transfer from Safe', N'There is no reason')   ", "");
            db.ExecuteData("update Bank set Money = Money + "+NubBalanceBTransfer.Value+" ", "");
            db.ExecuteData("insert into SafeBank_Transfer (Money ,Date ,From_ , To_, Transfer_Name ) Values ( " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'" + cbxSafes.Text + "', N'Bank', N'" + txtTransferNameBank.Text + "' )  ", "Transfer Successfully");


        }
        //Transfer from safe to bank
        private void BankSafe()
        {
            string Date = DateTTransfer.Value.ToString("dd/MM/yyyy");

            dt.Clear();
            dt = db.ReadData("select * from Bank ", "");
            if (NubBalanceBTransfer.Value > Convert.ToDecimal(dt.Rows[0][0]))
            {
                MessageBox.Show("It is not possible to transfer an amount greater than what is in a bank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.ExecuteData("update Bank set Money = Money - " + NubBalanceBTransfer.Value + "", "");
            db.ExecuteData("insert into Bank_Withdraw (Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values ( " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'" + txtTransferNameBank.Text + "', N'Transfer to a Safe', N'There is no reason')  ", "");
            db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + cbxSafes.SelectedValue + ", " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'" + txtTransferNameBank.Text + "', N'Transfer from Safe', N'There is no reason')  ", "");
            db.ExecuteData("update Safe set Safe_Money = Safe_Money + " + NubBalanceBTransfer.Value + " Where Safe_ID = "+cbxSafes.SelectedValue+"", "");
            db.ExecuteData("insert into SafeBank_Transfer (Money ,Date ,From_ , To_, Transfer_Name ) Values ( " + NubBalanceBTransfer.Value + ",'" + Date + "' , N'Bank', N'" + cbxSafes.Text + "', N'" + txtTransferNameBank.Text + "' )  ", "Transfer Successfully");

        }
        //BUTTON TRANSFER : From a safe to a bank and vice versa
        private void btnTransferBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxSafes.Items.Count <= 0)
                {
                    MessageBox.Show("Fill the tanks first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtTransferNameBank.Text == string.Empty)
                {
                    MessageBox.Show("Please write a name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                if(SwitchSafeToBank.Checked == true)
                {
                    SafeToBank();
                }
                else
                {
                    BankSafe();
                }

                loadingScreenSafeBank();
            }
            catch (Exception)
            {
            }
        }
        //FORM : report transfer bettween Safes
        //BUTTON : Searsh
        private void btnSearchR_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToR.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            dt = db.ReadData("SELECT [Order_ID] as 'Number Order',[Safe_Money] as 'Money', [Date]  ,(select Safe_Name from Safe_Data where Safe_Data.Safe_ID = From_) as 'Transfer From',(select Safe_Name from Safe_Data where Safe_Data.Safe_ID = To_) as 'Transfer To ',[Transfer_Name] as 'Transfer Name',[Reason] FROM [dbo].[Safe_Transfer] Where CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
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
                db.ExecuteData("delete from Safe_Transfer where CONVERT(Date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
            DateFromR.Text = DateTime.Now.ToShortDateString();
            DateToR.Text = DateTime.Now.ToShortDateString();
            btnSearchR_Click(null, null);
        }

        //FORM : Transfer bettween bank and safe 
        //BUTTON : Search 
        private void btnSearchRB_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRB.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRB.Value.ToString("yyyy-MM-dd");
            //RadioButton  : All Transfer 
            if (RadioAllTransfers.Checked == true)
            {
                dt.Clear();
                dt = db.ReadData("SELECT [Order_ID] as 'Number Order',[Money],[Date], From_ as 'Transfer From',To_ as 'Transfer To ',[Transfer_Name] as 'Transfer Name 'FROM [dbo].[SafeBank_Transfer] Where CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
                if (dt.Rows.Count >= 1)
                {
                    DgvRB.DataSource = dt;
                    decimal Sum = 0;
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        Sum += Convert.ToDecimal(dt.Rows[i][1]);
                    }
                    //function that returns 2 numbers after the comma
                    txtTotalRB.Text = $"{Math.Round(Sum, 2).ToString()} DH";
                }
                else
                {
                    txtTotalRB.Text = "0 DH";
                }
            }
            //RadioButton  : From Safe To Bank 
            if (RadioSafeToBank.Checked == true)
            {

                dt.Clear();
                dt = db.ReadData(" SELECT [Order_ID] as 'Number Order',[Money],[Date], From_ as 'Transfer From',To_ as 'Transfer To ',[Transfer_Name] as 'Transfer Name 'FROM [dbo].[SafeBank_Transfer] Where To_ = 'Bank' and  CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
                if (dt.Rows.Count >= 1)
                {
                    DgvRB.DataSource = dt;
                    decimal Sum = 0;
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        Sum += Convert.ToDecimal(dt.Rows[i][1]);
                    }
                    //function that returns 2 numbers after the comma
                    txtTotalRB.Text = $"{Math.Round(Sum, 2).ToString()} DH";
                }
                else
                {
                    txtTotalRB.Text = "0 DH";
                }
            }
            //RadioButton  : From bank To Safe
            if (RadioBankToSafe.Checked == true)
            {
                dt.Clear();
                dt = db.ReadData(" SELECT [Order_ID] as 'Number Order',[Money],[Date], From_ as 'Transfer From',To_ as 'Transfer To ',[Transfer_Name] as 'Transfer Name 'FROM [dbo].[SafeBank_Transfer] Where From_ = 'Bank' and  CONVERT(date,Date,105) between  '" + DateFrom + "' and '" + DateTo + "' ", "");
                if (dt.Rows.Count >= 1)
                {
                    DgvRB.DataSource = dt;
                    decimal Sum = 0;
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        Sum += Convert.ToDecimal(dt.Rows[i][1]);
                    }
                    //function that returns 2 numbers after the comma
                    txtTotalRB.Text = $"{Math.Round(Sum, 2).ToString()} DH";
                }
                else
                {
                    txtTotalRB.Text = "0 DH";
                }
            }          
    }
        //BUTTON : Delete 
        private void btnDeleteRB_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRB.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRB.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from SafeBank_Transfer where CONVERT(Date,Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                dt.Clear();
            }
            btnSearchR_Click(null, null);
        }

        private void ReportbetweeSafeBank_Click(object sender, EventArgs e)
        {

        }

       
    }
}
