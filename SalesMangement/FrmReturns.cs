using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;

namespace SalesMangement
{
    public partial class FrmReturns : MaterialForm
    {
        public FrmReturns()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        DataTable dt = new DataTable();
        Database db = new Database();
        DataTable dtUnit = new DataTable();
        private void FillWarehouse()
        {
            CbxWareh.DataSource = db.ReadData("select * from Warehouse", "");
            CbxWareh.DisplayMember = "Warehouse_Name";
            CbxWareh.ValueMember = "Warehouse_ID";

            CbxWarehSp.DataSource = db.ReadData("select * from Warehouse", "");
            CbxWarehSp.DisplayMember = "Warehouse_Name";
            CbxWarehSp.ValueMember = "Warehouse_ID";
        }

        //When Press Sales Return
        private void SalesReturn()
        {
            dt.Clear();
            dt = db.ReadData(" SELECT [Order_ID]  as 'Invoice Number',Product.Pro_Name as 'Name Product',[Cust_Name] as  'Customer', Sales_Detalis.[Quantity] as 'Quantity',Unit_Name as 'Units',[Sales_Date] as 'Date',[User_Name] as 'User Name',[Sales_Price] as 'Price',(Sales_TaxValue *  Sales_Detalis.[Quantity] ) as 'Total TAX Value',Sales_PriceTax as 'Tax Included Price' ,[Sales_Discount] as 'Discount',[Sales_Total] as 'Total',[Sales_TotalAll] as 'Total All',[Sales_PaidUp] as 'Paid Up',[Sales_RestAmount] as 'Rest Amount'FROM [dbo].[Sales_Detalis],Product where Product.Pro_Id = Sales_Detalis.Pro_ID  and Order_ID = " + txtInNumber.Text + " ", "");
            DgvReturns.DataSource = dt;
            decimal TotalOrder = 0 , AmountPaid = 0 , RemainingAmount = 0,TotalTax = 0, TotalAfterTax = 0 ;
            for (int i = 0; i <= DgvReturns.Rows.Count - 1; i++)
            {
                TotalOrder += Convert.ToDecimal(DgvReturns.Rows[i].Cells[9].Value) - Convert.ToDecimal(DgvReturns.Rows[i].Cells[8].Value);
                TotalTax += Convert.ToDecimal(DgvReturns.Rows[i].Cells[8].Value);
                TotalAfterTax += Convert.ToDecimal(DgvReturns.Rows[i].Cells[9].Value);

            }
            try
            {
                AmountPaid += Convert.ToDecimal(DgvReturns.Rows[0].Cells[13].Value);
                txtAmountPaid.Text = Math.Round(AmountPaid, 2).ToString();
                txtTotalBill.Text = Math.Round(TotalOrder, 2).ToString();
                RemainingAmount = TotalOrder - AmountPaid;
                txtRemainingAmount.Text =Math.Round(RemainingAmount, 2).ToString() ;
                txtTotalTax.Text = Math.Round(TotalTax, 2).ToString();
                txtTotalAfterTax.Text = Math.Round(TotalAfterTax, 2).ToString();;
            }
            catch (Exception)
            {

            }
           
            if(rbtnRtuSales.Checked == true)
            {
                txtCustName.Hint = "Customer Name";
            }
            else
            {
                txtCustName.Hint = "Supplier Name";
            }
        }

        //??
        private void loadingScreen()
        {
            dt.Clear();
            DgvReturns.DataSource = dt;
            txtAmountPaid.Clear();
            txtTotalBill.Clear();
            txtTotalTax.Clear();
            txtRemainingAmount.Clear();
            txtTotalAfterTax.Clear();
            txtCustName.Clear();
            txtCustNameSp.Clear();
            txtInNumber.Clear();
            txtInNumber.Focus();
            rbtnRtuSales.Checked = true;
        }
        //When Press Buy Return 
        private void BuyReturn()
        {
            dt.Clear();
            dt = db.ReadData(" SELECT [Order_ID] as 'Invoice Number ', Product.[Pro_Name] as 'Name Product', Suppliers.[Sup_Name] as 'Name Supplier',[Quantity] as 'Quantity',[Buy_Date] as ' Buy Date',[Buy_Price] as 'Price Before Tax',Buy_TaxValue* [Quantity] as 'Tax' ,Buy_PriceTax as 'Price After Tax',[Buy_Discount] as 'Discount',[Buy_Total] as 'Total Order',[Buy_TotalAll] as 'Total Invoice',[Buy_PaidUp] as 'Paid Up',[Buy_RestAmount] as 'Rest Amount', Unit_Name as 'Unit',[User_Name] as 'User Name'FROM[dbo].[Buy_Detalis], Suppliers, Product where Suppliers.Sup_ID = Buy_Detalis.Sup_ID and Product.Pro_Id = Buy_Detalis.Pro_ID and Order_ID = " + txtInNumber.Text + "  ", "");
            DgvReturns.DataSource = dt;
            decimal TotalOrder = 0, AmountPaid = 0, RemainingAmount = 0,TotalTax = 0, TotalAfterTax = 0;
            for (int i = 0; i <= DgvReturns.Rows.Count - 1; i++)
            {
                TotalOrder += Convert.ToDecimal(DgvReturns.Rows[i].Cells[7].Value) * Convert.ToDecimal(DgvReturns.Rows[i].Cells[3].Value);
                TotalTax += Convert.ToDecimal(DgvReturns.Rows[i].Cells[6].Value);
                TotalAfterTax += Convert.ToDecimal(DgvReturns.Rows[i].Cells[7].Value);

            }

            try
            {
                AmountPaid += Convert.ToDecimal(DgvReturns.Rows[0].Cells[12].Value);
                txtAmountPaid.Text = Math.Round(AmountPaid, 2).ToString();
                txtTotalBill.Text = Math.Round(TotalOrder, 2).ToString();
                RemainingAmount =TotalOrder - AmountPaid;
                txtRemainingAmount.Text = Math.Round(RemainingAmount, 2).ToString();
                txtTotalTax.Text = Math.Round(TotalTax, 2).ToString();
                txtTotalAfterTax.Text = Math.Round(TotalAfterTax , 2).ToString();

            }
            catch (Exception)
            {

                
            }
           
        }
        //Update Quantity : TABLE ==>  Producat
        

