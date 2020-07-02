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

        public void Update(Timer timer) {
            SqlCommand cmd = new SqlCommand();         
            cmd.CommandText = "UPDATE [Timer] SET time_left = @time_left, money_left = @money_left WHERE timer_id = @timer_id AND username = @username";
            cmd.Parameters.AddWithValue("@timer_id", timer.timer_id);
            cmd.Parameters.AddWithValue("@time_left", timer.time_left);
            cmd.Parameters.AddWithValue("@money_left", timer.money_left);
            cmd.Parameters.AddWithValue("@username", timer.username);
            DBHelper.ExecuteNonQuery(cmd);
        }
    }
}
