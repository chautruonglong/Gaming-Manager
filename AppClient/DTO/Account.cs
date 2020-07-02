using System.Collections.Generic;

namespace DTO {
    public class Account {
        public string username { get; set; }
        public string password { get; set; }
        public int group { get; set; }

        public DetailAccount detailAccount { get; set; }
        public Timer timer { get; set; }
        public List<HistoryFood> historyFoods { get; set; }
        public List<HistoryUsed> historyUseds { get; set; }

        public Account() {
            historyFoods = new List<HistoryFood>();
            historyUseds = new List<HistoryUsed>();
        }
    }
}