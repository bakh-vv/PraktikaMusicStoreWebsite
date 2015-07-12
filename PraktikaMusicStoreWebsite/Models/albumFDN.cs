using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaMusicStoreWebsite.Models
{
    public class albumFDN
    {
        public int albumFDNID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<short> Duration { get; set; }
        public Nullable<int> artistID { get; set; }
        public Nullable<int> Availability { get; set; }
        public Nullable<int> typeID { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
