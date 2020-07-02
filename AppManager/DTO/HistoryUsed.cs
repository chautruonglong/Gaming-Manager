using System;

namespace DTO {
    public class HistoryUsed {
        public string history_id { get; set; }
        public DateTime time { get; set; }
        public string username { get; set; }
        public string ipv4 { get; set; }
    
        public Account account { get; set; }
        public ComputerClient computerClient { get; set; }
    }
}
