using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security;

namespace yagmur
{
    public class crud
    {
        private static string cumle = "Data Source=.;Initial Catalog=ayak;Integrated Security=True";
        public  SqlConnection con=new SqlConnection(cumle);
        public SqlCommand cmd; 
        public SqlDataReader reader;
        public DataSet ds;
        public DataTable dt;
        public SqlDataAdapter da;

        public void openConnection()
        {
            
            try
            {
                if (this.con.State == ConnectionState.Closed)
                {
                    this.con.Open();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bağlantı Hatası");
            }
        }
        public void closeConnection()
        {
           
          try
            {
                if (this.con.State == ConnectionState.Open)
                {
                    this.con.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bağlantı Hatası");
            }

        }
        public  DataSet doldur(string sorgu)
        {
            this.openConnection();
            this.cmd = new SqlCommand(sorgu, this.con);
            this.da = new SqlDataAdapter(cmd);
            this.ds = new DataSet();
            this.da.Fill(this.ds);
            this.closeConnection();
            this.da.Dispose();
            this.con.Dispose();
            return this.ds;
        }
        public int sorgu (string sorgu)
        {
            this.cmd = new SqlCommand(sorgu, this.con);
            int donen =this.cmd.ExecuteNonQuery();

            return donen;
        }

    }
}
