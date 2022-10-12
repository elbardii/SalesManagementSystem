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
    public partial class FrmItemGroup : MaterialForm
    {
        public FrmItemGroup()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        DataTable dtGroup = new DataTable();
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
            dtGroup.Clear();
            dtGroup = db.ReadData("select Group_ID as 'Category Number' , Group_Name as 'Category Name' from Category", "");
            DgvItemGroup.DataSource = dtGroup;
            dt.Clear();
            dt = db.ReadData("select max(Group_ID) from Category ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtNumberGroup.Text = "1";
            }
            else
            {
                TxtNumberGroup.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            TxtNameGroup.Clear();
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
            dt = db.ReadData("select * from Category ", "");
            if (dt.Rows.Count <= 0)
            {

                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database customers
                TxtNumberGroup.Text = dt.Rows[Row][0].ToString();
                TxtNameGroup.Text = dt.Rows[Row][1].ToString();
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
            if (TxtNumberGroup.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Group number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (TxtNameGroup.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Type Group Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        // BUTTON : Add 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {

                db.ExecuteData("insert into Category values (" + TxtNumberGroup.Text + ",N'" + TxtNameGroup.Text + "') ", "done successfully");
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

            db.ExecuteData("update Category set Group_Name = N'" + TxtNameGroup.Text + "' where Group_ID  = " + TxtNumberGroup.Text + "", "Data has been modified successfully");
            AutoNumber();
        }
        //BUTTON : Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + TxtNameGroup.Text + " Types Group data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Item_Group where Group_ID = " + TxtNumberGroup.Text + " ", " Types Unit data has been deleted");
                AutoNumber();
            }
        }
        //Delete All
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all Type Item Group data? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Category ", "All Type Item Group data has been deleted");
                AutoNumber();
            }
        }
        //BUTTON : First 
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Row = 0;
            show();
        }
        //BUTTIN : Previous 
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Row == 0)
            {

                dt.Clear();
                dt = db.ReadData("select Count(Group_ID)from Category", "");
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
            dt = db.ReadData("select Count(Group_ID) from Category", "");
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
            dt = db.ReadData("select count(Group_ID) from Category", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
        }
        //Load
        private void FrmItemGroup_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void DgvItemGroup_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (DgvItemGroup.Rows.Count >= 1)
                {

                    DataTable dtGroupt2 = new DataTable();
                    dtGroupt2.Clear();
                    dtGroupt2 = db.ReadData("select * from Category Where Group_ID = " + DgvItemGroup.CurrentRow.Cells[0].Value + " ", "");


                    //first line of database customers
                    TxtNumberGroup.Text = dtGroupt2.Rows[0][0].ToString();
                    TxtNameGroup.Text = dtGroupt2.Rows[0][1].ToString();

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
