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
    public partial class FrmCustomersAccounts : MaterialForm
    {
        public FrmCustomersAccounts()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        Database db = new Database();
        DataTable dt = new DataTable();
        //COMBOBOX : Customers
        private void FillCustomers()
        {
            CbxCustAc.DataSource = db.ReadData("select * from Customers ", "");
            CbxCustAc.DisplayMember = "Cust_Name";
            CbxCustAc.ValueMember = "Cust_ID";
        }
        //PRINT : report pdf
        private void PrintCustomers()
        {

            String Name = Convert.ToString(CbxCustAc.Text);
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData("SELECT Order_ID as 'Invoice Number ',Customers.Cust_Name as 'Name Customer',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Customer_Money, Customers where   Customers.Cust_Name =  Customer_Money.Cust_Name and Customer_Money.Cust_Name = N'" + Name +"' ", "");
            FrmPrinting Print = new FrmPrinting();
            RptCustomersAccounts Rpt = new RptCustomersAccounts();
            Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("Name", Name);
            Print.crystalReportViewer.ReportSource = Rpt;
            //Print.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            Rpt.PrintToPrinter(1, true, 0, 0);

        }
        int Safe_ID = 0;
        private void FrmCustomersAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                FillCustomers();
                Safe_ID = Properties.Settings.Default.Safe_ID;
            }
            catch (Exception)
            {
            }
            CbxCustAc.SelectedIndex = -1;
            DateTimeNow.Text = DateTime.Now.ToString();
            dt.Clear();
            dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Customers.Cust_Name as 'Name Customer',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Customer_Money, Customers where   Customers.Cust_Name =  Customer_Money.Cust_Name", "");
            DgvCustAccounts.DataSource = dt; 
            decimal Total = 0;
            for (int i = 0; i <= DgvCustAccounts.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvCustAccounts.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = Total.ToString();
        }
        //BUTTON : Searsh
        private void btnSearsh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (rbtnAllCust.Checked == true)
            {
                dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Customers.Cust_Name as 'Name Customer',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Customer_Money, Customers where   Customers.Cust_Name =  Customer_Money.Cust_Name", "");
            }
            else if (rbtnSpCust.Checked == true)
            {
                dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Customers.Cust_Name as 'Name Customer',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Customer_Money, Customers where   Customers.Cust_Name =  Customer_Money.Cust_Name and Customers.Cust_Name = '"+txtSearsh.Text+"'", "");

            }
            DgvCustAccounts.DataSource = dt;
            decimal Total = 0;
            for (int i = 0; i <= DgvCustAccounts.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvCustAccounts.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = Math.Round(Total, 2).ToString();
        }

        private void txtSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dt.Clear();
                if (rbtnAllCust.Checked == true)
                {
                    dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Customers.Cust_Name as 'Name Customer',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Customer_Money, Customers where   Customers.Cust_Name =  Customer_Money.Cust_Name", "");
                }

                else if (rbtnSpCust.Checked == true)
                {
                    dt = db.ReadData("SELECT Order_ID as 'Invoice Number ',Customers.Cust_Name as 'Name Customer',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Customer_Money, Customers where   Customers.Cust_Name =  Customer_Money.Cust_Name and Customers.Cust_Name = '"+txtSearsh.Text+"' ", "");
                }
                DgvCustAccounts.DataSource = dt;
                decimal Total = 0;
                for (int i = 0; i <= DgvCustAccounts.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(DgvCustAccounts.Rows[i].Cells[2].Value);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
            }
        }
        //BOTTON : Definite Payment
        private void btnDefinitePay_Click(object sender, EventArgs e)
        {
            string Cust_Name = string.Empty;
            string Date = DateTimeNow.Value.ToString("dd/MM/yyyy");
            decimal Safe_Money = 0;
            dt.Clear();
            dt = db.ReadData("select * from Stock where Stock_ID=" + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(dt.Rows[0][1]);
            if (rbtnAllCust.Checked == true)
            {
                if (Convert.ToDecimal(DgvCustAccounts.CurrentRow.Cells[2].Value) > Safe_Money)
                {
                    MessageBox.Show("The amount in the safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (Convert.ToDecimal(NumPricePayPart.Value) > Safe_Money)
                {
                    MessageBox.Show("The amount in the safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (DgvCustAccounts.Rows.Count >= 0)
            {
                if (rbtnPayFull.Checked == true)
                {
                    if (MessageBox.Show("Are you sure you will pay the Full amount?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllCust.Checked == true)
                        {
                            MessageBox.Show("Please Select  Name Of  Customer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        db.ExecuteData("delete from Customer_Money where Order_ID=" + DgvCustAccounts.CurrentRow.Cells[0].Value + " and Price =" + DgvCustAccounts.CurrentRow.Cells[2].Value + "", "");
                        db.ExecuteData("insert  into Customer_Report values (" + DgvCustAccounts.CurrentRow.Cells[0].Value + " , " + DgvCustAccounts.CurrentRow.Cells[2].Value + " , '" + Date + "' , N'" + CbxCustAc.Text + "')", "The amount has been paid successfully");
                        FrmCustomersAccounts_Load(null, null);

                    }
                }


                else if (rbtnPayingPart.Checked == true)
                {
                    if (MessageBox.Show("Are you sure you will pay the Part amount?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllCust.Checked == true)
                        {
                            MessageBox.Show("Please Select  Name Of  Customer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        decimal money = Convert.ToDecimal(DgvCustAccounts.CurrentRow.Cells[2].Value) - NumPricePayPart.Value;
                        db.ExecuteData("update Customer_Money set Price=" + money + " where Order_ID=" + DgvCustAccounts.CurrentRow.Cells[0].Value + " and Price=" + DgvCustAccounts.CurrentRow.Cells[2].Value + "", "");
                        db.ExecuteData("insert  into Customer_Report values (" + DgvCustAccounts.CurrentRow.Cells[0].Value + " , " + NumPricePayPart.Value + " , '" + Date + "' , N'" + CbxCustAc.Text + "')", "The amount has been paid successfully");
                        FrmCustomersAccounts_Load(null, null);
                    }
                }
                if(rbtnAllCust.Checked == true)
                {
                    db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + DgvCustAccounts.CurrentRow.Cells[2].Value + ",N'" + Date + "' , N'" + Properties.Settings.Default.UserName + "', N'Dues From Clients', N'')  ", "");
                    db.ExecuteData("Update Safe Set Safe_Money = Safe_Money + " + DgvCustAccounts.CurrentRow.Cells[2].Value + " Where Safe_ID = " + Safe_ID + "", "");
                }
                else 
                {
                    db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + NumPricePayPart.Value + ",N'" + Date + "' , N'" + Properties.Settings.Default.UserName + "', N'Dues From Clients', N'')  ", "");
                    db.ExecuteData("Update Safe Set Safe_Money = Safe_Money + " + NumPricePayPart.Value + " Where Safe_ID = " + Safe_ID + "", "");

                }
            }
        }
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (rbtnSpCust.Checked == true)
            {
                if (DgvCustAccounts.Rows.Count >= 1)
                {
                    PrintCustomers();
                }
            }
        }
    }
}
