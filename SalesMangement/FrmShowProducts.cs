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
    public partial class FrmShowProducts : MaterialForm
    {
        public FrmShowProducts()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        private void FillCategory()
        {
            cbxCategory.DataSource = db.ReadData("select * from Category", "");
            cbxCategory.DisplayMember = "Group_Name";
            cbxCategory.ValueMember = "Group_ID";

        }

        private void show()
        {
            dt.Clear();
            dt = db.ReadData("SELECT Pro_Id as 'Number',Pro_Name as ' Name',Main_UnitName as 'Main Unit',Pro_Quantity as 'Quantity',Wholesale_Price as 'Wholesale Price',[Tax_Value] as 'TAX Value',[Sale_price] as 'Price',[Sale_PriceTax] as 'Price After Tax',[Pro_BarCode] as 'BarCode',[Sale_UnitName] as 'Sale Unit',[Buy_UnitName] as 'Buy Unit ',[MinQuantity] as 'Quantity Alert',[MaxDiscount] as 'Discount',[Is_Tax] as 'Taxable',Category.Group_Name as 'Category' FROM [dbo].[Product], Category Where  Category.Group_ID = [Product].Group_ID ", "");
            DgvShowPro.DataSource = dt;
        }

        private void ShowTotal()
        {
            decimal TotalQuantity = 0 , TotalWholesale = 0, TotalRetail = 0, TotalTax = 0;
            for (int i = 0; i <= DgvShowPro.Rows.Count - 1; i++)
            {
                TotalQuantity += Convert.ToDecimal(DgvShowPro.Rows[i].Cells[3].Value);
                TotalWholesale += Convert.ToDecimal(DgvShowPro.Rows[i].Cells[3].Value) * Convert.ToDecimal(DgvShowPro.Rows[i].Cells[4].Value);
                TotalRetail += Convert.ToDecimal(DgvShowPro.Rows[i].Cells[3].Value) * Convert.ToDecimal(DgvShowPro.Rows[i].Cells[5].Value);
                TotalTax += Convert.ToDecimal(DgvShowPro.Rows[i].Cells[3].Value) * Convert.ToDecimal(DgvShowPro.Rows[i].Cells[7].Value);

            }
            txtTotalQuantity.Text = Math.Round(TotalQuantity, 2).ToString();
            txtTotalWholesale.Text = Math.Round(TotalWholesale, 2).ToString();
            txtTotalRetail.Text = Math.Round(TotalRetail, 2).ToString();
            txtTotalSaleTax.Text = Math.Round(TotalTax, 2).ToString();


        }
        private void FrmShowProducts_Load(object sender, EventArgs e)
        {
            FillCategory();
            show();
            ShowTotal();
        }
        //BUTTON : Searsh Category
        private void btnSearshCategory_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("SELECT [Pro_Id] as 'Number',[Pro_Name] as ' Name',[Main_UnitName] as 'Main Unit',[Pro_Quantity] as 'Quantity',Wholesale_Price as 'Wholesale Price',[Tax_Value] as 'TAX Value',[Sale_price] as 'Price',[Sale_PriceTax] as 'Price After Tax',[Pro_BarCode] as 'BarCode',[Sale_UnitName] as 'Sale Unit',[Buy_UnitName] as 'Buy Unit ',[MinQuantity] as 'Quantity Alert',[MaxDiscount] as 'Discount',[Is_Tax] as 'Taxable',Category.Group_Name as 'Category' FROM [dbo].[Product], Category Where  Category.Group_ID = [Product].Group_ID and [Product].Group_ID = " + cbxCategory.SelectedValue+" ", "");
            DgvShowPro.DataSource = dt;
            ShowTotal();
        }
        //BUTTON : Searsh Pro Name
        private void btnSearshProName_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("SELECT [Pro_Id] as 'Number',[Pro_Name] as ' Name',[Main_UnitName] as 'Main Unit',[Pro_Quantity] as 'Quantity',Wholesale_Price as 'Wholesale Price',[Tax_Value] as 'TAX Value',[Sale_price] as 'Price',[Sale_PriceTax] as 'Price After Tax',[Pro_BarCode] as 'BarCode',[Sale_UnitName] as 'Sale Unit',[Buy_UnitName] as 'Buy Unit ',[MinQuantity] as 'Quantity Alert',[MaxDiscount] as 'Discount',[Is_Tax] as 'Taxable',Category.Group_Name as 'Category' FROM [dbo].[Product], Category Where  Category.Group_ID = [Product].Group_ID and [Product].Pro_Name like N'%"+txtNamePro.Text+"%' ", "");
            DgvShowPro.DataSource = dt;
            ShowTotal();
        }

        private void btnSearshBarcode_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("SELECT [Pro_Id] as 'Number',[Pro_Name] as ' Name',[Main_UnitName] as 'Main Unit',[Pro_Quantity] as 'Quantity',Wholesale_Price as 'Wholesale Price',[Tax_Value] as 'TAX Value',[Sale_price] as 'Price',[Sale_PriceTax] as 'Price After Tax',[Pro_BarCode] as 'BarCode',[Sale_UnitName] as 'Sale Unit',[Buy_UnitName] as 'Buy Unit ',[MinQuantity] as 'Quantity Alert',[MaxDiscount] as 'Discount',[Is_Tax] as 'Taxable',Category.Group_Name as 'Category' FROM [dbo].[Product], Category Where  Category.Group_ID = [Product].Group_ID and [Product].Pro_BarCode = N'" + txtBarcode.Text + "' ", "");
            DgvShowPro.DataSource = dt;
            ShowTotal();
        }
    }
}
