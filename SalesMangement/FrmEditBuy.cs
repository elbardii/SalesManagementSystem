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
    public partial class FrmEditBuy : MaterialForm
    {
        public FrmEditBuy()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        Database db = new Database();
        private void FrmEditBuy_Load(object sender, EventArgs e)
        {
          
            txtDiscount.Text = (Properties.Settings.Default.item_Discount).ToString();
            txtBuyPrice.Text = (Properties.Settings.Default.item_BuyPrice).ToString();
            txtQuantity.Text = (Properties.Settings.Default.item_Quantity).ToString();
            try
            {
                CbxItemsUnit.DataSource = db.ReadData("select * from Product_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "");
                CbxItemsUnit.DisplayMember = "Unit_Name";
                CbxItemsUnit.ValueMember = "Unit_ID";
            }
            catch (Exception) { }

            CbxItemsUnit.Text = (Properties.Settings.Default.Pro_Unit).ToString();
            txtQuantity.Focus();


        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txtBuyPrice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Buy Price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //!TextBox Unit 
            //if(txtUnit.Text == string.Empty)
            //{
            //    MessageBox.Show("Please Enter Unit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if(txtDiscount.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Discount ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Properties.Settings.Default.item_Discount = Convert.ToDecimal(txtDiscount.Text);
            Properties.Settings.Default.Pro_Unit = Convert.ToString(CbxItemsUnit.Text);
            Properties.Settings.Default.item_Quantity = Convert.ToDecimal(txtQuantity.Text);
            Properties.Settings.Default.item_BuyPrice = Convert.ToDecimal(txtBuyPrice.Text);
            Properties.Settings.Default.Save();
            Close();

        }

        private void FrmEditBuy_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtBuyPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Buy Price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Text Box Unit 
                //if (txtUnit.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Enter Unit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (txtDiscount.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Discount ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Properties.Settings.Default.item_Discount = Convert.ToDecimal(txtDiscount.Text);
                Properties.Settings.Default.Pro_Unit =Convert.ToString(CbxItemsUnit.Text);
                Properties.Settings.Default.item_Quantity = Convert.ToDecimal(txtQuantity.Text);
                Properties.Settings.Default.item_BuyPrice = Convert.ToDecimal(txtBuyPrice.Text);
                Properties.Settings.Default.Save();
                Close();

            }
        }

        private void FrmEditBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int index = FrmBuy.GetFormBuy.Dgvbuy.SelectedRows[0].Index;
                FrmBuy.GetFormBuy.Dgvbuy.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Quantity;
                FrmBuy.GetFormBuy.Dgvbuy.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
                FrmBuy.GetFormBuy.Dgvbuy.Rows[index].Cells[4].Value = Properties.Settings.Default.item_BuyPrice;
                FrmBuy.GetFormBuy.Dgvbuy.Rows[index].Cells[5].Value = Properties.Settings.Default.item_Discount;

            }
            catch (Exception)
            {

                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //textbox that only accepts numbers
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //textbox that only accepts numbers
        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //textbox that only accepts numbers
        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //textbox that only accepts numbers
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CbxItemsUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tblItems = new DataTable();
            tblItems.Clear();
            DataTable tblPrice = new DataTable();
            tblPrice.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            try
            {
                int countQty = 0;
                try
                {
                    countQty = Convert.ToInt32(db.ReadData("select sum (Pro_ID) from Product_Qty where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "").Rows[0][0]);
                }
                catch (Exception) { }


                tblPrice = db.ReadData("select * from Product_Qty where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "");
                string Product_Price = tblPrice.Rows[countQty - 1][4].ToString();

                tblunit = db.ReadData("select * from Product_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + " and Unit_ID=" + CbxItemsUnit.SelectedValue + "", "");
                decimal realPrice = 0;
                try
                {
                    realPrice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }
                txtBuyPrice.Text = Math.Round(realPrice, 2) + "";
            }
            catch (Exception) { }
        }
    }
}
    

