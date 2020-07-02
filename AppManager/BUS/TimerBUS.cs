using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS {
    public class TimerBUS {
        public Timer GetTimerAccount(string username) {
            DataTable dt = new DAO.TimerDAO().GetTimer(username);
            Timer timer = new Timer() {
                timer_id = dt.Rows[0]["timer_id"].ToString(),
                time_left = int.Parse(dt.Rows[0]["time_left"].ToString()),
                money_left = float.Parse(dt.Rows[0]["money_left"].ToString()),
                username = username
            };
            return timer;
        }

        public void InsertOrUpdate(Timer timer, float money) {
            timer.money_left += money;
            timer.time_left += DTO.Timer.MoneyToTime(money);
            new TimerDAO().InsertOrUpdate(timer);
        }

        public string GetTimerIdFromUsername(string username) {
            DataTable dt = DBHelper.GetTable("SELECT [timer_id] FROM [Timer] WHERE [username] = '" + username + "'");
            return dt.Rows[0][0].ToString();
        }
    }
}
