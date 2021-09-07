using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte(int discount) : base(discount)
        {
            base.Price = 40;
        }

        // public override int price()
        // {
        //     if (Discount<5)
        //     {
        //         return 40-Discount;
        //     }
        //     else
        //     {
        //         throw new ArgumentOutOfRangeException();
        //     }
        //     
        // }

        public override string Strength()
        {
            return "Weak";
        }

        public int MlMilk()
        {
            return 200;
        }
    }
}
