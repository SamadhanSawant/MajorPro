using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartBuy.Model
{
    public class Product
    {

        [Key,ForeignKey("CategoryId")]
        public int ProductID { get; set;}
        public string ProductName { get; set; }
        public decimal Price { get; set; } 

       public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Categories Categories { get; set; }

    }
}
