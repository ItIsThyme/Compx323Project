using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compx323Project.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Reviewer { get; set; }
        public int ProductID { get; set; }

        public override string ToString()
            => Title;
    }
}
