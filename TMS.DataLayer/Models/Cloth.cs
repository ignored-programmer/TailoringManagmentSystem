using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.DataLayer.Models
{
    public class Cloth
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string ClothName { get; set; }
        [Required]
        public string ClothCode { get; set; }
        public string Inventory { get; set; }
        public int AvailableSize { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}

