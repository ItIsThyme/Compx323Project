using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Models
{
    public class Order
    {
        public DateTime PurchaseTimestamp { get; set; }
        public string Purchaser { get; set; }
        public List<Product> Products { get; set; }
    }
}
