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
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.IO;

namespace SalesMangement
{
    public partial class FrmGeneralSettings : MaterialForm
    {
        public FrmGeneralSettings()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        //A function to convert an image into a Byte and in a database
        private void SaveImage(string stmt, string ParameterName, string Message)
        {
            //connection to database
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-K0R8A28U;Initial Catalog=Sales_System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(stmt, conn);
            //Convert image to byte
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            Byte[] bytes = new Byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();
            //=============================
            SqlParameter sqlParameter = new SqlParameter(ParameterName, SqlDbType.VarBinary, bytes.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytes);
            cmd.Parameters.Add(sqlParameter);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            if (Message != string.Empty)
            {
                MessageBox.Show(Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Call Show data in DB
        private void ShowOrderData()
        {

            dt.Clear();
            dt = db.ReadData("Select * from InvoiceSettings ", "");
            if(dt.Rows.Count >= 1)
            {
                txtStoreName.Text = dt.Rows[0][1].ToString();
                txtStoreAddress.Text = dt.Rows[0][2].ToString();
                txtInvoiceNote.Text = dt.Rows[0][3].ToString();
                txtPhoneNumber1.Text = dt.Rows[0][4].ToString();
                txtPhoneNumber2.Text = dt.Rows[0][5].ToString();
            }

            try
            {
                //retrive Image
                Byte[] bytes = new Byte[0]; 
                bytes = (Byte[]) (dt.Rows[0][0]);
                pictureLogo.BackgroundImageLayout = ImageLayout.Zoom;
                MemoryStream memoryStream = new MemoryStream(bytes);
                pictureLogo.BackgroundImage = Image.FromStream(memoryStream);

            }
            catch (Exception)
            {
            }


        }
        //show Name Prints in comb
        private void ShowPrint()
        {
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrintName = PrinterSettings.InstalledPrinters[i];
                cbxMainPrinter.Items.Add(PrintName);

            }
            if (Properties.Settings.Default.PrintName == String.Empty)
                cbxMainPrinter.SelectedIndex = 3;
            else
                cbxMainPrinter.Text = Properties.Settings.Default.PrintName;
        }
        //Call Show General Settings
        private void ShowGeneralSettings()
        {
            if (Properties.Settings.Default.ItemsDiscount == "Value" )
            {
                RadioBtnValueMoney.Checked = true;

            }
            else if (Properties.Settings.Default.ItemsDiscount == "Percentage")
            {
                RadioBtnPercentage.Checked = true;
            }
            //=================================
            NumNumberCopiesSales.Value = Properties.Settings.Default.SalesPrintNum;

            NumNumberCopiesPurchase.Value = Properties.Settings.Default.BuyPrintNum;
        
            //===================================

            if (Properties.Settings.Default.ActivateTaxes == true)
                CheckboxActivateTax.Checked = true;
            else
                CheckboxActivateTax.Checked = false;
            if (Properties.Settings.Default.ActivateDiscountEmp == true )
                CheckboxActivateDiscountEmp.Checked = true;
            else
                CheckboxActivateDiscountEmp.Checked = false;
            if (Properties.Settings.Default.ActivatePrintSales == true )
                CheckboxActivatePrintSales.Checked = true;
            else
                CheckboxActivatePrintSales.Checked  = false;
            if (Properties.Settings.Default.ActivatePrintBuy == true )
                CheckboxActivatePrintBuy.Checked =true;
            else
                CheckboxActivatePrintBuy.Checked = false;

            if (Properties.Settings.Default.PrintSalesKind == "8CM" )
            {
                RadioButtonPrintS8c.Checked = true;
            }
            else if (Properties.Settings.Default.PrintSalesKind == "A4" )
            {
                RadioButtonPrintSA4.Checked = true;
            }
            if (Properties.Settings.Default.PrintBuyKind == "8CM" )
            {
                RadioButtonPrintP8c.Checked = true;
            }
            else if (Properties.Settings.Default.PrintBuyKind== "A4")
            {
                RadioButtonPrintPA4.Checked = true;
            }
        }
        string PrintName = "";
        private void FrmGeneralSettings_Load(object sender, EventArgs e)
        {
            try
            {
                ShowPrint();
                ShowOrderData();
                ShowGeneralSettings();
            }
            catch (Exception)
            {
            }

        }
        //BUTTON : Save Main Print 
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (cbxMainPrinter.Text == "")
            {
                MessageBox.Show("Please check the printer information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Properties.Settings.Default.PrintName = cbxMainPrinter.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        //BUTTON : Upload Photo
        string imagePath = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*) | *.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureLogo.Image = null;
                pictureLogo.ImageLocation = imagePath;
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            pictureLogo.BackgroundImage = null;
            pictureLogo.Image = null;
            imagePath = "";
        }
        //BUTTON : Save Data 
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (imagePath == "")
            {
                {
                    MessageBox.Show("Please enter the store logo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dt.Clear();
            dt = db.ReadData("Select * from InvoiceSettings ", "");
            if(dt.Rows.Count >= 1)
            {
                //Call Function to save image 
                SaveImage("Update InvoiceSettings Set Logo = @Logo, StoreName = N' " + txtStoreName.Text + "', StoreAddress = N'" + txtStoreAddress.Text + "', InvoiceNote = N'" + txtInvoiceNote.Text + "', PhoneNumber1 = N'" + txtPhoneNumber1.Text + "', PhoneNumber2 = N'" + txtPhoneNumber2.Text + "'", "@Logo", "Data saved successfully");

            }
            else
            {
                SaveImage("insert into  InvoiceSettings Values (@Logo,  N' " + txtStoreName.Text + "', N'" + txtStoreAddress.Text + "',  N'" + txtInvoiceNote.Text + "', N'" + txtPhoneNumber1.Text + "',  N'" + txtPhoneNumber2.Text + "')", "@Logo", "Data saved successfully");

            }
           
            imagePath = "";
        }

        private void btnSaveOption_Click(object sender, EventArgs e)
        {
            if(NumNumberCopiesSales.Value < 1 || NumNumberCopiesPurchase.Value < 1)
            {
                MessageBox.Show("The number of printed invoices must be 1 or more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          

            if(RadioBtnValueMoney.Checked)
            {
                Properties.Settings.Default.ItemsDiscount = "Value";

            }
            else if(RadioBtnPercentage.Checked)
            {
                Properties.Settings.Default.ItemsDiscount = "Percentage";
            }

            Properties.Settings.Default.SalesPrintNum = Convert.ToInt32(  NumNumberCopiesSales.Value);

            Properties.Settings.Default.BuyPrintNum = Convert.ToInt32(NumNumberCopiesPurchase.Value);

            if (CheckboxActivateTax.Checked)
                Properties.Settings.Default.ActivateTaxes = true;
            else
                Properties.Settings.Default.ActivateTaxes = false;
            if (CheckboxActivateDiscountEmp.Checked)
                Properties.Settings.Default.ActivateDiscountEmp = true;
            else
                Properties.Settings.Default.ActivateDiscountEmp = false;
            if (CheckboxActivatePrintSales.Checked)
                Properties.Settings.Default.ActivatePrintSales = true;
            else
                Properties.Settings.Default.ActivatePrintSales = false;
            if (CheckboxActivatePrintBuy.Checked)
                Properties.Settings.Default.ActivatePrintBuy = true;
            else
                Properties.Settings.Default.ActivatePrintBuy =false;

            if(RadioButtonPrintS8c.Checked)
            {
                Properties.Settings.Default.PrintSalesKind = "8CM";
            }
            else if (RadioButtonPrintSA4.Checked)
            {
                Properties.Settings.Default.PrintSalesKind = "A4";
            }
            if(RadioButtonPrintP8c.Checked)
            {
                Properties.Settings.Default.PrintBuyKind = "8CM";
            }
            else if(RadioButtonPrintPA4.Checked)
            {
                Properties.Settings.Default.PrintBuyKind = "A4";
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
