using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(int discount) : base(discount)
        {
            base.Price = 25;
        }

        // public override int price()
        // {
        //
        // }

        public override string Strength()
        {
            return "Medium";
        }

        public int MlMilk()
        {
            return 40;
        }
    }
}
