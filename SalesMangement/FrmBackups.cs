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
using Microsoft.SqlServer.Management.Smo;


namespace SalesMangement
{
    public partial class FrmBackups : MaterialForm
    {
        public FrmBackups()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE);

        }
        Database db = new Database();
        //BUTTON : Take Backup
        private void btnTakeBackup_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.Date.ToString("dd-MM-yyyy");
            
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup File (*.bac) | *.bac";
                saveFileDialog.FileName = "Sales_Management_Backup_"+date;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    db.ExecuteData("backup database Sales_System To Disk = '"+saveFileDialog.FileName+"'", "Backup has been taken");
                }
            
        }
        //BUTTON : Restore Backup
        private void btnRestoreBackups_Click(object sender, EventArgs e)
        {
            Server server = new Server("LAPTOP-K0R8A28U");
            Microsoft.SqlServer.Management.Smo.Database db = server.Databases["Sales_System"];
            if(db != null)
            {
                server.KillAllProcesses(db.Name);
            }
            Restore restore = new Restore();
            restore.Database = db.Name;
            restore.Action = RestoreActionType.Database;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup File (*.bac) | *.bac";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                restore.Devices.AddDevice(openFileDialog.FileName, DeviceType.File);
                restore.ReplaceDatabase = true;
                restore.NoRecovery = false;
                restore.SqlRestore(server);
                MessageBox.Show("Backup restored successfully", "confirmation", MessageBoxButtons.OK);
            }



        }
    }
}
