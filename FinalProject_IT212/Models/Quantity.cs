using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_IT212.Models
{
    public class Quantity
    {
        [Key]
        public int QuantityId { get; set; }
        public int ProductId { get; set; }
        public int ProductQty { get; set; }
        public int OrdersOrderId { get; set; }
    }
}
