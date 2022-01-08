using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_MPD.Models
{
    public class Retailer
    {
        public int ID { get; set; }
        public string RetailerName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
