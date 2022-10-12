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
    public partial class FrmAddWarehouse : MaterialForm
    {
        public FrmAddWarehouse()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }

        Database db = new Database();
        DataTable dt = new DataTable();
        DataTable dtWarehouse = new DataTable();
        int Row;

        /// <summary>
        /// Type Expenses 
        ///AutoNumberExpT
        /// A function that adds a new ID in the database 
        ///and increments 1 automatically in each operation
        /// Clear the text box again after each operation
        /// Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumber()
        {
            dtWarehouse.Clear();
            dtWarehouse = db.ReadData("select Warehouse_ID as 'Warehouse Number' , Warehouse_Name as 'Warehouse Name' from Warehouse", "");
            DgvWarehouse.DataSource = dtWarehouse;
            dt.Clear();
            dt = db.ReadData("select max(Warehouse_ID) from Warehouse ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtWarehouseNumber.Text = "1";
            }
            else
            {
                txtWarehouseNumber.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            txtWarehouseName.Clear();
            //focus on textbox Name type Expenses
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }
        /* Show
         * A function that displays data from the database
        */
        private void show()
        {
            dt.Clear();
            dt = db.ReadData("select * from Warehouse ", "");
            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                txtWarehouseNumber.Text = dt.Rows[Row][0].ToString();
                txtWarehouseName.Text = dt.Rows[Row][1].ToString();
            }
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;

        }
        //check
        //A function that checks if important textBox have a value
        private bool check()
        {
            if (txtWarehouseNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Warehouse number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtWarehouseName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Warehouse Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //BUTTON : Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {

                db.ExecuteData("insert into Warehouse values (" + txtWarehouseNumber.Text + ",N'" + txtWarehouseName.Text + "') ", "done successfully");
                AutoNumber();
            }
            else
            {
                return;
            }
        }
        //BUTTON : New
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //BUTTON : Save
        private void btnSave_Click(object sender, EventArgs e)
        {

            db.ExecuteData("update Warehouse set Warehouse_Name = N'" + txtWarehouseName.Text + "' where Warehouse_ID  = " + txtWarehouseNumber.Text + "", "Data has been modified successfully");
            AutoNumber();
        }
        //BUTTON : Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + txtWarehouseName.Text + " Types Group data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Warehouse where Warehouse_ID = " + txtWarehouseNumber.Text + " ", " Types Warehouse data has been deleted");
                AutoNumber();
            }
        }
        //BUTTON : Delete All
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Type Item Warehouse data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Warehouse ", "All Type Item Warehouse data has been deleted");
                AutoNumber();
            }
        }
        //BUTTON : First
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
                dt = db.ReadData("select Count(Warehouse_ID)from Warehouse", "");
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
            dt = db.ReadData("select Count(Warehouse_ID) from Warehouse", "");
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
        //BUTTON : Last
        private void btnLast_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select count(Warehouse_ID) from Warehouse", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
        }
        //Mouse Click
        private void DgvWarehouse_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (DgvWarehouse.Rows.Count >= 1)
                {

                    DataTable dtWarehouse = new DataTable();
                    dtWarehouse.Clear();
                    dtWarehouse = db.ReadData("select * from Warehouse Where Warehouse_ID = " + DgvWarehouse.CurrentRow.Cells[0].Value + " ", "");


                    //first line of database customers
                    txtWarehouseNumber.Text = dtWarehouse.Rows[0][0].ToString();
                    txtWarehouseName.Text = dtWarehouse.Rows[0][1].ToString();

                    //Cancel buttons and activate them when needed
                    btnAdd.Enabled = false;
                    btnNew.Enabled = true;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteAll.Enabled = true;
                }


            }
            catch (Exception)
            {
            }
        }
    }
}
