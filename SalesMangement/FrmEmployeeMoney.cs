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
    public partial class FrmEmployeeMoney : MaterialForm
    {
        public FrmEmployeeMoney()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }

        Database db = new Database();
        DataTable dt = new DataTable();
        /// <summary>
        ///AutoNumber
        ///A function that adds a new ID in the database
        ///and increments 1 automatically in each operation
        ///Clear the text box again after each operation
        ///Cancel buttons and activate them when needed
        ///focus on textbox Name Employee
        /// </summary>
        private void AutoNumber()
        {
            dt.Clear();
            dt = db.ReadData("select max(Order_ID) from Employee_Withdrawals", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                TxtOperationNumber.Text = "1";
            }
            else
            {
                TxtOperationNumber.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            NumQuantity.Value = 1;
            //Clear the text box again after each operation
            //TxtIdCus.Clear();
            Date.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxChooseProduct.SelectedIndex = 0;
                cbxChooseEmployee.SelectedIndex = 0;
            }
            catch (Exception)
            {

               
            }
            
        }

        private void FillProducts()
        {
            cbxChooseProduct.DataSource = db.ReadData("select * from Product ", "");
            cbxChooseProduct.DisplayMember = "Pro_Name";
            cbxChooseProduct.ValueMember = "Pro_Id";
        }


        private void FillEmployees()
        {
            cbxChooseEmployee.DataSource = db.ReadData("select * from Employees ", "");
            cbxChooseEmployee.DisplayMember = "Emp_Name";
            cbxChooseEmployee.ValueMember = "Emp_ID";
        }

        private void FrmEmployeeMoney_Load(object sender, EventArgs e)
        {
           
            try
            {
                FillProducts();
                FillEmployees();
                AutoNumber();
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Save 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbxChooseProduct.Items.Count <= 0 || cbxChooseEmployee.Items.Count <= 0)
            {
                MessageBox.Show(" Please verify your information ", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if(NumQuantity.Value <= 0)
            {
                MessageBox.Show(" The amount withdrawn must be greater than 0 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal Price = 0, TotalPrice = 0;

            try
            {
                Price =  Convert.ToDecimal( db.ReadData("select sale_price from  Product where Pro_Id = "+cbxChooseProduct.SelectedValue+"", "").Rows[0][0]);
            }
            catch (Exception)
            {

            }
            TotalPrice = Price * NumQuantity.Value;
            string date = Date.Value.ToString("dd/MM/yyy");
            db.ExecuteData("insert into Employees_SalaryMinus (Emp_ID,Emp_Name,Emp_Date,Emp_Price,Emp_Pay) Values ("+cbxChooseEmployee.SelectedValue+",N'"+cbxChooseEmployee.Text+"',N'"+date+"',"+ TotalPrice + ", 'NO')", "");
            db.ExecuteData("update Product  set Pro_Quantity = Pro_Quantity - "+NumQuantity.Value + " Where Pro_Id = "+ cbxChooseProduct.SelectedValue +" ", "");
            db.ExecuteData(" insert into Employee_Withdrawals Values ( "+TxtOperationNumber.Text+","+cbxChooseProduct.SelectedValue+", "+cbxChooseEmployee.SelectedValue+", '"+ date + "' , "+NumQuantity.Value+" )", "You have been diapered successfully");
            AutoNumber();
        }
        //Search by barcode 
        private void txtSearchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchBarcode.Text == string.Empty)
            {
                return;
            }
            DataTable dtSearch = new DataTable();
            if (e.KeyChar == 13)

            {
                dtSearch.Clear();
                dtSearch = db.ReadData(" select * from Product where Pro_BarCode = N'"+txtSearchBarcode.Text+"'", "");

                if(dtSearch.Rows.Count >= 1)
                {
                    cbxChooseProduct.SelectedValue =  dtSearch.Rows[0][0];
                }
            }
        }
    }
}
