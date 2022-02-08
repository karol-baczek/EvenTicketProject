namespace bilety.Models
{
    public class orders
    {
        public int id { get; set; }
        public int ticketId { get; set; }

        public int userId { get; set; }

        public int quantity { get; set; }

        public DateTime orderDate  { get; set; }
    }
}
