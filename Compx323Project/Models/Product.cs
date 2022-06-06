using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Models
{
    public class Product
    {
        public int ID { get; set; }
        public DateTime ListingDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Publisher Publisher { get; set; }
        public string AgeRating { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
