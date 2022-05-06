using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBuy.Model
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        
        public virtual ICollection<Product> Products{get;set;}
    }
}
