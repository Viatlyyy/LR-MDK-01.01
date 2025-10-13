using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piaterochka
{
    class AveragePriceCalculationStep
    {
        public decimal CalculateAveragePrice(List<decimal> prices)
        {
            if (prices == null || prices.Count == 0)
            {
                return 0;
            }

            decimal sum = 0;
            foreach (decimal price in prices)
            {
                sum += price;
            }

            return sum / prices.Count;
        }
    }
}
