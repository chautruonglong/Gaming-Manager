using System;

namespace DTO {
    public class Timer {
        public string timer_id { get; set; }
        public int time_left { get; set; }
        public float money_left { get; set; }
        public string username { get; set; }
    
        public Account account { get; set; }

        public static int MoneyToTime(float money) {
            int time;
            time = (int)(money * 60 / 6000);
            return time;
        }
    }
}
