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
    public partial class FrmWarehouse : MaterialForm
    {
        public FrmWarehouse()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }

        Database db = new Database();
        DataTable dt = new DataTable();
        DataTable dtWarehouse = new DataTable();
        int Row;


        

        /// <summary>
        /// Type Expenses 
        ///AutoNumberExpT
        /// A function that adds a new ID in the database 
        ///and increments 1 automatically in each operation
        /// Clear the text box again after each operation
        /// Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumberAdd()
        {
            dtWarehouse.Clear();
            dtWarehouse = db.ReadData("select Warehouse_ID as 'Warehouse Number' , Warehouse_Name as 'Warehouse Name' from Warehouse", "");
            DgvWarehouse.DataSource = dtWarehouse;
            dt.Clear();
            dt = db.ReadData("select max(Warehouse_ID) from Warehouse ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtWarehouseNumber.Text = "1";
            }
            else
            {
                txtWarehouseNumber.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            txtWarehouseName.Clear();
            //focus on textbox Name type Expenses
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        /* Show
         * A function that displays data from the database
        */
        private void showAdd()
        {
            dt.Clear();
            dt = db.ReadData("select * from Warehouse ", "");
            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                txtWarehouseNumber.Text = dt.Rows[Row][0].ToString();
                txtWarehouseName.Text = dt.Rows[Row][1].ToString();
            }
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;

        }
        //check
        //A function that checks if important textBox have a value
        private bool checkAdd()
        {
            if (txtWarehouseNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Warehouse number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtWarehouseName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Warehouse Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            //DateFromRw.Text = DateTime.Now.ToShortDateString();
            //DateToRw.Text = DateTime.Now.ToShortDateString();

            try
            {
                AutoNumberAdd();
                FillWarehouse();
                showWarehous();
                ShowTotal();
                FillTransferred();
            }
            catch (Exception)
            {
            }

            



        }
        //BUTTON : Add New WareHouse
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkAdd() == false)
            {

                db.ExecuteData("insert into Warehouse values (" + txtWarehouseNumber.Text + ",N'" + txtWarehouseName.Text + "') ", "done successfully");
                AutoNumberAdd();
            }
            else
            {
                return;
            }
        }
        //BUTTON : NEW 
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumberAdd();
        }
        //BUTTON : Save 
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update Warehouse set Warehouse_Name = N'" + txtWarehouseName.Text + "' where Warehouse_ID  = " + txtWarehouseNumber.Text + "", "Data has been modified successfully");
            AutoNumberAdd();
        }
        //BUTTON : Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + txtWarehouseName.Text + " Types Group data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Warehouse where Warehouse_ID = " + txtWarehouseNumber.Text + " ", " Types Warehouse data has been deleted");
                AutoNumberAdd();
            }
        }
        //BUTTON : Delete All
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Type Item Warehouse data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Warehouse ", "All Type Item Warehouse data has been deleted");
                AutoNumberAdd();
            }
        }
        //BUTTON :First
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            showAdd();
        }
        //BUTTON : Previous
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Warehouse_ID)from Warehouse", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                showAdd();

            }
            else
            {
                Row--;
                showAdd();
            }
        }
        //BUTTON : Next
        private void btnNext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Warehouse_ID) from Warehouse", "");
            if (Convert.ToInt32(dt.Rows[0][0]) - 1 == Row)
            {

                Row = 0;
                showAdd();
            }
            else
            {
                Row++;
                showAdd();
            }
        }
        //BUTTON : Last
        private void btnLast_Click(object sender, EventArgs e)
        {

            dt.Clear();
            dt = db.ReadData("select count(Warehouse_ID) from Warehouse", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            showAdd();
        }

        private void DgvWarehouse_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (DgvWarehouse.Rows.Count >= 1)
                {

                    DataTable dtWarehouse = new DataTable();
                    dtWarehouse.Clear();
                    dtWarehouse = db.ReadData("select * from Warehouse Where Warehouse_ID = " + DgvWarehouse.CurrentRow.Cells[0].Value + " ", "");


                    //first line of database customers
                    txtWarehouseNumber.Text = dtWarehouse.Rows[0][0].ToString();
                    txtWarehouseName.Text = dtWarehouse.Rows[0][1].ToString();

                    //Cancel buttons and activate them when needed
                    btnAdd.Enabled = false;
                    btnNew.Enabled = true;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                }


            }
            catch (Exception)
            {
            }
        }
        //FORM : Show warehouse

        private void showWarehous()
        {
            dt.Clear();
            if (RadioBtnAllWarehouses.Checked)
            {
                dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID", "");
            }
            DgvWarehouses.DataSource = dt;
        }
        private void ShowTotal()
        {
            decimal TotalSales = 0, Totalbuy = 0, ExpectedProfits = 0;
            for (int i = 0; i < DgvWarehouses.Rows.Count ; i++)
            {
                TotalSales += Convert.ToDecimal(DgvWarehouses.Rows[i].Cells[5].Value);
                Totalbuy += Convert.ToDecimal(DgvWarehouses.Rows[i].Cells[4].Value);
                ExpectedProfits += (Convert.ToDecimal(DgvWarehouses.Rows[i].Cells[5].Value) - Convert.ToDecimal(DgvWarehouses.Rows[i].Cells[4].Value)) * Convert.ToDecimal(DgvWarehouses.Rows[i].Cells[3].Value);

            }
            txtTotalSales.Text = Math.Round(TotalSales, 2).ToString();
            txtTotalbuy.Text = Math.Round(Totalbuy, 2).ToString();
            txtExpectedProfits.Text = Math.Round(ExpectedProfits, 2).ToString();
          
        }

        //FIll All Warehouse 
        private void FillWarehouse()
        {
            cbxWarehouses.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxWarehouses.DisplayMember = "Warehouse_Name";
            cbxWarehouses.ValueMember = "Warehouse_ID";

            cbxChooseWarehouseFrom.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxChooseWarehouseFrom.DisplayMember = "Warehouse_Name";
            cbxChooseWarehouseFrom.ValueMember = "Warehouse_ID";
            //Form : Damage Products
            cbxChooseWarehouseDR.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxChooseWarehouseDR.DisplayMember = "Warehouse_Name";
            cbxChooseWarehouseDR.ValueMember = "Warehouse_ID";




        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if(RadioBtnAllWarehouses.Checked)
            {
                dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID", "");
            }
            else 
            {
                dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID and  Product_Qty.Pro_ID = "+cbxWarehouses.SelectedValue+" ", "");
            }
            DgvWarehouses.DataSource = dt;
            ShowTotal();

        }
        //PRESS : ENTER
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dt.Clear();
                if (txtBarcode.Text != String.Empty)
                {                
                    dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID and  Product.Pro_BarCode = " + txtBarcode.Text + " ", "");
                }
                DgvWarehouses.DataSource = dt;
                ShowTotal();
            }
        }
        //BUTTON : Searsh =>  BarCode 
        private void btnSearshBarcode_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == String.Empty)
            {
                MessageBox.Show("Please Enter BarCode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (RadioBtnAllWarehouses.Checked)
                {
                    dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID", "");
                }
                else
                {
                    dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID and  Product.Pro_BarCode = " + txtBarcode.Text + " ", "");
                }
                DgvWarehouses.DataSource = dt;
                ShowTotal();
            }
        }

        private void cbxWarehouses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.Clear();
            if (RadioBtnAllWarehouses.Checked)
            {
                dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID", "");
            }
            else
            {
                dt = db.ReadData("SELECT [Product_Qty].[Pro_ID] as 'Product Number',Product.Pro_Name as 'Product Name',[Warehouse_Name] as 'Warehouse Name',[Quantity] as 'Quantity',[Buy_Price] as 'Buy Price',[Product_Qty].[Sale_PriceTax] 'Sale Price Tax' FROM [dbo].[Product_Qty] , Product  Where Product.Pro_Id = Product_Qty.Pro_ID and  Product_Qty.Pro_ID = " + cbxWarehouses.SelectedValue + " ", "");
            }
            DgvWarehouses.DataSource = dt;
            ShowTotal();
        }


        //FORM : Transferred Warehouse
        private void FillTransferred()
        {
            //Product
            cbxChoosePro.DataSource = db.ReadData("select * from Product ", "");
            cbxChoosePro.DisplayMember = "Pro_Name";
            cbxChoosePro.ValueMember = "Pro_ID";
            //Product 2
            cbxChooseProduct.DataSource = db.ReadData("select * from Product ", "");
            cbxChooseProduct.DisplayMember = "Pro_Name";
            cbxChooseProduct.ValueMember = "Pro_ID";
            //Name Transferred From
            cbxNameTransferredFrom.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxNameTransferredFrom.DisplayMember = "Warehouse_Name";
            cbxNameTransferredFrom.ValueMember = "Warehouse_ID";
           
            //Warehouse Transferred To
            cbxWarehouseTransferredTo.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxWarehouseTransferredTo.DisplayMember = "Warehouse_Name";
            cbxWarehouseTransferredTo.ValueMember = "Warehouse_ID";
            //Name Transferred F)
            cbxtWarehousPro.DataSource = db.ReadData("select * from Warehouse ", "");
            cbxtWarehousPro.DisplayMember = "Warehouse_Name";
            cbxtWarehousPro.ValueMember = "Warehouse_ID";
        }

        private void txtSearchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                if (txtSearchBarcode.Text != "")
                {
                    dt.Clear();
                    dt = db.ReadData("select * from Product Where Pro_BarCode = N'" + txtSearchBarcode.Text + "'", "");
                    if (dt.Rows.Count >= 1)
                    {
                        cbxChoosePro.SelectedValue = Convert.ToDecimal(dt.Rows[0][0]);
                    }
                }

            }
        }

        private void cbxChoosePro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Units
                cbxUnits.DataSource = db.ReadData("select * from Product_Unit Where Pro_ID = " + cbxChoosePro.SelectedValue + " ", "");
                cbxUnits.DisplayMember = "Unit_Name";
                cbxUnits.ValueMember = "Unit_ID";
            }
            catch (Exception)
            {
            }
        }
        //call to Update In Warehouse
        public void UpDateQtyWarehouse(int ProID , decimal realQty)
        {
            DataTable dtQty = new DataTable();
            decimal QtyInWarehouseFirstRow = 0;
            db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
            dtQty.Clear();
            
            dtQty = db.ReadData("select Top 1 * from Product_Qty Where Pro_ID = "+ProID+ " and Warehouse_ID = "+ cbxNameTransferredFrom.SelectedValue+"", "");
            QtyInWarehouseFirstRow = Convert.ToDecimal(dtQty.Rows[0][3]);
            if(QtyInWarehouseFirstRow - realQty >= 1)
            {
                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + realQty + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = "+ QtyInWarehouseFirstRow + " and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");

            }
            else if (QtyInWarehouseFirstRow - realQty == 0)
            {
                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + realQty + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + " and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");

            }
            else if (QtyInWarehouseFirstRow - realQty < 0)
            {
                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInWarehouseFirstRow + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + " and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                decimal Remainder = Math.Abs( (QtyInWarehouseFirstRow - realQty));
                dtQty.Clear();
                dtQty = db.ReadData("select Top 1 * from Product_Qty Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + "", "");
                QtyInWarehouseFirstRow = Convert.ToDecimal(dtQty.Rows[0][3]);

                if (QtyInWarehouseFirstRow - Remainder >= 0)
                {
                    db.ExecuteData("update Product_Qty set Quantity = Quantity - " + Remainder + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                    db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");

                }
                else if (QtyInWarehouseFirstRow - Remainder < 0)
                {
                    decimal Remainder2 = Math.Abs((QtyInWarehouseFirstRow - Remainder));
                    db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInWarehouseFirstRow + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + " and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                    db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                    if (QtyInWarehouseFirstRow - Remainder2 >= 0)
                    {
                        db.ExecuteData("update Product_Qty set Quantity = Quantity - " + Remainder2 + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                        db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                    }
                    else if (QtyInWarehouseFirstRow - Remainder2 < 0)
                    {
                        decimal Remainder3 = Math.Abs((QtyInWarehouseFirstRow - Remainder2));
                        db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInWarehouseFirstRow + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                        db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                        dtQty.Clear();
                        dtQty = db.ReadData("select Top 1 * from Product_Qty Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + "", "");
                        QtyInWarehouseFirstRow = Convert.ToDecimal(dtQty.Rows[0][3]);
                        if(QtyInWarehouseFirstRow - Remainder3 >= 0)
                        {
                            db.ExecuteData("update Product_Qty set Quantity = Quantity - " + Remainder3 + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                            db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");

                        }
                        else if (QtyInWarehouseFirstRow - Remainder3 < 0)
                        {
                            decimal Remainder4 = Math.Abs((QtyInWarehouseFirstRow - Remainder3));
                            db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInWarehouseFirstRow + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                            db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                            dtQty.Clear();
                            dtQty = db.ReadData("select Top 1 * from Product_Qty Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + "", "");
                            QtyInWarehouseFirstRow = Convert.ToDecimal(dtQty.Rows[0][3]);
                            if(QtyInWarehouseFirstRow - Remainder4 >= 0)
                            {
                                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + Remainder4 + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                                db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                            }
                            else if (QtyInWarehouseFirstRow - Remainder4 < 0)
                            {
                                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInWarehouseFirstRow + " Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " and Quantity = " + QtyInWarehouseFirstRow + "and Buy_Price = N'" + Convert.ToDecimal(dtQty.Rows[0][4]) + "'", "");
                                db.ExecuteData("Delete From Product_Qty Where Quantity <= 0", "");
                            }


                        }
                    }   
                }


            }

        }
        //Call Insert QTY in Warehous
        public void InsertQtyWarehouse(int ProID, decimal realQty)
        {
            db.ExecuteData("insert into Product_Qty Values ("+ProID+", "+cbxWarehouseTransferredTo.SelectedValue+", N'"+cbxWarehouseTransferredTo.Text+"' , "+ realQty + ", '"+NumBuyPrice.Value+"', '"+NumSalePrice.Value+"')", "");
        }

        private void autonumber()
        {
            try
            {
                cbxChoosePro.SelectedIndex = 0;
                cbxNameTransferredFrom.SelectedIndex = 0;
                cbxWarehouseTransferredTo.SelectedIndex = 0;
                cbxUnits.SelectedIndex = 0;
                NumBuyPrice.Value = 1;
                NumSalePrice.Value = 1;
                NumQuantity.Value = 1;
                txtResponsible.Clear();
                TxtReasonTransfer.Clear();
            }
            catch (Exception) { }
        }
        private void insertIntoProductTransfire()
        {
            string date = DateTime.Value.ToString("dd/MM/yyyy");
            db.ExecuteData("insert into Products_Transfire (Pro_ID,Pro_Name,Warehouse_Name,Warehouse_From, Warehouse_To,  Quantity,Unit,Buy_Price,Sale_PriceTax,Transfire_Date,Responsible_Name,Reason) Values (" + cbxChoosePro.SelectedValue + " ,N'" + cbxChoosePro.Text + "',N'"+ cbxNameTransferredFrom.Text+"' ,N'" + cbxNameTransferredFrom.Text + "' ,N'" + cbxWarehouseTransferredTo.Text + "' ," + NumQuantity.Value + " ,N'" + cbxUnits.Text + "' ," + NumBuyPrice.Value + " ," + NumSalePrice.Value + " , N'" + date + "' ,N'" + txtResponsible.Text + "' ,N'" + TxtReasonTransfer.Text + "')", "");
        }
        //BUTTON : Save Operation
        private void btnSaveOperation_Click(object sender, EventArgs e)
        {
            DataTable dtUnit = new DataTable();
            Decimal UnitQtyMain = 0, realQty = 0, totalQtyWarehouse = 0;
            int ProID = Convert.ToInt32(cbxChoosePro.SelectedValue);

            if(NumSalePrice.Value <= 0 || NumBuyPrice.Value <= 0 )
            {
                MessageBox.Show("Please enter the purchase price and sale price for the converted product", "Confrm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if(Convert.ToInt32(cbxNameTransferredFrom.SelectedValue) == Convert.ToInt32(cbxWarehouseTransferredTo.SelectedValue))
            {
                MessageBox.Show("It is not possible to transfer to the same Warehouse", "Confrm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            try
            {
                dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = "+ ProID + " and Unit_Name = N'"+cbxUnits.Text+"'", "");
                try
                {
                    UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
                }
                catch (Exception)
                {    
                }
                if(UnitQtyMain > 1)
                {
                    realQty =    NumQuantity.Value / UnitQtyMain ; 
                }
                else
                {
                    realQty = NumQuantity.Value;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                try
                {
                    totalQtyWarehouse = Convert.ToDecimal(db.ReadData("select Sum(Quantity) From Product_Qty Where Pro_ID = " + ProID + " and Warehouse_ID = " + cbxNameTransferredFrom.SelectedValue + " ", "").Rows[0][0]);
                }
                catch (Exception)
                {
                }
                if (totalQtyWarehouse - realQty < 0)
                {
                    MessageBox.Show("The quantity to be transferred is not in stock", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UpDateQtyWarehouse(ProID, realQty);
                InsertQtyWarehouse(ProID, realQty);
                insertIntoProductTransfire();
                MessageBox.Show("Transfer completed successfully", "Confrm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                autonumber();
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Searsh
        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = DateFromRw.Value.ToString("yyyy-MM-dd");
            date2 = DateToRw.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (rbtnAllWarehousesFrom.Checked == true)
            {
                dt = db.ReadData("SELECT [Order_ID] as ' Order ID',[Pro_Name] as 'Product Name ',[Warehouse_From] as 'From',[Warehouse_To] as 'To',[Quantity] as 'QTY',[Unit],[Buy_Price] as 'Buy Price',[Sale_PriceTax] as 'Sale Price',[Transfire_Date] as 'Date',[Responsible_Name] as 'Responsible',[Reason] FROM [dbo].[Products_Transfire]", "");
            }
            else
            {
                dt = db.ReadData("SELECT [Order_ID] as ' Order ID',[Pro_Name] as 'Product Name ',[Warehouse_From] as 'From',[Warehouse_To] as 'To',[Quantity] as 'QTY',[Unit],[Buy_Price] as 'Buy Price',[Sale_PriceTax] as 'Sale Price',[Transfire_Date] as 'Date',[Responsible_Name] as 'Responsible',[Reason] FROM [dbo].[Products_Transfire] Where Warehouse_Name=N'" + cbxChooseWarehouseFrom.Text + "' and Convert(date,Transfire_Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");


            }
            DgvWarehouseReport.DataSource = dt;

            if (dt.Rows.Count >= 1)
            {
                decimal totalQty = 0;
                for (int i = 0; i <= DgvWarehouseReport.Rows.Count - 1; i++)
                {
                    totalQty += Convert.ToDecimal(DgvWarehouseReport.Rows[i].Cells[4].Value);

                }
                txtTotalQuantity.Text = Math.Round(totalQty, 2).ToString();
            }
        }

        private void btnDeteWarehouseReport_Click(object sender, EventArgs e)
        {
            if (DgvWarehouseReport.Rows.Count >= 1)
            {
                string date1;
                string date2;
                date1 = DateFromRw.Value.ToString("yyyy-MM-dd");
                date2 = DateToRw.Value.ToString("yyyy-MM-dd");
                if (MessageBox.Show("Are you sure you want to erase the data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ExecuteData("delete from Products_Transfire where  Convert(date,Transfire_Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "successfully deleted");

                    btnSearsh_Click(null, null);
                }
            }
        }
        //FORM : Damage Products
        private void InsertIntoProductOutStore()
        {
            string d = Date.Value.ToString("dd/MM/yyyy");
            db.ExecuteData("insert into Damaged_Products (Pro_ID,Pro_Name,Warehouse_Name,Quantity,Unit,Damaged_Date,Responsible_Name,Reason) Values (" + cbxChooseProduct.SelectedValue + " ,N'" + cbxChooseProduct.Text + "' ,N'" + cbxtWarehousPro.Text + "'  ," + NumQuantityProD.Value + " ,N'" + cbxUnitsDPro.Text + "' , N'" + d + "' ,N'" + txtresponsibleoutput.Text + "' ,N'" + txtReason.Text + "')", "");
        }
        private void AutonumberProD()
        {
            try
            {
                cbxChooseProduct.SelectedIndex = 0;
                cbxtWarehousPro.SelectedIndex = 0;
                cbxUnitsDPro.SelectedIndex = 0;
                NumQuantityProD.Value = 1;
                txtresponsibleoutput.Clear();
                txtReason.Clear();
            }
            catch (Exception) { }
        }

        //call to update qty in store
        private void UpdateQtyInStore(int pro_ID, decimal realQty)
        {
            DataTable tblQty = new DataTable();
            decimal QtyInStoreFirstRaw = 0;
            db.ExecuteData("delete from Product_Qty where Quantity <=0", "");

            tblQty.Clear();
            tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + "", "");

            QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
            if (QtyInStoreFirstRaw - realQty >= 1)
            {
                db.ExecuteData("update Product_Qty set Quantity=Quantity - " + realQty + " where Pro_ID = " + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");

            }
            else if (QtyInStoreFirstRaw - realQty == 0)
            {
                db.ExecuteData("update Product_Qty set Quantity=Quantity - " + realQty + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
            }
            else if (QtyInStoreFirstRaw - realQty < 0)
            {

                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                db.ExecuteData("delete Product_Qty where Quantity  <= 0", "");

                decimal baky = Math.Abs(QtyInStoreFirstRaw - realQty);

                tblQty.Clear();
                tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + "", "");

                QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                if (QtyInStoreFirstRaw - baky >= 0)
                {
                    db.ExecuteData("update Product_Qty set Quantity = Quantity - " + baky + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    db.ExecuteData("delete Product_Qty where Quantity <= 0", "");

                }
                else if (QtyInStoreFirstRaw - baky < 0)
                {
                    decimal secondbaky = Math.Abs(QtyInStoreFirstRaw - baky);
                    db.ExecuteData("update Product_Qty set Quantity = Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                    db.ExecuteData("delete Product_Qty where Quantity <= 0", "");

                    tblQty.Clear();
                    tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + "", "");

                    QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                    if (QtyInStoreFirstRaw - secondbaky >= 0)
                    {
                        db.ExecuteData("update Product_Qty set Quantity = Quantity - " + secondbaky + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                    }
                    else if (QtyInStoreFirstRaw - secondbaky < 0)
                    {
                        decimal thirdbaky = Math.Abs(QtyInStoreFirstRaw - secondbaky);
                        db.ExecuteData("update Product_Qty set Quantity = Quantity  - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + " and Quantity =" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                        db.ExecuteData("delete Product_Qty where Quantity <= 0", "");

                        tblQty.Clear();
                        tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + "", "");

                        QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);
                        if (QtyInStoreFirstRaw - thirdbaky >= 0)
                        {
                            db.ExecuteData("update Product_Qty set Qty=Qty - " + thirdbaky + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                        }
                        else if (QtyInStoreFirstRaw - thirdbaky < 0)
                        {
                            decimal forthbaky = Math.Abs(QtyInStoreFirstRaw - thirdbaky);
                            db.ExecuteData("update Product_Qty set Quantity=Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                            db.ExecuteData("delete Product_Qty where Quantity <= 0", "");


                            tblQty.Clear();
                            tblQty = db.ReadData("select Top 1 * from Product_Qty where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + "", "");

                            QtyInStoreFirstRaw = Convert.ToDecimal(tblQty.Rows[0][3]);

                            if (QtyInStoreFirstRaw - forthbaky >= 0)
                            {
                                db.ExecuteData("update Product_Qty set Quantity=Quantity - " + forthbaky + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                            }
                            else if (QtyInStoreFirstRaw - forthbaky < 0)
                            {
                                db.ExecuteData("update Product_Qty set Quantity=Quantity - " + QtyInStoreFirstRaw + " where Pro_ID=" + pro_ID + " and Warehouse_ID=" + cbxtWarehousPro.SelectedValue + " and Quantity=" + QtyInStoreFirstRaw + " and Buy_Price=" + Convert.ToDecimal(tblQty.Rows[0][4]) + "", "");
                                db.ExecuteData("delete Product_Qty where Quantity <= 0", "");
                            }
                        }
                    }
                }

            }

        }


        private void cbxChooseProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Units
                cbxUnitsDPro.DataSource = db.ReadData("select * from Product_Unit Where Pro_ID = " + cbxChooseProduct.SelectedValue + " ", "");
                cbxUnitsDPro.DisplayMember = "Unit_Name";
                cbxUnitsDPro.ValueMember = "Unit_ID";
            }
            catch (Exception)
            {
            }
        }

        private void btnSaveProD_Click(object sender, EventArgs e)
        {
            if (cbxChooseProduct.Items.Count >= 1)
            {
                if (cbxUnitsDPro.Items.Count >= 1)
                {
                    if (cbxtWarehousPro.Items.Count >= 1)
                    {


                        DataTable dtUnit = new DataTable();
                        decimal QtyInMain = 0, realQty = 0, totalQtyInStore = 0;
                        try
                        {
                            int ProID = Convert.ToInt32(cbxChooseProduct.SelectedValue);
                            dt.Clear();
                            dt = db.ReadData("select * from Product_Unit where Pro_ID =" + ProID + " and Unit_Name=N'" + cbxUnitsDPro.Text + "'", "");
                            try
                            {
                                QtyInMain = Convert.ToDecimal(dt.Rows[0][3]);
                            }
                            catch (Exception) { }

                            if (QtyInMain > 1)
                            {
                                realQty = NumQuantityProD.Value / QtyInMain;
                            }
                            else
                            {
                                realQty = NumQuantityProD.Value;
                            }

                            try
                            {
                                totalQtyInStore = Convert.ToDecimal(db.ReadData("select sum(Quantity) from Product_Qty where Pro_ID =" + ProID + " and Warehouse_ID =" + cbxtWarehousPro.SelectedValue + "", "").Rows[0][0]);
                            }
                            catch (Exception) { }

                            if (totalQtyInStore - realQty < 0)
                            {
                                MessageBox.Show("The quantity to be taken out is not in stock at the moment", "Confirm");
                                return;
                            }

                            UpdateQtyInStore(ProID, realQty);
                            InsertIntoProductOutStore();
                            MessageBox.Show("The output has been completed successfully", "Confirm");
                            AutonumberProD();
                        }
                        catch (Exception) { }
                    }


                }
            }
        }
        //FORM : Damage Products
        private void btnSearshDR_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string date1;
            string date2;
            date1 = dateFromDR.Value.ToString("yyyy-MM-dd");
            date2 = dateToDR.Value.ToString("yyyy-MM-dd");

            if (RadioBtnAllWarehousesDR.Checked == true)
                dt = db.ReadData("SELECT [Order_ID] as 'Order ID',[Pro_ID] as 'Product ID',[Pro_Name] as 'Product Name',[Warehouse_Name] as 'Warehouse',[Quantity] as 'Quantity',[Unit] as 'Unit',[Damaged_Date] as 'Damage Date',[Responsible_Name] as 'Responsible Name',[Reason] as 'Reason'FROM [dbo].[Damaged_Products] ", "");
            else
                dt = db.ReadData(" SELECT [Order_ID] as 'Order ID',[Pro_ID] as 'Product ID',[Pro_Name] as 'Product Name',[Warehouse_Name] as 'Warehouse',[Quantity] as 'Quantity',[Unit] as 'Unit',[Damaged_Date] as 'Damage Date',[Responsible_Name] as 'Responsible Name',[Reason] as 'Reason'FROM [dbo].[Damaged_Products] where Warehouse_Name =N'" + cbxChooseWarehouseDR.Text + "' and Convert(date,Damaged_Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");



            DgvDamageReports.DataSource = dt;

            if (dt.Rows.Count >= 1)
            {
                decimal totalQty = 0;
                for (int i = 0; i <= DgvDamageReports.Rows.Count - 1; i++)
                {
                    totalQty += Convert.ToDecimal(DgvDamageReports.Rows[i].Cells[4].Value);

                }
                txtTotalQtyDR.Text = Math.Round(totalQty, 2).ToString();
            }
        }
        //BUTTON : Delete
        private void btnDeleteDR_Click(object sender, EventArgs e)
        {
            if (DgvDamageReports.Rows.Count >= 1)
            {
                string date1;
                string date2;
                date1 = dateFromDR.Value.ToString("yyyy-MM-dd");
                date2 = dateToDR.Value.ToString("yyyy-MM-dd");
                if (MessageBox.Show("Are you sure you want to erase the data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ExecuteData("delete from Damaged_Products where  Convert(date,Damaged_Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم المسح بنجاح");

                    btnSearshDR_Click(null, null);
                }
            }
            
        }

    }
}
