using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TMS.DataLayer.Models
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string PostalCode { get; set; }
        public bool IsActive { get; set; }
        //Pant
        public string BalaRoPant { get; set; }
        public string GhadZanooPant { get; set; }
        public string GhadKamelPant { get; set; }
        public string KamarPant { get; set; }
        public string BasanPant { get; set; }
        public string RanPant { get; set; }
        public string ZanooPant { get; set; }
        public string DampaPant { get; set; }
        //Shirt
        public string SarShaneShirt { get; set; }
        public string GhadAstinShirt { get; set; }
        public string GhadPirahanShirt { get; set; }
        public string SineShirt { get; set; }
        public string KamarShirt { get; set; }
        public string YagheShirt { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