        //When Press Return All Order Sales
        private void ReturnAllSales()
        {
            if(txtCustName.Text == "")
            {
                MessageBox.Show("Please Enter a Customer Name", "confirmation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataTable dtWarehouse = new DataTable();
            decimal Safe_Money = 0;
            dtWarehouse.Clear();
            dtWarehouse = db.ReadData("Select * from Safe where Safe_ID = " + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(dtWarehouse.Rows[0][1]);

            if (Convert.ToDecimal(txtTotalAfterTax.Text) > Safe_Money)
            {
                MessageBox.Show(" The amount in the Safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string date = DateReturns.Value.ToString("dd/MM/yyyy");
            //TABLE : Sales
            db.ExecuteData("Delete From Sales Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value +"", "");
            //TABLE : Sales Detalis
            db.ExecuteData("Delete From Sales_Detalis Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + "", "");
            //  //TABLE : Sales Profits
            db.ExecuteData("Delete From Sales_Profits Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + "", "");
            //insert data into  Return Table
           db.ExecuteData("insert into  Returns (Order_Date ,Order_Type ) values ('" + date+"',N'Returns Sales') ", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.ReadData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            decimal totalTax = 0;
            //insert data into Retuens Details
            for (int i = 0; i <= DgvReturns.Rows.Count - 1; i++)
            {
                //Bug003 == Fix
                db.ExecuteData("insert into Returns_Detalis values ("+ id +",N'"+DgvReturns.Rows[i].Cells[1].Value+"',N'', '"+ txtCustName.Text + "',"+ DgvReturns.Rows[i].Cells[3].Value+" ,N'" + date + "', N'"+ DgvReturns.Rows[i].Cells[7].Value + "',"+ txtTotalBill.Text + ","+ txtTotalAfterTax.Text + ","+ txtAmountPaid.Text + ","+ txtRemainingAmount.Text + ",N'"+ Properties.Settings.Default.UserName + "')", "");
                int ProId = 1;
                try
                {

                    ProId = Convert.ToInt32(db.ReadData("select  Pro_Id from Product where Pro_Name = '" + DgvReturns.Rows[i].Cells[1].Value + "'", "").Rows[0][0]);
                }
                catch (Exception)
                {
                }
                decimal UnitQtyMain = 0, realQty = 0 ;
                dtUnit.Clear();
                dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.Rows[i].Cells[4].Value + "'", "");
                try
                {
                    UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
                }
                catch (Exception)
                {
                }
                 realQty =Convert.ToDecimal( DgvReturns.Rows[i].Cells[3].Value) / UnitQtyMain;
                totalTax += Convert.ToDecimal(DgvReturns.Rows[i].Cells[8].Value);
                //Bug004 : 
                //Return products : Update  Quantity increase 
                 db.ExecuteData(" update Product set Pro_Quantity = Pro_Quantity +  " + realQty + " where Pro_Id = " + ProId + " ", "");
                DataTable dtQty = new DataTable();
                dtQty.Clear();
                dtQty = db.ReadData("select top 1 * from Product_Qty Where Pro_ID = "+ProId+" and  Warehouse_ID= "+CbxWareh.SelectedValue+"", "");
                if(dtQty.Rows.Count >= 1)
                {
                    db.ExecuteData("update Product_Qty set Quantity = Quantity + "+ realQty + " where Pro_ID = "+ ProId + " and Quantity = " + dtQty.Rows[0][3] + " and Buy_Price = "+ dtQty.Rows[0][4] + "", "");
                }
                else
                {
                    dtQty.Clear();
                    dtQty = db.ReadData("select top 1 * from Product_Qty where Pro_ID = " + ProId + " and  Warehouse_ID= " + CbxWareh.SelectedValue + "", "");
                    if (dtQty.Rows.Count >= 1)
                    {
                       db.ExecuteData("insert into Products_Qty values (" + ProId + " , " + CbxWareh.SelectedValue + " ,N'" + CbxWareh.Text + "' , " + realQty + " , " + dtQty.Rows[0][4] + " , " + DgvReturns.Rows[i].Cells[7].Value + ")", "");
                    }
                    else
                    {
                        string buyPrice = Microsoft.VisualBasic.Interaction.InputBox("Enter the purchase price of the product " + (DgvReturns.Rows[i].Cells[3].Value), "Buy Price", "Please enter the price here", 1, 1);
                        db.ExecuteData("insert into Product_Qty values (" + ProId + " , " + CbxWareh.SelectedValue + " ,N'" + CbxWareh.Text + "' , " + realQty + " , " + buyPrice + " , " + DgvReturns.Rows[i].Cells[7].Value + ")", "");
                    }
                }
            }

            decimal TotalBeforTax = 0;
            TotalBeforTax = totalTax - Convert.ToDecimal(txtTotalAfterTax.Text);
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + DgvReturns.CurrentRow.Cells[8].Value + " , N'Returns Sales ', N'Added Value', N'Not Found', N'" + txtCustName.Text + "', " + TotalBeforTax + " , " + totalTax + " , " + txtTotalAfterTax.Text + ", N'" + date + "')", "");

            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + txtTotalAfterTax.Text + ",N'" + date + "' , N'"+Properties.Settings.Default.UserName+"', N'Returns Sales', N'')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + txtTotalAfterTax.Text + " Where Safe_ID = " + Safe_ID + "", "");

            MessageBox.Show("Return has been completed successfully", "Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
           loadingScreen();
        }
        //When Press Return All Order buy
        private void ReturnAllBuy()
        {
            if (txtCustName.Text == "")
            {
                MessageBox.Show("Please Enter a Supplier Name", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string date = DateReturns.Value.ToString("dd/MM/yyyy");
            //TABLE : Buy
            db.ExecuteData("Delete From Buy Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + "", "");
            //TABLE : Buy Deatlis
            db.ExecuteData("Delete From Buy_Detalis Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + "", "");
            //insert data into  Return Table
            db.ExecuteData("insert into  Returns (Order_Date ,Order_Type ) values ('" + date + "',N'Returns Buy') ", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.ReadData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            decimal totalTax = 0;
            //insert data into Retuens Details
            for (int i = 0; i <= DgvReturns.Rows.Count - 1; i++)
            {
                 int ProId = 0;
                //Bug002 => Fix 
                db.ExecuteData("insert into Returns_Detalis values (" + id + ",N'" + DgvReturns.Rows[i].Cells[1].Value + "',N'" + txtCustName.Text + "', ''," + DgvReturns.Rows[i].Cells[3].Value + " ,N'" + date + "', N'" + DgvReturns.Rows[i].Cells[5].Value + "'," + DgvReturns.Rows[i].Cells[9].Value + "," + txtTotalAfterTax.Text + "," + txtAmountPaid.Text + "," + txtRemainingAmount.Text + ",N'" + Properties.Settings.Default.UserName + "')", "");
               
                try
                {
                    ProId = Convert.ToInt32(db.ReadData("select Pro_Id  from Product where Pro_Name = '" + DgvReturns.Rows[i].Cells[1].Value + "'", "").Rows[0][0]);

                }
                catch (Exception)
                {

                }

                decimal UnitQtyMain = 0, realQty = 0;
                dtUnit.Clear();
                //Bug : no fix 
                dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.Rows[i].Cells[13].Value + "'", "");
                try
                {
                    UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
                }
                catch (Exception)
                {
                }
                realQty = Convert.ToDecimal(DgvReturns.Rows[i].Cells[3].Value) / UnitQtyMain;
                totalTax += Convert.ToDecimal(DgvReturns.Rows[i].Cells[5].Value);

                //Return products : Update  Quantity increase 

                db.ExecuteData("update Product set Pro_Quantity=Pro_Quantity -  " + Math.Round( realQty, 0) + " where Pro_Id = " + ProId + " ", "");
                DataTable dtQty = new DataTable();
                dtQty.Clear();
                dtQty = db.ReadData("select * from Product_Qty Where Pro_ID = " + ProId + " and Warehouse_ID = " + CbxWareh.SelectedValue + "", "");
                decimal def = 0;
                def = Convert.ToDecimal(dtQty.Rows[0][3]) - realQty;
                if (def < 0)
                {
                    MessageBox.Show("The quantity to be returned is not in stock", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //else
                //{
                //    db.ExecuteData("update Product_Qty set Quantity = Quantity - " + realQty + " where Pro_ID = " + ProId + " ", "");
                //}
                //totalTax += Convert.ToDecimal(DgvSearch.Rows[i].Cells[6].Value);
            }


            decimal TotalBeforTax = 0;
            TotalBeforTax = totalTax - Convert.ToDecimal(txtTotalAfterTax.Text);
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + DgvReturns.CurrentRow.Cells[8].Value + " , N'Returns Buy ', N'Added Value', N'"+txtCustName.Text+"', N'Not Found', " + TotalBeforTax + " , " + totalTax + " , " + txtTotalAfterTax.Text + ", N'" + date + "')", "");


            db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + txtTotalAfterTax.Text + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Returns Buy', N'')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + txtTotalAfterTax.Text + " Where Safe_ID = " + Safe_ID + "", "");

            MessageBox.Show("Return has been completed successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadingScreen();
        }
        string Safe_ID = "1";
        private void FrmReturns_Load(object sender, EventArgs e)
        {
            DateReturns.Text = DateTime.Now.ToString();
            FillWarehouse();
             
            Safe_ID = Convert.ToString( Properties.Settings.Default.Safe_ID);

        }

        private void txtInNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rbtnRtuBuy_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnRtuBuy.Checked == true)
            {
                txtCustName.Hint = "Supplier Name";
                txtCustNameSp.Hint = "Supplier Name";
            }
            else
            {
                txtCustName.Hint = "Customer Name";
                txtCustNameSp.Hint = "Customer Name";
            }

        }

        private void rbtnRtuSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRtuBuy.Checked == true)
            {
                txtCustName.Hint = "Customer Name";
                txtCustNameSp.Hint = "Customer Name";
            }
            //else
            //{
            //    txtCustName.Hint = "Supplier Name";
            //    txtCustNameSp.Hint = "Supplier Name";
            //}
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (DgvReturns.Rows.Count >= 1)
            {
                if (rbtnRtuSales.Checked == true)
                {
                    ReturnAllSales();

                }
                else if (rbtnRtuBuy.Checked == true)
                {
                    ReturnAllBuy();
                }
            }

        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            if (txtInNumber.Text == "")
            {
                MessageBox.Show("Please Enter Invoice Number", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //I am assuming from context and the tags you used that you are writing a .NET C# app.
            //In this case, you can subscribe to the text changed event, and validate each key stroke.
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtInNumber.Text = txtInNumber.Text.Remove(txtInNumber.Text.Length - 1);
                return;
            }
            if (rbtnRtuSales.Checked == true)
            {
                SalesReturn();
            }
            else if (rbtnRtuBuy.Checked == true)
            {
                BuyReturn();
            }
        }

        //When Press Return Sales => Full Quantity 
        private void ReturnFullQtySales()
        {
            if (txtCustNameSp.Text == "")
            {
                MessageBox.Show("Please Enter a Customer Name", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dtWarehouse = new DataTable();
            decimal Safe_Money = 0;
            dtWarehouse.Clear();
            dtWarehouse = db.ReadData("Select * from Safe where Safe_ID = " + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(dtWarehouse.Rows[0][1]);

            if (Convert.ToDecimal(DgvReturns.CurrentRow.Cells[8].Value) > Safe_Money)
            {
                MessageBox.Show(" The amount in the Safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int ProId = 1;
            try
            {
                ProId = Convert.ToInt32(db.ReadData("select  Pro_Id from Product where Pro_Name = '" + DgvReturns.CurrentRow.Cells[1].Value + "' ", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            string date = DateReturns.Value.ToString("dd/MM/yyyy");
            //TABLE : Sales Detalis
            db.ExecuteData("Delete From Sales_Detalis Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + " and Pro_ID = "+ ProId + " and Quantity = "+ DgvReturns.CurrentRow.Cells[3].Value + "  and Sales_Total = "+ DgvReturns.CurrentRow.Cells[11].Value + "", "");
            //  //TABLE : Sales Profits
            db.ExecuteData("Delete From Sales_Profits Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + " and Pro_ID = " + ProId + " and Quantity = " + DgvReturns.CurrentRow.Cells[3].Value + "  and Sales_Total = " + DgvReturns.CurrentRow.Cells[11].Value + "", "");
            //insert data into  Return Table
            db.ExecuteData("insert into  Returns (Order_Date ,Order_Type ) values ('" + date + "',N'Returns Sales') ", "");

            //insert data into Retuens Details
            //Bug003 == Fix
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.ReadData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            db.ExecuteData("insert into Returns_Detalis values (" + id + ",N'" + DgvReturns.CurrentRow.Cells[1].Value + "',N'', '" + txtCustNameSp.Text + "'," + DgvReturns.CurrentRow.Cells[3].Value + " ,N'" + date + "', N'" + DgvReturns.CurrentRow.Cells[7].Value + "'," + txtTotalBill.Text + "," + txtTotalAfterTax.Text + "," + txtAmountPaid.Text + "," + txtRemainingAmount.Text + ",N'" + Properties.Settings.Default.UserName + "')", "");
               
                decimal UnitQtyMain = 0, realQty = 0 , totalTax = 0;
                dtUnit.Clear();
                dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.CurrentRow.Cells[4].Value + "'", "");
                try
                {
                    UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
                }
                catch (Exception)
                {
                }
                realQty = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) / UnitQtyMain;
                //Bug004 : 
                //Return products : Update  Quantity increase 
                db.ExecuteData(" update Product set Pro_Quantity = Pro_Quantity +  " + realQty + " where Pro_Id = " + ProId + " ", "");
                DataTable dtQty = new DataTable();
                dtQty.Clear();
                dtQty = db.ReadData("select top 1 * from Product_Qty Where Pro_ID = " + ProId + " and  Warehouse_ID= " + CbxWarehSp.SelectedValue + "", "");
                if (dtQty.Rows.Count >= 1)
                {
                    db.ExecuteData("update Product_Qty set Quantity = Quantity + " + realQty + " where Pro_ID = " + ProId + " and Quantity = " + dtQty.Rows[0][3] + " and Buy_Price = " + dtQty.Rows[0][4] + "", "");
                }
                else
                {
                    dtQty.Clear();
                    dtQty = db.ReadData("select top 1 * from Product_Qty where Pro_ID = " + ProId + " and  Warehouse_ID= " + CbxWarehSp.SelectedValue + "", "");
                    if (dtQty.Rows.Count >= 1)
                    {
                        db.ExecuteData("insert into Products_Qty values (" + ProId + " , " + CbxWarehSp.SelectedValue + " ,N'" + CbxWarehSp.Text + "' , " + realQty + " , " + dtQty.Rows[0][4] + " , " + DgvReturns.CurrentRow.Cells[7].Value + ")", "");
                    }
                    else
                    {
                        string buyPrice = Microsoft.VisualBasic.Interaction.InputBox("Enter the purchase price of the product " + (DgvReturns.CurrentRow.Cells[3].Value), "Buy Price", "Please enter the price here", 1, 1);
                        db.ExecuteData("insert into Product_Qty values (" + ProId + " , " + CbxWarehSp.SelectedValue + " ,N'" + CbxWarehSp.Text + "' , " + realQty + " , " + buyPrice + " , " + DgvReturns.CurrentRow.Cells[7].Value + ")", "");
                    }
                }
           
            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + DgvReturns.CurrentRow.Cells[9].Value + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Returns Sales', N'')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + DgvReturns.CurrentRow.Cells[9].Value + " Where Safe_ID = " + Safe_ID + "", "");
            //insert into Tax Reports
            decimal TotalBeforTax = 0, TotalItem = 0;
            TotalItem = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) * Convert.ToDecimal(DgvReturns.CurrentRow.Cells[9].Value);
            TotalBeforTax = totalTax - Convert.ToDecimal(TotalItem);
            totalTax = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[8].Value);
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + DgvReturns.CurrentRow.Cells[0].Value + " , N'Returns Sales ', N'Added Value', N'Not Found', N'"+txtCustNameSp.Text+"', " + TotalBeforTax + " , " + totalTax + " , " + TotalItem + ", N'" + date + "')", "");
            MessageBox.Show("Return has been completed successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadingScreen();
        }
        //When Press Return Buy => Full Quantity 
        private void ReturnFullQtyBuy()
        {
            int ProId = 1;
            if (txtCustNameSp.Text == "")
            {
                MessageBox.Show("Please Enter a Supplier Name", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ProId = Convert.ToInt32(db.ReadData("select Pro_Id  from Product where Pro_Name = '" + DgvReturns.CurrentRow.Cells[1].Value + "'", "").Rows[0][0]);

            }
            catch (Exception)
            {

            }
            string date = DateReturns.Value.ToString("dd/MM/yyyy");
            db.ExecuteData("Delete From Buy_Detalis Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + " and Pro_Id = "+ ProId + " and Quantity = "+ DgvReturns.CurrentRow.Cells[3].Value + " and Buy_Total = "+ DgvReturns.CurrentRow.Cells[9].Value + "", "");
            //insert data into  Return Table
            db.ExecuteData("insert into  Returns (Order_Date ,Order_Type ) values ('" + date + "',N'Returns Buy') ", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.ReadData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            //insert data into Retuens Details
                
                //Bug002 => Fix 
                db.ExecuteData("insert into Returns_Detalis values (" + id + ",N'" + DgvReturns.CurrentRow.Cells[1].Value + "',N'" + txtCustNameSp.Text + "', N''," + DgvReturns.CurrentRow.Cells[3].Value + " ,N'" + date + "', N'" + DgvReturns.CurrentRow.Cells[5].Value + "'," + DgvReturns.CurrentRow.Cells[9].Value + "," + txtTotalAfterTax.Text + "," + txtAmountPaid.Text + "," + txtRemainingAmount.Text + ",N'" + Properties.Settings.Default.UserName + "')", "");

              

                decimal UnitQtyMain = 0, realQty = 0 , totalTax = 0;
                dtUnit.Clear();
                //Bug : no fix 
                dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.CurrentRow.Cells[13].Value + "'", "");
                try
                {
                    UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
                }
                catch (Exception)
                {
                }
                realQty = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) / UnitQtyMain;

                //Return products : Update  Quantity increase 

                db.ExecuteData("update Product set Pro_Quantity=Pro_Quantity -  " + Math.Round(realQty, 0) + " where Pro_Id = " + ProId + " ", "");
                DataTable dtQty = new DataTable();
                dtQty.Clear();
                dtQty = db.ReadData("select * from Product_Qty Where Pro_ID = " + ProId + " and Warehouse_ID = " + CbxWarehSp.SelectedValue + "", "");
                decimal def = 0;
                def = Convert.ToDecimal(dtQty.Rows[0][3]) - realQty;
                if (def < 0)
                {
                    MessageBox.Show("The quantity to be returned is not in stock", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            else
            {
                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + realQty + " where Pro_ID = " + ProId + " ", "");
            }
            totalTax += Convert.ToDecimal(DgvReturns.CurrentRow.Cells[6].Value);
            db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + DgvReturns.CurrentRow.Cells[9].Value + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Returns Buy', N'')  ", "");
           db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + DgvReturns.CurrentRow.Cells[9].Value + " Where Safe_ID = " + Safe_ID + "", "");
            //insert into Tax Reports
            decimal TotalBeforTax = 0, TotalItem = 0;
            TotalItem = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) * Convert.ToDecimal(DgvReturns.CurrentRow.Cells[7].Value);
            TotalBeforTax = totalTax - Convert.ToDecimal(TotalItem);
            totalTax = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[6].Value);
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + DgvReturns.CurrentRow.Cells[0].Value + " , N'Returns buy ', N'Added Value', N'"+txtCustNameSp.Text+"', N'Not Found ', " + TotalBeforTax + " , " + totalTax + " , " + TotalItem + ", N'" + date + "')", "");
            MessageBox.Show("Return has been completed successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadingScreen();
        }
        //When Press Return Sales => Specified Quantity
        private void ReturnSpecifiedSales()
        {

            if (txtCustNameSp.Text == "")
            {
                MessageBox.Show("Please Enter a Customer Name", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dtWarehouse = new DataTable();
            decimal Safe_Money = 0;
            dtWarehouse.Clear();
            dtWarehouse = db.ReadData("Select * from Safe where Safe_ID = " + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(dtWarehouse.Rows[0][1]);

            if ((Convert.ToDecimal(DgvReturns.CurrentRow.Cells[9].Value) * NumSpecifiedQuantity.Value) > Safe_Money)
            {
                MessageBox.Show(" The amount in the Safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int ProId = 1;
            try
            {
                ProId = Convert.ToInt32(db.ReadData("select  Pro_Id from Product where Pro_Name = '" + DgvReturns.CurrentRow.Cells[1].Value + "' ", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            decimal UnitQtyMain = 0, realQty = 0 , totalTax = 0;
            dtUnit.Clear();
            dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.CurrentRow.Cells[4].Value + "'", "");
            try
            {
                UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
            }
            catch (Exception)
            {
            }
            realQty = NumSpecifiedQuantity.Value / UnitQtyMain;
            string date = DateReturns.Value.ToString("dd/MM/yyyy");
            if ((Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) - NumSpecifiedQuantity.Value) <= 0)
            {
                MessageBox.Show("The quantity to be returned is greater than the quantity sold", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //TABLE : Sales Detalis
            db.ExecuteData("Update  Sales_Detalis set Quantity = Quantity - "+ realQty + "   Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + " and Pro_ID = " + ProId + " and Quantity = " + DgvReturns.CurrentRow.Cells[3].Value + "  and Sales_Total = " + DgvReturns.CurrentRow.Cells[11].Value + "", "");
            //  //TABLE : Sales Profits
            db.ExecuteData("Update  Sales_Profits set Quantity = Quantity -  "+ realQty + "  Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + " and Pro_ID = " + ProId + " and Quantity = " + DgvReturns.CurrentRow.Cells[3].Value + "  and Sales_Total = " + DgvReturns.CurrentRow.Cells[11].Value + "", "");
            //insert data into  Return Table
            db.ExecuteData("insert into  Returns (Order_Date ,Order_Type ) values ('" + date + "',N'Returns Sales') ", "");

            //insert data into Retuens Details
            //Bug003 == Fix
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.ReadData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            db.ExecuteData("insert into Returns_Detalis values (" + id + ",N'" + DgvReturns.CurrentRow.Cells[1].Value + "',N'', '" + txtCustNameSp.Text + "'," + realQty  + " ,N'" + date + "', N'" + DgvReturns.CurrentRow.Cells[7].Value + "'," + txtTotalBill.Text + "," + txtTotalAfterTax.Text + "," + txtAmountPaid.Text + "," + txtRemainingAmount.Text + ",N'" + Properties.Settings.Default.UserName + "')", "");

           
            //Bug004 : 
            //Return products : Update  Quantity increase 
            db.ExecuteData(" update Product set Pro_Quantity = Pro_Quantity +  " + realQty + " where Pro_Id = " + ProId + " ", "");
            DataTable dtQty = new DataTable();
            dtQty.Clear();
            dtQty = db.ReadData("select top 1 * from Product_Qty Where Pro_ID = " + ProId + " and  Warehouse_ID= " + CbxWarehSp.SelectedValue + "", "");
            if (dtQty.Rows.Count >= 1)
            {
                db.ExecuteData("update Product_Qty set Quantity = Quantity + " + realQty + " where Pro_ID = " + ProId + " and Quantity = " + dtQty.Rows[0][3] + " and Buy_Price = " + dtQty.Rows[0][4] + "", "");
            }
            else
            {
                dtQty.Clear();
                dtQty = db.ReadData("select top 1 * from Product_Qty where Pro_ID = " + ProId + " and  Warehouse_ID= " + CbxWarehSp.SelectedValue + "", "");
                if (dtQty.Rows.Count >= 1)
                {
                    db.ExecuteData("insert into Products_Qty values (" + ProId + " , " + CbxWarehSp.SelectedValue + " ,N'" + CbxWarehSp.Text + "' , " + realQty + " , " + dtQty.Rows[0][4] + " , " + DgvReturns.CurrentRow.Cells[7].Value + ")", "");
                }
                else
                {
                    string buyPrice = Microsoft.VisualBasic.Interaction.InputBox("Enter the purchase price of the product " + (DgvReturns.CurrentRow.Cells[3].Value), "Buy Price", "Please enter the price here", 1, 1);
                    db.ExecuteData("insert into Product_Qty values (" + ProId + " , " + CbxWarehSp.SelectedValue + " ,N'" + CbxWarehSp.Text + "' , " + realQty + " , " + buyPrice + " , " + DgvReturns.CurrentRow.Cells[7].Value + ")", "");
                }
            }

            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", "+ (Convert.ToDecimal(DgvReturns.CurrentRow.Cells[9].Value) * NumSpecifiedQuantity.Value) + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Returns Sales', N'')  ", "");          
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " +( Convert.ToDecimal(DgvReturns.CurrentRow.Cells[9].Value) * NumSpecifiedQuantity.Value) + " Where Safe_ID = " + Safe_ID + "", "");

            //insert into Tax Reports
            decimal TotalBeforTax = 0, TotalItem = 0 , IthemTotal = 0;
            TotalItem = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[8].Value) / Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value);
            totalTax = TotalItem * NumSpecifiedQuantity.Value;
            IthemTotal = NumSpecifiedQuantity.Value * Convert.ToDecimal(DgvReturns.CurrentRow.Cells[9].Value);
            TotalBeforTax = IthemTotal - totalTax;
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + DgvReturns.CurrentRow.Cells[0].Value + " , N'Returns Sales ', N'Added Value', N'Not Found', N' "+txtCustNameSp.Text+"', " + TotalBeforTax + " , " + totalTax + " , " + TotalItem + ", N'" + date + "')", "");

            MessageBox.Show("Return has been completed successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadingScreen();
        }
        //When Press Return Buy => Specified Quantity
        private void ReturnSpecifiedBuy()
        {


            int ProId = 1;
            if (txtCustNameSp.Text == "")
            {
                MessageBox.Show("Please Enter a Supplier Name", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ProId = Convert.ToInt32(db.ReadData("select Pro_Id  from Product where Pro_Name = '" + DgvReturns.CurrentRow.Cells[1].Value + "'", "").Rows[0][0]);

            }
            catch (Exception)
            {

            }
            string date = DateReturns.Value.ToString("dd/MM/yyyy");
            decimal UnitQtyMain = 0, realQty = 0 , totalTax = 0;
            dtUnit.Clear();
            dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.CurrentRow.Cells[13].Value + "'", "");
            try
            {
                UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
            }
            catch (Exception)
            {
            }
            realQty = NumSpecifiedQuantity.Value ;
            if ((Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) - NumSpecifiedQuantity.Value) <= 0)
            {
                MessageBox.Show("The quantity to be returned is greater than the quantity Buy", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //TABLE : Sales Detalis
            db.ExecuteData("Update  Buy_Detalis set Quantity = Quantity - " + realQty + "   Where Order_ID = " + DgvReturns.CurrentRow.Cells[0].Value + " and Pro_ID = " + ProId + " and Quantity = " + DgvReturns.CurrentRow.Cells[3].Value + "  and Buy_Total = " + DgvReturns.CurrentRow.Cells[9].Value + "", "");

            //insert data into  Return Table
            db.ExecuteData("insert into  Returns (Order_Date ,Order_Type ) values ('" + date + "',N'Returns Buy') ", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.ReadData("select max(Order_ID) from Returns", "").Rows[0][0]);
            }
            catch (Exception)
            {
            }
            //insert data into Retuens Details

            //Bug002 => Fix 
            db.ExecuteData("insert into Returns_Detalis values (" + id + ",N'" + DgvReturns.CurrentRow.Cells[1].Value + "',N'', N'" + txtCustNameSp.Text + "'," + realQty + " ,N'" + date + "', N'" + DgvReturns.CurrentRow.Cells[5].Value + "'," + DgvReturns.CurrentRow.Cells[9].Value + "," + txtTotalAfterTax.Text + "," + txtAmountPaid.Text + "," + txtRemainingAmount.Text + ",N'" + Properties.Settings.Default.UserName + "')", "");
            //Return products : Update  Quantity increase 

            db.ExecuteData("update Product set Pro_Quantity=Pro_Quantity -  " + Math.Round(realQty, 0) + " where Pro_Id = " + ProId + " ", "");
            DataTable dtQty = new DataTable();
            dtQty.Clear();
          
            dtQty = db.ReadData("select * from Product_Qty Where Pro_ID = " + ProId + " and Warehouse_ID = " + CbxWarehSp.SelectedValue + "", "");
            dtUnit.Clear();
            dtUnit = db.ReadData("select * from Product_Unit Where Pro_ID = " + ProId + " and Unit_Name = N'" + DgvReturns.CurrentRow.Cells[13].Value + "'", "");
            try
            {
                UnitQtyMain = Convert.ToDecimal(dtUnit.Rows[0][3]);
            }
            catch (Exception)
            {
            }
            realQty = NumSpecifiedQuantity.Value / UnitQtyMain;
            if ((Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value) - NumSpecifiedQuantity.Value) <= 0)
            {
                MessageBox.Show("The quantity to be returned is greater than the quantity Buy", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal def = 0;
            def = Convert.ToDecimal(dtQty.Rows[0][3]) - realQty;
            if (def < 0)
            {
                MessageBox.Show("The quantity to be returned is not in stock", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                db.ExecuteData("update Product_Qty set Quantity = Quantity - " + realQty + " where Pro_ID = " + ProId + " ", "");
            }
            totalTax += Convert.ToDecimal(DgvReturns.CurrentRow.Cells[6].Value);
            db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + (Convert.ToDecimal(DgvReturns.CurrentRow.Cells[7].Value) * NumSpecifiedQuantity.Value) + ",N'" + date + "' , N'" + Properties.Settings.Default.UserName + "', N'Returns Buy', N'')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + (Convert.ToDecimal(DgvReturns.CurrentRow.Cells[7].Value) * realQty)  + " Where Safe_ID = " + Safe_ID + "", "");

            //insert into Tax Reports
            decimal TotalBeforTax = 0, TotalItem = 0, IthemTotal = 0;
            TotalItem = Convert.ToDecimal(DgvReturns.CurrentRow.Cells[6].Value) / Convert.ToDecimal(DgvReturns.CurrentRow.Cells[3].Value);
            totalTax = TotalItem * NumSpecifiedQuantity.Value;
            IthemTotal = NumSpecifiedQuantity.Value * Convert.ToDecimal(DgvReturns.CurrentRow.Cells[6].Value);
            TotalBeforTax = IthemTotal - totalTax;
            db.ExecuteData("Insert into Taxes_Report (Invoice_ID,Order_Type, Tax_Type,Sup_Name, Cust_Name , Total_Order, Total_Tax,Total_AfterTax,Tax_Date ) values (" + DgvReturns.CurrentRow.Cells[0].Value + " , N'Returns Buy ', N'Added Value', N'"+txtCustNameSp.Text+"', N'Not Found', " + TotalBeforTax + " , " + totalTax + " , " + TotalItem + ", N'" + date + "')", "");


            MessageBox.Show("Return has been completed successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadingScreen();
        }
        private void btnSpecific_Click(object sender, EventArgs e)
        {
            if (DgvReturns.Rows.Count >= 1)
            {
                if (rbtnFullQuantity.Checked == true)
                {
                    if (rbtnRtuSales.Checked == true)
                    {
                        ReturnFullQtySales();

                    }
                    else if (rbtnRtuBuy.Checked == true)
                    {
                        ReturnFullQtyBuy();
                    }
                }
                //bug004 22/05//2022
                else if (rbtnSpecifiedQuantity.Checked == true)
                {
                    if (rbtnRtuSales.Checked == true)
                    {
                        ReturnSpecifiedSales();
                    }
                    else if (rbtnRtuBuy.Checked == true)
                    {
                        ReturnSpecifiedBuy();
                    }
                }
            }
            
        }

        private void txtInNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
