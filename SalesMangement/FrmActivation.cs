using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SalesMangement
{
    public partial class FrmActivation : MaterialForm
    {
        public FrmActivation()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);
        }
        /// <summary>
        /// Finds the MAC address of the first operation NIC found.
        /// </summary>
        /// <returns>The MAC address.</returns>
        private string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }
        Database db = new Database();
        DataTable dt = new DataTable();
        private void activation(string key)
        {
            try
            {
                string MACAddresses = GetMacAddress();
                dt.Clear();
                dt = db.ReadData("select COUNT(*) as CountIthems from KeyActivation Where (UserKey = CONVERT(uniqueidentifier,'"+ key +"') and UserMAC is Null ) or (UserKey = CONVERT(uniqueidentifier,'"+ key +"') and UserMAC = '"+ MACAddresses +"') ", "");
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("The program has been successfully activated", "Confirm", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Properties.Settings.Default.KeyActivation = key;
                    Properties.Settings.Default.Save();
                    //update database
                    db.ExecuteData("Update KeyActivation Set UserMAC = '" + MACAddresses + "' Where UserKey = CONVERT(uniqueidentifier,'"+ key +"')", "");
                    
                }
                else
                {
                    MessageBox.Show("Activation code is wrong", "Confirm");
                    return;
                }

                this.Close();
                

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        private string identifier(string wmiClass, string wmiProperty)
        //Return a hardware identifier
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                        
                    {
                        //System.NullReferenceException
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmActivation_Load(object sender, EventArgs e)
        {
           //string Key = identifier("Win32_DiskDrive", "SerialNumber");
           // string signature = identifier("Win32_DiskDrive", "Signature");
           // Labelnumber1.Text = signature;
           //Labelnumber2.Text = Key;
           // x = (Convert.ToDecimal(signature) * 12345).ToString();
        }
        String ActivationNumber = "";
        private void btnActivation_Click(object sender, EventArgs e)
        {
            if (txtActivationNumber.Text == "")
            {
                MessageBox.Show("Please enter the activation code", "Confirm");
                return;
            }
            ActivationNumber = txtActivationNumber.Text;
            activation(ActivationNumber);
            Properties.Settings.Default.Activation = "YES";
            Properties.Settings.Default.Save();

        }
    }
}
