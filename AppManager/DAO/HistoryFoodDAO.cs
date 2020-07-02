using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class HistoryFoodDAO {
        public DataTable GetHistoriesFromFoodId(string food_id) {
            string query = "SELECT * FROM [HistoryFood] WHERE [food_id] = '" + food_id + "'";
            return DBHelper.GetTable(query);
        }

        public DataTable GetHistoriesFromUsername(string username) {
            string query = "SELECT * FROM [HistoryFood] WHERE [username] = '" + username + "'";
            return DBHelper.GetTable(query);
        }
    }
}
