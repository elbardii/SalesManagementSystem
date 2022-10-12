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
    public partial class FrmPermission : MaterialForm
    {
        public FrmPermission()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        DataTable dtPermission = new DataTable();
        int Row;
        /// <summary>
        ///AutoNumberNSafe
        /// A function that adds a new ID in the database 
        ///and increments 1 automatically in each operation
        /// Clear the text box again after each operation
        /// Cancel buttons and activate them when needed
        /// </summary>
        private void AutoNumber()
        {
            dtPermission.Clear();
            dtPermission = db.ReadData("SELECT [User_ID] as 'ID',[UserName] AS 'User Name',[User_Type] as 'Type',[User_Profit] as 'Profit Rate'FROM [dbo].[Users]", "");
            DgvNewUser.DataSource = dtPermission;   
            dt.Clear();
            dt = db.ReadData("select max(User_ID) from Users ", "");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtIdUser.Text = "1";
            }
            else
            {
                txtIdUser.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
            //Clear the text box again after each operation
            txtUsername.Clear();
            txtPassword.Clear();
            NumProfit.Value = 0;

            try
            {
                cbxType.SelectedIndex = 0;
                cbxDepositInSafe.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
            FillUser();
            //focus on textbox Name type Expenses
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
           
        }
        /* showNSafe
         * A function that displays data from the database
        */
        private void show()
        {
            dt.Clear();
            dt = db.ReadData("select * from Users ", "");
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("There is no data on this screen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //first line of database Table  Safe_Data
                txtIdUser.Text = dt.Rows[Row][0].ToString();
                txtUsername.Text = dt.Rows[Row][1].ToString();
                txtPassword.Text = dt.Rows[Row][2].ToString();
                cbxType.Text = dt.Rows[Row][3].ToString();
                cbxDepositInSafe.SelectedValue = Convert.ToDecimal(dt.Rows[Row][4]);
                NumProfit.Value = Convert.ToDecimal( dt.Rows[Row][4]);
            }
            //Cancel buttons and activate them when needed
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
    
        }

        private bool check()
        {
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtPassword.Text == string.Empty )
            {
                MessageBox.Show("Please enter  Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtPassword.Text.Length <= 7)
            {
                MessageBox.Show ("Your password must be at least 8 characters.");
                return true;
            }

            else
            {
                return false;
            }
        }
        //FILL : Safe
        private void FillSafe()
        {
            cbxDepositInSafe.DataSource = db.ReadData("select * from Safe_Data", "");
            cbxDepositInSafe.DisplayMember = "Safe_Name";
            cbxDepositInSafe.ValueMember = "Safe_ID";
        }
        //FILL : User 
        private void FillUser()
        {
            cbxChooseUsernameSe.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsernameSe.DisplayMember = "UserName";
            cbxChooseUsernameSe.ValueMember = "User_ID";

            cbxChooseUsernameSB.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsernameSB.DisplayMember = "UserName";
            cbxChooseUsernameSB.ValueMember = "User_ID";


            cbxChooseUsernameEM.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsernameEM.DisplayMember = "UserName";
            cbxChooseUsernameEM.ValueMember = "User_ID";


            cbxChooseUsernameEM.DataSource = db.ReadData("select * from Users", "");
            cbxChooseUsernameEM.DisplayMember = "UserName";
            cbxChooseUsernameEM.ValueMember = "User_ID";

        }


        //FORM : Permission Customers
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmPermissionCustomers frmPermissionCustomers = new FrmPermissionCustomers();
            frmPermissionCustomers.ShowDialog();    
        }
        //FORM : Permission Suppliers
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FrmPermissionSuppliers frmPermissionSuppliers = new FrmPermissionSuppliers();   
            frmPermissionSuppliers.ShowDialog();    
        }
        //FORM : Permission Sales
        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmPermissionSales frmPermissionSales = new FrmPermissionSales();
            frmPermissionSales.ShowDialog();
        }
        //FORM : Permission Purchasing
        private void btnPurchasing_Click(object sender, EventArgs e)
        {
            FrmPermissionBuy frmPermissionBuy = new FrmPermissionBuy(); 
            frmPermissionBuy.ShowDialog();  
        }
        //FORM : Permission Returns
        private void btnReturns_Click(object sender, EventArgs e)
        {
            FrmPermissionReturns frmPermissionReturns = new FrmPermissionReturns();
            frmPermissionReturns.ShowDialog();
        }
        //FORM : Permission Expenses
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            FrmPermissionExpenses frmPermissionExpenses = new FrmPermissionExpenses();
            frmPermissionExpenses.ShowDialog();
        }
        // FORM : Permission Reports
        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmPermissionReports frmPermissionReports = new FrmPermissionReports(); 
            frmPermissionReports.ShowDialog();
        }
        // FORM : Permission Backup
        private void btnBackup_Click(object sender, EventArgs e)
        {
            FrmPermissionBackup frmPermissionBackup = new FrmPermissionBackup();
            frmPermissionBackup.ShowDialog();
        }
        //lOAD
        private void FrmPermission_Load(object sender, EventArgs e)
        {
            try
            {
                AutoNumber();
                FillSafe();
                cbxChooseUsernameSe_SelectionChangeCommitted(null, null);
                cbxChooseUsernameSB_SelectionChangeCommitted(null, null);
                cbxChooseUsernameEM_SelectionChangeCommitted(null,null);
                cbxChooseUsernameSB_SelectionChangeCommitted(null, null);


                //show();
            }
            catch (Exception)
            {
            }
           //canal 
          // CSPS.Dispose();
        }
        //BUTTON : Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                db.ExecuteData("insert into Users values (" + txtIdUser.Text + ",N'" + txtUsername.Text + "' , N'"+txtPassword.Text+"', N'"+cbxType.Text+"', "+ cbxDepositInSafe.SelectedValue +", "+ NumProfit.Value +") ", "done successfully");
                db.ExecuteData("insert into Users_Settings Values ("+txtIdUser.Text+", 0,0,0,0,0,0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Customers Values (" + txtIdUser.Text + ", 0,0,0)", "");
                db.ExecuteData("insert into Users_Suppliers Values (" + txtIdUser.Text + ", 0,0,0)", "");
                db.ExecuteData("insert into Users_Purchasing Values (" + txtIdUser.Text + ", 0,0)", "");
                db.ExecuteData("insert into Users_Sales Values (" + txtIdUser.Text + ", 0,0,0)", "");
                db.ExecuteData("insert into Users_Returns Values (" + txtIdUser.Text + ", 0,0)", "");
                db.ExecuteData("insert into Users_Expenses Values (" + txtIdUser.Text + ", 0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Backups Values (" + txtIdUser.Text + ", 0,0)", "");
                db.ExecuteData("insert into Users_SafeBank Values (" + txtIdUser.Text + ", 0,0,0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Employees Values (" + txtIdUser.Text + ",0,0,0,0,0,0,0)", "");
                db.ExecuteData("insert into Users_Reports Values (" + txtIdUser.Text + ",0,0,0,0,0,0)", "");




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
            db.ExecuteData("update Users set UserName = N'" + txtUsername.Text + "' , User_Password =N'"+ txtPassword.Text + "' ,  User_Type = N'"+cbxType.Text+"', Safe_ID = "+cbxDepositInSafe.SelectedValue+ " , User_Profit = "+NumProfit.Value+ " Where User_ID = "+txtIdUser.Text+" ", "Data has been modified successfully");
            AutoNumber();
        }
        //BUTTON : Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you will delete " + txtUsername.Text + "  User data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteData("Delete from Users where User_ID = " + txtIdUser.Text + " ", " User data has been deleted");
                db.ExecuteData("Delete from Users_Settings Where User_ID = "+txtIdUser.Text+"", "");
                db.ExecuteData("Delete from Users_Customers Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Suppliers Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Purchasing Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Sales Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Returns Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Reports Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Expenses Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Backups Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_SafeBank Where User_ID = " + txtIdUser.Text + "", "");
                db.ExecuteData("Delete from Users_Employees Where User_ID = " + txtIdUser.Text + "", "");



                DataTable dtUser = new DataTable();
                dtUser.Clear();
                dtUser = db.ReadData("select * from Users", "");
                if(dtUser.Rows.Count <= 0)
                {
                    db.ExecuteData("insert into Users Values (1 , N'Admin' , N'AdminAdmin' , N'Administrator' , 1 , 0 )", "");
                    db.ExecuteData("insert into Users_Settings Values (" + txtIdUser.Text + ", 1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Customers Values (" + txtIdUser.Text + ", 1,1,1)", "");
                    db.ExecuteData("insert into Users_Suppliers Values (" + txtIdUser.Text + ", 1,1,1)", "");
                    db.ExecuteData("insert into Users_Purchasing Values (" + txtIdUser.Text + ", 1,1)", "");
                    db.ExecuteData("insert into Users_Sales Values (" + txtIdUser.Text + ", 1,1,1)", "");
                    db.ExecuteData("insert into Users_Returns Values (" + txtIdUser.Text + ", 1,1)", "");
                    db.ExecuteData("insert into Users_Reports Values (" + txtIdUser.Text + ", 1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Expenses Values (" + txtIdUser.Text + ",1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Backups Values (" + txtIdUser.Text + ", 1,1)", "");
                    db.ExecuteData("insert into Users_SafeBank Values (" + txtIdUser.Text + ", 1,1,1,1,1,1,1,1,1)", "");
                    db.ExecuteData("insert into Users_Employees Values (" + txtIdUser.Text + ", 1,1,1,1,1,1,1)", "");





                }
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
                dt = db.ReadData("select Count(User_ID) from Users", "");
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
            dt = db.ReadData("select Count(User_ID) from Users", "");
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
            dt = db.ReadData("select count(User_ID) from Users", "");
            Row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            show();
        }
        DataTable dtSettings = new DataTable();
        private void cbxChooseUsernameSe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtSettings.Clear();
                dtSettings = db.ReadData("select * from Users_Settings Where User_ID = "+cbxChooseUsernameSe.SelectedValue+" ", "");
                if(dtSettings.Rows.Count >= 1)
                {
                    //===================Settings
                    if (Convert.ToInt32( dtSettings.Rows[0][1]) == 1)
                    {
                        CheckboxSettings.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][1]) == 0)
                    {
                        CheckboxSettings.Checked = false;
                    }
                    //=====================Units
                    if (Convert.ToInt32(dtSettings.Rows[0][2]) == 1)
                    {
                        CheckboxUnits.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][2]) == 0)
                    {
                        CheckboxUnits.Checked = false;
                    }
                    //=====================Permissions
                    if (Convert.ToInt32(dtSettings.Rows[0][3]) == 1)
                    {
                        CheckboxPermissions.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][3]) == 0)
                    {
                        CheckboxPermissions.Checked = false;
                    }
                    //=====================Show Products
                    if (Convert.ToInt32(dtSettings.Rows[0][4]) == 1)
                    {
                        CheckboxShowPro.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][4]) == 0)
                    {
                        CheckboxShowPro.Checked = false;
                    }
                    //=====================Add Product
                    if (Convert.ToInt32(dtSettings.Rows[0][5]) == 1)
                    {
                        CheckboxAddPro.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][5]) == 0)
                    {
                        CheckboxAddPro.Checked = false;
                    }
                    //=====================Product Categories
                    if (Convert.ToInt32(dtSettings.Rows[0][6]) == 1)
                    {
                        CheckboxCategories.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][6]) == 0)
                    {
                        CheckboxCategories.Checked = false;
                    }
                    //=====================Add New Warehouse
                    if (Convert.ToInt32(dtSettings.Rows[0][7]) == 1)
                    {
                        CheckboxAddWarehouse.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][7]) == 0)
                    {
                        CheckboxAddWarehouse.Checked = false;
                    }
                    //=====================Show Warehouse
                    if (Convert.ToInt32(dtSettings.Rows[0][8]) == 1)
                    {
                        CheckboxShowWarehouses.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][8]) == 0)
                    {
                        CheckboxShowWarehouses.Checked = false;
                    }

                    //=====================Warehouse Report
                    if (Convert.ToInt32(dtSettings.Rows[0][9]) == 1)
                    {
                        CheckboxWarehouseReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][9]) == 0)
                    {
                        CheckboxWarehouseReport.Checked = false;
                    }

                    //=====================Damaged Products
                    if (Convert.ToInt32(dtSettings.Rows[0][10]) == 1)
                    {
                        CheckboxDamagedProducts.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][10]) == 0)
                    {
                        CheckboxDamagedProducts.Checked = false;
                    }


                    //=====================Damage Report
                    if (Convert.ToInt32(dtSettings.Rows[0][11]) == 1)
                    {
                        CheckboxDamageReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][11]) == 0)
                    {
                        CheckboxDamageReport.Checked = false;
                    }


                    //===================== Transfer Warehouses
                    if (Convert.ToInt32(dtSettings.Rows[0][12]) == 1)
                    {
                        CheckboxTransferWarehouses.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSettings.Rows[0][12]) == 0)
                    {
                        CheckboxTransferWarehouses.Checked = false;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Save Setting User
        private void btnSaveUserSe_Click(object sender, EventArgs e)
        {
            try
            {
                int Settings = 0, Units = 0, Permissions = 0, ShowProducts = 0, AddProduct = 0, ProductCategories = 0, AddWarehouse = 0 , ShowWarehouse = 0 , ReportWarehouse = 0 , DamagedProducts = 0 , DamageReport = 0 , TransferWarehouses = 0;
                //=============Settings
                if (CheckboxSettings.Checked)
                    Settings = 1;
                else
                    Settings = 0;
                //=============Units
                if (CheckboxUnits.Checked)
                    Units = 1;
                else
                    Units = 0;
                //=============Permissions
                if (CheckboxPermissions.Checked)
                    Permissions = 1;
                else
                    Permissions = 0;
                //=============ShowProducts
                if (CheckboxShowPro.Checked)
                    ShowProducts = 1;
                else
                    ShowProducts = 0;
                //=============Add Product
                if (CheckboxAddPro.Checked)
                    AddProduct = 1;
                else
                    AddProduct = 0;
                //=============Product Categories
                if (CheckboxCategories.Checked)
                    ProductCategories = 1;
                else
                    ProductCategories = 0;
                //=============Add New Warehouse
                if (CheckboxAddWarehouse.Checked)
                    AddWarehouse = 1;
                else
                    AddWarehouse = 0;
                //=============Show Warehouse
                if (CheckboxShowWarehouses.Checked)
                    ShowWarehouse = 1;
                else
                    ShowWarehouse = 0;
                //=============Report Warehouse
                if (CheckboxWarehouseReport.Checked)
                    ReportWarehouse = 1;
                else
                    ReportWarehouse = 0;
                //=============Damaged Products
                if (CheckboxDamagedProducts.Checked)
                    DamagedProducts = 1;
                else
                    DamagedProducts = 0;
                //=============Damage Report
                if (CheckboxDamageReport.Checked)
                    DamageReport = 1;
                else
                    DamageReport = 0;
                //=============Transfer Warehouses 
                if (CheckboxTransferWarehouses.Checked)
                    TransferWarehouses = 1;
                else
                    TransferWarehouses = 0;
                db.ExecuteData("Update Users_Settings Set User_Settings = "+Settings+ ", User_Units = "+Units+ ",User_Permissions = "+Permissions+ ", User_ShowProducts = "+ShowProducts+ ", User_AddProduct = "+AddProduct+ ", User_ProductCategories = "+ProductCategories+ ", User_AddWarehouse = "+AddWarehouse+ ", User_ShowWarehouses = "+ShowWarehouse+ ", User_WarehouseReport = "+ReportWarehouse+ ", User_DamagedProducts = "+DamagedProducts+ " , User_DamageReport = "+DamageReport+ " , User_TransferWarehouses = "+TransferWarehouses+"Where User_ID = " + cbxChooseUsernameSe.SelectedValue+"", "Edited Successfully");
                cbxChooseUsernameSe.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }

        //Safe and Bank
        DataTable dtSafeBank = new DataTable();
        private void cbxChooseUsernameSB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtSafeBank.Clear();
                dtSafeBank = db.ReadData("select * from Users_SafeBank Where User_ID = " + cbxChooseUsernameSB.SelectedValue + " ", "");
                if (dtSafeBank.Rows.Count >= 1)
                {
                    //===================Add New Safe 
                    if (Convert.ToInt32(dtSafeBank.Rows[0][1]) == 1)
                    {
                        CheckboxAddSafe.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][1]) == 0)
                    {
                        CheckboxAddSafe.Checked = false;
                    }
                    //===================== Deposit balance in a safe
                    if (Convert.ToInt32(dtSafeBank.Rows[0][2]) == 1)
                    {
                        CheckboxDepositSafe.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][2]) == 0)
                    {
                        CheckboxDepositSafe.Checked = false;
                    }
                    //=====================Deposit balance in a Bank
                    if (Convert.ToInt32(dtSafeBank.Rows[0][3]) == 1)
                    {
                        CheckboxDepositBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][3]) == 0)
                    {
                        CheckboxDepositBank.Checked = false;
                    }
                    //===================== Withdrawing From Safe
                    if (Convert.ToInt32(dtSafeBank.Rows[0][4]) == 1)
                    {
                        CheckboxWithdrawingSafe.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][4]) == 0)
                    {
                        CheckboxWithdrawingSafe.Checked = false;
                    }
                    //=====================Withdrawing from Bank
                    if (Convert.ToInt32(dtSafeBank.Rows[0][5]) == 1)
                    {
                        CheckboxWithdrawingBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][5]) == 0)
                    {
                        CheckboxWithdrawingBank.Checked = false;
                    }
                    //=====================Transfer between Safes
                    if (Convert.ToInt32(dtSafeBank.Rows[0][6]) == 1)
                    {
                        CheckboxTransferSafe.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][6]) == 0)
                    {
                        CheckboxTransferSafe.Checked = false;
                    }
                    //=====================Transfer between Banks
                    if (Convert.ToInt32(dtSafeBank.Rows[0][7]) == 1)
                    {
                        CheckboxTransferBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][7]) == 0)
                    {
                        CheckboxTransferBank.Checked = false;
                    }

                    //=====================Safe Bank Balance
                    if (Convert.ToInt32(dtSafeBank.Rows[0][8]) == 1)
                    {
                        CheckboxSafeBankBalance.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][8]) == 0)
                    {
                        CheckboxSafeBankBalance.Checked = false;
                    }
                    //=====================reports Safe and Bank
                    if (Convert.ToInt32(dtSafeBank.Rows[0][9]) == 1)
                    {
                        CheckboxReaportsSafeBank.Checked = true;
                    }
                    else if (Convert.ToInt32(dtSafeBank.Rows[0][9]) == 0)
                    {
                        CheckboxReaportsSafeBank.Checked = false;
                    }
                   
                }
            }
            catch (Exception)
            {

            }
        }
        //BUTTON : Save User => Safe and Bank 
        private void btnSaveUserSB_Click(object sender, EventArgs e)
        {

            try
            {
                int AddSafe = 0, DepositSafe = 0 , DepositBank = 0, WithdrawingSafe = 0, WithdrawingBank = 0, TransferSafes = 0, TransferBank = 0, SafeBankBalance = 0, ReportsSafeBank = 0;
                //=============Add new Safe 
                if (CheckboxAddSafe.Checked)
                    AddSafe = 1;
                else
                    AddSafe = 0;
                //=============Deposit in Safe 
                if (CheckboxDepositSafe.Checked)
                    DepositSafe = 1;
                else
                    DepositSafe = 0;
                //=============Deposit in Bank
                if (CheckboxDepositBank.Checked)
                    DepositBank = 1;
                else
                    DepositBank = 0;
                //=============Withdrawing Safe
                if (CheckboxWithdrawingSafe.Checked)
                    WithdrawingSafe = 1;
                else
                    WithdrawingSafe = 0;
                //=============Withdrawing Bank
                if (CheckboxWithdrawingBank.Checked)
                    WithdrawingBank = 1;
                else
                    WithdrawingBank = 0;
                //=============Transfer between Safes
                if (CheckboxTransferSafe.Checked)
                    TransferSafes = 1;
                else
                    TransferSafes = 0;
                //=============Transfer between Bank
                if (CheckboxTransferBank.Checked)
                    TransferBank = 1;
                else
                    TransferBank = 0;

                //=============Safe Bank Balance
                if (CheckboxSafeBankBalance.Checked)
                    SafeBankBalance = 1;
                else
                    SafeBankBalance = 0;
                //=============reports Safe and Bank
                if (CheckboxReaportsSafeBank.Checked)
                    ReportsSafeBank = 1;
                else
                    ReportsSafeBank = 0;


                //inser Data in Table 
                db.ExecuteData("Update Users_SafeBank Set User_AddSafe = " + AddSafe + ", User_DepositBalanceSafe = " + DepositSafe + ",User_DepositBalanceBank = " + DepositBank + ", User_WithdrawingSafe = " + WithdrawingSafe + ", User_WithdrawingBank = " + WithdrawingBank + ", User_TransferbetweenSafes = " + TransferSafes + ", User_TransferbetweenBank = " + TransferBank + ", User_SafeBankBalance = "+SafeBankBalance+ ", User_ReportsSafeBank = "+ ReportsSafeBank + " Where User_ID = " + cbxChooseUsernameSB.SelectedValue + "", "Edited Successfully");
                cbxChooseUsernameSB.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }
        //Employees Management
        DataTable dtEmployees = new DataTable();
        private void cbxChooseUsernameEM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dtEmployees.Clear();
                dtEmployees = db.ReadData("select * from Users_Employees Where User_ID = " + cbxChooseUsernameEM.SelectedValue + " ", "");
                if (dtEmployees.Rows.Count >= 1)
                {
                    //===================Employees Data 
                    if (Convert.ToInt32(dtEmployees.Rows[0][1]) == 1)
                    {
                        CheckboxEmployeeData.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][1]) == 0)
                    {
                        CheckboxEmployeeData.Checked = false;
                    }
                    //===================== Monthly Withdrawals
                    if (Convert.ToInt32(dtEmployees.Rows[0][2]) == 1)
                    {
                        CheckboxMonthlyWithdrawals.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][2]) == 0)
                    {
                        CheckboxMonthlyWithdrawals.Checked = false;
                    }

                    //==================== Salary Disbursement
                    if (Convert.ToInt32(dtEmployees.Rows[0][3]) == 1)
                    {
                        CheckboxSalaryDisbursement.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][3]) == 0)
                    {
                        CheckboxSalaryDisbursement.Checked = false;
                    }
                    //==================== Credits
                    if (Convert.ToInt32(dtEmployees.Rows[0][4]) == 1)
                    {
                        CheckboxCredits.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][4]) == 0)
                    {
                        CheckboxCredits.Checked = false;
                    }
                    //===================== Salary Report
                    if (Convert.ToInt32(dtEmployees.Rows[0][5]) == 1)
                    {
                        CheckboxSalaryReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][5]) == 0)
                    {
                        CheckboxSalaryReport.Checked = false;
                    }
                    //=====================Withdrawal Report
                    if (Convert.ToInt32(dtEmployees.Rows[0][6]) == 1)
                    {
                        CheckboxWithdrawalReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][6]) == 0)
                    {
                        CheckboxWithdrawalReport.Checked = false;
                    }
                    //=====================Credit Report
                    if (Convert.ToInt32(dtEmployees.Rows[0][7]) == 1)
                    {
                        CheckboxCreditReport.Checked = true;
                    }
                    else if (Convert.ToInt32(dtEmployees.Rows[0][7]) == 0)
                    {
                        CheckboxCreditReport.Checked = false;
                    }
                }


            }
            catch (Exception)
            {

            }
        }
        //BUTTON : add user
        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeData = 0, MonthlyWithdrawals = 0, SalaryDisbursement = 0, Credits = 0, SalaryReport = 0, WithdrawalReport = 0, CreditReport = 0;
                //=============Employee Data
                if (CheckboxEmployeeData.Checked)
                    EmployeeData = 1;
                else
                    EmployeeData = 0;
                //=============Monthly Withdrawals 
                if (CheckboxMonthlyWithdrawals.Checked)
                    MonthlyWithdrawals = 1;
                else
                    MonthlyWithdrawals = 0;

                //=============Salary Disbursement
                if (CheckboxSalaryDisbursement.Checked)
                    SalaryDisbursement = 1;
                else
                    SalaryDisbursement = 0;
                //=============Credits
                if (CheckboxCredits.Checked)
                    Credits = 1;
                else
                    Credits = 0;
                //============Salary Report
                if (CheckboxSalaryReport.Checked)
                    SalaryReport = 1;
                else
                    SalaryReport = 0;
                //=============Withdrawal Report
                if (CheckboxWithdrawalReport.Checked)
                    WithdrawalReport = 1;
                else
                    WithdrawalReport = 0;
                //=============Credit Report
                if (CheckboxCreditReport.Checked)
                    CreditReport = 1;
                else
                    CreditReport = 0;

                //inser Data in Table 
                db.ExecuteData("Update Users_Employees Set User_EmployeeData = " + EmployeeData + ", User_MonthlyWithdrawals = " + MonthlyWithdrawals + ",User_SalaryDisbursement = " + SalaryDisbursement + ", User_credits = " + Credits + ", User_SalaryReport = " + SalaryReport + ", User_WithdrawalReport = " + WithdrawalReport + ", User_CreditReport = " + CreditReport + " Where User_ID = " + cbxChooseUsernameEM.SelectedValue + "", "Edited Successfully");
                cbxChooseUsernameEM.SelectedIndex = 0;

            }
            catch (Exception)
            {
            }
        }

        private void cbxChooseUsernameSe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
