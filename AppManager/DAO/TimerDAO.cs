using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO {
    public class TimerDAO {
        public DataTable GetTimer(string username) {
            string query = "SELECT * FROM [Timer] WHERE [username] = '" + username + "'";
            return DBHelper.GetTable(query);    
        }

        public void InsertOrUpdate(Timer timer) {
            SqlCommand cmd = new SqlCommand();
            int rows = DBHelper.GetTable("SELECT * FROM [Timer] WHERE [timer_id] = '" + timer.timer_id + "'").Rows.Count;

            if (rows > 0) cmd.CommandText = "UPDATE [Timer] SET time_left = @time_left, money_left = @money_left WHERE timer_id = @timer_id AND username = @username";
            else {
                cmd.CommandText = "INSERT INTO [Timer] Values(@timer_id, @time_left, @money_left, @username)";
                timer.timer_id = GenerateTimerId();
            }

            cmd.Parameters.AddWithValue("@timer_id", timer.timer_id);
            cmd.Parameters.AddWithValue("@time_left", timer.time_left);
            cmd.Parameters.AddWithValue("@money_left", timer.money_left);
            cmd.Parameters.AddWithValue("@username", timer.username);

            DBHelper.ExecuteNonQuery(cmd);
        }


        public string GenerateTimerId() {
            int count = Count - 1;
            string timer_id = "Timer" + count.ToString();
            int rows = DBHelper.GetTable("SELECT * FROM [Timer] WHERE [timer_id] = '" + timer_id + "'").Rows.Count;
            while (rows > 0) {
                count++;
                timer_id = "Timer" + count.ToString();
                rows = DBHelper.GetTable("SELECT * FROM [Timer] WHERE [timer_id] = '" + timer_id + "'").Rows.Count;
            }
            return timer_id;
        }

        public int Count {
            get {
                string query = "SELECT * FROM [Timer]";
                return DBHelper.GetTable(query).Rows.Count;
            }
        }
    }
}
