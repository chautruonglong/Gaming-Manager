using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class HistoryUsedDAO {
        public DataTable GetHistoriesFromUsername(string username) {
            string query = "SELECT * FROM [HistoryUsed] WHERE [username] = '" + username + "'";
            return DBHelper.GetTable(query);
        }

        public DataTable GetHistoriesFromIpv4(string ipv4) {
            string query = "SELECT * FROM [HistoryUsed] WHERE [ipv4] = '" + ipv4 + "'";
            return DBHelper.GetTable(query);
        }
    }
}
