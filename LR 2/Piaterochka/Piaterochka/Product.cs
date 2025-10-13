using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public List<decimal> PriceHistory { get; set; }
    }
}
