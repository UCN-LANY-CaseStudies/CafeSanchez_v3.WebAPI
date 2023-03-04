namespace OrderHandlingAPI.Model
{
    public class OrderResponse
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
