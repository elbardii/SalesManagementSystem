using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SalesMangement
{
    public partial class FrmSalesManagement : MaterialForm
    {
        //FrmBuy and GetForlBuy.
        //A fixed Function , any change in a form made to the form it follows.
        private static FrmSalesManagement frmSalesManagement;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSalesManagement = null;
        }
        public static FrmSalesManagement GetFrmSalesManagement
        {
            get
            {
                if (frmSalesManagement == null)
                {
                    frmSalesManagement = new FrmSalesManagement();
                    frmSalesManagement.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmSalesManagement;
            }
        }
        public FrmSalesManagement()
        {
            InitializeComponent();
            if (frmSalesManagement == null)
            frmSalesManagement = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        Database db = new Database();
        DataTable dt = new DataTable();
        private void AutoNumber()
        {
            dt.Clear();
            //Last Customer table ID 
            dt = db.ReadData("select max (Order_ID)  from  Sales", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtInvoiceId.Text = "1";
            }
            else
            {
                txtInvoiceId.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            DtpDate.Text = DateTime.Now.ToShortDateString();
            DtpdateDue.Text = DateTime.Now.ToShortDateString();
            try
            {
                CbxItemsPro.SelectedIndex = 0;
                CbxCustomer.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
            //CbxItemsProBuy.Text = "Choose a Product";
            //CbxSupplierBuy.Text = "Supplier Name";
            rbtnCash.Checked = true;
            DgvSales.Rows.Clear();
            txtBarcode.Clear();
            txtBarcode.Focus();
            txtTotalAll.Clear();
            txtCustomer.Clear();
        }
        //Total All in DataGV
        private void TotalAll()
        {
            try
            {
                decimal TotalAll = 0;
                for (int i = 0; i <= DgvSales.Rows.Count - 1; i++)
                {
                    TotalAll += Convert.ToDecimal(DgvSales.Rows[i].Cells[6].Value);
                    DgvSales.ClearSelection();
                    DgvSales.FirstDisplayedScrollingRowIndex = DgvSales.RowCount - 1;
                    DgvSales.Rows[DgvSales.RowCount - 1].Selected = true;
                }
                txtTotalAll.Text = Math.Round(TotalAll, 2).ToString();
                //count itemes 
                lblItems.Text = (DgvSales.Rows.Count).ToString();
            }
            catch (Exception)
            {
            }
        }

        // FillitemsBuy : Product display function
        private void FillitemsPro()
        {
            CbxItemsPro.DataSource = db.ReadData("select * from Product ", "");
            CbxItemsPro.DisplayMember = "Pro_Name";
            CbxItemsPro.ValueMember = "Pro_Id";
        }
        //FillSupplier : Customers display function 
        public void FillCustomers()
        {
            CbxCustomer.DataSource = db.ReadData("select * from Customers ", "");
            CbxCustomer.DisplayMember = "Cust_Name";
            CbxCustomer.ValueMember = "Cust_Id";
        }
        private void EditBuy()
        {
            if (DgvSales.Rows.Count <= 0)
            {
                MessageBox.Show("No Invoice Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DgvSales.Rows.Count >= 1)
            {
                int index = DgvSales.SelectedRows[0].Index;
                Properties.Settings.Default.Pro_ID = Convert.ToInt32(DgvSales.Rows[index].Cells[0].Value);
                Properties.Settings.Default.item_Discount = Convert.ToDecimal(DgvSales.Rows[index].Cells[5].Value);
                Properties.Settings.Default.Pro_Unit = Convert.ToString(DgvSales.Rows[index].Cells[2].Value);
                Properties.Settings.Default.item_SalesPrice = Convert.ToDecimal(DgvSales.Rows[index].Cells[4].Value);
                Properties.Settings.Default.item_Quantity = Convert.ToDecimal(DgvSales.Rows[index].Cells[3].Value);
                Properties.Settings.Default.Save();
                FrmEditSales frmEditSales = new FrmEditSales();
                frmEditSales.ShowDialog();


                try
                {

                    int index2 = DgvSales.SelectedRows[0].Index;
                    DgvSales.Rows[index2].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                    DgvSales.Rows[index2].Cells[3].Value = Properties.Settings.Default.item_Quantity;
                    DgvSales.Rows[index2].Cells[4].Value = Properties.Settings.Default.item_SalesPrice;
                    DgvSales.Rows[index2].Cells[5].Value = Properties.Settings.Default.item_Discount;

                }
                catch (Exception) { }
            }
        }
        string Cust_Name = string.Empty;
        private void PayOrder()
        {
            string date = DtpDate.Value.ToString("dd/MM/yyyy");

            if (DgvSales.Rows.Count >= 1)
            {
                
                if (rbtnDefePay.Checked == true)
                {  
                    Cust_Name = CbxCustomer.Text;
                }
                else
                { 
                    if(txtCustomer.Text == "")
                    Cust_Name = "Cash Customer";
                    else if(txtCustomer.Text != "")
                    {
                        Cust_Name = txtCustomer.Text;
                    }
                }
                Properties.Settings.Default.TotalOrder = Convert.ToDecimal(txtTotalAll.Text);
                Properties.Settings.Default.PaidUp = 0;
                Properties.Settings.Default.RestAmount = 0;
                Properties.Settings.Default.Save();

                //SHOW : form PaySales

                FrmPaySales frmPaySales = new FrmPaySales();
                frmPaySales.ShowDialog();
                //call to insert in data in sales Detalis and Sales Profit and upDate Qty in Warehouse 
                updateQtyInStore();
                if (Properties.Settings.Default.CheckButton == true)
                {
                    try
                    {
                      
                        if (rbtnCash.Checked == true)
                        {
                            db.ExecuteData("insert into Customer_Report values ( " + txtInvoiceId.Text + ",N'" + Cust_Name + "'," + Properties.Settings.Default.TotalOrder + ", '" + date + "' )", "");
                        }
                        else if (rbtnDefePay.Checked == true)
                        {
                            string ReminderDate = DtpdateDue.Value.ToString("dd/MM/yyyy");
                            db.ExecuteData("insert into Customer_Money values ( " + txtInvoiceId.Text + ",N'" + Cust_Name + "'," + Properties.Settings.Default.RestAmount + ", '" + date + "' , '" + ReminderDate + "'  )", "");
                            if (Properties.Settings.Default.TotalOrder >= 1)
                            {
                                db.ExecuteData("insert into Customer_Report values ( " + txtInvoiceId.Text + ",N'" + Cust_Name + "'," + Properties.Settings.Default.TotalOrder + ", '" + date + "' )", "");
                            }
                        }
                        InsertMoneyIntoSafe();
                        if (Properties.Settings.Default.ActivatePrintSales == true)
                        {
                            int data = 0;
                            if (Properties.Settings.Default.PrintName == "")
                            {
                                MessageBox.Show("Please select the name of the printer from the program settings screen", "Confirm");
                                return;
                            }

                            try
                            {
                                data = Convert.ToInt32(db.ReadData("select count(StoreName) from InvoiceSettings", "").Rows[0][0]);
                            }
                            catch (Exception) { }
                            if (data <= 0)
                            {
                                MessageBox.Show("Please enter the billing data first in the program settings screen", "Confirm");
                                return;
                            }
                            for (int i = 0; i <= Properties.Settings.Default.SalesPrintNum - 1; i++)
                            {
                                Print();
                            }

                        }
                        AutoNumber();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
        //call to inser in Safe Money and Update Safe money 
  
        private void InsertMoneyIntoSafe()
        {
            string date = DtpDate.Value.ToString("dd/MM/yyyy");
            DataTable tblSafe = new DataTable();
            if (Properties.Settings.Default.Pay_Visa == false)
            {
                db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + Properties.Settings.Default.PaidUp + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Sales', N'')  ", "");
                db.ExecuteData("Update Safe Set Safe_Money = Safe_Money + " + Properties.Settings.Default.PaidUp + " Where Safe_ID = " + Safe_ID + "", "");
            }
            else
            {
                db.ExecuteData("insert into Bank_insert ( Money ,Date ,Depositor_Name , Type, Reason ) Values ( " + Properties.Settings.Default.PaidUp + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Sales', N'')  ", "");
                db.ExecuteData("Update Bank Set Money = Money + " + Properties.Settings.Default.PaidUp + " ", "");
            }


        }
        //PayOrder : A function that saves invoices in the database
        //PRINT : Invoice printing function 8cm
        private void Print()
        {
            int id = Convert.ToInt32(txtInvoiceId.Text);
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData("SELECT [Order_ID] as 'Invoice Number ',Product.[Pro_Name] as 'Name Product',Sales_Detalis.[Cust_Name] as 'Name Customer',[Quantity] as 'Quantity',[Sales_Date] as ' Sales Date',[User_Name] as 'User Name',Unit_Name as 'Unit', Sale_PriceTax as 'Tax Included Price',[Sales_Discount] as 'Discount',[Sales_Total] as 'Total Order',[Sales_TotalAll] as 'Total Invoice',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount',[Sales_Detalis].Sales_TaxValue as 'TAX Value' FROM [dbo].[Sales_Detalis] , Product where  Product.Pro_Id = Sales_Detalis.Pro_ID  and Order_ID = " + id + "", "");
          //  FrmPrinting Print = new FrmPrinting();
           // Print.crystalReportViewer.RefreshReport();
           
            if(Properties.Settings.Default.PrintSalesKind == "8CM")
            {
                RptOrderSales Rpt = new RptOrderSales();
                //Username and password data Database name
                //In order to run a program in the client's machine without problems
                Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
                Rpt.SetDataSource(dtRtp);
                Rpt.SetParameterValue("ID_Order", id);
               // Print.crystalReportViewer.ReportSource = Rpt;
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                Rpt.PrintOptions.PrinterName = Properties.Settings.Default.PrintName;
                //Print.ShowDialog();
                Rpt.PrintToPrinter(1, true, 0, 0);
            }
            else if(Properties.Settings.Default.PrintSalesKind == "A4")
            {
                RptOrderSalesA4 Rpt2 = new RptOrderSalesA4();
                //Username and password data Database name
                //In order to run a program in the client's machine without problems
                Rpt2.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
                Rpt2.SetDataSource(dtRtp);
                Rpt2.SetParameterValue("ID_Order", id);
               // Print.crystalReportViewer.ReportSource = Rpt2;
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                Rpt2.PrintOptions.PrinterName = Properties.Settings.Default.PrintName;
                //Print.ShowDialog();
                Rpt2.PrintToPrinter(1, true, 0, 0);
            }
         
        }

        //inser Data into Sales Table and update in WareHouse 
        private void  updateQtyInStore()
        {
            string Cust_Name = string.Empty;
            if (rbtnDefePay.Checked == true)
            {
                Cust_Name = CbxCustomer.Text;
            }
            else
            {
                if (txtCustomer.Text == "")
                    Cust_Name = "Cash Customer";
                else if (txtCustomer.Text != "")
                {
                    Cust_Name = txtCustomer.Text;
                }
            }

            DataTable TblPro = new DataTable();
            TblPro.Clear();
            DataTable TblQty = new DataTable();
            TblQty.Clear();

            string date = DtpDate.Value.ToString("dd/MM/yyyy");
            db.ExecuteData("insert into sales values ( " + txtInvoiceId.Text + ",N'" + Cust_Name + "', '" + date + "') ", "");
            decimal PriceBeforeTax = 0, TaxValue = 0, totalTax = 0, QtyInMain = 0, RealQty = 0;
            for (int i = 0; i <= DgvSales.Rows.Count - 1; i++)
            {
                TblPro = db.ReadData("select * from Product where Pro_ID=" + DgvSales.Rows[i].Cells[0].Value + "", "");
                TblQty = db.ReadData("select * from Product_Unit where Pro_ID=" + DgvSales.Rows[i].Cells[0].Value + " and Unit_Name =N'" + DgvSales.Rows[i].Cells[2].Value + "'", "");
                QtyInMain = Convert.ToDecimal(TblQty.Rows[0][3]);
                TaxValue = (Convert.ToDecimal(TblPro.Rows[0][6]) - Convert.ToDecimal(TblPro.Rows[0][5])) / QtyInMain;
                PriceBeforeTax = Convert.ToDecimal(TblPro.Rows[0][5]);
                RealQty = Convert.ToDecimal(DgvSales.Rows[i].Cells[3].Value) / QtyInMain;
                totalTax += TaxValue * Convert.ToDecimal(TblPro.Rows[0][2]);
                if (Convert.ToDecimal(TblPro.Rows[0][2]) - RealQty < 0)
                {
                    MessageBox.Show("The quantity in stock is not enough for sale", "Confirm");
                    return;
                }
                db.ExecuteData("insert into Sales_Detalis values(" + txtInvoiceId.Text + "," + DgvSales.Rows[i].Cells[0].Value + " ,N'" + Cust_Name + "'," + DgvSales.Rows[i].Cells[3].Value + ",'" + date + "',N'" + Properties.Settings.Default.UserName + "', " + PriceBeforeTax + " , " + DgvSales.Rows[i].Cells[5].Value + ", " + DgvSales.Rows[i].Cells[6].Value + ", " + Properties.Settings.Default.TotalOrder + ", " + Properties.Settings.Default.PaidUp + ", " + Properties.Settings.Default.RestAmount + ", " + Math.Round(TaxValue, 0) + ",  " + DgvSales.Rows[i].Cells[4].Value + ",N'" + DgvSales.Rows[i].Cells[2].Value + "', '" + dateTime.Text + "')", "");
               
                db.ExecuteData(" Update Product set Pro_Quantity = Pro_Quantity - " + RealQty + " Where Pro_ID = " + DgvSales.Rows[i].Cells[0].Value + "  ", "");
                UpdateQtyInStore(Convert.ToInt32(DgvSales.Rows[i].Cells[0].Value) , RealQty, i, PriceBeforeTax , TaxValue);





             

            }

            decimal TotalBeforTax = 0;
            TotalBeforTax = totalTax - Convert.ToDecimal(txtTotalAll.Text) ;
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + txtInvoiceId.Text + " , N'Sales Invoice', N'Added Value', N'Not Found', N'"+CbxCustomer.Text+"', " + TotalBeforTax + " , " + totalTax + " , " + txtTotalAll.Text + ", N'" + date + "')", "");



        }
        //call when insert  profit  in Sales
        private void InsertSaleProfit( int i, decimal PriceBeforeTax ,  decimal TaxValue,  decimal realQty, decimal BuyPrice)
        {
            string date = DtpDate.Value.ToString("dd/MM/yyyy");
            db.ExecuteData("insert into Sales_Profits values(" + txtInvoiceId.Text + "," + DgvSales.Rows[i].Cells[0].Value + " ,N'" + Cust_Name + "'," + realQty + ",'" + date + "',N'" + Properties.Settings.Default.UserName + "', " + PriceBeforeTax + " , " + DgvSales.Rows[i].Cells[5].Value + ", " + DgvSales.Rows[i].Cells[6].Value + ", " + Properties.Settings.Default.TotalOrder + ", " + Properties.Settings.Default.PaidUp + ", " + Properties.Settings.Default.RestAmount + ", " + Math.Round(TaxValue, 0) + ",  " + DgvSales.Rows[i].Cells[4].Value + ",N'" + DgvSales.Rows[i].Cells[2].Value + "', '" + dateTime.Text + "', "+ BuyPrice +")", "");

        }
        //Call to update in warehouse 
        private void UpdateQtyInStore(int pro_ID, decimal realQty, int x, decimal PriceBeforeTax, decimal TaxValue)
        {
            DataTable tblQty = new DataTable();
            decimal QtyInStoreFirstRaw = 0;
            db.ExecuteData("delete from Product_Qty where Quantity <=0", "");
            int countQty = 0;
            try
            {
                countQty = Convert.ToInt32(db.ReadData("select count(Pro_ID) from Product_Qty where Pro_ID=" + pro_ID + "", "").Rows[0][0]);
            }
            catch (Exception) { }
            decimal currentQty = realQty;
            for (int i = 0;  i <=  countQty - 1; i++)

            {
                tblQty.Clear();
                tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " ", "");

                QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
                if (QtyInStoreFirstRaw - realQty >= 1)
                {
                    db.ExecuteData("update Product_Qty set Quantity=Quantity - " + realQty + " where Pro_ID = " + pro_ID + " and Warehouse_ID =" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    InsertSaleProfit(x,PriceBeforeTax , TaxValue , realQty, Convert.ToDecimal(tblQty.Rows[0][4])); 
                    currentQty -= realQty;
                    return;
                }
                else if (QtyInStoreFirstRaw - realQty == 0)
                {
                    db.ExecuteData("update Product_Qty set Quantity=Quantity - " + realQty + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                    InsertSaleProfit(x, PriceBeforeTax, TaxValue, realQty, Convert.ToDecimal(tblQty.Rows[0][4]));
                    currentQty -= realQty;
                    return;
                }

                else if (QtyInStoreFirstRaw - realQty < 0)
                {

                    db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    db.ExecuteData("delete Product_Qty where Quantity  <= 0", "");
                    InsertSaleProfit(x, PriceBeforeTax, TaxValue, QtyInStoreFirstRaw , Convert.ToDecimal(tblQty.Rows[0][4]));
                    currentQty -= QtyInStoreFirstRaw;
                    decimal baky = Math.Abs(QtyInStoreFirstRaw - realQty);

                    tblQty.Clear();
                    tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " ", "");

                    QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                    if (QtyInStoreFirstRaw - baky >= 0)
                    {
                        db.ExecuteData("update Product_Qty set Quantity = Quantity - " + baky + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                        InsertSaleProfit(x, PriceBeforeTax, TaxValue, baky, Convert.ToDecimal(tblQty.Rows[0][4]));

                        return;
                    }
                    else if (QtyInStoreFirstRaw - baky < 0)
                    {
                        decimal secondbaky = Math.Abs(QtyInStoreFirstRaw - baky);
                        db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                        InsertSaleProfit(x, PriceBeforeTax, TaxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));

                        currentQty -= QtyInStoreFirstRaw;
                        tblQty.Clear();
                        tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " ", "");

                        QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                        if (QtyInStoreFirstRaw - secondbaky >= 0)
                        {
                            db.ExecuteData("update Product_Qty set Quantity = Quantity - " + secondbaky + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                            InsertSaleProfit(x, PriceBeforeTax, TaxValue, secondbaky, Convert.ToDecimal(tblQty.Rows[0][4]));
                            return;
                        }
                        else if (QtyInStoreFirstRaw - secondbaky < 0)
                        {
                            decimal thirdbaky = Math.Abs(QtyInStoreFirstRaw - secondbaky);
                            db.ExecuteData("update Product_Qty set Quantity = Quantity  - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                            InsertSaleProfit(x, PriceBeforeTax, TaxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));
                            currentQty -= QtyInStoreFirstRaw;
                            tblQty.Clear();
                            tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " ", "");

                            QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
                            if (QtyInStoreFirstRaw - thirdbaky >= 0)
                            {
                                db.ExecuteData("update Product_Qty set Qty=Qty - " + thirdbaky + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                                InsertSaleProfit(x, PriceBeforeTax, TaxValue, thirdbaky, Convert.ToDecimal(tblQty.Rows[0][4]));

                                return;
                            }
                            else if (QtyInStoreFirstRaw - thirdbaky < 0)
                            {
                                decimal forthbaky = Math.Abs(QtyInStoreFirstRaw - thirdbaky);
                                db.ExecuteData("update Product_Qty set Quantity=Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                                InsertSaleProfit(x, PriceBeforeTax, TaxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));

                                currentQty -= QtyInStoreFirstRaw;

                                tblQty.Clear();
                                tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " ", "");

                                QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                                if (QtyInStoreFirstRaw - forthbaky >= 0)
                                {
                                    db.ExecuteData("update Product_Qty set Quantity=Quantity - " + forthbaky + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                    db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                                    InsertSaleProfit(x, PriceBeforeTax, TaxValue, forthbaky, Convert.ToDecimal(tblQty.Rows[0][4]));

                                    return;
                                }
                                else if (QtyInStoreFirstRaw - forthbaky < 0)
                                {
                                    db.ExecuteData("update Product_Qty set Quantity=Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                    db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                                    InsertSaleProfit(x, PriceBeforeTax, TaxValue, QtyInStoreFirstRaw, Convert.ToDecimal(tblQty.Rows[0][4]));

                                    currentQty -= QtyInStoreFirstRaw;
                                }
                            }
                        }
                    }

                }
                if (currentQty <= 0)
                { return; } 

            }

        }
        string Safe_ID = "";
        private void FrmSalesManagement_Load(object sender, EventArgs e)
        {
            DtpDate.Text = DateTime.Now.ToShortDateString();
            DtpdateDue.Text = DateTime.Now.ToShortDateString();
            FillitemsPro();
            FillCustomers();
            TotalAll();
            rbtnCash_CheckedChanged(null, null);
            try
            {
                AutoNumber();
            }
            catch (Exception)
            {
            }
            Safe_ID = Convert.ToString(Properties.Settings.Default.Safe_ID);
        }
        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CbxCustomer.Enabled = false;
                DtpdateDue.Enabled = false;
                btnAddCust.Enabled = false;
                txtCustomer.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
        private void rbtnDefePay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CbxCustomer.Enabled = true;
                DtpdateDue.Enabled = true;
                btnAddCust.Enabled = true;
                txtCustomer.Enabled = false;
            }
            catch (Exception)
            {
            }
        }
        //BUTTON : ADD 
        private void btnAddCust_Click(object sender, EventArgs e)
        {
           FrmCustomerData frmCustomerData = new FrmCustomerData();
            frmCustomerData.ShowDialog();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (CbxItemsPro.Items.Count <= 0)
            {
                MessageBox.Show("Please enter the products first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable TbItems = new DataTable();
            TbItems.Clear();
            DataTable TblUnit = new DataTable();
            TblUnit.Clear();

            TbItems = db.ReadData("select * from Product where Pro_ID = " + CbxItemsPro.SelectedValue + " ", "");
            if (TbItems.Rows.Count >= 1)
            {
                try
                {
                  
                    string Pro_ID = TbItems.Rows[0][0].ToString();
                    string Pro_Name = TbItems.Rows[0][1].ToString();
                    string Pro_Unit = TbItems.Rows[0][14].ToString();
                    string Pro_Quantity = "1";
                    string Pro_price = "0";
                    decimal Pro_Discount = 0;

               
                    decimal Pro_Total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(TbItems.Rows[0][6].ToString());
                    int rowsindex = DgvSales.Rows.Count;
                    DgvSales.Rows.Add(1);
                    DgvSales.Rows[rowsindex].Cells[0].Value = Pro_ID;
                    DgvSales.Rows[rowsindex].Cells[1].Value = Pro_Name;
                    DgvSales.Rows[rowsindex].Cells[3].Value = Pro_Quantity;
                    DgvSales.Rows[rowsindex].Cells[2].Value = Pro_Unit;
                    TblUnit = db.ReadData("select * from Product_Unit where Pro_ID=" + DgvSales.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + DgvSales.CurrentRow.Cells[2].Value + "'", "");

                    decimal realPrice = 0;
                    try
                    {
                        realPrice = Convert.ToDecimal(TblUnit.Rows[0][5]) / Convert.ToDecimal(TblUnit.Rows[0][3]);
                    }
                    catch (Exception) { }
            
                    DgvSales.Rows[rowsindex].Cells[4].Value = realPrice;
                    decimal total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(realPrice);
                    DgvSales.Rows[rowsindex].Cells[5].Value = Pro_Discount;
                    DgvSales.Rows[rowsindex].Cells[6].Value = total;
                }
                catch (Exception)
                {
                }
                TotalAll();
            }
        }
        private void FrmSalesManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F12)
            {
                btnShow_Click(null,null);
            }
            else if(e.KeyCode == Keys.F1)
            {
                txtBarcode.Clear();
                txtBarcode.Focus();
            }
            else if(e.KeyCode == Keys.F2)
            {
                EditBuy();
            }
            if(e.KeyCode == Keys.F3)
            {
                PayOrder();
            }
        }
        //BARCODE => Sales Management
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

            //textbox that only accepts numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (CbxItemsPro.Items.Count <= 0)
                {
                    MessageBox.Show("Choose The Product First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable TbItems = new DataTable();
                TbItems.Clear();
                TbItems = db.ReadData("select * from Product where Pro_BarCode = '" + txtBarcode.Text + "' ", "");
                if (TbItems.Rows.Count >= 1)
                {
                    try
                    {
                        string Pro_ID = TbItems.Rows[0][0].ToString();
                        string Pro_Name = TbItems.Rows[0][1].ToString();
                        string Pro_Quantity = "1";
                        string Pro_price = TbItems.Rows[0][4].ToString();
                        decimal Pro_Discount = 0;
                        decimal Pro_Total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(TbItems.Rows[0][4].ToString());
                        DgvSales.Rows.Add(1);
                        int rowsindex = DgvSales.Rows.Count - 1;
                        DgvSales.Rows[rowsindex].Cells[0].Value = Pro_ID;
                        DgvSales.Rows[rowsindex].Cells[1].Value = Pro_Name;
                        DgvSales.Rows[rowsindex].Cells[2].Value = Pro_Quantity;
                        DgvSales.Rows[rowsindex].Cells[3].Value = Pro_price;
                        DgvSales.Rows[rowsindex].Cells[4].Value = Pro_Discount;
                        DgvSales.Rows[rowsindex].Cells[5].Value = Pro_Total;
                    }
                    catch (Exception)
                    {
                    }
                    TotalAll();
                }
            }
        }
        //BUTTON : Remove 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DgvSales.Rows.Count >= 1)
            {
                int index = DgvSales.SelectedRows[0].Index;
                DgvSales.Rows.RemoveAt(index);
            }
            if (DgvSales.Rows.Count <= 1)
            {
                txtTotalAll.Text = "0";
            }
            TotalAll();
        }
        //BUTTON : Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditBuy();


            }
            catch (Exception)
            {
            }
        }
        //BUTTON : Save
        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            PayOrder();
            try
            {
                int index = DgvSales.SelectedRows[0].Index;
                DgvSales.Rows[index].Cells[3].Value = Properties.Settings.Default.item_BuyPrice;
                DgvSales.Rows[index].Cells[2].Value = Properties.Settings.Default.item_Quantity;
                DgvSales.Rows[index].Cells[4].Value = Properties.Settings.Default.item_Discount;
            }
            catch (Exception)
            {
            }
            
        }
        private void DgvSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal itemQuantity, itemDiscount, itemSalesPrice;
            try
            {
                int index = DgvSales.SelectedRows[0].Index;
                itemQuantity = Convert.ToDecimal(DgvSales.Rows[index].Cells[3].Value);
                itemSalesPrice = Convert.ToDecimal(DgvSales.Rows[index].Cells[4].Value);
                itemDiscount = Convert.ToDecimal(DgvSales.Rows[index].Cells[5].Value);
                decimal Total = 0;
                Total = (itemQuantity * itemSalesPrice) - itemDiscount;
                DgvSales.Rows[index].Cells[6].Value = Total;
                TotalAll();
            }
            catch (Exception)
            {
            }
        }

        private void txtInvoiceId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox that only accepts numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBarcode_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            DataTable TbItems = new DataTable();
            TbItems.Clear();
            DataTable TblUnit = new DataTable();
            TblUnit.Clear();

            TbItems = db.ReadData("select * from Product where Pro_BarCode = N'" + txtBarcode.Text+ "' ", "");
            if (TbItems.Rows.Count >= 1)
            {
                try
                {

                    CbxItemsPro.SelectedValue = Convert.ToInt32( TbItems.Rows[0][0]);
                    string Pro_ID = TbItems.Rows[0][0].ToString();
                    string Pro_Name = TbItems.Rows[0][1].ToString();
                    string Pro_Unit = TbItems.Rows[0][14].ToString();
                    string Pro_Quantity = "1";
                    string Pro_price = "0";
                    decimal Pro_Discount = 0;


                    decimal Pro_Total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(TbItems.Rows[0][6].ToString());
                    int rowsindex = DgvSales.Rows.Count;
                    DgvSales.Rows.Add(1);
                    DgvSales.Rows[rowsindex].Cells[0].Value = Pro_ID;
                    DgvSales.Rows[rowsindex].Cells[1].Value = Pro_Name;
                    DgvSales.Rows[rowsindex].Cells[3].Value = Pro_Quantity;
                    DgvSales.Rows[rowsindex].Cells[2].Value = Pro_Unit;
                    TblUnit = db.ReadData("select * from Product_Unit where Pro_ID=" + DgvSales.CurrentRow.Cells[0].Value + " and Unit_Name=N'" + DgvSales.CurrentRow.Cells[2].Value + "'", "");

                    decimal realPrice = 0;
                    try
                    {
                        realPrice = Convert.ToDecimal(TblUnit.Rows[0][5]) / Convert.ToDecimal(TblUnit.Rows[0][3]);
                    }
                    catch (Exception) { }

                    DgvSales.Rows[rowsindex].Cells[4].Value = realPrice;
                    decimal total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(realPrice);
                    DgvSales.Rows[rowsindex].Cells[5].Value = Pro_Discount;
                    DgvSales.Rows[rowsindex].Cells[6].Value = total;
                }
                catch (Exception)
                {
                }
                TotalAll();
            }

        }

        private void txtInvoiceId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
