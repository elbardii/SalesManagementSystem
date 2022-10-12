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
    public partial class FrmPrintBarcode : MaterialForm
    {
        public FrmPrintBarcode()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        private void FillPro()
        {
            cbxChooseProduct.DataSource = db.ReadData("select * from Product", "");
            cbxChooseProduct.DisplayMember = "Pro_Name";
            cbxChooseProduct.ValueMember = "Pro_Id";
        }

        private void FrmPrintBarcode_Load(object sender, EventArgs e)
        {
            txtNamePro.Text = Properties.Settings.Default.Pro_Name;
            txtPrice.Text = Convert.ToString( Properties.Settings.Default.Pro_Price);
            txtBarcode.Text = Properties.Settings.Default.Pro_BarCode;
            FillPro();
        }

        private void btnRandomBarcode_Click(object sender, EventArgs e)
        {
            dt = db.ReadData("select * from Random_BarCode ", "");
            if(dt.Rows.Count <= 0)
            {
                txtBarcode.Text = "1000000";
                db.ExecuteData("insert into Random_BarCode Values (1000000) ", "");

            }
            else
            {
                txtBarcode.Text =(Convert.ToInt32(dt.Rows[0][0])+ 1).ToString() ;
                db.ExecuteData("Update Random_BarCode set BarCode = N'"+txtBarcode.Text+"'", "");
            }
        }
        //SaveBarCode 
        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            dt = db.ReadData("select * from Random_BarCode ", "");
            if (dt.Rows.Count <= 0)
            {
                db.ExecuteData("insert into Random_BarCode Values (N'"+txtBarcode.Text+"') ", "Saved successfully");
            }
            else
            {
                db.ExecuteData("Update Random_BarCode set BarCode = N'" + txtBarcode.Text + "'", "Saved successfully");
            }
        }
        //=============================================================//
        //Choose Product 
        private void cbxChooseProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbxChooseProduct.Items.Count >= 1)
            {
                dt.Clear();
                dt = db.ReadData("select * from Product Where Pro_ID = "+cbxChooseProduct.SelectedValue+"", "");
                if(dt.Rows.Count >= 1)
                {
                    txtBarcode.Text = dt.Rows[0][8].ToString();
                    txtNamePro.Text = dt.Rows[0][1].ToString();
                    txtPrice.Text  = dt.Rows[0][5].ToString();

                }
            }
        }

        private void btnPrintDesignated_Click(object sender, EventArgs e)
        {
            if(txtBarcode.Text == "" || txtNamePro.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please enter all data", "confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DataSetBarCode ds = new DataSetBarCode();
            ds.Clear();
            RptBarCodePrint rptBarCodePrint = new RptBarCodePrint();

            ds.Tables["PrintBarCode"].Rows.Add(txtNamePro.Text, txtPrice.Text, "*"+txtBarcode.Text.Trim()+ "*", txtBarcode.Text);
            rptBarCodePrint.SetDataSource(ds);



            FrmPrinting frmPrinting = new FrmPrinting();

            frmPrinting.crystalReportViewer.ReportSource = rptBarCodePrint;
            frmPrinting.crystalReportViewer.Refresh();
            frmPrinting.ShowDialog();
            txtBarcode.Text = Properties.Settings.Default.Pro_BarCode = txtBarcode.Text;
            Properties.Settings.Default.Save();
            db.ExecuteData("Update Product set Pro_BarCode = "+txtBarcode.Text+ " Where Pro_Name = N'"+txtNamePro.Text+"'", "");

        }

        private void btnBarcodePrint_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || txtNamePro.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please enter all data", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataSetBarCode ds = new DataSetBarCode();
            ds.Clear();
            RptBarCodePrint rptBarCodePrint = new RptBarCodePrint();

            ds.Tables["PrintBarCode"].Rows.Add(txtNamePro.Text, txtPrice.Text, "*" + txtBarcode.Text.Trim() + "*", txtBarcode.Text);
            rptBarCodePrint.SetDataSource(ds);
            FrmPrinting frmPrinting = new FrmPrinting();
            frmPrinting.crystalReportViewer.ReportSource = rptBarCodePrint;
            frmPrinting.crystalReportViewer.Refresh();
            //frmPrinting.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            rptBarCodePrint.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            rptBarCodePrint.PrintToPrinter(1, true, 0, 0);
            txtBarcode.Text = Properties.Settings.Default.Pro_BarCode = txtBarcode.Text;
            Properties.Settings.Default.Save();
            db.ExecuteData("Update Product set Pro_BarCode = " + txtBarcode.Text + " Where Pro_Name = N'" + txtNamePro.Text + "'", "");

        }
    }
}
