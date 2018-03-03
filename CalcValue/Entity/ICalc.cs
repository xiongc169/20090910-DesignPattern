using System;
using System.Collections.Generic;
using System.Text;

namespace CalcValue.Entity
{
    public interface ICalc
    {
        double GetTotalCost(Product[] products);
    }
}
