using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace SalesMangement
{
    class Database
    {
        //connection to database
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-K0R8A28U;Initial Catalog=Sales_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        //select 
        public DataTable ReadData(string Stmt,string Message)
        {
            DataTable Tbl = new DataTable();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = Stmt;
                conn.Open();
                //load data from database to tbl
                Tbl.Load(cmd.ExecuteReader());
                conn.Close();
                if (Message != string.Empty)
                {
                    MessageBox.Show(Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Tbl;

        }
        //insert update delete
        public bool ExecuteData(string Stmt, string Message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = Stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if(Message != string.Empty)
                {
                    MessageBox.Show(Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;

            }
            catch (Exception )
            {

                return false;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
