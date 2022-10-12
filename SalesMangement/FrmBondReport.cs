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
    public partial class FrmBondReport : MaterialForm

    {
        public FrmBondReport()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        DataTable dt = new DataTable();
        private void FrmBondReport_Load(object sender, EventArgs e)
        {
            DateFrom.Text = DateTime.Now.ToString();
            DateTo.Text = DateTime.Now.ToString();
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            string dateFrom;
            string dateTo;
           if(rbtnCatchReceipt.Checked)
            {
                dateFrom = DateFrom.Value.ToString("yyyy-MM-dd");
                dateTo = DateTo.Value.ToString("yyyy-MM-dd");
                dt.Clear();
                dt = db.ReadData("SELECT [Order_ID] as 'Bond Number ',[Name] as 'Responsible Name' ,[Price]  as 'Amount' ,[Date],[Bond_From] as 'Band From',[Reason]FROM [dbo].[Bonds] where  CONVERT(date,Date,105) between  '" + dateFrom + "' and '" + dateTo + "' ", "");
                if (dt.Rows.Count >= 1)
                {
                    DgvReport.DataSource = dt;
                    decimal Sum = 0;
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        Sum += Convert.ToDecimal(dt.Rows[i][2]);
                    }
                    //function that returns 2 numbers after the comma
                    txtTotal.Text = $"{Math.Round(Sum, 2)} DH";
                }
                else
                {
                    txtTotal.Text = "0 DH";
                }
            }
           else
            {
                dateFrom = DateFrom.Value.ToString("yyyy-MM-dd");
                dateTo = DateTo.Value.ToString("yyyy-MM-dd");
                dt.Clear();
                dt = db.ReadData("SELECT [Order_ID] as 'Bond Number ' ,[Name] as 'Responsible Name',[Price],[Date],[Cashing_To] as 'Band To',[Reason] FROM [dbo].[Bond_Receipt]  where  CONVERT(date,Date,105) between  '" + dateFrom + "' and '" + dateTo + "' ", "");
                if (dt.Rows.Count >= 1)
                {
                    DgvReport.DataSource = dt;
                    decimal Sum = 0;
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        Sum += Convert.ToDecimal(dt.Rows[i][2]);
                    }
                    //function that returns 2 numbers after the comma
                    txtTotal.Text = $"{Math.Round(Sum, 2)} DH";
                }
                else
                {
                    txtTotal.Text = "0 DH";
                }
            }
        }
        //BUTTON  : delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dateFrom;
            string dateTo;
           
                dateFrom = DateFrom.Value.ToString("yyyy-MM-dd");
                dateTo = DateTo.Value.ToString("yyyy-MM-dd");
                dt.Clear();
                if (MessageBox.Show("Are you sure to delete this data? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (rbtnCatchReceipt.Checked)
                    {
                        db.ExecuteData("delete from Bonds where CONVERT(Date,Date,105) between '" + dateFrom + "' and '" + dateTo + "' ", "It has been deleted successfully");
                        dt.Clear();
                    }
                    else
                    db.ExecuteData("delete from Bond_Receipt where CONVERT(Date,Date,105) between '" + dateFrom + "' and '" + dateTo + "' ", "It has been deleted successfully");
                    dt.Clear();
            }
            
          
            btnSearsh_Click(null, null);
        }
    }
}
