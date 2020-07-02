using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class DBHelper {
        public static SqlConnection GetConnection() {
            return new SqlConnection(@"Data Source=103.95.197.121,9696;Initial Catalog=GamingManager;User ID=DACNPM;Password=khoa18@itf");
        }

        public static DataTable GetTable(string query) {
            SqlConnection conn = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void ExecuteNonQuery(string query) {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ExecuteNonQuery(SqlCommand cmd) {
            SqlConnection conn = GetConnection();
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
