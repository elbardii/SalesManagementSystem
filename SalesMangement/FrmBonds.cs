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
    public partial class FrmBonds : MaterialForm
    {
        public FrmBonds()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable(); 
        int Row;

        //PayOrder : A function that saves invoices in the database
        //PRINT : Invoice printing function 8cm
        private void Print()
        {
            int id = Convert.ToInt32(txtNumberBond.Text);
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData(" SELECT [Order_ID] as 'Bond Number ' ,[Name] as 'Responsible Name',[Price]  ,[Date],[Bond_From] as 'Band From',[Reason]FROM [dbo].[Bonds] WHERE Order_ID = " + id + "", "");
           // FrmPrinting Print = new FrmPrinting();
            RptBonds Rpt = new RptBonds();
           // Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("ID", id);
           // Print.crystalReportViewer.ReportSource = Rpt;
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            // Print.ShowDialog();
            Rpt.PrintToPrinter(1, true, 0, 0);
        }

        private void AutoNumberR()
        {
            dt.Clear();
            dt = db.ReadData("select max(Order_ID) from Bonds ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtNumberBond.Text = "1";
            }
            else
            {
                txtNumberBond.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            DateBond.Text = DateTime.Now.ToString();
            //clear Data
            txtResponsibleName.Clear();
            txtReason.Clear();
            txtBondFrom.Clear();    
            NumAmount.Value = 1;
            //Cancel buttons and activate them when needed
            btnNewR.Enabled = true;
            btnSaveR.Enabled = true;
            btnDeleteR.Enabled = false;
            btnDeleteAllR.Enabled = false;
        }
        /* ShowExpT
         * A function that displays data from the database
        */
        private void showR()
        {
            dt.Clear();
            dt = db.ReadData("select * from Bonds ", "");
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                txtNumberBond.Text = dt.Rows[Row][0].ToString();
                txtResponsibleName.Text = dt.Rows[Row][1].ToString();
                NumAmount.Value = Convert.ToInt32(dt.Rows[Row][2]);
                //date format problem
                this.Text = dt.Rows[Row][3].ToString();
                DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                DateBond.Value = date;
                txtBondFrom.Text = dt.Rows[Row][4].ToString();  
                txtReason.Text = dt.Rows[Row][5].ToString();    

            }
           
            //Cancel buttons and activate them when needed
            btnNewR.Enabled = true;
            btnSaveR.Enabled = true;
            btnDeleteR.Enabled = true;
            btnDeleteAllR.Enabled = true;

        }

        private bool check()
        {
            if (txtResponsibleName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Responsible Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtBondFrom.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Bond From", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
        int Safe_ID = 0;

        private void FrmBonds_Load(object sender, EventArgs e)
        {
            try
            {
                AutoNumberR();
                AutoNumber();
               Safe_ID = Properties.Settings.Default.Safe_ID;
                
            }
            catch (Exception)
            {

                
            }
        }
        //BUTTON : Save and print
        private void btnSaveR_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                string Date = DateBond.Value.ToString("dd/MM/yyyy");
                db.ExecuteData("Update Safe Set Safe_Money = Safe_Money + "+NumAmount.Value+" Where Safe_ID = "+Safe_ID+"", "");
                db.ExecuteData("insert into Safe_insert (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + NumAmount.Value + ",N'" + Date + "' , N'" + txtResponsibleName.Text + "', N'Bonds', N'" + txtReason.Text + "')  ", "");
                db.ExecuteData("insert into Bonds values ("+txtNumberBond.Text +",N'" + txtResponsibleName.Text + "'," + NumAmount.Value + ",N'" + Date + "', N'" + txtBondFrom.Text + "', N'"+txtReason.Text+"' ) ", "done successfully");
                Print();
                AutoNumberR();
                

            }
            else
            {
                return;
            }
        }
        //BUTTON Delete
        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete Bonds data ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Bonds where Order_ID = " + txtNumberBond.Text + " ", "  Bonds data has been deleted");

                AutoNumberR();
            }
        }

        private void btnDeleteAllR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete All data ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Bonds  ", "  All data has been deleted");

                AutoNumberR();
            }
        }
        //BUTTON : First
        private void btnFirstR_Click(object sender, EventArgs e)
        {
            Row = 0;
            showR();
        }
        //BUTTON :Previous 
        private void btnPreviousR_Click(object sender, EventArgs e)
        {

            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Order_ID) from Bonds", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                showR();

            }
            else
            {
                Row--;
                showR();
            }
        }
        //BUTTON  : Next 
        private void btnNextR_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Order_ID) from Bonds", "");
            if (Convert.ToInt32(dt.Rows[0][0]) - 1 == Row)
            {

                Row = 0;
                showR();
            }
            else
            {
                Row++;
                showR();
            }
        }
        //BUTTON : Last 
        private void btnLastR_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Order_ID) from Bonds", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            showR();
        }
        //BUTTON : New 
        private void btnNewR_Click(object sender, EventArgs e)
        {
            AutoNumberR();
        }

        //FORM :Receipt 

        private void PrintR()
        {
            int id = Convert.ToInt32(txtNumberBondR.Text);
            DataTable dtRtp = new DataTable();
            dtRtp.Clear();
            dtRtp = db.ReadData("  SELECT [Order_ID] as 'Bond Number ' ,[Name] as 'Responsible Name',[Price],[Date],[Cashing_To] as 'Band To',[Reason] FROM[dbo].[Bond_Receipt]  WHERE Order_ID = " + id + "", "");
            //FrmPrinting Print = new FrmPrinting();
            RptBondReceipt Rpt = new RptBondReceipt();
            // Print.crystalReportViewer.RefreshReport();
            //Username and password data Database name
            //In order to run a program in the client's machine without problems
            Rpt.SetDatabaseLogon("", "", "LAPTOP-K0R8A28U", "Sales_System");
            Rpt.SetDataSource(dtRtp);
            Rpt.SetParameterValue("ID", id);
            // Print.crystalReportViewer.ReportSource = Rpt;
            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            Rpt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            // Print.ShowDialog();
            Rpt.PrintToPrinter(1, true, 0, 0);
        }
        private bool checkR()
        {

            if (txtResponsibleExchange.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Responsible Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (txtCashingTO.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Bond To ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AutoNumber()
        {
            dt.Clear();
            dt = db.ReadData("select max(Order_ID) from Bond_Receipt ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtNumberBondR.Text = "1";
            }
            else
            {
                txtNumberBondR.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            DateBondR.Text = DateTime.Now.ToString();
            //clear Data
            txtResponsibleExchange.Clear();
            txtReasonR.Clear();
            txtCashingTO.Clear();
            NumAmountR.Value = 1;
            //Cancel buttons and activate them when needed
            btnNew.Enabled = true;
            btnSavePrint.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        /* ShowExpT
         * A function that displays data from the database
        */
        private void show()
        {
            dt.Clear();
            dt = db.ReadData("select * from Bond_Receipt ", "");
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //first line of database customers
                txtNumberBondR.Text = dt.Rows[Row][0].ToString();
                txtResponsibleExchange.Text = dt.Rows[Row][1].ToString();
                NumAmountR.Value = Convert.ToInt32(dt.Rows[Row][2]);
                //date format problem
                this.Text = dt.Rows[Row][3].ToString();
                DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                DateBondR.Value = date;
                txtCashingTO.Text = dt.Rows[Row][4].ToString();
                txtReasonR.Text = dt.Rows[Row][5].ToString();

            }

            //Cancel buttons and activate them when needed
            btnNew.Enabled = true;
            btnSavePrint.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;

        }
        //BUTTON :New 
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //BUTTON :  Delete 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete Bonds data ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Bond_Receipt where Order_ID = " + txtNumberBond.Text + " ", "  Bonds data has been deleted");
                AutoNumber();
            }
        }
            //BUTTON : Delete All
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete All data ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Bond_Receipt  " , "  All data has been deleted");
                AutoNumber();
            }
        }
        //BUTTON : Frist
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }
        //BUTTON : Previous
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Order_ID) from Bond_Receipt", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                show();
            }
            else
            {
                Row--;
                show();
            }
        }
        //BUTTON : Next 
        private void btnNext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Order_ID) from Bond_Receipt", "");
            if (Convert.ToInt32(dt.Rows[0][0]) - 1 == Row)
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
        //BUTTON  : Last 
        private void btnLast_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Order_ID) from Bond_Receipt ", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
        }
        private void btnSavePrint_Click(object sender, EventArgs e)
        {


            decimal Safe_Money = 0;
            try
            {
               Safe_Money = Convert.ToDecimal( db.ReadData("select * from Safe where Safe_ID = "+Safe_ID+"", "").Rows[0][1]);
            }
            catch (Exception)
            { 
            }

            if (NumAmountR.Value > Safe_Money)
            {
                MessageBox.Show("There is not enough balance to perform the operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkR() == false)
            {
                string Date = DateBondR.Value.ToString("dd/MM/yyyy");
                db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + NumAmountR.Value + " Where Safe_ID = " + Safe_ID + "", "");
                db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + NumAmountR.Value + ",N'" + Date + "' , N'" + txtResponsibleExchange.Text + "', N'Bonds Receipt ', N'" + txtReasonR.Text + "')  ", "");
                db.ExecuteData("insert into Bond_Receipt values (" + txtNumberBondR.Text + ",N'" + txtResponsibleExchange.Text + "'," + NumAmountR.Value + ",N'" + Date + "', N'" + txtCashingTO.Text + "', N'" + txtReasonR.Text + "' ) ", "done successfully");
                PrintR();
                AutoNumber();
            }
            else
            {
                return;
            }
        }
    }
}
