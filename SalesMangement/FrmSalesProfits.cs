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
    public partial class FrmSalesProfits : MaterialForm
    {
        public FrmSalesProfits()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        //FILLSUPPLIERS : Filled combobox by Suppliers 
        private void FillUsers()
        {
            CbxUsersRep.DataSource = db.ReadData("select * from Users ", "");
            CbxUsersRep.DisplayMember = "UserName";
            CbxUsersRep.ValueMember = "User_ID";
        }

        //PRINT : All Sales
        private void PrintAll()
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromExpR.Value.ToString("yyyy/MM/dd");
            DateTo = DateToExpR.Value.ToString("yyyy/MM/dd");
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData("  SELECT [Order_ID] as 'Invoice Number',[Sales_Profits].[Pro_ID] as 'Name Product',[Cust_Name] as 'Name Customer',[Quantity],[Unit_Name] as 'Unit',[Sales_Date] as 'Sales Date',[Sales_Price] as 'Sales Price',[Sales_Discount] as 'Discount',[Sales_Total] as ' Total Sales',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'PaidUp',[Sales_RestAmount] as 'Rest Amount',[Sales_TaxValue] as 'TAX Value',[Sales_PriceTax] as 'Price TAX',[Buy_Price] as 'Buy Price',([Sales_Price] -[Buy_Price]  ) * [Quantity] as 'Profit',[Sales_Time] as 'Time',[User_Name] as 'Username' FROM [dbo].[Sales_Profits] , Product Where Product.Pro_Id = Sales_Profits.Pro_ID   and CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ORDER BY Order_ID ASC", "");
           // FrmPrinting Print = new FrmPrinting();
            RptProfits Rpt = new RptProfits();
           // Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("From", DateFrom);
            Rpt.SetParameterValue("To", DateTo);
          //  Print.crystalReportViewer.ReportSource = Rpt;
            //Print.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            Rpt.PrintToPrinter(1, true, 0, 0);
        }
        //TOTAL: A function that sums the sum of price
        private void Total()
        {
            decimal TotalOrder = 0, TotalProfit = 0 ;
            for (int i = 0; i <= DgvCustRep.Rows.Count - 1; i++)
            {
                TotalOrder += Convert.ToDecimal(DgvCustRep.Rows[i].Cells[8].Value);
                TotalProfit += Convert.ToDecimal(DgvCustRep.Rows[i].Cells[15].Value);

            }
            txtTotal.Text = $"{Math.Round(TotalOrder, 2)} HD";
            txtTotalProfit.Text = $"{Math.Round(TotalProfit, 2) } HD";
        }
        private void FrmSalesProfits_Load(object sender, EventArgs e)
        {
            FillUsers();
            DateFromExpR.Text = DateTime.Now.ToShortDateString();
            DateToExpR.Text = DateTime.Now.ToShortDateString(); 
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (CheckboxInNumber.Checked == false)
            {
                if (rbtnAllUsers.Checked == true)
                {
                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number',[Sales_Profits].[Pro_ID] as 'Name Product',[Cust_Name] as 'Name Customer',[Quantity],[Unit_Name] as 'Unit',[Sales_Date] as 'Sales Date',[Sales_Price] as 'Sales Price',[Sales_Discount] as 'Discount',[Sales_Total] as ' Total Sales',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'PaidUp',[Sales_RestAmount] as 'Rest Amount',[Sales_TaxValue] as 'TAX Value',[Sales_PriceTax] as 'Price TAX',[Buy_Price] as 'Buy Price',([Sales_Price] -[Buy_Price]  ) * [Quantity] as 'Profit',[Sales_Time] as 'Time',[User_Name] as 'Username' FROM [dbo].[Sales_Profits] , Product Where Product.Pro_Id = Sales_Profits.Pro_ID   and  CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");

                }
                else if (rbtnSpUsers.Checked == true)
                {
                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number',[Sales_Profits].[Pro_ID] as 'Name Product',[Cust_Name] as 'Name Customer',[Quantity],[Unit_Name] as 'Unit',[Sales_Date] as 'Sales Date',[Sales_Price] as 'Sales Price',[Sales_Discount] as 'Discount',[Sales_Total] as ' Total Sales',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'PaidUp',[Sales_RestAmount] as 'Rest Amount',[Sales_TaxValue] as 'TAX Value',[Sales_PriceTax] as 'Price TAX',[Buy_Price] as 'Buy Price',([Sales_Price] -[Buy_Price]  ) * [Quantity] as 'Profit',[Sales_Time] as 'Time',[User_Name] as 'Username' FROM [dbo].[Sales_Profits] , Product Where Product.Pro_Id = Sales_Profits.Pro_ID and User_Name = N'" + CbxUsersRep.Text + "'  and  CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");
                }
            }


            if (CheckboxInNumber.Checked == true)
            {
                if (rbtnAllUsers.Checked == true)
                {

                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number',[Sales_Profits].[Pro_ID] as 'Name Product',[Cust_Name] as 'Name Customer',[Quantity],[Unit_Name] as 'Unit',[Sales_Date] as 'Sales Date',[Sales_Price] as 'Sales Price',[Sales_Discount] as 'Discount',[Sales_Total] as ' Total Sales',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'PaidUp',[Sales_RestAmount] as 'Rest Amount',[Sales_TaxValue] as 'TAX Value',[Sales_PriceTax] as 'Price TAX',[Buy_Price] as 'Buy Price',([Sales_Price] -[Buy_Price]  ) * [Quantity] as 'Profit',[Sales_Time] as 'Time',[User_Name] as 'Username' FROM [dbo].[Sales_Profits] , Product Where Product.Pro_Id = Sales_Profits.Pro_ID and Order_ID = " + txtInNumber.Text + " and CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");

                }
                else if (rbtnSpUsers.Checked == true)
                {
                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number',[Sales_Profits].[Pro_ID] as 'Name Product',[Cust_Name] as 'Name Customer',[Quantity],[Unit_Name] as 'Unit',[Sales_Date] as 'Sales Date',[Sales_Price] as 'Sales Price',[Sales_Discount] as 'Discount',[Sales_Total] as ' Total Sales',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'PaidUp',[Sales_RestAmount] as 'Rest Amount',[Sales_TaxValue] as 'TAX Value',[Sales_PriceTax] as 'Price TAX',[Buy_Price] as 'Buy Price',([Sales_Price] -[Buy_Price]  ) * [Quantity] as 'Profit',[Sales_Time] as 'Time',[User_Name] as 'Username' FROM [dbo].[Sales_Profits] , Product Where Product.Pro_Id = Sales_Profits.Pro_ID  and Order_ID = " + txtInNumber.Text + " and User_Name = N'" + CbxUsersRep.Text + "' and CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");
                }

            }
            DgvCustRep.DataSource = dt;
            Total();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            if (DgvCustRep.Rows.Count >= 1)
            {
                if (MessageBox.Show("Are you sure you will delete All Reports  ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string DateFrom;
                    string DateTo;
                    DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
                    DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
                    db.ExecuteData("Delete From Sales_Profits Where  CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                    btnSearsh_Click(null, null);

                }
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (DgvCustRep.Rows.Count >= 1)
            {
                PrintAll();
            }
        }
        // textbox that only accepts numbers
        private void txtInNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
