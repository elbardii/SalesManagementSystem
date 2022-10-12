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
    public partial class FrmProductManagement : MaterialForm
    {
        public FrmProductManagement()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        /// <summary>
        ///AutoNumber
        ///A function that adds a new ID in the database
        ///and increments 1 automatically in each operation
        ///Clear the text box again after each operation
        ///Cancel buttons and activate them when needed
        ///focus on textbox Name Customer
        /// </summary>
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.ReadData("select max(Pro_Id) from Product", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtIdPro.Text = "1";
            }
            else
            {
                txtIdPro.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            if(Properties.Settings.Default.ActivateTaxes == true)
            {
                CheckboxVAT.Checked = true;
            }
            else
            {
                CheckboxVAT.Checked = false;
            }
            txtNamePro.Clear();
            txtBarcode.Clear();
            NumRetailPrice.Value = 0;
            NudMaxDiscount.Value = 0;
            NudMinQuantity.Value = 0;
            NumQuantityWarehouse.Value = 1;
            NumBuyPrice.Value = 0;
            NudTotalQuantity.Value = 1;
            NumPieces.Value = 0;
            NumUnitPrice.Value = 0; 
            try
            {
                FillPro();
                CbxProM.SelectedIndex = 0;
            }
            catch (Exception)
            {
                
            }

            try
            {
                cbxCategory.SelectedIndex = 0;
                cbxGreatUnits.SelectedIndex = 0;
                cbxUnitMostBuy.SelectedIndex = 0;   
                cbxUnitMostSelling.SelectedIndex = 0;   
            }
            catch (Exception)
            {
            }
            //Cancel buttons and activate them when needed
            try
            {
                DgvWarehouse.Rows.Clear();
                DgvUnits.Rows.Clear();  
            }
            catch (Exception)
            {

            }
            btnAddProM.Enabled = true;
            btnNewProM.Enabled = true;
            btnSaveProM.Enabled = false;
            btnDeleteProM.Enabled = false;
            btnDeleteAllProM.Enabled = false;
            btnBarcodePrint.Enabled = false;
        }
        /* Show
        * A function that displays data from the database
       */
        int Row;
        private void show()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from Product", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data on this screen");
            }
            else
            {
                try
                {
                    //##1
                    txtIdPro.Text = tbl.Rows[Row][0].ToString();
                    txtNamePro.Text = tbl.Rows[Row][1].ToString();
                    NudTotalQuantity.Value = Convert.ToDecimal(tbl.Rows[Row][2]);
                    NumWholesalePrice.Value = Convert.ToDecimal(tbl.Rows[Row][3]);
                    NumVAT.Value = Convert.ToDecimal(tbl.Rows[Row][4]);
                    NumRetailPrice.Value = Convert.ToDecimal(tbl.Rows[Row][5]);
                    txtPricetax.Text = tbl.Rows[Row][6].ToString();
                    txtBarcode.Text = tbl.Rows[Row][7].ToString();
                    NudMinQuantity.Value = Convert.ToDecimal(tbl.Rows[Row][8]);
                    NudMaxDiscount.Value = Convert.ToDecimal(tbl.Rows[Row][9]);
                    if(tbl.Rows[Row][10].ToString() == "Taxable")
                    {
                        CheckboxVAT.Checked = true;
                    }
                    else
                    {
                        CheckboxVAT.Checked = false;
                    }
                    cbxCategory.SelectedValue = tbl.Rows[Row][11].ToString();
                    cbxGreatUnits.SelectedValue = tbl.Rows[Row][13].ToString();
                    cbxUnitMostSelling.SelectedValue = tbl.Rows[Row][15].ToString();
                    cbxUnitMostBuy.SelectedValue = tbl.Rows[Row][17].ToString();
                }
                catch (Exception)
                {
                }
                //Werehouse
                try
                {
                    DataTable dtWerehous = new DataTable();
                    dtWerehous = db.ReadData("select * from Product_Qty where Pro_ID = "+txtIdPro.Text+"", "");
                    DgvWarehouse.Rows.Clear();  
                    if(dtWerehous.Rows.Count >= 1)
                    {
                        
                        foreach (DataRow  row in dtWerehous.Rows)
                        {
                            DgvWarehouse.Rows.Add(1);
                            int index = DgvWarehouse.Rows.Count - 1;
                            DgvWarehouse.Rows[index].Cells[0].Value = row[2];
                            DgvWarehouse.Rows[index].Cells[1].Value = row[3];
                            DgvWarehouse.Rows[index].Cells[2].Value = row[4];

                        }
                    }

                }
                catch (Exception)
                {  
                }

                //Unit
                try
                {
                    DataTable dtUnit = new DataTable();
                    dtUnit = db.ReadData("select * from Product_Unit where Pro_ID = " + txtIdPro.Text + "", "");
                    DgvUnits.Rows.Clear();
                    if (dtUnit.Rows.Count >= 1)
                    {

                        foreach (DataRow row in dtUnit.Rows)
                        {
                            DgvUnits.Rows.Add(1);
                            int index = DgvUnits.Rows.Count - 1;
                            DgvUnits.Rows[index].Cells[0].Value = row[2];
                            DgvUnits.Rows[index].Cells[1].Value = row[3];
                            DgvUnits.Rows[index].Cells[2].Value = row[4];

                        }
                    }
                }
                catch (Exception)
                {
                }

            }

            btnAddProM.Enabled = false;
            btnNewProM.Enabled = true;
            btnDeleteProM.Enabled = true;
            btnDeleteAllProM.Enabled = true;
            btnSaveProM.Enabled = true;
            btnBarcodePrint.Enabled = true;
        }
        // read Data from Database in CbxNamePr
        private void FillPro()
        {
            CbxProM.DataSource = db.ReadData("select * from Product", "");
            CbxProM.DisplayMember = "Pro_Name";
            CbxProM.ValueMember = "Pro_Id";

        }
        private void FillUnit()
        {
            cbxGreatUnits.DataSource = db.ReadData("select * from Units", "");
            cbxGreatUnits.DisplayMember = "Unit_Name";
            cbxGreatUnits.ValueMember = "Unit_ID";

            cbxUnitName.DataSource = db.ReadData("select * from Units", "");
            cbxUnitName.DisplayMember = "Unit_Name";
            cbxUnitName.ValueMember = "Unit_ID";

            cbxUnitMostSelling.DataSource = db.ReadData("select * from Units", "");
            cbxUnitMostSelling.DisplayMember = "Unit_Name";
            cbxUnitMostSelling.ValueMember = "Unit_ID";

            cbxUnitMostBuy.DataSource = db.ReadData("select * from Units", "");
            cbxUnitMostBuy.DisplayMember = "Unit_Name";
            cbxUnitMostBuy.ValueMember = "Unit_ID";
        }
        private void FillGroup()
        {
            cbxCategory.DataSource = db.ReadData("select * from Category", "");
            cbxCategory.DisplayMember = "Group_Name";
            cbxCategory.ValueMember = "Group_ID";

        }
        private void FillWarehouse()
        {
            cbxWarehouseName.DataSource = db.ReadData("select * from Warehouse", "");
            cbxWarehouseName.DisplayMember = "Warehouse_Name";
            cbxWarehouseName.ValueMember = "Warehouse_ID";

        }
        //A function check product 
        private bool check()
        {
            if (txtNamePro.Text == string.Empty)
            {
                MessageBox.Show("Please enter a product name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if(txtBarcode.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Barcode name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }
        
            if (NumRetailPrice.Value <= 0)
            {
                MessageBox.Show("The Selling price cannot be less than 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (NudMaxDiscount.Value >= NumRetailPrice.Value)
            {
                MessageBox.Show("The discount cannot be greater than the selling price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            //if (NudMinQuantity.Value <= NudTotalQuantity.Value)
            //{
            //    MessageBox.Show("Quantity Alert cannot be greater than Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return true;
            //}
            if (NumWholesalePrice.Value > Convert.ToDecimal(txtPricetax.Text))
            {
                MessageBox.Show("Wholesale price cannot be greater than the selling price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbxGreatUnits.Items.Count <= 0)
            {
                MessageBox.Show("Please enter the units first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbxCategory.Items.Count <= 0)
            {
                MessageBox.Show("Please enter categories first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (DgvWarehouse.Rows.Count <= 0)
            {
                MessageBox.Show("It is not possible to add a product before adding a quantity" +
                    "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }


            else
            {
                return false;
            }

        }

        //Load Form Product 
        private void FrmProductManagement_Load(object sender, EventArgs e)
        {
           
            FillPro();
            FillUnit();
            FillGroup();
            FillWarehouse();
            AutoNumber();
        }
        //Enter
        private void txtSearchProM_Enter(object sender, EventArgs e)
        {
            

        }
        //Leave
        private void txtSearchProM_Leave(object sender, EventArgs e)
        {
           
        }
        //Button First line on database ==> table Product
        private void btnFirstProM_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }
        //Button Previous == > table Product
        private void btnPreviousProM_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {
                tbl.Clear();
                tbl = db.ReadData("select count(Pro_ID) from Product", "");
                Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {


                Row--;
                show();
            }
        }
        //Button Next line on database == > table  Product 
        private void btnNextProM_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select count(Pro_ID) from Product", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == Row)
            {
                Row = 0;
                show();
            }
            else
            {
                Row++;
                show();
            }
        }
        //Button Last line on database == > table Product
        private void btnLastProM_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select count(Pro_ID) from Product", "");
            Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }
        //Button Add Product on database ==> table Product 
        private void btnAddProM_Click(object sender, EventArgs e)
        {
            string Is_Tax = "";
            if(CheckboxVAT.Checked == true)
            {
                Is_Tax = "Taxable";
            }
            else
            {
                Is_Tax = "tax free";
            }

            if (check() == false)
            {
                db.ExecuteData("insert into Product Values (" + txtIdPro.Text + ", N'"+txtNamePro.Text+"',"+NudTotalQuantity.Value+ ", "+NumWholesalePrice.Value+ ", "+ NumVAT.Value + ","+ NumRetailPrice.Value + "" +
                    ", N'"+ txtPricetax.Text + "', "+txtBarcode.Text+", "+ NudMinQuantity.Value + ","+ NudMaxDiscount.Value+ ",'"+Is_Tax+"', "+cbxCategory.SelectedValue+", N'"+cbxGreatUnits.Text+"', "+cbxGreatUnits.SelectedValue+" , N'"+cbxUnitMostSelling.Text+"', "+cbxUnitMostSelling.SelectedValue+" , N'"+cbxUnitMostBuy.Text+"', "+cbxUnitMostBuy.SelectedValue+" )", "");

                //WareHouse==================================================//
                for (int i = 0; i <=  DgvWarehouse.Rows.Count - 1; i++)
                {
                    int WarehouseID = 0;
                    try
                    {
                        WarehouseID = Convert.ToInt32( db.ReadData(" select * from Warehouse Where Warehouse_Name = N'" + DgvWarehouse.Rows[i].Cells[0].Value +"'", "").Rows[0][0]);
                    }
                    catch (Exception)
                    {
                    }
                    db.ExecuteData("insert into Product_Qty Values ("+txtIdPro.Text+", "+WarehouseID+" , N'" + DgvWarehouse.Rows[i].Cells[0].Value +"', "+ DgvWarehouse.Rows[i].Cells[1].Value + ", "+ DgvWarehouse.Rows[i].Cells[2].Value + " , N'"+txtPricetax.Text+"'  ) ", "");
                }



                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    int UnitID = 0;
                    try
                    {
                        UnitID = Convert.ToInt32(db.ReadData("select * from Units Where Unit_Name = N'" + DgvUnits.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception)
                    {
                    }
                    db.ExecuteData("insert into Product_Unit Values (" + txtIdPro.Text + "," + UnitID + ", N'" + DgvUnits.Rows[i].Cells[0].Value + "', " + DgvUnits.Rows[i].Cells[1].Value +" , " + DgvUnits.Rows[i].Cells[2].Value +" , N'"+txtPricetax.Text+"' )", "");
                }

                db.ExecuteData("insert into Product_Unit Values (" + txtIdPro.Text + "," + cbxGreatUnits.SelectedValue + ", N'" + cbxGreatUnits.Text + "', 1  , N'" + txtPricetax.Text+ "' , N'" + txtPricetax.Text + "' )", "");

                MessageBox.Show("Product data added successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoNumber();
            }
            else
                return;
          

        }
        //Button new Product on database == > table Product
        private void btnNewProM_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //Button Save(update) on databse == > table Product 
        private void btnSaveProM_Click(object sender, EventArgs e)
        {
            string Is_Tax = "";
            if (CheckboxVAT.Checked == true)
            {
                Is_Tax = "Taxable";
            }
            else
            {
                Is_Tax = "tax free";
            }

            if (check() == false)
            {
                db.ExecuteData("Update  Product set Pro_Name = N'" + txtNamePro.Text + "',Pro_Quantity = " + NudTotalQuantity.Value + ",Wholesale_Price =  " + NumWholesalePrice.Value + ", Tax_Value = " + NumVAT.Value + ",Sale_price = " + NumRetailPrice.Value + "" +
                    ", Sale_PriceTax = N'" + txtPricetax.Text + "',Pro_BarCode =  " + txtBarcode.Text + ", MinQuantity = " + NudMinQuantity.Value + ",MaxDiscount = " + NudMaxDiscount.Value + ",Is_Tax = '" + Is_Tax + "', Group_ID = " + cbxCategory.SelectedValue + ", Main_UnitName = N'" + cbxGreatUnits.Text + "',Main_UnitID =  " + cbxGreatUnits.SelectedValue + " ,Sale_UnitName =  N'" + cbxUnitMostSelling.Text + "',Sale_UnitID =  " + cbxUnitMostSelling.SelectedValue + " ,Buy_UnitName =  N'" + cbxUnitMostBuy.Text + "',Buy_UnitID =  " + cbxUnitMostBuy.SelectedValue + " Where Pro_ID = "+txtIdPro.Text+" ", "");
                db.ExecuteData("Delete from Product_Qty Where Pro_ID = "+txtIdPro.Text+" ", "");
                //WareHouse==================================================//
                for (int i = 0; i <= DgvWarehouse.Rows.Count - 1; i++)
                {
                    int WarehouseID = 0;
                    try
                    {
                        WarehouseID = Convert.ToInt32(db.ReadData(" select * from Warehouse Where Warehouse_Name = N'" + DgvWarehouse.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception)
                    {
                    }
                    db.ExecuteData("insert into Product_Qty Values (" + txtIdPro.Text + ", " + WarehouseID + " , N'" + DgvWarehouse.Rows[i].Cells[0].Value + "', " + DgvWarehouse.Rows[i].Cells[1].Value + ", N'" + DgvWarehouse.Rows[i].Cells[2].Value + "' , N'" + txtPricetax.Text + "'  ) ", "");
                }

                //units===========================================================================

                db.ExecuteData("Delete from Product_Unit Where Pro_ID = " + txtIdPro.Text + " ", "");
               

                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    int UnitID = 0;
                    try
                    {
                        UnitID = Convert.ToInt32(db.ReadData("select * from Units Where Unit_Name = N'" + DgvUnits.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception)
                    {
                    }
                    db.ExecuteData("insert into Product_Unit Values (" + txtIdPro.Text + "," + UnitID + ", N'" + DgvUnits.Rows[i].Cells[0].Value + "', " + DgvUnits.Rows[i].Cells[1].Value + " , N'" + DgvUnits.Rows[i].Cells[2].Value + "' , N'" + txtPricetax.Text + "' )", "");
                }
                string UnitName = cbxUnitName.Text;
                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    if (UnitName == (DgvUnits.Rows[i].Cells[0].Value).ToString())
                    {
                        MessageBox.Show("Data saved successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AutoNumber();
                        return;
                    }
                }
                db.ExecuteData("insert into Product_Unit Values (" + txtIdPro.Text + "," + cbxGreatUnits.SelectedValue + ", N'" + cbxGreatUnits.Text + "', 1  , N'" + txtPricetax.Text + "' , N'" + txtPricetax.Text + "' )", "");

                MessageBox.Show("Data saved successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoNumber();
            }
            else
                return;




        }
        //Button Delete Product 1 on database ==> table Product
        private void btnDeleteProM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You  Deleted Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ReadData("delete from Product_Qty where Pro_Id=" + txtIdPro.Text + "", "");
                db.ReadData("delete from Product_Unit where Pro_Id=" + txtIdPro.Text + "", "");
                db.ReadData("delete from Product where Pro_Id=" + txtIdPro.Text + "", "The Product has been deleted successfully");
                AutoNumber();
            }
        }
        //Button Delete all Product on database  == > table Product
        private void btnDeleteAllProM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete All Product data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ReadData("delete from Product_Qty ", "");
                db.ReadData("delete from Product_Unit ", "");
                db.ReadData("delete from Product ", "The Product has been deleted successfully");
                AutoNumber();
            }

        }

        private void btnSearchProM_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text != "")
            {

                DataTable dtSearsh = new DataTable();
                dtSearsh.Clear();
                dtSearsh = db.ReadData("select * from Product Where Pro_Name like N'%" + txtSearch.Text + "%'", "");

                if (dtSearsh.Rows.Count <= 0)
                {

                }
                else
                {
                    try
                    {
                        //##1
                        txtIdPro.Text = dtSearsh.Rows[0][0].ToString();
                        txtNamePro.Text = dtSearsh.Rows[0][1].ToString();
                        NudTotalQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][2]);
                        NumWholesalePrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][3]);
                        NumVAT.Value = Convert.ToDecimal(dtSearsh.Rows[0][4]);
                        NumRetailPrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][5]);
                        txtPricetax.Text = dtSearsh.Rows[0][6].ToString();
                        txtBarcode.Text = dtSearsh.Rows[0][7].ToString();
                        NudMinQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][8]);
                        NudMaxDiscount.Value = Convert.ToDecimal(dtSearsh.Rows[0][9]);
                        if (dtSearsh.Rows[0][10].ToString() == "Taxable")
                        {
                            CheckboxVAT.Checked = true;
                        }
                        else
                        {
                            CheckboxVAT.Checked = false;
                        }
                        cbxCategory.SelectedValue = dtSearsh.Rows[0][11].ToString();
                        cbxGreatUnits.SelectedValue = dtSearsh.Rows[0][13].ToString();
                        cbxUnitMostSelling.SelectedValue = dtSearsh.Rows[0][15].ToString();
                        cbxUnitMostBuy.SelectedValue = dtSearsh.Rows[0][17].ToString();
                    }
                    catch (Exception)
                    {
                    }
                    //Werehouse
                    try
                    {
                        DataTable dtWerehous = new DataTable();
                        dtWerehous = db.ReadData("select * from Product_Qty where Pro_ID = " + txtIdPro.Text + "", "");
                        DgvWarehouse.Rows.Clear();
                        if (dtWerehous.Rows.Count >= 1)
                        {

                            foreach (DataRow row in dtWerehous.Rows)
                            {
                                DgvWarehouse.Rows.Add(1);
                                int index = DgvWarehouse.Rows.Count - 1;
                                DgvWarehouse.Rows[index].Cells[0].Value = row[2];
                                DgvWarehouse.Rows[index].Cells[1].Value = row[3];
                                DgvWarehouse.Rows[index].Cells[2].Value = row[4];

                            }
                        }

                    }
                    catch (Exception)
                    {
                    }

                    //Unit
                    try
                    {
                        DataTable dtUnit = new DataTable();
                        dtUnit = db.ReadData("select * from Product_Unit where Pro_ID = " + txtIdPro.Text + "", "");
                        DgvUnits.Rows.Clear();
                        if (dtUnit.Rows.Count >= 1)
                        {

                            foreach (DataRow row in dtUnit.Rows)
                            {
                                DgvUnits.Rows.Add(1);
                                int index = DgvUnits.Rows.Count - 1;
                                DgvUnits.Rows[index].Cells[0].Value = row[2];
                                DgvUnits.Rows[index].Cells[1].Value = row[3];
                                DgvUnits.Rows[index].Cells[2].Value = row[4];

                            }
                        }
                    }
                    catch (Exception)
                    {
                    }

                }

                btnAddProM.Enabled = false;
                btnNewProM.Enabled = true;
                btnDeleteProM.Enabled = true;
                btnDeleteAllProM.Enabled = true;
                btnSaveProM.Enabled = true;
                btnBarcodePrint.Enabled = true;
            }
        }
    
        //search is used ComboBox ==> CbxProM
        private void CbxProM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CbxProM.Items.Count >= 1)
            {

                DataTable dtSearsh = new DataTable();
                dtSearsh.Clear();
                dtSearsh = db.ReadData("select * from Product Where Pro_ID = "+CbxProM.SelectedValue+"", "");

                if (dtSearsh.Rows.Count <= 0)
                {
                }
                else
                {
                    try
                    {
                        //##1
                        txtIdPro.Text = dtSearsh.Rows[0][0].ToString();
                        txtNamePro.Text = dtSearsh.Rows[0][1].ToString();
                        NudTotalQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][2]);
                        NumWholesalePrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][3]);
                        NumVAT.Value = Convert.ToDecimal(dtSearsh.Rows[0][4]);
                        NumRetailPrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][5]);
                        txtPricetax.Text = dtSearsh.Rows[0][6].ToString();
                        txtBarcode.Text = dtSearsh.Rows[0][7].ToString();
                        NudMinQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][8]);
                        NudMaxDiscount.Value = Convert.ToDecimal(dtSearsh.Rows[0][9]);
                        if (dtSearsh.Rows[0][10].ToString() == "Taxable")
                        {
                            CheckboxVAT.Checked = true;
                        }
                        else
                        {
                            CheckboxVAT.Checked = false;
                        }
                        cbxCategory.SelectedValue = dtSearsh.Rows[0][11].ToString();
                        cbxGreatUnits.SelectedValue = dtSearsh.Rows[0][13].ToString();
                        cbxUnitMostSelling.SelectedValue = dtSearsh.Rows[0][15].ToString();
                        cbxUnitMostBuy.SelectedValue = dtSearsh.Rows[0][17].ToString();
                    }
                    catch (Exception)
                    {
                    }
                    //Werehouse
                    try
                    {
                        DataTable dtWerehous = new DataTable();
                        dtWerehous = db.ReadData("select * from Product_Qty where Pro_ID = " + txtIdPro.Text + "", "");
                        DgvWarehouse.Rows.Clear();
                        if (dtWerehous.Rows.Count >= 1)
                        {

                            foreach (DataRow row in dtWerehous.Rows)
                            {
                                DgvWarehouse.Rows.Add(1);
                                int index = DgvWarehouse.Rows.Count - 1;
                                DgvWarehouse.Rows[index].Cells[0].Value = row[2];
                                DgvWarehouse.Rows[index].Cells[1].Value = row[3];
                                DgvWarehouse.Rows[index].Cells[2].Value = row[4];

                            }
                        }

                    }
                    catch (Exception)
                    {
                    }

                    //Unit
                    try
                    {
                        DataTable dtUnit = new DataTable();
                        dtUnit = db.ReadData("select * from Product_Unit where Pro_ID = " + txtIdPro.Text + "", "");
                        DgvUnits.Rows.Clear();
                        if (dtUnit.Rows.Count >= 1)
                        {

                            foreach (DataRow row in dtUnit.Rows)
                            {
                                DgvUnits.Rows.Add(1);
                                int index = DgvUnits.Rows.Count - 1;
                                DgvUnits.Rows[index].Cells[0].Value = row[2];
                                DgvUnits.Rows[index].Cells[1].Value = row[3];
                                DgvUnits.Rows[index].Cells[2].Value = row[4];

                            }
                        }
                    }
                    catch (Exception)
                    {
                    }

                }

                btnAddProM.Enabled = false;
                btnNewProM.Enabled = true;
                btnDeleteProM.Enabled = true;
                btnDeleteAllProM.Enabled = true;
                btnSaveProM.Enabled = true;
                btnBarcodePrint.Enabled = true;
            }
            
        }
        //textbox that only accepts numbers
        private void txtIdProM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBarcodeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NumRetailPrice_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TaxValue = 0, SalePrice = 0, Tax = 0; ;
                SalePrice = NumRetailPrice.Value;
                TaxValue = (SalePrice / 100) * NumVAT.Value;
                Tax = TaxValue + SalePrice;
                if (CheckboxVAT.Checked == true)
                {
                    txtPricetax.Text = (TaxValue + SalePrice).ToString();
                }
                else
                {
                    txtPricetax.Text = SalePrice.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void CheckboxVAT_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckboxVAT.Checked == true)
            {
                NumVAT.Value = 20;
            }
            else
            {
                NumVAT.Value = 0;
            }
        }

        private void NumVAT_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                decimal TaxValue = 0, SalePrice = 0, Tax = 0; ;
                SalePrice = NumRetailPrice.Value;
                TaxValue = (SalePrice / 100) * NumVAT.Value;
                Tax = TaxValue + SalePrice;
                if (CheckboxVAT.Checked == true)
                {
                    txtPricetax.Text = $"{Tax} DH";

                }
                else
                {
                    txtPricetax.Text = $"{SalePrice} DH";
                }
            }
            catch (Exception)
            {
            }
        }
        //BUTTON : Add Warehouse =================================================//
        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            if(cbxWarehouseName.Items.Count >= 1)
            {
                if(NumQuantityWarehouse.Value <= 0 || NumBuyPrice.Value <= 0)
                {
                    MessageBox.Show("Please enter the quantity and Buy price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ;
                }

               

                DgvWarehouse.Rows.Add(1);
                int index = DgvWarehouse.Rows.Count - 1;
                DgvWarehouse.Rows[index].Cells[0].Value = cbxWarehouseName.Text;
                DgvWarehouse.Rows[index].Cells[1].Value = NumQuantityWarehouse.Value;
                DgvWarehouse.Rows[index].Cells[2].Value = NumBuyPrice.Value;

                decimal total = 0;

                for (int i = 0; i <= DgvWarehouse.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(DgvWarehouse.Rows[i].Cells[1].Value);
                }
                NudTotalQuantity.Value = total; 

            }
        }
        //BUTTON : Delete WareHouse ======================================//
        private void btnDeleteWarehouse_Click(object sender, EventArgs e)
        {
            if(DgvWarehouse.Rows.Count >= 1)
            {
                DgvWarehouse.Rows.RemoveAt(DgvWarehouse.CurrentCell.RowIndex);
                decimal total = 0;
                for (int i = 0; i <= DgvWarehouse.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(DgvWarehouse.Rows[i].Cells[1].Value);
                }
                NudTotalQuantity.Value = total;
            }
        }
        //BUTTON : Add Unit  ========================================//
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (cbxUnitName.Items.Count >= 1)
            {
                if (NumPieces.Value <= 0 || NumUnitPrice.Value <= 0)
                {
                    MessageBox.Show("Please enter the Pieces and Unit price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(cbxUnitName.SelectedValue) == Convert.ToInt32(cbxGreatUnits.SelectedValue))
                {
                    MessageBox.Show("It is not possible to choose a small unit like a large unit", "Check the units", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string UnitName = cbxUnitName.Text;
                for (int i = 0; i <= DgvUnits.Rows.Count - 1; i++)
                {
                    if (UnitName ==( DgvUnits.Rows[i].Cells[0].Value).ToString() )
                    {
                        MessageBox.Show("This unit has already been added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DgvUnits.Rows.Add(1);
                int index = DgvUnits.Rows.Count - 1;
                DgvUnits.Rows[index].Cells[0].Value = cbxUnitName.Text;
                DgvUnits.Rows[index].Cells[1].Value = NumPieces.Value;
                DgvUnits.Rows[index].Cells[2].Value =  NumUnitPrice.Value;
            }
        }
        //BUTTON :  Remove Unit ==================================//
        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (DgvUnits.Rows.Count >= 1)
            {
                DgvUnits.Rows.RemoveAt(DgvUnits.CurrentCell.RowIndex);
            }
        }

        private void NumPieces_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NumUnitPrice.Value = Convert.ToDecimal(txtPricetax.Text) / NumPieces.Value;
            }
            catch (Exception)
            {

            }
        }

        private void txtSearchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSearchBarcode.Text != "")
                {

                    DataTable dtSearsh = new DataTable();
                    dtSearsh.Clear();
                    dtSearsh = db.ReadData("select * from Product Where Pro_BarCode = N'" + txtSearchBarcode.Text + "'", "");

                    if (dtSearsh.Rows.Count <= 0)
                    {

                    }
                    else
                    {
                        try
                        {
                            //##1
                            txtIdPro.Text = dtSearsh.Rows[0][0].ToString();
                            txtNamePro.Text = dtSearsh.Rows[0][1].ToString();
                            NudTotalQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][2]);
                            NumWholesalePrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][3]);
                            NumVAT.Value = Convert.ToDecimal(dtSearsh.Rows[0][4]);
                            NumRetailPrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][5]);
                            txtPricetax.Text = dtSearsh.Rows[0][6].ToString();
                            txtBarcode.Text = dtSearsh.Rows[0][7].ToString();
                            NudMinQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][8]);
                            NudMaxDiscount.Value = Convert.ToDecimal(dtSearsh.Rows[0][9]);
                            if (dtSearsh.Rows[0][10].ToString() == "Taxable")
                            {
                                CheckboxVAT.Checked = true;
                            }
                            else
                            {
                                CheckboxVAT.Checked = false;
                            }
                            cbxCategory.SelectedValue = dtSearsh.Rows[0][11].ToString();
                            cbxGreatUnits.SelectedValue = dtSearsh.Rows[0][13].ToString();
                            cbxUnitMostSelling.SelectedValue = dtSearsh.Rows[0][15].ToString();
                            cbxUnitMostBuy.SelectedValue = dtSearsh.Rows[0][17].ToString();
                        }
                        catch (Exception)
                        {
                        }
                        //Werehouse
                        try
                        {
                            DataTable dtWerehous = new DataTable();
                            dtWerehous = db.ReadData("select * from Product_Qty where Pro_ID = " + txtIdPro.Text + "", "");
                            DgvWarehouse.Rows.Clear();
                            if (dtWerehous.Rows.Count >= 1)
                            {

                                foreach (DataRow row in dtWerehous.Rows)
                                {
                                    DgvWarehouse.Rows.Add(1);
                                    int index = DgvWarehouse.Rows.Count - 1;
                                    DgvWarehouse.Rows[index].Cells[0].Value = row[2];
                                    DgvWarehouse.Rows[index].Cells[1].Value = row[3];
                                    DgvWarehouse.Rows[index].Cells[2].Value = row[4];

                                }
                            }

                        }
                        catch (Exception)
                        {
                        }

                        //Unit
                        try
                        {
                            DataTable dtUnit = new DataTable();
                            dtUnit = db.ReadData("select * from Product_Unit where Pro_ID = " + txtIdPro.Text + "", "");
                            DgvUnits.Rows.Clear();
                            if (dtUnit.Rows.Count >= 1)
                            {

                                foreach (DataRow row in dtUnit.Rows)
                                {
                                    DgvUnits.Rows.Add(1);
                                    int index = DgvUnits.Rows.Count - 1;
                                    DgvUnits.Rows[index].Cells[0].Value = row[2];
                                    DgvUnits.Rows[index].Cells[1].Value = row[3];
                                    DgvUnits.Rows[index].Cells[2].Value = row[4];

                                }
                            }
                        }
                        catch (Exception)
                        {
                        }

                    }

                    btnAddProM.Enabled = false;
                    btnNewProM.Enabled = true;
                    btnDeleteProM.Enabled = true;
                    btnDeleteAllProM.Enabled = true;
                    btnSaveProM.Enabled = true;
                    btnBarcodePrint.Enabled = true;
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSearch.Text != "")
                {

                    DataTable dtSearsh = new DataTable();
                    dtSearsh.Clear();
                    dtSearsh = db.ReadData("select * from Product Where Pro_Name like N'%"+txtSearch.Text+"%'", "");

                    if (dtSearsh.Rows.Count <= 0)
                    {

                    }
                    else
                    {
                        try
                        {
                            //##1
                            txtIdPro.Text = dtSearsh.Rows[0][0].ToString();
                            txtNamePro.Text = dtSearsh.Rows[0][1].ToString();
                            NudTotalQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][2]);
                            NumWholesalePrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][3]);
                            NumVAT.Value = Convert.ToDecimal(dtSearsh.Rows[0][4]);
                            NumRetailPrice.Value = Convert.ToDecimal(dtSearsh.Rows[0][5]);
                            txtPricetax.Text = dtSearsh.Rows[0][6].ToString();
                            txtBarcode.Text = dtSearsh.Rows[0][7].ToString();
                            NudMinQuantity.Value = Convert.ToDecimal(dtSearsh.Rows[0][8]);
                            NudMaxDiscount.Value = Convert.ToDecimal(dtSearsh.Rows[0][9]);
                            if (dtSearsh.Rows[0][10].ToString() == "Taxable")
                            {
                                CheckboxVAT.Checked = true;
                            }
                            else
                            {
                                CheckboxVAT.Checked = false;
                            }
                            cbxCategory.SelectedValue = dtSearsh.Rows[0][11].ToString();
                            cbxGreatUnits.SelectedValue = dtSearsh.Rows[0][13].ToString();
                            cbxUnitMostSelling.SelectedValue = dtSearsh.Rows[0][15].ToString();
                            cbxUnitMostBuy.SelectedValue = dtSearsh.Rows[0][17].ToString();
                        }
                        catch (Exception)
                        {
                        }
                        //Werehouse
                        try
                        {
                            DataTable dtWerehous = new DataTable();
                            dtWerehous = db.ReadData("select * from Product_Qty where Pro_ID = " + txtIdPro.Text + "", "");
                            DgvWarehouse.Rows.Clear();
                            if (dtWerehous.Rows.Count >= 1)
                            {

                                foreach (DataRow row in dtWerehous.Rows)
                                {
                                    DgvWarehouse.Rows.Add(1);
                                    int index = DgvWarehouse.Rows.Count - 1;
                                    DgvWarehouse.Rows[index].Cells[0].Value = row[2];
                                    DgvWarehouse.Rows[index].Cells[1].Value = row[3];
                                    DgvWarehouse.Rows[index].Cells[2].Value = row[4];

                                }
                            }

                        }
                        catch (Exception)
                        {
                        }

                        //Unit
                        try
                        {
                            DataTable dtUnit = new DataTable();
                            dtUnit = db.ReadData("select * from Product_Unit where Pro_ID = " + txtIdPro.Text + "", "");
                            DgvUnits.Rows.Clear();
                            if (dtUnit.Rows.Count >= 1)
                            {

                                foreach (DataRow row in dtUnit.Rows)
                                {
                                    DgvUnits.Rows.Add(1);
                                    int index = DgvUnits.Rows.Count - 1;
                                    DgvUnits.Rows[index].Cells[0].Value = row[2];
                                    DgvUnits.Rows[index].Cells[1].Value = row[3];
                                    DgvUnits.Rows[index].Cells[2].Value = row[4];

                                }
                            }
                        }
                        catch (Exception)
                        {
                        }

                    }

                    btnAddProM.Enabled = false;
                    btnNewProM.Enabled = true;
                    btnDeleteProM.Enabled = true;
                    btnDeleteAllProM.Enabled = true;
                    btnSaveProM.Enabled = true;
                    btnBarcodePrint.Enabled = true;
                }
            }
        }
        //FORM : Print Barcode
        private void btnBarcodePrint_Click(object sender, EventArgs e)
        {

            try
            {
                Properties.Settings.Default.Pro_Name = txtNamePro.Text;
                Properties.Settings.Default.Pro_Price = Convert.ToDecimal(txtPricetax.Text);
                Properties.Settings.Default.Pro_BarCode = txtBarcode.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {

            }
            FrmPrintBarcode frmPrintBarcode = new FrmPrintBarcode();
            frmPrintBarcode.ShowDialog();
            txtBarcode.Text = Properties.Settings.Default.Pro_BarCode;

        }
    }
}
