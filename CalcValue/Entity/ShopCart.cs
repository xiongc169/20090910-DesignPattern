using System;
using System.Collections.Generic;
using System.Text;

namespace CalcValue.Entity
{
    public class ShopCart
    {
        private ICalc icalc;

        private Product[] products;

        public ShopCart(ICalc iCalc)
        {
            this.icalc = iCalc;

            products = new Product[]
                {
                    new Product("Apple",10), 
                    new Product("Pear",20), 
                    new Product("Orange",30), 
                    new Product("Grapes",40), 
                    new Product("Jujube",50)
                };
        }

        public double GetAllCost()
        {
            return icalc.GetTotalCost(products);
        }
    }
}
