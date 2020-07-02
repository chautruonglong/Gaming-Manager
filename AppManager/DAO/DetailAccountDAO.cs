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

        public void InsertOrUpdate(DetailAccount detail) {
            SqlCommand cmd = new SqlCommand();
            int rows = DBHelper.GetTable("SELECT * FROM [DetailAccount] WHERE [detail_id] = '" + detail.detail_id + "'").Rows.Count;

            if (rows > 0) cmd.CommandText = "UPDATE [DetailAccount] SET name = @name, phone = @phone, age = @age, cmnd = @cmnd WHERE detail_id = @detail_id AND username = @username)";
            else {
                cmd.CommandText = "INSERT INTO [DetailAccount] VALUES(@detail_id, @name, @phone, @age, @cmnd, @username)";
                detail.detail_id = GenerateDetailId();
            }

            cmd.Parameters.AddWithValue("@detail_id", detail.detail_id);
            cmd.Parameters.AddWithValue("@name", detail.name);
            cmd.Parameters.AddWithValue("@phone", detail.phone);
            cmd.Parameters.AddWithValue("@age", detail.age);
            cmd.Parameters.AddWithValue("@cmnd", detail.cmnd);
            cmd.Parameters.AddWithValue("@username", detail.username);

            DBHelper.ExecuteNonQuery(cmd);
        }

        public string GenerateDetailId() {
            int count = Count - 1;
            string detail_id = "Detail" + count.ToString();
            int rows = DBHelper.GetTable("SELECT * FROM [DetailAccount] WHERE [detail_id] = '" + detail_id + "'").Rows.Count;
            while (rows > 0) {
                count++;
                detail_id = "Detail" + count.ToString();
                rows = DBHelper.GetTable("SELECT * FROM [DetailAccount] WHERE [detail_id] = '" + detail_id + "'").Rows.Count;
            }
            return detail_id;
        }

        public int Count {
            get {
                string query = "SELECT * FROM [DetailAccount]";
                return DBHelper.GetTable(query).Rows.Count;
            }
        }
    }
}
