using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;

namespace SalesMangement
{
    public partial class FrmDashboard : MaterialForm
    {
        public FrmDashboard()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        Database db = new Database();
        //FORM : Customers
        private void btnCustomerData_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_CustomerData  From Users_Customers Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmCustomerData CustomerData = new FrmCustomerData();
            CustomerData.ShowDialog();
        }
        //FORM : Suppliers
        private void btnSupplierData_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SuppliersData  From Users_Suppliers Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSuppliersData SuppliersData = new FrmSuppliersData();
            SuppliersData.ShowDialog();
        }
        //FORM : Expenses
        private void btnExpenses_Click(object sender, EventArgs e)
        {

            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_ExpensesType From Users_Expenses Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmExpenses Expenses = new FrmExpenses();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_ExpenseManagement From Users_Expenses Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                Expenses.tabExpenses.Dispose();
            }

            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_ExpensesReports From Users_Expenses Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                Expenses.tabExpensesReports.Dispose();
            }
            Expenses.ShowDialog();
            
        }
        //FORM : Product Management
        private void btnSettingsPro_Click(object sender, EventArgs e)
        {

            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_AddProduct From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmProductManagement ProductManagement = new FrmProductManagement();
            ProductManagement.ShowDialog();
        }
        //FORM : Buy
        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_PurchasingManagement From Users_Purchasing Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBuy Buy = new FrmBuy();
            Buy.ShowDialog();
        }
        //FORM : Suppliers Accounts
        private void btnSupplierAccounts_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SuppliersAccounts  From Users_Suppliers Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSuppliersAccounts SuppliersAccounts = new FrmSuppliersAccounts();
            SuppliersAccounts.ShowDialog();  
        }
        //FORM : Supplier Reports
        private void btnSupplierReports_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SuppliersReports  From Users_Suppliers Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSupplierReports SupplierReports = new FrmSupplierReports();
            SupplierReports.ShowDialog();
        }
        //FORM : Buy Report
        private void btnPurchaseReport_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_PurchasingReports  From Users_Purchasing Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBuyReport BuyReport = new FrmBuyReport();
            BuyReport.ShowDialog();
        }
        //FORM : Sales Management 
        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SalesManagement  From Users_Sales Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSalesManagement SalesManagement = new FrmSalesManagement(); 
            SalesManagement.ShowDialog();
        }
        //FORM : Customers Accounts
        private void btnCustomerAccounts_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_CustomerAccounts From Users_Customers Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmCustomersAccounts frmCustomersAccounts = new FrmCustomersAccounts();
            frmCustomersAccounts.ShowDialog();  
        }
        //FORM : Customers Repoets
        private void btnReports_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_CustomersReports From Users_Customers Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmCustomerReports frmReports = new FrmCustomerReports();
            frmReports.ShowDialog();
        }
        //FORM : Sales Reports
        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Sales_Report  From Users_Sales Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSalesReport frmSalesReport = new FrmSalesReport();
            frmSalesReport.ShowDialog();    
        }
        //FORM : Sales Profit
        private void btnSalesProfit_Click(object sender, EventArgs e)
        {

            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Sales_Profit  From Users_Sales Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSalesProfits  frmSalesProfits = new FrmSalesProfits();
            frmSalesProfits.ShowDialog();
        }
        //FORM : Returns
        private void btnReturns_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_ReturnsManagement  From Users_Returns Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmReturns frmReturns = new FrmReturns();
            frmReturns.ShowDialog();
        }
        //FORM : Returns Report
        private void btnReturnsReports_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_ReturnsReport  From Users_Returns Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmReturnsReport frmReturnsReport = new FrmReturnsReport();
            frmReturnsReport.ShowDialog();  
        }
        //FORM : Safe 
        private void btnSafe_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPermission = new DataTable();
                dtPermission.Clear();
                dtPermission = db.ReadData("select User_AddSafe From Users_SafeBank Where User_ID = " + User_ID + "", "");
                if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
                {
                    MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                FrmSafe frmSafe = new FrmSafe();
                DataTable dtPermission2 = new DataTable();
                dtPermission2.Clear();
                dtPermission2 = db.ReadData("select User_DepositBalanceSafe From Users_SafeBank Where User_ID = " + User_ID + "", "");
                if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
                {
                    frmSafe.AddMoney.Dispose();
                }
                dtPermission2.Clear();
                dtPermission2 = db.ReadData("select User_WithdrawingSafe From Users_SafeBank Where User_ID = " + User_ID + "", "");
                if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
                {
                    frmSafe.WithdrowMoney.Dispose();
                }
                dtPermission2.Clear();
                dtPermission2 = db.ReadData("select User_ReportsSafeBank From Users_SafeBank Where User_ID = " + User_ID + "", "");
                if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
                {
                    frmSafe.Treasurydeporeport.Dispose();
                    frmSafe.TotalWithdrawalReport.Dispose();
                }
                frmSafe.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
        //FORM : Bank
        private void btnBank_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_DepositBalanceBank From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBank frmBank = new FrmBank();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_WithdrawingBank From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmBank.WithdrawBank.Dispose();
            }
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_ReportsSafeBank From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmBank.Bankdeposreport.Dispose();
                frmBank.BankWithdReport.Dispose();
            }
            frmBank.ShowDialog();   
        }
        //FORM : Transfers 
        private void btnTransfers_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_TransferbetweenSafes From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmTransfers frmTransfers = new FrmTransfers();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_TransferbetweenBank From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmTransfers.TrandferBetSafeBank.Dispose();
            }
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_ReportsSafeBank From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmTransfers.transferreportbetweentanks.Dispose();
                frmTransfers.ReportbetweeSafeBank.Dispose();
            }
            frmTransfers.ShowDialog();  
        }
        //FORM : Employees Information 
        private void btnEmployeesInfo_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_EmployeeData From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmEmployeesInformation frmEmployeesInformation = new FrmEmployeesInformation();
            frmEmployeesInformation.ShowDialog();   
        }
        //FORM : Employees Money 
        private void btnEmployeeMoney_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SalaryDisbursement From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmEmployeeBenefits frmEmployeeBenefits = new FrmEmployeeBenefits();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_credits From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmEmployeeBenefits.Employeeorrowing.Dispose();
            }
            frmEmployeeBenefits.ShowDialog();
        }
        //FORM : Employees Reports
        private void btnEmployeesReport_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SalaryReport From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmEmployeesReport frmEmployeesReport = new FrmEmployeesReport();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_WithdrawalReport From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmEmployeesReport.WithdrawalReport.Dispose();
            }

            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_CreditReport From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmEmployeesReport.CreditReport.Dispose();
            }
            frmEmployeesReport.ShowDialog();
        }
        //FORM : Bonds 
        private void btnBond_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Receipt From Users_Expenses Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBonds frmBonds = new FrmBonds();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_ReceiptVoucher From Users_Expenses Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmBonds.VoucherExchange.Dispose();
            }
            frmBonds.ShowDialog();  
        }
        //FORM : Bond Reports
        private void btnBondReport_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_BondReport From Users_Expenses Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBondReport frmBondReport = new FrmBondReport();
            frmBondReport.ShowDialog(); 
        }
        //FORM : Backups
        private void btnBackups_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_TakeBackups From Users_Backups Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBackups frmBackups = new FrmBackups();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_RestoreBackups From Users_Backups Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmBackups.btnRestoreBackups.Dispose();
            }
            frmBackups.ShowDialog();
        }
        //FORM : units
        private void btnUnits_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Units From Users_Settings Where User_ID = " + User_ID+"", "");
            if (Convert.ToInt32( dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmUnits frmUnits = new FrmUnits();
            frmUnits.ShowDialog();  
        }
        //FORM : Item Group
        private void btnItemGroup_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_ProductCategories From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmItemGroup frmItemGroup = new FrmItemGroup();
            frmItemGroup.ShowDialog();  
        }
        //FORM :Add WareHouse
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_AddWarehouse From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmWarehouse frmWarehouse = new FrmWarehouse();
            DataTable dtPermission2 = new DataTable();
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_ShowWarehouses From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            { 
                frmWarehouse.ShowWarehouses.Dispose();
            }
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_WarehouseReport From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmWarehouse.warehousereport.Dispose();
            }
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_DamagedProducts From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmWarehouse.DamagedProducts.Dispose();
            }
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_DamageReport From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmWarehouse.DamageReport.Dispose();
            }
            dtPermission2.Clear();
            dtPermission2 = db.ReadData("select User_TransferWarehouses From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission2.Rows[0][0]) == 0)
            {
                frmWarehouse.TransferProductsBetween.Dispose();
            }
            frmWarehouse.ShowDialog();




        }
        //FORM : Permission 
        private void btnUserAccess_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Permissions From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmPermission frmPermission = new FrmPermission();  
            frmPermission.ShowDialog(); 
        }
        //FORM : General Settings
        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Settings From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmGeneralSettings frmGeneralSettings = new FrmGeneralSettings();   
            frmGeneralSettings.ShowDialog();    
        }
        //FORM : Show Products
        private void btnShowProdcuts_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_ShowProducts From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmShowProducts frmShowProducts = new FrmShowProducts();
            frmShowProducts.ShowDialog();   
        }

        private void btnTaxDeclaration_Click(object sender, EventArgs e)
        {
            //DataTable dtPermission = new DataTable();
            //dtPermission.Clear();
            //dtPermission = db.ReadData("select User_TaxDeclaration From Users_Settings Where User_ID = " + User_ID + "", "");
            //if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            //{
            //    MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            FrmTaxesReports frmTaxesReports = new FrmTaxesReports();
            frmTaxesReports.ShowDialog();
        }
      
        int User_ID = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                User_ID = Convert.ToInt32( db.ReadData("select * from Users Where UserName = N'"+Properties.Settings.Default.UserName+"'", "").Rows[0][0]);
            }
            catch (Exception)
            {

            }
        }
        //Form user Premission Dashboard
        private void btnUserPermission_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Permissions From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmPermission frmPermission = new FrmPermission();
            frmPermission.ShowDialog();
        }
        //Form Safe Dashboard

        private void btnSafeDash_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_AddSafe From Users_SafeBank Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSafe frmSafe = new FrmSafe();
            frmSafe.ShowDialog();

        }
        //Form Add Products Dashboard
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_AddProduct From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmProductManagement ProductManagement = new FrmProductManagement();
            ProductManagement.ShowDialog();
        }
        //from Sales Management Dashboard
        private void btnSalesManagementDash_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_SalesManagement  From Users_Sales Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmSalesManagement SalesManagement = new FrmSalesManagement();
            SalesManagement.ShowDialog();
        }
        //Form buy Managemant Dashboard 
        private void btnBuyManagement_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_PurchasingManagement From Users_Purchasing Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBuy Buy = new FrmBuy();
            Buy.ShowDialog();
        }
        //Button Exit 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //BUTTON Add New User 
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {

            FrmAddNewUser frmAddNewUser = new FrmAddNewUser();
            frmAddNewUser.ShowDialog(); 
        }
        //button settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_Settings From Users_Settings Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmGeneralSettings frmGeneralSettings = new FrmGeneralSettings();
            frmGeneralSettings.ShowDialog();
        }
        //button Employees information 
        private void btnEmployeesinformation_Click(object sender, EventArgs e)
        {
            DataTable dtPermission = new DataTable();
            dtPermission.Clear();
            dtPermission = db.ReadData("select User_EmployeeData From Users_Employees Where User_ID = " + User_ID + "", "");
            if (Convert.ToInt32(dtPermission.Rows[0][0]) == 0)
            {
                MessageBox.Show("You do not have access to this screen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmEmployeesInformation frmEmployeesInformation = new FrmEmployeesInformation();
            frmEmployeesInformation.ShowDialog();
        }

        MaterialSkinManager Tmanager = MaterialSkinManager.Instance;

        private void SwitchDark_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchDark.Checked)
                Tmanager.Theme = MaterialSkinManager.Themes.DARK;
            else
                Tmanager.Theme = MaterialSkinManager.Themes.LIGHT;

        }
    }
}

