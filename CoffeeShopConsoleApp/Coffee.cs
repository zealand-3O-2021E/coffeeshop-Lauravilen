using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        protected Coffee(int discount)
        {
            Discount = discount;
            Price = 20;
        }

        public int Discount { get; set; }
        public int Price { get; set; }
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        
        
        
        public virtual int price()
        {
            if (Discount<5)
            {
                return Price-Discount;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }

        public abstract string Strength();

    }
}
