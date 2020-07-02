using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class ComputerClientDAO {
       public DataTable GetComputerClients() {
            string query = "SELECT * FROM [ComputerClient]";
            return DBHelper.GetTable(query);
       }

       public void Insert(ComputerClient computerClient) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO [ComputerClient] VALUES (@ipv4, @number)";
            cmd.Parameters.AddWithValue("@ipv4", computerClient.ipv4);
            cmd.Parameters.AddWithValue("@number", computerClient.number);
            DBHelper.ExecuteNonQuery(cmd);
       }

       public int Count {
            get {
                int count = DBHelper.GetTable("SELECT * FROM [ComputerClient]").Rows.Count;
                return count;
            }
        }
    }
}
