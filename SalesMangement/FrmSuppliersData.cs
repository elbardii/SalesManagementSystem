using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesMangement
{
    public partial class FrmSuppliersData : MaterialForm
    {
        public FrmSuppliersData()
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
            tbl = db.ReadData("select max(Sup_Id) from Suppliers", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtIdSup.Text = "1";
            }
            else
            {
                TxtIdSup.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            //TxtIdCus.Clear();
            TxtNameSup.Clear();
            TxtPhoneSup.Clear();
            TxtAddressSup.Clear();
            TxtNoteSup.Clear();
            //txtSearchCust.Clear();

            //focus on textbox Name Customer



            //Cancel buttons and activate them when needed
            btnAddSup.Enabled = true;
            btnNewSup.Enabled = true;
            btnSaveSup.Enabled = false;
            btnDeleteSup.Enabled = false;
            btnDeleteAllSup.Enabled = false;
        }
        /* Show
         * A function that displays data from the database
        */
        int Row;
        private void show()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from Suppliers", "");
            if (tbl.Rows.Count <= 0)
            {  
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              //first line of database customers
              TxtIdSup.Text = tbl.Rows[Row][0].ToString();
              TxtNameSup.Text = tbl.Rows[Row][1].ToString();
              TxtPhoneSup.Text = tbl.Rows[Row][2].ToString();
              TxtAddressSup.Text = tbl.Rows[Row][3].ToString();
              TxtNoteSup.Text = tbl.Rows[Row][4].ToString();
            }
            //Cancel buttons and activate them when needed
            btnAddSup.Enabled = false;
            btnNewSup.Enabled = true;
            btnSaveSup.Enabled = true;
            btnDeleteSup.Enabled = true;
            btnDeleteAllSup.Enabled = true;

        }
        //A function that checks if important textBox have a value
        private bool check()
        {
            if (TxtIdSup.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Supplier number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtNameSup.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Supplier Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtPhoneSup.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Supplier Phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtAddressSup.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Supplier Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
        private void FrmSuppliersData_Load(object sender, EventArgs e)
        {
            AutoNumber();

        }
        //textbox Searsh enter
        private void txtSearchSup_Enter(object sender, EventArgs e)
        {
            if (txtSearchSup.Text == "Searsh, and click Enter")
            {
                txtSearchSup.Text = string.Empty;
                txtSearchSup.ForeColor = Color.Black;
            }
        }
        //textbox Searsh leave
        private void txtSearchSup_Leave(object sender, EventArgs e)
        {
            if(txtSearchSup.Text == string.Empty)
            {
                txtSearchSup.Text = "Searsh, and click Enter";
                txtSearchSup.ForeColor = Color.Gray;
            }

        }
        //Button Add Suppliers
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                db.ExecuteData("insert into Suppliers values (" + TxtIdSup.Text + ", N'" + TxtNameSup.Text + "',N'" + TxtPhoneSup.Text + "',N'" + TxtAddressSup.Text + "', N'" + TxtNoteSup.Text + "' ) ", "done successfully");
                AutoNumber();
            }
            else
            {
                return;
            }
        }
        //Button new suppliers
        private void btnNewSup_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //button first line on database ==> table Supplier
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }
        //button update ==> table Suppliers
        private void btnSaveSup_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update Suppliers set Sup_Name = N'" + TxtNameSup.Text + "', Sup_Phone =N'" + TxtPhoneSup.Text + "'," +
               " Sup_Address = N'" + TxtAddressSup.Text + "', Sup_Note = N'" + TxtNoteSup.Text + "' where Sup_Id = " + TxtIdSup.Text + "", "Data has been modified successfully");
            AutoNumber();
        }
        //button delete Suppliers
        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + TxtNameSup.Text + " Customer data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Suppliers where Sup_id = " + TxtIdSup.Text + " ", "Supplier data has been deleted");

                AutoNumber();
            }
        }
        //Button delete all Delete
        private void btnDeleteAllSup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Supplier data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Suppliers ", "All Suppliers data has been deleted");
                AutoNumber();
            }
        }
        //Button last Suppliers
        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select count(Sup_id) from Suppliers", "");
            Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();

        }
        //Button Next Suppliers
        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select Count(Sup_Id) from Suppliers", "");
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
        //Button Previous 
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                tbl.Clear();
                tbl = db.ReadData("select Count(Sup_Id) from Suppliers", "");
                Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();

            }
            else
            {
                Row--;
                show();
            }
        }
        //Button Search ==> enter
        private void txtSearchSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable tblSearsh = new DataTable();
                tblSearsh.Clear();
                tblSearsh = db.ReadData("select * from Suppliers where Sup_Name = N'" + txtSearchSup.Text + "' ", "");
                try
                {
                    TxtIdSup.Text = tblSearsh.Rows[0][0].ToString();
                    TxtNameSup.Text = tblSearsh.Rows[0][1].ToString();
                    TxtPhoneSup.Text = tblSearsh.Rows[0][2].ToString();
                    TxtAddressSup.Text = tblSearsh.Rows[0][3].ToString();
                    TxtNoteSup.Text = tblSearsh.Rows[0][4].ToString();
                }
                catch (Exception)
                {

                }
                //Cancel buttons and activate them when needed
                btnAddSup.Enabled = false;
                btnNewSup.Enabled = true;
                btnSaveSup.Enabled = true;
                btnDeleteSup.Enabled = true;
                btnDeleteAllSup.Enabled = true;
            }
        }

        private void FrmSuppliersData_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///When a form is closed, the code is run
            ///Pressing close reloads #cbxSupplier
            try
            {
                FrmBuy.GetFormBuy.FillSupplier();
            }
            catch (Exception)
            {
            }
        }

        private void TxtIdSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtPhoneSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
