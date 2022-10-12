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
    public partial class FrmBuy : MaterialForm
    {

        //FrmBuy and GetForlBuy.
        //A fixed Function , any change in a form made to the form it follows.
        private static FrmBuy frmBuy;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBuy = null;
        }
        public static FrmBuy GetFormBuy
        {
            get
            {
                if (frmBuy == null)
                {
                    frmBuy = new FrmBuy();
                    frmBuy.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmBuy;
            }
        }

        public FrmBuy()
        {
            InitializeComponent();
            if (frmBuy == null)
                frmBuy = this;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
           

        }
        Database db = new Database();
        DataTable tbl = new DataTable();

        private void AutoNumber()
        {
            tbl.Clear();
            //Last Customer table ID 
            tbl = db.ReadData("select max (Order_ID)  from  Buy", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtInvoiceIdBuy.Text = "1";
            }
            else
            {
                txtInvoiceIdBuy.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            DtpDateBuy.Text = DateTime.Now.ToShortDateString();
            DtpdateDueBuy.Text = DateTime.Now.ToShortDateString();
            try
            {
                CbxItemsProBuy.SelectedIndex = 0;
                CbxSupplierBuy.SelectedIndex = 0;
                cbxChooseWarehouse.SelectedIndex = 0;   

            }
            catch (Exception)
            {
            }
            //CbxItemsProBuy.Text = "Choose a Product";
            // CbxSupplierBuy.Text = "Supplier Name";
            rbtnCash.Checked = true;

            Dgvbuy.Rows.Clear();
            txtBarcodeBuy.Clear();
            txtBarcodeBuy.Focus();
            txtTotalAll.Clear();
        }
        // FillitemsBuy : Product display function
        private void FillitemsBuy()
        {
            CbxItemsProBuy.DataSource = db.ReadData("select * from Product ", "");
            CbxItemsProBuy.DisplayMember = "Pro_Name";
            CbxItemsProBuy.ValueMember = "Pro_Id";
        }

        //FillSupplier : Supplier display function 
        public void FillSupplier()
        {
            CbxSupplierBuy.DataSource = db.ReadData("select * from Suppliers ", "");
            CbxSupplierBuy.DisplayMember = "Sup_Name";
            CbxSupplierBuy.ValueMember = "Sup_ID";
        }
        //Fillwarehouse : Warehouse display function 
        public void FillWarehouses()
        {
            cbxChooseWarehouse.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxChooseWarehouse.DisplayMember = "Warehouse_Name";
            cbxChooseWarehouse.ValueMember = "Warehouse_ID";
        }

        //PayOrder : A function that saves invoices in the database
        //PRINT : Invoice printing function 8cm
        private void Print()
        {
            FrmPrinting Print = new FrmPrinting();

            int id = Convert.ToInt32(txtInvoiceIdBuy.Text);
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date', Unit_Name as 'Unit',[User_Name] as 'User Name',[Buy_Price] as 'Price Before Tax',Buy_TaxValue as 'Tax',Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID  and Order_ID = " + id+"", "");
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

        //========
        //call to insert data in buy and buy detalis table and update qty in store
        private void insertAndUpdateData()
        {
            DataTable tblUnit = new DataTable();
            tblUnit.Clear();
            DataTable tblQty = new DataTable();
            tblQty.Clear();
            //date time 
            string date = DtpDateBuy.Value.ToString("dd/MM/yyyy");
            decimal taxValue = 0, totalTax = 0, taxPersent = 0, priceBeforeTax = 0, qtyInMqin = 0, realQty = 0;
            db.ExecuteData("insert into Buy values(" + txtInvoiceIdBuy.Text + ", N'" + date + "'," + CbxSupplierBuy.SelectedValue + ")", "");
            for (int i = 0; i <= Dgvbuy.Rows.Count - 1; i++)
            {
                try
                {
                    //to get products persent tax
                    taxPersent = Convert.ToDecimal(db.ReadData("select * from Product where Pro_ID=" + Dgvbuy.Rows[i].Cells[0].Value + "", "").Rows[0][4]);
                }
                catch (Exception) { }
                //to get product tax value
                taxValue = (Convert.ToDecimal(Dgvbuy.Rows[i].Cells[4].Value) / 100) * taxPersent;
                //to get product price before tax
                priceBeforeTax = Convert.ToDecimal(Dgvbuy.Rows[i].Cells[4].Value) - taxValue;
                totalTax += Convert.ToDecimal(Dgvbuy.Rows[i].Cells[3].Value) * taxValue;
                db.ExecuteData("insert into Buy_Detalis values(" + txtInvoiceIdBuy.Text + "," + Dgvbuy.Rows[i].Cells[0].Value + " ," + CbxSupplierBuy.SelectedValue + "," + Dgvbuy.Rows[i].Cells[3].Value + ",'" + date + "',N'" + Properties.Settings.Default.UserName + "', " + Math.Round(priceBeforeTax, 0) + " , " + Dgvbuy.Rows[i].Cells[5].Value + ", " + Dgvbuy.Rows[i].Cells[6].Value + ", " + Math.Round(Convert.ToDecimal(txtTotalAll.Text), 0) + ", " + Properties.Settings.Default.PaidUp + ", " + Properties.Settings.Default.RestAmount + ", " + Math.Round(taxValue, 0) + ", " + Dgvbuy.Rows[i].Cells[4].Value + ",N'" + Dgvbuy.Rows[i].Cells[2].Value + "', N'" + dateTime.Text + "' )", "");
                tblUnit = db.ReadData("select * from Product_Unit where Pro_ID=" + Dgvbuy.Rows[i].Cells[0].Value + " and Unit_Name=N'" + Dgvbuy.Rows[i].Cells[2].Value + "'", "");
                qtyInMqin = Convert.ToDecimal(tblUnit.Rows[0][3]);
                realQty = Convert.ToDecimal(Dgvbuy.Rows[i].Cells[3].Value) / qtyInMqin;
                db.ExecuteData(" Update Product set Pro_Quantity = Pro_Quantity + " + Math.Round(realQty, 0) + " Where Pro_ID = " + Dgvbuy.Rows[i].Cells[0].Value + "  ", "");

                //===================================
                //check if same product data exist or not
                tblQty = db.ReadData("select * from Product_Qty where Pro_ID=" + Dgvbuy.Rows[i].Cells[0].Value + " and Warehouse_ID =" + cbxChooseWarehouse.SelectedValue + " and Buy_Price =" + Dgvbuy.Rows[i].Cells[4].Value + "", "");
                if (tblQty.Rows.Count >= 1)
                {//if exist .. update data
                    db.ExecuteData("update Product_Qty set Quantity=Quantity  +" + Math.Round(realQty, 0) + " where Pro_ID=" + Dgvbuy.Rows[i].Cells[0].Value + " and Warehouse_ID =" + cbxChooseWarehouse.SelectedValue + " and Buy_Price=" + Dgvbuy.Rows[i].Cells[4].Value + " ", "");
                }
                else
                {
                    decimal salePrice = 0;
                    try
                    {
                        salePrice = Convert.ToDecimal(db.ReadData("select * from Product where Pro_ID=" + Dgvbuy.Rows[i].Cells[0].Value + "", "").Rows[0][6]);
                    }
                    catch (Exception) { }
                    //if not exist .. insert new data
                    db.ExecuteData("insert into Product_Qty values  (" + Dgvbuy.Rows[i].Cells[0].Value + " ," + cbxChooseWarehouse.SelectedValue + " ,N'" + cbxChooseWarehouse.Text + "' , " + Math.Round(realQty, 0) + "," + Dgvbuy.Rows[i].Cells[4].Value + " ," + Math.Round(salePrice, 0) + ")", "");
                }

            }
            decimal TotalBeforTax = 0;
            TotalBeforTax =Convert.ToDecimal( txtTotalAll.Text) - totalTax;
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + txtInvoiceIdBuy.Text+ " , N'Purchase Invoice', N'Added Value', N'"+CbxSupplierBuy.Text+ "', N'Not Found', " + TotalBeforTax + " , "+totalTax+" , "+txtTotalAll.Text+", N'"+ date + "')", "");

        }
        //call to check if the stock have money to pay or not
        string Safe_ID = "";
        private bool checkIfMoneyExist()
        {
            string date = DtpDateBuy.Value.ToString("dd/MM/yyyy");
            DataTable tblSafe = new DataTable();
            decimal Safe_Money = 0;
            tblSafe.Clear();
            tblSafe = db.ReadData("select * from Safe where Safe_ID=" + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(tblSafe.Rows[0][1]);

            if (Convert.ToDecimal(Properties.Settings.Default.PaidUp) > Safe_Money)
            {
                MessageBox.Show("The amount in the safe is not enough to perform the operation", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + Properties.Settings.Default.PaidUp + ",N'" + date + "' , N'"+ Properties.Settings.Default.UserName+ "', N'purchase', N'')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + Properties.Settings.Default.PaidUp + " Where Safe_ID = " + Safe_ID + "", "");
            return true;
        }
        private void PayOrder()
        {
           

            try
            {
                
                {
                    if (CbxSupplierBuy.Items.Count <= 0) { MessageBox.Show("Please choose a supplier first", "Confirm"); return; }
                    if (cbxChooseWarehouse.Items.Count <= 0) { MessageBox.Show("Please enter the stores firstا", "Confirm"); return; }
                    string date = DtpDateBuy.Value.ToString("dd/MM/yyyy");

                    if (Dgvbuy.Rows.Count >= 1)
                    {
                        Properties.Settings.Default.TotalOrder = Convert.ToDecimal( txtTotalAll.Text);
                        Properties.Settings.Default.PaidUp = 0;
                        Properties.Settings.Default.RestAmount = 0;
                        Properties.Settings.Default.Save();
                        FrmPayBuy frmPayBuy = new FrmPayBuy();
                        frmPayBuy.ShowDialog();
                    }
                    if (Properties.Settings.Default.CheckButton == true)
                    {

                        bool check = checkIfMoneyExist();
                        if (check == false)
                        {
                            return;
                        }
                        insertAndUpdateData();

                        if (rbtnCash.Checked == true)
                        {
                            db.ExecuteData("insert into Supplier_Report values ( " + txtInvoiceIdBuy.Text + "," + CbxSupplierBuy.SelectedValue + "," + Properties.Settings.Default.TotalOrder + ", '" + date + "' )", "");
                        }
                        else if(rbtnDefePay.Checked == true)
                            {
                            string ReminderDate = DtpdateDueBuy.Value.ToString("dd/MM/yyyy");
                            db.ExecuteData("insert into Supplier_Money values ( " + txtInvoiceIdBuy.Text + "," + CbxSupplierBuy.SelectedValue + "," + Properties.Settings.Default.RestAmount + ", '" + date + "' , '"+ ReminderDate + "'  )", "");
                            if(Properties.Settings.Default.TotalOrder >=1)
                            {
                                db.ExecuteData("insert into Supplier_Report values ( " + txtInvoiceIdBuy.Text + "," + CbxSupplierBuy.SelectedValue + "," + Properties.Settings.Default.TotalOrder + ", '" + date + "' )", "");
                            }
                           
                        }

                        if (Properties.Settings.Default.ActivatePrintBuy == true)
                        {
                            int data = 0;
                            if (Properties.Settings.Default.PrintName == "")
                            { MessageBox.Show("Please select the name of the printer from the program settings screen", "Confirm"); 
                                return; 
                            }

                            try
                            {
                                data = Convert.ToInt32(db.ReadData("select count(StoreName) from InvoiceSettings", "").Rows[0][0]);
                            }
                            catch (Exception) { }
                            if (data <= 0)
                            { MessageBox.Show("Please enter the billing data first in the program settings screen", "Confirm"); 
                                return;
                            }
                            for (int i = 0; i <= Properties.Settings.Default.BuyPrintNum - 1; i++)
                            {
                                Print();
                            }

                        }
                        AutoNumber();


                    }
                }

            }
            catch (Exception)
            { 
            }
           
        }
        //Form Edit Buy
        private void EditBuy()
        {
            if (Dgvbuy.Rows.Count <= 0)
            {
                MessageBox.Show("No Invoice Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Dgvbuy.Rows.Count >= 1)
            {
                int index = Dgvbuy.SelectedRows[0].Index;
                Properties.Settings.Default.item_Discount = Convert.ToDecimal(Dgvbuy.Rows[index].Cells[5].Value);
                //Properties.Settings.Default.item_Unit = "";
                Properties.Settings.Default.item_BuyPrice = Convert.ToDecimal(Dgvbuy.Rows[index].Cells[4].Value);
                Properties.Settings.Default.item_Quantity = Convert.ToDecimal(Dgvbuy.Rows[index].Cells[3].Value);
                Properties.Settings.Default.Pro_Unit = Convert.ToString(Dgvbuy.Rows[index].Cells[2].Value);
                Properties.Settings.Default.Pro_ID = Convert.ToInt32(Dgvbuy.Rows[index].Cells[0].Value);
                Properties.Settings.Default.Save();
                FrmEditBuy frmEdit = new FrmEditBuy();
                frmEdit.ShowDialog();

            }
        }
        //Total All in DataGV
        private void TotalAll()
        {

            try
            {
                decimal TotalAll = 0;
                for (int i = 0; i <= Dgvbuy.Rows.Count - 1; i++)
                {
                    TotalAll += Convert.ToDecimal(Dgvbuy.Rows[i].Cells[6].Value);
                    Dgvbuy.ClearSelection();
                    Dgvbuy.FirstDisplayedScrollingRowIndex = Dgvbuy.RowCount - 1;
                    Dgvbuy.Rows[Dgvbuy.RowCount - 1].Selected = true;

                }

                txtTotalAll.Text = Math.Round(TotalAll, 2).ToString();
                //count itemes 
                lblItemsBuy.Text = (Dgvbuy.Rows.Count).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void FrmBuy_Load(object sender, EventArgs e)
        {
            FillWarehouses();
            FillitemsBuy();
            FillSupplier();
            TotalAll();

            try
            {
                AutoNumber();

            }
            catch (Exception)
            {
            }
            Safe_ID = Convert.ToString(Properties.Settings.Default.Safe_ID);
        }
        //Button Add New Supplier
        private void btnAddSupBuy_Click(object sender, EventArgs e)
        {
            FrmSuppliersData FrmSup = new FrmSuppliersData();
            FrmSup.ShowDialog();
        }

        private void FrmBuy_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnShowBuy_Click(object sender, EventArgs e)
        {
            if (CbxItemsProBuy.Items.Count <= 0)
            {
                MessageBox.Show("Please enter the products first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable TbItems = new DataTable();
            TbItems.Clear();
            DataTable tblPrice = new DataTable();
            tblPrice.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            TbItems = db.ReadData("select * from Product where Pro_ID = " + CbxItemsProBuy.SelectedValue + " ", "");
            if (TbItems.Rows.Count >= 1)
            {
                try
                {
                    int countQty = 0;
                    try
                    {
                        countQty = Convert.ToInt32(db.ReadData("select sum(Pro_ID) from Product_Qty where Pro_ID=" + CbxItemsProBuy.SelectedValue + "", "").Rows[0][0]);
                    }
                    catch (Exception)
                    {
                    }
                    tblPrice = db.ReadData("select * from Product_Qty where Pro_ID =" + CbxItemsProBuy.SelectedValue + "", "");
                    string Pro_ID = TbItems.Rows[0][0].ToString();
                    string Pro_Name = TbItems.Rows[0][1].ToString();
                    string Pro_Quantity = "1";
                    string Pro_price = tblPrice.Rows[countQty - 1 ][4].ToString(); 
                    decimal Pro_Discount = 0;
                    string Pro_Units = TbItems.Rows[0][16].ToString();
                    Dgvbuy.Rows.Add(1);
                    int rowsindex = Dgvbuy.Rows.Count -1 ;
                    Dgvbuy.Rows[rowsindex].Cells[0].Value = Pro_ID;
                    Dgvbuy.Rows[rowsindex].Cells[1].Value = Pro_Name;
                    Dgvbuy.Rows[rowsindex].Cells[2].Value = Pro_Units;
                    tblunit = db.ReadData("select * from Product_Unit Where Pro_ID = " + Dgvbuy.CurrentRow.Cells[0].Value + " and Unit_Name =N'" +Dgvbuy.CurrentRow.Cells[2].Value+ "'", "");
                    decimal realPrice = 0;
                    try
                    {
                        realPrice = Convert.ToDecimal(Pro_price) / Convert.ToDecimal(tblunit.Rows[0][3]);
                    }
                    catch (Exception) { }
                    decimal total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(realPrice); 
                    Dgvbuy.Rows[rowsindex].Cells[3].Value = Pro_Quantity;
                    Dgvbuy.Rows[rowsindex].Cells[4].Value = Math.Round(realPrice, 2);
                    Dgvbuy.Rows[rowsindex].Cells[5].Value = Pro_Discount;
                    Dgvbuy.Rows[rowsindex].Cells[6].Value = Math.Round(total, 2);
                }
                catch (Exception)
                {
                }
                TotalAll();
            }
        }
        private void txtBarcodeBuy_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //Button Remove Row on database
        private void btnRemoveBuy_Click(object sender, EventArgs e)
        {
            if (Dgvbuy.Rows.Count >= 1)
            {
                int index = Dgvbuy.SelectedRows[0].Index;
                Dgvbuy.Rows.RemoveAt(index);
            }
            if(Dgvbuy.Rows.Count <= 1)
            {
                txtTotalAll.Text = "0";
            }
            TotalAll();
        }
        //Button Save Order on database
        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            PayOrder();
         
            
            try
            {
                int index = Dgvbuy.SelectedRows[0].Index;
                Dgvbuy.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Quantity;
                Dgvbuy.Rows[index].Cells[2].Value = Properties.Settings.Default.item_Unit;
                Dgvbuy.Rows[index].Cells[4].Value = Properties.Settings.Default.item_BuyPrice;
                Dgvbuy.Rows[index].Cells[5].Value = Properties.Settings.Default.item_Discount;

            }
            catch (Exception)
            {


            }
      
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBuy();
        }

        private void Dgvbuy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal itemQuantity , itemDiscount , itemBuyPrice ;
            try
            {
                int index = Dgvbuy.SelectedRows[0].Index;
                itemQuantity = Convert.ToDecimal(Dgvbuy.Rows[index].Cells[3].Value);
                itemBuyPrice = Convert.ToDecimal(Dgvbuy.Rows[index].Cells[4].Value); 
                itemDiscount = Convert.ToDecimal(Dgvbuy.Rows[index].Cells[5].Value);
                decimal Total = 0;
                Total = ( itemQuantity * itemBuyPrice) - itemDiscount;

                Dgvbuy.Rows[index].Cells[6].Value = Total;
                TotalAll();

            }
            catch (Exception)
            {

                
            }

        }

        private void CbxSupplierBuy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //textbox that only accepts numbers
        private void txtInvoiceIdBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                DataTable TbItems = new DataTable();
                TbItems.Clear();
                DataTable tblPrice = new DataTable();
                tblPrice.Clear();
                DataTable tblunit = new DataTable();
                tblunit.Clear();
                TbItems = db.ReadData("select * from Product where Pro_BarCode = " + txtBarcodeBuy.Text + " ", "");
                if (TbItems.Rows.Count >= 1)
                {
                    try
                    {
                        CbxItemsProBuy.SelectedValue = Convert.ToInt32(TbItems.Rows[0][0]);
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        int countQty = 0;
                        try
                        {
                            countQty = Convert.ToInt32(db.ReadData("select sum(Pro_ID) from Product_Qty where Pro_ID=" + CbxItemsProBuy.SelectedValue + "", "").Rows[0][0]);
                        }
                        catch (Exception)
                        {
                        }
                        tblPrice = db.ReadData("select * from Product_Qty where Pro_ID =" + CbxItemsProBuy.SelectedValue + "", "");
                        string Pro_ID = TbItems.Rows[0][0].ToString();
                        string Pro_Name = TbItems.Rows[0][1].ToString();
                        string Pro_Quantity = "1";
                        string Pro_price = tblPrice.Rows[countQty - 1][4].ToString();
                        decimal Pro_Discount = 0;
                        string Pro_Units = TbItems.Rows[0][16].ToString();
                        Dgvbuy.Rows.Add(1);
                        int rowsindex = Dgvbuy.Rows.Count - 1;
                        Dgvbuy.Rows[rowsindex].Cells[0].Value = Pro_ID;
                        Dgvbuy.Rows[rowsindex].Cells[1].Value = Pro_Name;
                        Dgvbuy.Rows[rowsindex].Cells[2].Value = Pro_Units;
                        tblunit = db.ReadData("select * from Product_Unit Where Pro_ID = " + Dgvbuy.CurrentRow.Cells[0].Value + " and Unit_Name =N'" + Dgvbuy.CurrentRow.Cells[2].Value + "'", "");
                        decimal realPrice = 0;
                        try
                        {
                            realPrice = Convert.ToDecimal(Pro_price) / Convert.ToDecimal(tblunit.Rows[0][3]);
                        }
                        catch (Exception) { }
                        decimal total = Convert.ToDecimal(Pro_Quantity) * Convert.ToDecimal(realPrice);
                        Dgvbuy.Rows[rowsindex].Cells[3].Value = Pro_Quantity;
                        Dgvbuy.Rows[rowsindex].Cells[4].Value = Math.Round(realPrice, 2);
                        Dgvbuy.Rows[rowsindex].Cells[5].Value = Pro_Discount;
                        Dgvbuy.Rows[rowsindex].Cells[6].Value = Math.Round(total, 2);
                    }
                    catch (Exception)
                    {
                    }
                    TotalAll();
                }

            }

        }

        private void FrmBuy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {

                EditBuy();

                try
                {

                    int index = Dgvbuy.SelectedRows[0].Index;
                    Dgvbuy.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                    Dgvbuy.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Quantity;
                    Dgvbuy.Rows[index].Cells[4].Value = Properties.Settings.Default.item_BuyPrice;
                    Dgvbuy.Rows[index].Cells[5].Value = Properties.Settings.Default.item_Discount;

                }
                catch (Exception) { }

            }
            else if (e.KeyCode == Keys.F1)
            {
                txtBarcodeBuy.Clear();
                txtBarcodeBuy.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnShowBuy_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnRemoveBuy_Click(null, null);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FrmAddWarehouse frmAddWarehouse = new FrmAddWarehouse();    
            frmAddWarehouse.ShowDialog();   
        }

        private void txtInvoiceIdBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
