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
    public partial class FrmPayBuy : MaterialForm
    {
        public FrmPayBuy()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        private void FrmPayBuy_Load(object sender, EventArgs e)
        {
            //txtPaidUp.Focus();
            try
            {
                txtTotal.Text =( Properties.Settings.Default.TotalOrder).ToString();

            }
            catch (Exception)
            {
            }
            txtPaidUp.Text = "0.0";
            txtRestAmount.Text = "0.0";
            txtPaidUp.Focus();

        }

        private void txtPaidUp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal RestAmount = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtPaidUp.Text);
                txtRestAmount.Text = Math.Round(RestAmount, 2).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if(txtPaidUp.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The Amount Paid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Properties.Settings.Default.TotalOrder = Convert.ToDecimal(txtTotal.Text);
            Properties.Settings.Default.PaidUp = Convert.ToDecimal(txtPaidUp.Text); 
            Properties.Settings.Default.RestAmount= Convert.ToDecimal(txtRestAmount.Text);
            Properties.Settings.Default.CheckButton = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void FrmPayBuy_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtPaidUp.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter The Amount Paid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Properties.Settings.Default.TotalOrder = Convert.ToDecimal(txtTotal.Text);
                Properties.Settings.Default.PaidUp = Convert.ToDecimal(txtPaidUp.Text);
                Properties.Settings.Default.RestAmount = Convert.ToDecimal(txtRestAmount.Text);
                Properties.Settings.Default.CheckButton = true;
                Properties.Settings.Default.Save();
                Close();
            }
            else if(e.KeyCode == Keys.F12)
                {
                Properties.Settings.Default.CheckButton = false;
                Properties.Settings.Default.Save();
                Close();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckButton = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPaidUp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRestAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
