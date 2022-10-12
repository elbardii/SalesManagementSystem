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
    public partial class FrmTaxesReports : MaterialForm
    {
        public FrmTaxesReports()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();


        private void FrmTaxesReports_Load(object sender, EventArgs e)
        {

        }
        private void Total()
        {
            decimal TotalInvoice = 0; decimal Totaltax = 0 , TotalAfterTax = 0;
            for (int i = 0; i <= DgvTaxesReport.Rows.Count - 1; i++)
            {
                TotalInvoice += Convert.ToDecimal(DgvTaxesReport.Rows[i].Cells[6].Value);
                Totaltax += Convert.ToDecimal(DgvTaxesReport.Rows[i].Cells[7].Value);
                TotalAfterTax += Convert.ToDecimal(DgvTaxesReport.Rows[i].Cells[8].Value);
            }
            txtTotalInvoice.Text = Math.Round(TotalInvoice, 2).ToString();
            txtTotalTax.Text = Math.Round(Totaltax, 2).ToString();
            txtTotalAfterTax.Text = Math.Round(TotalAfterTax, 2).ToString();
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRut.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRut.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            string Sale = "Sales Invoice", Buy = "Purchase Invoice", ReturnsSale = "Returns Sales", ReturnsBuy = "Returns Buy";


            if (CheckboxSalesInvoices.Checked)
            {
                Sale = "Sales Invoice";
            }
            else
            {
                Sale = "";
            }

            if(CheckboxPurchaseInvoices.Checked)
            {
                Buy = "Purchase Invoice";
            }
            else
            {
                Buy = "";
            }

            if(CheckboxSalesReturnsIn.Checked)
            {
                ReturnsSale = "Returns Sales";
            }
            else
            {
                ReturnsSale = "";
            }

            if(CheckboxBuyReturnsIn.Checked)
            {
                ReturnsBuy = "Returns Buy";

            }
            else
            {
                ReturnsBuy = "";
            }


            dt = db.ReadData(" SELECT [Order_ID] as 'Order ID',[Invoice_ID] as 'Invoice ID',[Order_Type] as 'Order Type',[Tax_Type] as 'Tax Type',[Sup_Name] as 'Suppliers',[Cust_Name] as 'Customers',[Total_Order] as 'Total Order',[Total_Tax] as 'Total Tax',[Total_AfterTax] as 'Total After Tax',[Tax_Date] as 'Tax Date'FROM [dbo].[Taxes_Report] Where   Order_Type in (N'" + Sale+"',N'"+Buy+"',N'"+ReturnsSale+"',N'"+ReturnsBuy+"') and  CONVERT(date,Tax_Date,105) between '" + DateFrom + "' and '" + DateTo + "'", "");
            DgvTaxesReport.DataSource = dt;
            Total();
            


        }
        //PRINT : All Taxes Reports
        private void PrintAll()
        {
            string Sale = "Sales Invoice", Buy = "Purchase Invoice", ReturnsSale = "Returns Sales", ReturnsBuy = "Returns Buy";


            if (CheckboxSalesInvoices.Checked)
            {
                Sale = "Sales Invoice";
            }
            else
            {
                Sale = "";
            }

            if (CheckboxPurchaseInvoices.Checked)
            {
                Buy = "Purchase Invoice";
            }
            else
            {
                Buy = "";
            }

            if (CheckboxSalesReturnsIn.Checked)
            {
                ReturnsSale = "Returns Sales";
            }
            else
            {
                ReturnsSale = "";
            }

            if (CheckboxBuyReturnsIn.Checked)
            {
                ReturnsBuy = "Returns Buy";

            }
            else
            {
                ReturnsBuy = "";
            }
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRut.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRut.Value.ToString("yyyy-MM-dd");
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData("SELECT [Order_ID] as 'Order ID',[Invoice_ID] as 'Invoice ID',[Order_Type] as 'Order Type',[Tax_Type] as 'Tax Type',[Sup_Name] as 'Suppliers',[Cust_Name] as 'Customers',[Total_Order] as 'Total Order',[Total_Tax] as 'Total Tax',[Total_AfterTax] as 'Total After Tax',[Tax_Date] as 'Tax Date'FROM [dbo].[Taxes_Report] Where   Order_Type in (N'" + Sale+"',N'"+Buy+"',N'"+ReturnsSale+"',N'"+ReturnsBuy+"') and  CONVERT(date,Tax_Date,105) between '" + DateFrom + "' and '" + DateTo + "'", "");
            FrmPrinting Print = new FrmPrinting();
            RptTaxesReportsA4 Rpt = new RptTaxesReportsA4();
            Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("From", DateFrom);
            Rpt.SetParameterValue("TO", DateTo);
            Print.crystalReportViewer.ReportSource = Rpt;
            //Print.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            Rpt.PrintToPrinter(1, true, 0, 0);
        }

        

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (DgvTaxesReport.Rows.Count >= 1)
            {
                if (MessageBox.Show("Are you sure you will delete All Reports  ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ExecuteData("Delete From Taxes_Report Where Order_ID = " + DgvTaxesReport.CurrentRow.Cells[0].Value + "", "It has been deleted successfully");
                    btnSearsh_Click(null, null);
                }
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            if (DgvTaxesReport.Rows.Count >= 1)
            {
                PrintAll();
            }
        }
    }
}
