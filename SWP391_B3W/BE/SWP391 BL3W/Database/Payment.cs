using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391_BL3W.Database
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        //Navigation
        public ICollection<Order> Orders { get; set; }

    }
}
