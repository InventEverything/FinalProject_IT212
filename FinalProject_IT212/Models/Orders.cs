namespace FinalProject_IT212.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public ICollection<Quantity> ProductQty { get; set; }
        public decimal OrderCost { get; set; }
    }
}
