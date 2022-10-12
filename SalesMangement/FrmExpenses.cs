using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SalesMangement
{
    public partial class FrmExpenses : MaterialForm
    {
        public FrmExpenses()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        int Row;
        //Form Load
        int Safe_ID = 0;
        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            AutoNumberExpT();
            AutoNumberExpM();
            FillType();
            checkExpM();
            DateFromExpR.Text = DateTime.Now.ToShortDateString();
            DateToExpR.Text = DateTime.Now.ToShortDateString();
            Safe_ID = Properties.Settings.Default.Safe_ID;



        }

        /// <summary>
        /// Type Expenses 
        ///AutoNumberExpT
        /// A function that adds a new ID in the database 
        ///and increments 1 automatically in each operation
        /// Clear the text box again after each operation
        /// Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumberExpT()
        {
            tbl.Clear();
            tbl = db.ReadData("select max(Exp_ID) from types_Expenses ", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtIdExpT.Text = "1";
            }
            else
            {
                TxtIdExpT.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            TxtNameExpT.Clear();
            //focus on textbox Name type Expenses
            //Cancel buttons and activate them when needed
            btnAddExpT.Enabled = true;
            btnNewExpT.Enabled = true;
            btnSaveExpT.Enabled = false;
            btnDeleteExpT.Enabled = false;
            btnDeleteAllExpT.Enabled = false;
        }
        /* ShowExpT
         * A function that displays data from the database
        */
        private void showExpT()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from types_Expenses ", "");
            if (tbl.Rows.Count <= 0)
            {
               
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                TxtIdExpT.Text = tbl.Rows[Row][0].ToString();
                TxtNameExpT.Text = tbl.Rows[Row][1].ToString();
            }
            //Cancel buttons and activate them when needed
            btnAddExpT.Enabled = false;
            btnNewExpT.Enabled = true;
            btnSaveExpT.Enabled = true;
            btnDeleteExpT.Enabled = true;
            btnDeleteAllExpT.Enabled = true;

        }
        //checkExpT
        //A function that checks if important textBox have a value
        private bool checkExpT()
        {
            if (TxtIdExpT.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Expenses number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtNameExpT.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Expenses Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
       
        //Button Add Type Expenses #
        private void btnAddExpT_Click(object sender, EventArgs e)
        {
            if (checkExpT() == false)
            {
                
                db.ExecuteData("insert into types_Expenses values (" + TxtIdExpT.Text + ",N'" + TxtNameExpT.Text + "') ", "done successfully");
                AutoNumberExpT();
            }
            else
            {
                return;
            }


        }
        //button new type Expense #
        private void btnNewExpT_Click(object sender, EventArgs e)
        {
            AutoNumberExpT();
        }
        //button update ==> table types_Expenses #
        private void btnSaveExpT_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update types_Expenses set Exp_Name = N'" + TxtNameExpT.Text + "' where Exp_Id = " + TxtIdExpT.Text + "", "Data has been modified successfully");
            AutoNumberExpT();
        }
        //button Delete Types Expenses #
        private void btnDeleteExpT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + TxtNameExpT.Text + " Types Expenses data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from types_Expenses where Exp_id = " + TxtIdExpT.Text + " ", " Types Expenses data has been deleted");

                AutoNumberExpT();
            }

        }
        //button delete all Types Expenses #
        private void btnDeleteAllExpT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Type Expenses data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Types_Expenses ", "All Type Expenses data has been deleted");
                AutoNumberExpT();
            }
        }
        //Button First line on database ==> table Type Expenses
        private void btnFirstExpT_Click(object sender, EventArgs e)
        {
            Row = 0;
            showExpT();

        }
        //button Previous Type Expenses 
        private void btnPreviousExpT_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                tbl.Clear();
                tbl = db.ReadData("select Count(Exp_Id) from types_Expenses", "");
                Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                showExpT();

            }
            else
            {
                Row--;
                showExpT();
            }

        }
        //button Next Type Expenses 
        private void btnNextExpT_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select Count(Exp_Id) from types_Expenses", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == Row)
            {

                Row = 0;
                showExpT();
            }
            else
            {
                Row++;
                showExpT();
            }

        }
        //button Last Type Expenses 
        private void btnLastExpT_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select count(Exp_id) from types_Expenses", "");
            Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            showExpT();
        }

        //????
        private void TabSelectorExpenses_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Expense Management
        ///AutoNumberExpM
        ///A function that adds a new ID in the database
        ///and increments 1 automatically in each operation
        ///Clear the text box again after each operation
        ///Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumberExpM()
        {
            tbl.Clear();
            tbl = db.ReadData("select max(Exp_ID) from Expenses ", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtIdExpM.Text = "1";
            }
            else
            {
                TxtIdExpM.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operatio
            //Cancel buttons and activate them when needed
            DateTimeExpM.Text = DateTime.Now.ToShortDateString();
            NumPriceExpM.Value = 1;
            TxtNoteExpM.Clear();
            btnAddExpM.Enabled = true;
            btnNewExpM.Enabled = true;
            btnSaveExpM.Enabled = false;
            btnDeleteExpM.Enabled = false;
            btnDeleteAllExpM.Enabled = false;
        }
        /* ShowExpM
         * A function that displays data from the database
        */
        private void showExpM()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from Expenses ", "");
            if (tbl.Rows.Count <= 0)
            {

                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //first line of database customers
                    TxtIdExpM.Text = tbl.Rows[Row][0].ToString();
                    NumPriceExpM.Value = Convert.ToDecimal(tbl.Rows[Row][1]);
                    //date format problem
                    this.Text = tbl.Rows[Row][2].ToString();
                    DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    DateTimeExpM.Value = date;
                    //DateTimeExpM.Text = tbl.Rows[Row][2].ToString();
                    TxtNoteExpM.Text = tbl.Rows[Row][3].ToString();
                    CbxNamTypeM.SelectedValue = Convert.ToDecimal(tbl.Rows[Row][4]);

                }
                catch (Exception)
                { 
                    
                }
               
            }
            //Cancel buttons and activate them when needed
            btnAddExpM.Enabled = false;
            btnNewExpM.Enabled = true;
            btnSaveExpM.Enabled = true;
            btnDeleteExpM.Enabled = true;
            btnDeleteAllExpM.Enabled = true;

        }
        //checkExpM
        //A function that checks if important textBox have a value
        private bool checkExpM()
        {
            if (TxtIdExpM.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Expenses number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if(CbxNamTypeM.Items.Count <= 0)
            {
                MessageBox.Show("Paleass enter Types Expenses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
        // read Data from Database in CbxNameType
        private void FillType()
        {
            CbxNamTypeM.DataSource = db.ReadData("select * from types_Expenses ", "");
            CbxNamTypeM.DisplayMember = "Exp_Name";
            CbxNamTypeM.ValueMember = "Exp_Id";
        }
        //button Add Expenses Management Data
        private void btnAddExpM_Click(object sender, EventArgs e)
        {
            string Date = DateTimeExpM.Value.ToString("dd/MM/yyyy");
            decimal Safe_Money = 0;
            tbl.Clear();
            tbl = db.ReadData("Select * from Safe where Safe_ID = " + Safe_ID + "", "");
            Safe_Money = Convert.ToDecimal(tbl.Rows[0][1]);

            if (Convert.ToDecimal(NumPriceExpM.Value) > Safe_Money)
            {
                MessageBox.Show(" The amount in the Safe is not enough to perform the operation", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            db.ExecuteData("insert into Safe_Withdraw (Safe_ID ,Safe_Money ,Date ,Depositor_Name , Type, Reason ) Values (" + Safe_ID + ", " + NumPriceExpM.Value + ",N'" + Date + "' , N'"+Properties.Settings.Default.UserName+"', N'Expenses', N'" + TxtNoteExpM.Text + "')  ", "");
            db.ExecuteData("Update Safe Set Safe_Money = Safe_Money - " + NumPriceExpM.Value + " Where Safe_ID = " + Safe_ID + "", "");
            
            if (checkExpM() == false)
            {
                
                db.ExecuteData("insert into Expenses values (" + TxtIdExpM.Text + ","+ NumPriceExpM.Value +",N'"+Date+"',N'"+TxtNoteExpM.Text+"', " + CbxNamTypeM.SelectedValue + " ) ", "done successfully");
                AutoNumberExpM();
            }
            else
            {
                return;
            }

        }
        //Button First line on database ==> table Expense Management
        private void btnFirstExpM_Click(object sender, EventArgs e)
        {
            Row = 0;
            showExpM();
        }
        //Button Previous Expense Management
        private void btnPreviousExpM_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                tbl.Clear();
                tbl = db.ReadData("select Count(Exp_Id) from Expenses", "");
                Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                showExpM();

            }
            else
            {
                Row--;
                showExpM();
            }

        }
        //Button Next 
        private void btnNextExpM_Click(object sender, EventArgs e)
        {

            tbl.Clear();
            tbl = db.ReadData("select Count(Exp_Id) from Expenses", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == Row)
            {

                Row = 0;
                showExpM();
            }
            else
            {
                Row++;
                showExpM();
            }

        }
        //Button Last
        private void btnLastExpM_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select count(Exp_id) from Expenses", "");
            Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            showExpM();
        }
        //Button new Expenses Management
        private void btnNewExpM_Click(object sender, EventArgs e)
        {
            AutoNumberExpM();
        }
        //Button update in table Expenses on database
        private void btnSaveExpM_Click(object sender, EventArgs e)
        {
            if(NumPriceExpM.Value <= 0)
            {
                MessageBox.Show("Less than 1 . cannot be entered", "Confirm");
                return;
            }
            string DateM = DateTimeExpM.Value.ToString("dd/MM/yyyy");
            db.ExecuteData("update Expenses set Exp_Price = " + NumPriceExpM.Value + ", Exp_Date = N'"+ DateM + "', Exp_Note =N'"+ TxtNoteExpM.Text+ "' where Exp_Id = " + TxtIdExpM.Text + "", "Data has been modified successfully");
            AutoNumberExpM();

        }
        //Button Delete column in table Expenses 
        private void btnDeleteExpM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete Expenses data ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Expenses where Exp_id = " + TxtIdExpM.Text + " ", "  Expenses data has been deleted");

                AutoNumberExpM();
            }
        }
        //Button Delete table == > Expenses ,  All Expenses Data
        private void btnDeleteAllExpM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete All Expenses data ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Expenses ", "  Expenses data has been deleted");

                AutoNumberExpM();
            }

        }
        //Expenses Reborts
        //button Searsh 
        private void btnSearchExpR_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.ReadData("select Expenses.Exp_ID as 'Number', Exp_Price as 'Amount' , Exp_Date as 'Date',Exp_Note as 'Notes', types_Expenses.Exp_Name as 'Type' from Expenses , types_Expenses where Expenses.Type_ID = types_Expenses.Exp_ID " +
                "and CONVERT(date,Exp_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "");
            if (tbl.Rows.Count >= 1)
            {
                DgvExpR.DataSource = tbl;
                decimal Sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(tbl.Rows[i][1]);
                }
                //function that returns 2 numbers after the comma
                txtTotalExpR.Text = Math.Round(Sum, 2).ToString();

            }
            else
                txtTotalExpR.Text = "0";
        }
        //Button delete
        private void btnDeleteExpR_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromExpR.Value.ToString("yyyy-MM-dd");
            DateTo = DateToExpR.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("delete from Expenses where CONVERT(Date,Exp_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "It has been deleted successfully");
                tbl.Clear();
            }
        }
        private void tabTypesExpenses_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdExpT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtIdExpM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
