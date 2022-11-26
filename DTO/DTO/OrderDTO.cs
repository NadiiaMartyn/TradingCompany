namespace DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}