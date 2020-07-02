using System.Collections.Generic;

namespace DTO {
    public class Food {      
        public string food_id { get; set; }
        public string name { get; set; }
        public byte[] image { get; set; }
        public float cost { get; set; }

        List<HistoryFood> historyFoods { get; set; }

        public Food() {
            historyFoods = new List<HistoryFood>();
        }
    }
}
