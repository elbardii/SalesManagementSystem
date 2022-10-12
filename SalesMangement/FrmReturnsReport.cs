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
    public partial class FrmReturnsReport : MaterialForm
    {
        public FrmReturnsReport()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();

        private void FrmReturnsReport_Load(object sender, EventArgs e)
        {
            DateFromRut.Text = DateTime.Now.ToShortDateString();
            DateToRut.Text = DateTime.Now.ToShortDateString();

        }
        //Total amount in returns
        //TABLE => Returns_Detalis
        private void TotalAmount()
        {
            decimal Total = 0;
            for (int i = 0; i < DgvReturnsReport.Rows.Count - 1; i++)
            {
                Total = Convert.ToDecimal(DgvReturnsReport.Rows[i].Cells[7].Value);
            }

            txtTotalAmount.Text = Total.ToString();
        }


        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRut.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRut.Value.ToString("yyyy-MM-dd");
            dt.Clear();
            if (rbtnReturnsAll.Checked == true)
            {
                //TABLE : Returns_Detalis
                dt = db.ReadData("SELECT [Order_ID] as 'Invoice Number',[Pro_Name] as 'Product Name',[Sup_Name] as 'Supplire',[Cust_Name] as 'Customer',[Quantity] as 'Quantity',[Retur_Date] as 'Return Date ',[Price] as 'Price',[Total] as 'Total',[Total_Order] as 'Total Order',[PaidUp] as 'Paid Up',[RestAmount] as 'Rest Amount',[User_Name] as 'User Name' FROM [dbo].[Returns_Detalis]  Where  CONVERT(date,Retur_Date,105) between '" + DateFrom + "' and '" + DateTo + "'  ", "");
            }
            else if (rbtnRtuSales.Checked == true)
            {
                dt = db.ReadData("SELECT Returns_Detalis.[Order_ID] as 'Invoice Number',[Pro_Name] as 'Product Name',[Sup_Name] as 'Supplire',[Cust_Name] as 'Customer',[Quantity] as 'Quantity',[Retur_Date] as 'Return Date ',[Price] as 'Price',[Total] as 'Total',[Total_Order] as 'Total Order',[PaidUp] as 'Paid Up',[RestAmount] as 'Rest Amount',[User_Name] as 'User Name' FROM [dbo].[Returns_Detalis], Returns Where [Returns_Detalis].Order_ID = Returns.Order_ID and Order_Type = N'Returns Sales'  and CONVERT(date,Retur_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "");
            }
            else if (rbtnRtuBuy.Checked == true)
            {
                dt = db.ReadData("SELECT Returns_Detalis.[Order_ID] as 'Invoice Number',[Pro_Name] as 'Product Name',[Sup_Name] as 'Supplire',[Cust_Name] as 'Customer',[Quantity] as 'Quantity',[Retur_Date] as 'Return Date ',[Price] as 'Price',[Total] as 'Total',[Total_Order] as 'Total Order',[PaidUp] as 'Paid Up',[RestAmount] as 'Rest Amount',[User_Name] as 'User Name' FROM [dbo].[Returns_Detalis], Returns Where [Returns_Detalis].Order_ID = Returns.Order_ID and Order_Type = N'Returns Buy'  and CONVERT(date,Retur_Date,105) between '" + DateFrom + "' and '" + DateTo + "' ", "");

            }
            DgvReturnsReport.DataSource = dt;
            TotalAmount();
        }
        //BUTTON : Delete Row On TABLE =>  Rerurns_Detalis 
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            string DateFrom;
            string DateTo;
            DateFrom = DateFromRut.Value.ToString("yyyy-MM-dd");
            DateTo = DateToRut.Value.ToString("yyyy-MM-dd");
            if (DgvReturnsReport.Rows.Count >= 1)
            {
                if (MessageBox.Show("Are you sure you will delete  Reports  ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.ExecuteData("Delete From Returns_Detalis  Where Order_ID = " + DgvReturnsReport.CurrentRow.Cells[0].Value + " ", "");
                    db.ExecuteData("Delete From Returns Where  Order_ID = " + DgvReturnsReport.CurrentRow.Cells[0].Value + "  ", "It has been deleted successfully");
                    btnSearsh_Click(null, null);
                }
            }
        }
    }
}
