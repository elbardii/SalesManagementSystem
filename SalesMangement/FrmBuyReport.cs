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
    public partial class FrmBuyReport : MaterialForm
    {
        public FrmBuyReport()
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
        private void FillSuppliers()
        {
            CbxSupRep.DataSource = db.ReadData("select * from Suppliers ", "");
            CbxSupRep.DisplayMember = "Sup_Name";
            CbxSupRep.ValueMember = "Sup_ID";
        }
        //PRINT : buy
        private void Print()
        {
            try
            {
                FrmPrinting Print = new FrmPrinting();

                int id = Convert.ToInt32(DgvSupRep.CurrentRow.Cells[0].Value);
                DataTable dtRtp = new DataTable();
                dtRtp.Clear();
                dtRtp = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date', Unit_Name as 'Unit',[User_Name] as 'User Name',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID  and Order_ID = " + id + "", "");
                Print.crystalReportViewer.RefreshReport();
                if (Properties.Settings.Default.PrintBuyKind == "8CM")
                {
                    RptOrderBuy Rpt = new RptOrderBuy();
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
                    RptOrderBuyA4 Rpt = new RptOrderBuyA4();
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
        //PRINT : all Buy
        private void PrintAll()
        {
            try
            {
                string DateFrom;
                string DateTo;
                DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
                DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
                DataTable dtRtp = new DataTable();
                dtRtp.Clear();
                dtRtp = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount', Unit_Name as 'Unit',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID   and CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ORDER BY Order_ID ASC", "");
               // FrmPrinting Print = new FrmPrinting();
                //Print.crystalReportViewer.RefreshReport();
                RptBuyReport Rpt = new RptBuyReport();

                //Username and password data Database name
                //In order to run a program in the client's machine without problems
                Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
                Rpt.SetDataSource(dtRtp);
                Rpt.SetParameterValue("From", DateFrom);
                Rpt.SetParameterValue("To", DateTo);
                //Print.crystalReportViewer.ReportSource = Rpt;
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                Rpt.PrintToPrinter(1,true,0,0);
                //Print.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
        //TOTAL: A function that sums the sum of price
        private void Total()
        {
            decimal Total = 0; decimal Totaltax = 0;
            for (int i = 0; i <= DgvSupRep.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvSupRep.Rows[i].Cells[9].Value);
                Totaltax+= Convert.ToDecimal(DgvSupRep.Rows[i].Cells[7].Value) * Convert.ToDecimal(DgvSupRep.Rows[i].Cells[3].Value);
            }
            txtTotal.Text = Math.Round(Total, 2).ToString();
            txtToatalTax.Text = Math.Round(Totaltax, 2).ToString() ;
        }

        private void FrmBuyReport_Load(object sender, EventArgs e)
        {
            //FillSuppliers();
            //DateTime: dtp 
            DateFromExpR.Text = DateTime.Now.ToShortDateString();
            DateToExpR.Text = DateTime.Now.ToShortDateString();

            try
            {
                FillSuppliers();
            }
            catch (Exception)
            {
            }
            //DateTimeSup.Text = DateTime.Now.ToString();
           
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (rbtnAllSup.Checked == true)
            {
                if (CheckboxInNumber.Checked == false)
                {
                    dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount', Unit_Name as 'Unit',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID  ", "");
                }
                else if (CheckboxInNumber.Checked == true)
                    {
                    dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount', Unit_Name as 'Unit',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID and Order_ID = " + txtInNumber.Text+"  ", "");

                }
            }
            else if (rbtnSpSup.Checked == true)
            {
                if (CheckboxInNumber.Checked == false)
                {
                    dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount', Unit_Name as 'Unit',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID and Suppliers.Sup_Name = '" + txtSearsh.Text + "' and CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "'", "");

                }
                else if (CheckboxInNumber.Checked == true)
                {
                    dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount', Unit_Name as 'Unit',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID and Order_ID = " + txtInNumber.Text + " and  CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "");
                }

            }
            DgvSupRep.DataSource = dt;
            Total();

        }

        private void txtSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string DateFrom;
                string DateTo;
                DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
                DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
                dt.Clear();
                if (rbtnAllSup.Checked == true)
                {
                    if (CheckboxInNumber.Checked == false)
                    {
                        dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number', Product.Pro_Name as 'Product Name', Suppliers.Sup_Name as 'Supplier Name',[Quantity] as 'Quantity',[Buy_Date] as 'Date',[Buy_Price] as 'Price',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where[Buy_Detalis].Sup_ID = Suppliers.Sup_ID and[Buy_Detalis].Pro_ID = Product.Pro_Id and CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ORDER BY Order_ID ASC ", "");
                    }
                    else if (CheckboxInNumber.Checked == true)
                    {
                        dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number', Product.Pro_Name as 'Product Name', Suppliers.Sup_Name as 'Supplier Name',[Quantity] as 'Quantity',[Buy_Date] as 'Date',[Buy_Price] as 'Price',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where[Buy_Detalis].Sup_ID = Suppliers.Sup_ID and[Buy_Detalis].Pro_ID = Product.Pro_Id and Order_ID = " + txtInNumber.Text + " and  CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ORDER BY Order_ID ASC ", "");

                    }
                }
                else if (rbtnSpSup.Checked == true)
                {
                    if (CheckboxInNumber.Checked == false)
                    {
                        dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number', Product.Pro_Name as 'Product Name', Suppliers.Sup_Name as 'Supplier Name',[Quantity] as 'Quantity',[Buy_Date] as 'Date',[Buy_Price] as 'Price',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where[Buy_Detalis].Sup_ID = Suppliers.Sup_ID and[Buy_Detalis].Pro_ID = Product.Pro_Id and Suppliers.Sup_Name = '" + txtSearsh.Text + "' and CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ORDER BY Order_ID ASC", "");

                    }
                    else if (CheckboxInNumber.Checked == true)
                    {
                        dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number', Product.Pro_Name as 'Product Name', Suppliers.Sup_Name as 'Supplier Name',[Quantity] as 'Quantity',[Buy_Date] as 'Date',[Buy_Price] as 'Price',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where[Buy_Detalis].Sup_ID = Suppliers.Sup_ID and[Buy_Detalis].Pro_ID = Product.Pro_Id and Order_ID = " + txtInNumber.Text + " and  CONVERT(date,Buy_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ORDER BY Order_ID ASC ", "");

                    }

                }
                DgvSupRep.DataSource = dt;
                Total();
            }
        }

        private void btnPrintRep_Click(object sender, EventArgs e)
        {
            if (DgvSupRep.Rows.Count >= 1)
            {
                Print();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            if(DgvSupRep.Rows.Count >= 1)
            {
                if (MessageBox.Show("Are you sure you will delete All Reports  ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ExecuteData("Delete From Buy Where Order_ID = " + DgvSupRep.CurrentRow.Cells[0].Value + "", "It has been deleted successfully");
                    btnSearsh_Click(null, null);

                }
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if(DgvSupRep.Rows.Count >= 1)
            {
                PrintAll();
            }
        }
        //textbox that only accepts numbers
        private void txtInNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
