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
    public partial class FrmUnits : MaterialForm
    {
        public FrmUnits()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        DataTable dtUnit = new DataTable();
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
            dtUnit.Clear();
            dtUnit = db.ReadData("select Unit_ID as 'Unit Number' , Unit_Name as 'Unit Name' from Units", "");
            DgvUnit.DataSource = dtUnit;    
            dt.Clear();
            dt = db.ReadData("select max(Unit_ID) from Units ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtIdUnit.Text = "1";
            }
            else
            {
                TxtIdUnit.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            TxtNameUnit.Clear();
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
            dt = db.ReadData("select * from Units ", "");
            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                TxtIdUnit.Text = dt.Rows[Row][0].ToString();
                TxtNameUnit.Text = dt.Rows[Row][1].ToString();
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
            if (TxtIdUnit.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Uint number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtNameUnit.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Unit Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }



        }
        //BUTTON : Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {

                db.ExecuteData("insert into Units values (" + TxtIdUnit.Text + ",N'" + TxtNameUnit.Text + "') ", "done successfully");
                AutoNumber();
            }
            else
            {
                return;
            }
        }
        //BUTTNO : New 
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }
        //BUTTON : Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.ExecuteData("update Units set Unit_Name = N'" + TxtNameUnit.Text + "' where Unit_Id = " + TxtIdUnit.Text + "", "Data has been modified successfully");
            AutoNumber();
        }
        //BUTTON : Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + TxtNameUnit.Text + " Types Unit data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Units where Unit_id = " + TxtIdUnit.Text + " ", " Types Unit data has been deleted");
                AutoNumber();
            }
        }
        //BUTTON : Delete all 
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Type Units data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Units ", "All Type Units data has been deleted");
                AutoNumber();
            }
            
        }
        //BUTTON : First Line
        private void btnFirst_Click(object sender, EventArgs e)
        {

            Row = 0;
            show();
            
        }
        //BUTTON : Previous Line
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Unit_ID)from Units", "");
                Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                show();

            }
            else
            {
                Row--;
                show();
            }
            
        }
        //BUTTON : Next line
        private void btnNext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select Count(Unit_ID) from Units", "");
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
        //BUTTON : LAST Line
        private void btnLast_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select count(Unit_ID) from Units", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
            
        }
        //Load 
        private void FrmUnits_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void DgvUnit_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(DgvUnit.Rows.Count >= 1)
                {

                    DataTable dtUnit2 = new DataTable();
                    dtUnit2.Clear();
                    dtUnit2 = db.ReadData("select * from Units Where Unit_ID = " + DgvUnit.CurrentRow.Cells[0].Value +" ", "");

                    
                        //first line of database customers
                        TxtIdUnit.Text = dtUnit2.Rows[0][0].ToString();
                        TxtNameUnit.Text = dtUnit2.Rows[0][1].ToString();
                    
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
