using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS {
    public class HistoryUsedBUS {
        public HistoryUsed[] GetHistoryUsedsFromUsername(string username) {
            DataTable dt = new HistoryUsedDAO().GetHistoriesFromUsername(username);
            int count = dt.Rows.Count;
            HistoryUsed[] historyUseds = new HistoryUsed[count];

            for (int i = 0; i < count; ++i) {
                historyUseds[i] = new HistoryUsed();
                historyUseds[i].history_id = dt.Rows[i]["history_id"].ToString();
                historyUseds[i].time = (DateTime)dt.Rows[i]["time"];
                historyUseds[i].ipv4 = dt.Rows[i]["ipv4"].ToString();
                historyUseds[i].username = dt.Rows[i]["username"].ToString();
                historyUseds[i].computerClient = new ComputerClientBUS().GetComputerClientFromIpv4(historyUseds[i].ipv4);
            }

            return historyUseds;
        }
    }
}
