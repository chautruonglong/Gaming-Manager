namespace DTO {
    public class DetailAccount {
        public string detail_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public int age { get; set; }
        public int cmnd { get; set; }
        public string username { get; set; }
    
        public Account account { get; set; }
    }
}
