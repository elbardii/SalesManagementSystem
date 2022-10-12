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
    public partial class FrmCustomerData : MaterialForm
    {
        public FrmCustomerData()
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
            tbl = db.ReadData("select max(Cust_Id) from customers","");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtIdCus.Text = "1";
            }
            else
            {
                TxtIdCus.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            //TxtIdCus.Clear();
            TxtNameCus.Clear();
            TxtPhoneCus.Clear();
            TxtAddressCus.Clear();
            TxtNoteCus.Clear();
            //txtSearchCust.Clear();

            //focus on textbox Name Customer
            
            

            //Cancel buttons and activate them when needed
            btnAddCus.Enabled = true;
            btnNewCus.Enabled = true;
            btnSaveCus.Enabled = false;
            btnDeleteCus.Enabled = false;
            btnDeleteAllCus.Enabled = false;
        }
        /* Show
         * A function that displays data from the database
        */
        int Row;
        private void show()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from Customers", "");
            if(tbl.Rows.Count <= 0)
            {
               MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                TxtIdCus.Text = tbl.Rows[Row][0].ToString();
                TxtNameCus.Text = tbl.Rows[Row][1].ToString();
                TxtPhoneCus.Text = tbl.Rows[Row][2].ToString();
                TxtAddressCus.Text = tbl.Rows[Row][3].ToString();
                TxtNoteCus.Text = tbl.Rows[Row][4].ToString();
            }
            //Cancel buttons and activate them when needed
            btnAddCus.Enabled = false;
            btnNewCus.Enabled = true;
            btnSaveCus.Enabled = true;
            btnDeleteCus.Enabled = true;
            btnDeleteAllCus.Enabled = true;

        }
        //A function that checks if important textBox have a value
        private bool check()
        {
            if (TxtIdCus.Text == string.Empty)
            {
                MessageBox.Show("Please enter a customer number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtNameCus.Text == string.Empty)
            {
                MessageBox.Show("Please enter a customer Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtPhoneCus.Text == string.Empty)
            {
                MessageBox.Show("Please enter a customer Phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtAddressCus.Text == string.Empty)
            {
                MessageBox.Show("Please enter a customer Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
        //textbox Searsh enter
        private void txtSearchCust_Enter(object sender, EventArgs e)
        {
            if (txtSearchCust.Text == "Searsh, and click Enter")
            {
                txtSearchCust.Text = string.Empty;
                txtSearchCust.ForeColor = Color.Black;
            }
        }
        //textbox Searsh leave
        private void txtSearchCust_Leave(object sender, EventArgs e)
        {
            if (txtSearchCust.Text == string.Empty)
            {
                txtSearchCust.Text = "Searsh, and click Enter";
                txtSearchCust.ForeColor = Color.Gray;
            }

        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            AutoNumber();

        }
        //Button ADD Customers
        private void btnAddCus_Click(object sender, EventArgs e)
        {
            if(check() == false)
            {
                db.ExecuteData("insert into customers values (" + TxtIdCus.Text + ", N'" + TxtNameCus.Text + "',N'" + TxtPhoneCus.Text + "',N'" + TxtAddressCus.Text + "', N'" + TxtNoteCus.Text + "' ) ", "done successfully");
                AutoNumber();
            }
            else
            {
                return;
            }
            
          

        }
        //button new Customers
        private void btnNewCus_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //button first line on database ==> table Customers
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }

        //button update ==> table Customers
        private void btnSaveCus_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update Customers set Cust_Name = N'"+TxtNameCus.Text+ "', Cust_Phone =N'"+TxtPhoneCus.Text+ "'," +
                " Cust_Address = N'"+TxtAddressCus.Text+ "', Cust_Note = N'"+TxtNoteCus.Text+ "' where Cust_Id = "+TxtIdCus.Text+"", "Data has been modified successfully");
            AutoNumber();
        }
        //button Delete Customers
        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete "+TxtNameCus.Text+" Customer data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Customers where Cust_id = " + TxtIdCus.Text + " ", "Customer data has been deleted");

                AutoNumber();
            }
        }
        //button Delete All ==> delete Table Customers
        private void btnDeleteAllCus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all customer data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Customers ", "All customer data has been deleted");
                AutoNumber();
            }

        }
        //button last Customers
        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select count(Cust_id) from Customers","");
            Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();

        }
        //button Next Customers
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.ReadData("select Count(Cust_Id) from Customers", "");
            if(Convert.ToInt32(tbl.Rows[0][0]) - 1 == Row)
            {
                
                Row = 0;
                show();
            }
            else
            {
                Row++;
                show();
            }
;            
        }
        //button Previous Customers
        private void btnPrevious_Click(object sender, EventArgs e)
        {
           
            if (Row == 0)
            {

                tbl.Clear();
                tbl = db.ReadData("select Count(Cust_Id) from Customers", "");
                Row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();

            }
            else
            {
                Row--;
                show();
            }
            
           
        }
        //Searsh , click enter 
        private void txtSearchCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                DataTable tblSearsh = new DataTable();
                tblSearsh.Clear();
                tblSearsh = db.ReadData("select * from Customers where Cust_Name = N'" + txtSearchCust.Text + "' ", "");

                try
                {
                    TxtIdCus.Text = tblSearsh.Rows[0][0].ToString();
                    TxtNameCus.Text = tblSearsh.Rows[0][1].ToString();
                    TxtPhoneCus.Text = tblSearsh.Rows[0][2].ToString();
                    TxtAddressCus.Text = tblSearsh.Rows[0][3].ToString();
                    TxtNoteCus.Text = tblSearsh.Rows[0][4].ToString();

                }
                catch (Exception)
                {

                }
                //Cancel buttons and activate them when needed
                btnAddCus.Enabled = false;
                btnNewCus.Enabled = true;
                btnSaveCus.Enabled = true;
                btnDeleteCus.Enabled = true;
                btnDeleteAllCus.Enabled = true;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCustomerData_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FrmSalesManagement.GetFrmSalesManagement.FillCustomers();
               
            }
            catch (Exception)
            {

                
            }
        }
        //textbox that only accepts numbers
        private void TxtIdCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //textbox that only accepts numbers
        private void TxtPhoneCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtSearchCust_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable tblSearsh = new DataTable();
                tblSearsh.Clear();
                tblSearsh = db.ReadData("select * from Customers where Cust_Name = N'" + txtSearchCust.Text + "' ", "");

                try
                {
                    TxtIdCus.Text = tblSearsh.Rows[0][0].ToString();
                    TxtNameCus.Text = tblSearsh.Rows[0][1].ToString();
                    TxtPhoneCus.Text = tblSearsh.Rows[0][2].ToString();
                    TxtAddressCus.Text = tblSearsh.Rows[0][3].ToString();
                    TxtNoteCus.Text = tblSearsh.Rows[0][4].ToString();

                }
                catch (Exception)
                {

                }
                //Cancel buttons and activate them when needed
                btnAddCus.Enabled = false;
                btnNewCus.Enabled = true;
                btnSaveCus.Enabled = true;
                btnDeleteCus.Enabled = true;
                btnDeleteAllCus.Enabled = true;
            }
        }
    }
}
