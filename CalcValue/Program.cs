using System;
using System.Collections.Generic;
using System.Text;
using CalcValue.Entity;

namespace CalcValue
{
    /// <summary>
    /// http://www.cnblogs.com/tylerdonet/p/3297915.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ICalc iCalc = new Calculator();
            ShopCart cart = new ShopCart(iCalc);
            double cost = cart.GetAllCost();
        }
    }
}
