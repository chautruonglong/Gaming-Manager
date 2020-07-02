using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO {
    public class AccountDAO {
        public bool IsUsernameExist(string username) {
            string query = "SELECT RTRIM([username]) FROM [Account] WHERE [username] = '" + username + "'";
            DataTable dt = DBHelper.GetTable(query);
            if(dt.Rows.Count == 1 && dt.Rows[0][0].ToString() == username) return true;
            else return false;
        }

        public string GetPassword(string username) {
            string query = "SELECT RTRIM([password]) FROM [Account] WHERE [username] = '" + username + "'";
            DataTable dt = DBHelper.GetTable(query);
            if(dt.Rows.Count == 1) return dt.Rows[0][0].ToString();
            else return null;
        }

        public void Update(Account account) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE [Account] SET [password] = @password WHERE [username] = @username";
            cmd.Parameters.AddWithValue("@username", account.username);
            cmd.Parameters.AddWithValue("@password", account.password);
            DBHelper.ExecuteNonQuery(cmd);
        }
    }
}
