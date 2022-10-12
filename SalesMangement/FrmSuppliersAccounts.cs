using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace SalesMangement
{
    public partial class FrmSuppliersAccounts : MaterialForm
    {
        public FrmSuppliersAccounts()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable Tbl = new DataTable();

        private void FillSuppliers()
        {
            CbxSupAc.DataSource = db.ReadData("select * from Suppliers ", "");
            CbxSupAc.DisplayMember = "Sup_Name";
            CbxSupAc.ValueMember = "Sup_ID";
        }
        //PRINT : report pdf
        private void PrintSpSupplier()
        {

            int id = Convert.ToInt32(CbxSupAc.SelectedValue);
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData("SELECT Order_ID as 'Invoice Number ',  Suppliers.Sup_ID as 'Supplier Number ' ,Suppliers.Sup_Name as 'Name Supplier',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Supplier_Money, Suppliers where   Suppliers.Sup_ID =  Supplier_Money.Sup_ID and  Suppliers.Sup_ID = " + id + "", "");
            FrmPrinting Print = new FrmPrinting();
            RptSupplierAccount Rpt = new RptSupplierAccount();
            Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("ID", id);
            Print.crystalReportViewer.ReportSource = Rpt;
            //Print.ShowDialog();
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            Rpt.PrintToPrinter(1, true, 0, 0);

        }
        int Safe_ID = 0;
        private void FrmSuppliersAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                FillSuppliers();
            }
            catch (Exception)
            {
            }    
            CbxSupAc.SelectedIndex = -1;
            DateTimeSup.Text = DateTime.Now.ToString();
            Tbl.Clear();
            Tbl = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Supplier_Money, Suppliers where   Suppliers.Sup_ID =  Supplier_Money.Sup_ID ", "");
            DgvSupAccounts.DataSource = Tbl;
            decimal Total = 0;
            for (int i = 0; i <= DgvSupAccounts.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvSupAccounts.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = Total.ToString();
            Safe_ID = Properties.Settings.Default.Safe_ID;
        }
        
        private void btnSearsh_Click(object sender, EventArgs e)
        {
            Tbl.Clear();  
            if (rbtnAllSup.Checked == true)
            {
                Tbl = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Supplier_Money, Suppliers where   Suppliers.Sup_ID =  Supplier_Money.Sup_ID ", "");

            }

            else if (rbtnSpSup.Checked == true)
            {

                Tbl = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Supplier_Money, Suppliers where   Suppliers.Sup_ID =  Supplier_Money.Sup_ID  and Suppliers.Sup_Name = '" + txtSearsh.Text + "'", "");

            }
            DgvSupAccounts.DataSource = Tbl;
            decimal Total = 0;
            for (int i = 0; i <= DgvSupAccounts.Rows.Count - 1; i++)
            {
                Total += Convert.ToDecimal(DgvSupAccounts.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = Math.Round(Total, 2).ToString();
        }
        private void btnDefinitePay_Click(object sender, EventArgs e)
        {
            if (DgvSupAccounts.Rows.Count >= 1)
            {
                string Date = DateTimeSup.Value.ToString("dd/MM/yyyy");
                decimal Safe_Money = 0;
                Tbl.Clear();
                Tbl = db.ReadData("select * from Stock where Stock_ID=" + Safe_ID + "", "");
                Safe_Money = Convert.ToDecimal(Tbl.Rows[0][1]);
                if (rbtnAllSup.Checked == true)
                {
                    if (Convert.ToDecimal(DgvSupAccounts.CurrentRow.Cells[2].Value) > Safe_Money)
                    {
                        MessageBox.Show("The amount in the safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    if (Convert.ToDecimal(NumPricePayPart.Value) > Safe_Money)
                    {
                        MessageBox.Show("The amount in the safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (rbtnPayFull.Checked == true)
                {
                    if (MessageBox.Show("Are you sure you will pay the full amount?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllSup.Checked == true)
                        {
                            MessageBox.Show("Please Select  Name Of  Supplier", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        db.ExecuteData("delete from Supplier_Money where  Order_ID = " + DgvSupAccounts.CurrentRow.Cells[0].Value + "", "");
                        db.ExecuteData("insert into Supplier_Report  values (" + DgvSupAccounts.CurrentRow.Cells[0].Value + " , " + CbxSupAc.SelectedValue + ", " + DgvSupAccounts.CurrentRow.Cells[2].Value + ", '" + Date + "')", "");
                        FrmSuppliersAccounts_Load(null, null);
                    }

                }

                else if (rbtnPayingPart.Checked == true)
                {
                    if (MessageBox.Show("Are you sure you will pay the full amount?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtnAllSup.Checked == true)
                        {
                            MessageBox.Show("Please Select  Name Of  Supplier", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        decimal Money = Convert.ToDecimal(DgvSupAccounts.CurrentRow.Cells[2].Value) - Convert.ToDecimal(NumPricePayPart.Value);
                        db.ExecuteData("Update Supplier_Money set Rest_Price = " + Money + " where Order_ID = " + DgvSupAccounts.CurrentRow.Cells[0].Value + " and Rest_Price = " + DgvSupAccounts.CurrentRow.Cells[2].Value + "", "");
                        db.ExecuteData("insert into Supplier_Report  values (" + DgvSupAccounts.CurrentRow.Cells[0].Value + " , " + CbxSupAc.SelectedValue + ", " + NumPricePayPart.Value + ", '" + Date + "')", "Payment has been made successfully");
                        FrmSuppliersAccounts_Load(null, null);
                    }
                }
                if (rbtnAllSup.Checked == true)
                {
                    db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) values (" + Safe_ID + " ," + DgvSupAccounts.CurrentRow.Cells[2].Value + " ,N'" + Date + "' ,N'" + Properties.Settings.Default.UserName + "' ,N'Dues to suppliers', N'') ", "");
                    db.ExecuteData("update stock set Safe_Money = Safe_Money - " + DgvSupAccounts.CurrentRow.Cells[2].Value + " where Safe_ID = " + Safe_ID + "", "");
                }
                else
                {
                    db.ExecuteData("insert into  Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) values (" + Safe_ID + " ," + NumPricePayPart.Value + " ,N'" + Date + "' ,N'" + Properties.Settings.Default.UserName + "' ,N'Dues to suppliers', N'') ", "");
                    db.ExecuteData("update Safe set Safe_Money = Safe_Money - " + NumPricePayPart.Value + " where Safe_ID=" + Safe_ID + "", "");

                }
            }
        }

        private void txtSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 )
            {
                Tbl.Clear();
                if (rbtnAllSup.Checked == true)
                {
                    Tbl = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Supplier_Money, Suppliers where   Suppliers.Sup_ID =  Supplier_Money.Sup_ID ", "");

                }

                else if (rbtnSpSup.Checked == true)
                {

                    Tbl = db.ReadData("SELECT Order_ID as 'Invoice Number ',Suppliers.Sup_Name as 'Name Supplier',Rest_Price as 'Price ',Order_Date as  'Invoice Date',Reminder_Date as 'due date'FROM dbo.Supplier_Money, Suppliers where   Suppliers.Sup_ID =  Supplier_Money.Sup_ID  and Suppliers.Sup_Name = '" + txtSearsh.Text + "'", "");

                }
                DgvSupAccounts.DataSource = Tbl;
                decimal Total = 0;
                for (int i = 0; i <= DgvSupAccounts.Rows.Count - 1; i++)
                {
                    Total += Convert.ToDecimal(DgvSupAccounts.Rows[i].Cells[2].Value);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
          if(rbtnSpSup.Checked == true)
            {
                if (DgvSupAccounts.Rows.Count >= 1)
                {
                    PrintSpSupplier();
                }
            }
        }
    }
}
