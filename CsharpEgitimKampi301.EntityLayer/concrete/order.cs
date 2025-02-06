using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.EntityLayer.concrete
{
    public class order
    {
        public int orderId { get; set; }
        public int productId { get; set; }
        public virtual product product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public virtual customer Customer { get; set; }
    }
}
