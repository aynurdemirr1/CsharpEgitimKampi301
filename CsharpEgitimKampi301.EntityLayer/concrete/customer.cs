using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.EntityLayer.concrete
{
    public class customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerDistrict { get; set; }
        public string customercity { get; set; }
        public List<order> Orders { get; set; }
        public bool customerStatus { get; set; }

    }
}
