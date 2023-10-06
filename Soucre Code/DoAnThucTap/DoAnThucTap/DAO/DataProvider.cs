using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnThucTap.DAO
{
    public class DataProvider
    {
        private string strConn = global::DoAnThucTap.Properties.Settings.Default.QLSHOPConnectionString;
        SqlConnection Conn;
        SqlCommand Cmd;
        SqlDataAdapter Dap;

        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            DataTable Dt = new DataTable();
            using (Conn = new SqlConnection(strConn)){
                Conn.Open();
                Cmd = new SqlCommand(query, Conn);
                Dap = new SqlDataAdapter(Cmd);
                Dap.Fill(Dt);
                Conn.Close();
            }
            return Dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int Dt = 0;
            using (Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                Cmd = new SqlCommand(query, Conn);
                Dt = Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            return Dt;
        }

        public object ExecuteScalar(string query)
        {
            object Dt = 0;
            using (Conn = new SqlConnection(strConn))
            {
                Conn.Open();
                Cmd = new SqlCommand(query, Conn);
                Dt = Cmd.ExecuteScalar();
                Conn.Close();
            }
            return Dt;
        }
    }
}
