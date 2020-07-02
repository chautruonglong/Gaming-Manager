using System.Collections.Generic;

namespace DTO {
    public class ComputerClient {
        public string ipv4 { get; set; }
        public int number { get; set; }

        public List<HistoryUsed> historyUseds { get; set; }

        public ComputerClient() {
            historyUseds = new List<HistoryUsed>();
        }
    }
}