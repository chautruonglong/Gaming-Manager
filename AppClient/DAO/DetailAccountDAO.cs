using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO {
    public class DetailAccountDAO {
        public DataTable GetDetailAccount(string username) {
            string query = "SELECT * FROM [DetailAccount] WHERE [username] = '" + username + "'";
            return DBHelper.GetTable(query);
        }

        public void Update(DetailAccount detail) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE [DetailAccount] SET [name] = @name, [phone] = @phone, [age] = @age, [cmnd] = @cmnd WHERE [detail_id] = @detail_id AND [username] = @username";
            cmd.Parameters.AddWithValue("@detail_id", detail.detail_id);
            cmd.Parameters.AddWithValue("@name", detail.name);
            cmd.Parameters.AddWithValue("@phone", detail.phone);
            cmd.Parameters.AddWithValue("@age", detail.age);
            cmd.Parameters.AddWithValue("@cmnd", detail.cmnd);
            cmd.Parameters.AddWithValue("@username", detail.username);
            DBHelper.ExecuteNonQuery(cmd);
        }
    }
}
