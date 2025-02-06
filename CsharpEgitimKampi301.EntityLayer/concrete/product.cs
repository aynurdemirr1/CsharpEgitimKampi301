using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.EntityLayer.concrete
{
    public class product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int productStock {  get; set; }
        public decimal productPrice { get; set; }
        public string productDescripton { get; set; }
        public int CategoryId { get; set; }
        public virtual Category category { get; set; }
        public List<order> orders { get; set; }



    }
}
