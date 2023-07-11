using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.DataLayer.Models
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public int OrderCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerFullName { get; set; }
        [Required]
        [MaxLength(12)]
        public string MobileCustomer { get; set; }
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; }
        [Required]
        public int ReceivedMoney { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public long CustomerId { get; set; }
        [Required]
        public long ClothId { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("ClothId")]
        public virtual Cloth Cloth { get; set; }
    }
}
