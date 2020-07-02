using System;

namespace DTO {
    public class HistoryFood {
        public string history_id { get; set; }
        public DateTime time { get; set; }
        public string username { get; set; }
        public string food_id { get; set; }

        public Account account { get; set; }
        public Food food { get; set; }
    }
}
