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
    public partial class FrmSalesReport : MaterialForm
    {
        public FrmSalesReport()
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
        //PRINT : sales 
        private void Print()
        {
            try
            {
                FrmPrinting Print = new FrmPrinting();

                int id = Convert.ToInt32(DgvCustRep.CurrentRow.Cells[0].Value);
                DataTable dtRtp = new DataTable();
                dtRtp.Clear();
                dtRtp = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ',Product.[Pro_Name] as 'Name Product',Sales_Detalis.[Cust_Name] as 'Name Customer',[Quantity] as 'Quantity',[Sales_Date] as ' Sales Date',[User_Name] as 'User Name',Unit_Name as 'Unit', Sale_PriceTax as 'Tax Included Price',[Sales_Discount] as 'Discount',[Sales_Total] as 'Total Order',[Sales_TotalAll] as 'Total Invoice',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount',[Sales_Detalis].Sales_TaxValue as 'TAX Value' FROM [dbo].[Sales_Detalis] , Product where  Product.Pro_Id = Sales_Detalis.Pro_ID  and Order_ID = " + id + "", "");
                Print.crystalReportViewer.RefreshReport();
                if (Properties.Settings.Default.PrintBuyKind == "8CM")
                {
                    RptOrderSales Rpt = new RptOrderSales();
                    //Username and password data Database name
                    //In order to run a program in the client's machine without problems
                    Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
                    Rpt.SetDataSource(dtRtp);
                    Rpt.SetParameterValue("ID_Order", id);
                    Print.crystalReportViewer.ReportSource = Rpt;
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    Rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrintName;
                    Rpt.PrintToPrinter(1, true, 0, 0);
                    //Print.ShowDialog();
                }

                else if (Properties.Settings.Default.PrintBuyKind == "A4")
                {
                    RptOrderSalesA4 Rpt = new RptOrderSalesA4();
                    //Username and password data Database name
                    //In order to run a program in the client's machine without problems
                    Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
                    Rpt.SetDataSource(dtRtp);
                    Rpt.SetParameterValue("Order_ID", id);
                    Print.crystalReportViewer.ReportSource = Rpt;
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    Rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrintName;
                    Rpt.PrintToPrinter(1, true, 0, 0);
                    //Print.ShowDialog();
                }
            }
            catch (Exception)
            {
            }

        }
        //PRINT : All Sales
        private void PrintAll()
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData(" SELECT [Order_ID]  as 'Invoice Number',Product.Pro_Name as 'Name Product',[Cust_Name] as  'Customer', Sales_Detalis.[Quantity] as 'Quantity',Unit_Name as 'Units',[Sales_Date] as 'Date',[User_Name] as 'User Name',[Sales_Price] as 'Price',Sales_PriceTax as 'Tax Included Price' ,[Sales_Discount] as 'Discount',[Sales_Total] as 'Total',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount'FROM [dbo].[Sales_Detalis],Product where Product.Pro_Id = Sales_Detalis.Pro_ID and CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ORDER BY Order_ID ASC", "");
            FrmPrinting Print = new FrmPrinting();
            RptSalesReport Rpt = new RptSalesReport();
            Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("From", DateFrom);
            Rpt.SetParameterValue("To", DateTo);
            Print.crystalReportViewer.ReportSource = Rpt;
            //Print.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            Rpt.PrintToPrinter(1, true, 0, 0);
        }
        //TOTAL: A function that sums the sum of price
        private void Total()
        {
            decimal TotalOrder = 0 ,TotalSoldTax = 0 , TotalSpecific = 0, TotalTax = 0;
            for (int i = 0; i <= DgvCustRep.Rows.Count - 1; i++)
            {
                TotalOrder += (Convert.ToDecimal(DgvCustRep.Rows[i].Cells[4].Value) * Convert.ToDecimal(DgvCustRep.Rows[i].Cells[3].Value)) - Convert.ToDecimal(DgvCustRep.Rows[i].Cells[10].Value);
                TotalTax += Convert.ToDecimal(DgvCustRep.Rows[i].Cells[5].Value) * Convert.ToDecimal(DgvCustRep.Rows[i].Cells[3].Value) ;
                TotalSoldTax += Convert.ToDecimal(DgvCustRep.Rows[i].Cells[11].Value) ;
            }

            txtTotal.Text = $"{Math.Round(TotalOrder, 2)} HD " ;
            txtTotalTax.Text  = $"{Math.Round(TotalTax, 2)} HD ";
            txtTotalSoldTax.Text = $"{Math.Round(TotalSoldTax, 2)} HD ";

            if(rbtnSpUsers.Checked == true)
            {
                try
                {
                    TotalSpecific = Convert.ToDecimal(db.ReadData("select * from Users where User_ID=" + CbxUsersRep.SelectedValue + "", "").Rows[0][5]);
                    txtTotalSpecific.Text = $"{((Convert.ToDecimal(Math.Round(TotalSoldTax, 2)) / 100) * TotalSpecific) } HD";
                }
                catch (Exception)
                {
                }
            }
        }

        private void FrmSalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                FillUsers();
            }
            catch (Exception)
            {

                
            }
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
                    if(rbtnAllUsers.Checked == true)
                    {
                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ',Product.[Pro_Name] as 'Name Product',Sales_Detalis.[Cust_Name] as 'Name Customer',[Quantity] as 'Quantity',[Sales_Detalis].Sales_Price as 'TAX-Free price',[Sales_Detalis].Sales_TaxValue as 'TAX Value', Sale_PriceTax as 'TAX Included Price',[Sales_Date] as ' Sales Date',[User_Name] as 'User Name',Unit_Name as 'Unit',[Sales_Discount] as 'Discount',[Sales_Total] as 'Total Order',[Sales_TotalAll] as 'Total Invoice',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount' FROM [dbo].[Sales_Detalis] , Product where  Product.Pro_Id = Sales_Detalis.Pro_ID   and  CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");

                    }
                    else if(rbtnSpUsers.Checked == true)
                    {
                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ',Product.[Pro_Name] as 'Name Product',Sales_Detalis.[Cust_Name] as 'Name Customer',[Quantity] as 'Quantity',[Sales_Detalis].Sales_Price as 'TAX-Free price',[Sales_Detalis].Sales_TaxValue as 'TAX Value', Sale_PriceTax as 'TAX Included Price',[Sales_Date] as ' Sales Date',[User_Name] as 'User Name',Unit_Name as 'Unit',[Sales_Discount] as 'Discount',[Sales_Total] as 'Total Order',[Sales_TotalAll] as 'Total Invoice',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount' FROM [dbo].[Sales_Detalis] , Product where  Product.Pro_Id = Sales_Detalis.Pro_ID and User_Name = N'"+CbxUsersRep.Text+"'  and  CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");
                    }
                }


                if(CheckboxInNumber.Checked == true)
                {
                    if(rbtnAllUsers.Checked == true)
                    {

                    dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ',Product.[Pro_Name] as 'Name Product',Sales_Detalis.[Cust_Name] as 'Name Customer',[Quantity] as 'Quantity',[Sales_Detalis].Sales_Price as 'TAX-Free price',[Sales_Detalis].Sales_TaxValue as 'TAX Value', Sale_PriceTax as 'TAX Included Price',[Sales_Date] as ' Sales Date',[User_Name] as 'User Name',Unit_Name as 'Unit',[Sales_Discount] as 'Discount',[Sales_Total] as 'Total Order',[Sales_TotalAll] as 'Total Invoice',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount' FROM [dbo].[Sales_Detalis] , Product where  Product.Pro_Id = Sales_Detalis.Pro_ID  and Order_ID = " + txtInNumber.Text + " and CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");

                    }
                    else if (rbtnSpUsers.Checked == true)
                    {
                     dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ',Product.[Pro_Name] as 'Name Product',Sales_Detalis.[Cust_Name] as 'Name Customer',[Quantity] as 'Quantity',[Sales_Detalis].Sales_Price as 'TAX-Free price',[Sales_Detalis].Sales_TaxValue as 'TAX Value', Sale_PriceTax as 'TAX Included Price',[Sales_Date] as ' Sales Date',[User_Name] as 'User Name',Unit_Name as 'Unit',[Sales_Discount] as 'Discount',[Sales_Total] as 'Total Order',[Sales_TotalAll] as 'Total Invoice',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount' FROM [dbo].[Sales_Detalis] , Product where  Product.Pro_Id = Sales_Detalis.Pro_ID  and Order_ID = " + txtInNumber.Text + " and User_Name = N'"+CbxUsersRep.Text+"' and CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC  ", "");
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
                    db.ExecuteData("Delete From Sales Where  CONVERT(date,Sales_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
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

        private void btnPrintRep_Click(object sender, EventArgs e)
        {
            if(DgvCustRep.Rows.Count >= 1)
            {
                Print();
            }
        }
        // textbox that only accepts numbers
        private void txtInNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}