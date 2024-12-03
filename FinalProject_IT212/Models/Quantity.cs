using System.ComponentModel.DataAnnotations;

namespace FinalProject_IT212.Models
{
    public class Quantity
    {
        [Key]
        public int QuantityId { get; set; }
        public int ProductId { get; set; }
        public int ProductQty { get; set; }
    }
}
