using System;
using System.Collections.Generic;
using System.Text;

namespace CalcValue.Entity
{
    public class Calculator : ICalc
    {
        public double GetTotalCost(Product[] products)
        {
            double total = 0;
            foreach (Product item in products)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
