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
    public partial class FrmEditSales : MaterialForm
    {
        public FrmEditSales()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        Database db = new Database();
        //Form Load
        private void FrmEditSales_Load(object sender, EventArgs e)
        {
            txtQuantity.Focus();
            txtDiscount.Text = (Properties.Settings.Default.item_Discount).ToString();

            try
            {
                CbxItemsUnit.DataSource = db.ReadData("select * from Product_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + "", "");
                CbxItemsUnit.DisplayMember = "Unit_Name";
                CbxItemsUnit.ValueMember = "Unit_ID";
            }
            catch (Exception) { }

            CbxItemsUnit.Text = Properties.Settings.Default.Pro_Unit;
            txtSalesPrice.Text = (Properties.Settings.Default.item_SalesPrice).ToString();
            txtQuantity.Text = (Properties.Settings.Default.item_Quantity).ToString();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSalesPrice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Sales Price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiscount.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Discount ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Properties.Settings.Default.ActivateDiscountEmp == true)
            {

                try
                {
                    if (Properties.Settings.Default.ItemsDiscount == "Value")
                    {
                        Properties.Settings.Default.item_Discount = Convert.ToDecimal(txtDiscount.Text);
                        Properties.Settings.Default.Save();
                    }
                    else if (Properties.Settings.Default.ItemsDiscount == "Percentage")
                    {
                        decimal PercentageValue = 0;
                        PercentageValue = (Convert.ToDecimal(txtSalesPrice.Text) / 100) * Convert.ToDecimal(txtDiscount.Text);
                        Properties.Settings.Default.item_Discount = Convert.ToDecimal(PercentageValue);
                        Properties.Settings.Default.Save();

                    }
                }

                catch (Exception)
                {

                }
            }
            else
            {
                if(Convert.ToDecimal( txtDiscount.Text) >= 1)
                {
                    MessageBox.Show("You are not allowed to make a discount on a product", "Warning", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                    txtDiscount.Text = "0";
                    return;
                }
            }
            Properties.Settings.Default.Pro_Unit = Convert.ToString(CbxItemsUnit.Text);
            Properties.Settings.Default.item_Quantity = Convert.ToDecimal(txtQuantity.Text);
            Properties.Settings.Default.item_SalesPrice = Convert.ToDecimal(txtSalesPrice.Text);
            if(CheckboxVisa.Checked == true)
            {
                Properties.Settings.Default.Pay_Visa = true;
            }
            else
            {
                Properties.Settings.Default.Pay_Visa = false;
            }


            Properties.Settings.Default.Save();
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEditSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtSalesPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Sales Price ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //!TextBox Unit 
                //if(txtUnit.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Enter Unit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (txtDiscount.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Discount ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                if (Properties.Settings.Default.ActivateDiscountEmp == true)
                {

                    try
                    {
                        if (Properties.Settings.Default.ItemsDiscount == "Value")
                        {
                            Properties.Settings.Default.item_Discount = Convert.ToDecimal(txtDiscount.Text);
                            Properties.Settings.Default.Save();
                        }
                        else if (Properties.Settings.Default.ItemsDiscount == "Percentage")
                        {
                            decimal PercentageValue = 0;
                            PercentageValue = (Convert.ToDecimal(txtSalesPrice.Text) / 100) * Convert.ToDecimal(txtDiscount.Text);
                            Properties.Settings.Default.item_Discount = Convert.ToDecimal(PercentageValue);
                            Properties.Settings.Default.Save();

                        }
                    }

                    catch (Exception)
                    {

                    }
                }
                else
                {
                    if (Convert.ToDecimal(txtDiscount.Text) >= 1)
                    {
                        MessageBox.Show("You are not allowed to make a discount on a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDiscount.Text = "0";
                        return;
                    }
                }
                Properties.Settings.Default.item_Unit = Convert.ToString(CbxItemsUnit.Text);
                Properties.Settings.Default.item_Quantity = Convert.ToDecimal(txtQuantity.Text);
                Properties.Settings.Default.item_SalesPrice = Convert.ToDecimal(txtSalesPrice.Text);

                if (CheckboxVisa.Checked == true)
                {
                    Properties.Settings.Default.Pay_Visa = true;
                }
                else
                {
                    Properties.Settings.Default.Pay_Visa = false;
                }
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void FrmEditSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int index = FrmSalesManagement.GetFrmSalesManagement.DgvSales.SelectedRows[0].Index;
                FrmSalesManagement.GetFrmSalesManagement.DgvSales.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Quantity;
                FrmSalesManagement.GetFrmSalesManagement.DgvSales.Rows[index].Cells[4].Value = Properties.Settings.Default.item_SalesPrice;
                FrmSalesManagement.GetFrmSalesManagement.DgvSales.Rows[index].Cells[5].Value = Properties.Settings.Default.item_Discount;
                FrmSalesManagement.GetFrmSalesManagement.DgvSales.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_Unit;
            }
            catch (Exception)
            {

            }
        }

        private void CbxItemsUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tblItems = new DataTable();
            tblItems.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            try
            {

                tblunit = db.ReadData("select * from Product_Unit where Pro_ID=" + Properties.Settings.Default.Pro_ID + " and Unit_ID=" + CbxItemsUnit.SelectedValue + "", "");
                decimal realPrice = 0;
                try
                {
                    realPrice = Convert.ToDecimal(tblunit.Rows[0][5]) / Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }
                txtSalesPrice.Text = Math.Round(realPrice, 2) + "";
            }
            catch (Exception) { }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
