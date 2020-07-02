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
        // Sever
        public bool IsUsernameSeverExist(string username) {
            string query = "SELECT RTRIM([username]) FROM [Account] WHERE [username] = '" + username + "' AND [group] = 1";
            DataTable dt = DBHelper.GetTable(query);
            if(dt.Rows.Count == 1 && dt.Rows[0][0].ToString() == username) return true;
            else return false;
        }

        public string GetPassword(string username) {
            string query = "SELECT RTRIM([password]) FROM [Account] WHERE [username] = '" + username + "' AND [group] = 1";
            DataTable dt = DBHelper.GetTable(query);
            if(dt.Rows.Count == 1) return dt.Rows[0][0].ToString();
            else return null;
        }

        // Clients
        public bool IsUsernameClientExist(string username) {
            string query = "SELECT RTRIM([username]) FROM [Account] WHERE [username] = '" + username + "'";
            DataTable dt = DBHelper.GetTable(query);
            if (dt.Rows.Count == 1 && dt.Rows[0][0].ToString() == username) return true;
            else return false;
        }

        public DataTable GetClientAccounts() {
            string query = "SELECT * FROM [Account] WHERE [group] = 2";
            return DBHelper.GetTable(query);
        }

        public void InsertOrUpdate(Account account) {
            SqlCommand cmd = new SqlCommand();
            int row = DBHelper.GetTable("SELECT * FROM [Account] WHERE [username] = '" + account.username + "'").Rows.Count;

            if(row > 0) cmd.CommandText = "UPDATE [Account] SET [password] = @password WHERE [username] = @username AND [group] = @group";
            else cmd.CommandText = "INSERT INTO [Account] VALUES (@username, @password, @group)";

            cmd.Parameters.AddWithValue("@username", account.username);
            cmd.Parameters.AddWithValue("@password", account.password);
            cmd.Parameters.AddWithValue("@group", account.group);

            DBHelper.ExecuteNonQuery(cmd);
        }

        public void Delete(string username) {
            string query = "DELETE FROM [Account] WHERE [username] = '" + username + "' AND [group] = 2";
            DBHelper.ExecuteNonQuery(query);
        }
    }
}
