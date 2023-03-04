using System.ComponentModel.DataAnnotations;

namespace OrderHandlingAPI.Model
{
    public class CreateOrderRequest
    {
        [Required]
        public string? CustomerName { get; set; }
        public int Discount { get; set; } = 0;

        public class OrderLine
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}
