using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SqlClass
{
    public class ConnectSQL
    {
        SqlConnection conn;
        public void createConnection(string pConnectionstring)
        {
            conn = new SqlConnection("Data Source = ;Initial Catalog= ;Integrated Security = true");
        }
        public void testConnection()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception)
            {
                conn.Close();
            }
        }

        public DataTable ExcuteQuery(string pQuery)
        {
            testConnection();
            SqlCommand cmd = new SqlCommand(pQuery, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();//Chứa dữ liệu bảng
            ad.Fill(dt);
            return dt;
        }

        //Insert
        public bool insert(string pQuery, SqlConnection pConnection)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(pQuery, pConnection);
                int kq = cmd.ExecuteNonQuery();
                return (kq < 0) ? true : false;
            }
            catch
            {
                //Thêm thất bại
                return false;
            }
        }
    }
}
