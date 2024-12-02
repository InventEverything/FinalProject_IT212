namespace FinalProject_IT212.Models
{
    public class Quantity
    {
        public int QuantityId { get; set; }
        public Products Product { get; set; }
        public int ProductQty { get; set; }
    }
}
