using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLGR.DataLayer
{
    class DataAccessHelper
    {
        #region Data access properties
        SqlConnection con;
        SqlCommand cmd;
        public DataTable dt;
        string path = System.IO.Directory.GetCurrentDirectory() + @"\QLGR.mdf";
        
        #endregion

        #region Init properties
        public DataAccessHelper ()
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + this.path + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
            //string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + this.path + ";Integrated Security=True;Connect Timeout=30";
            //string connectionString = @"Server=(LocalDB)\v11.0;AttachDbFilename=" + this.path+ ";UId=sa;Pwd=sa;Integrated Security=true";
            String connectionString = Properties.Settings.Default.QLGRCon.ToString();

            con = new SqlConnection(connectionString);
        }
        #endregion

        #region Procceed with database
        public void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        private void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public DataTable GetDataTable(string select)
        {
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        public SqlCommand Command(String commandString)
        {
            this.cmd = new SqlCommand(commandString, con);
            return cmd;
        }
    }
}
