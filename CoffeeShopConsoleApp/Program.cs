using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(0),
                new Cortado(0),
                new Latte(0)

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price() + " and the strength of the coffee is: " + coffee.Strength());
            }

            List<IMilk> orderList2 = new List<IMilk>()
            {
                new Cortado(0),
                new Latte(0)
            };

            foreach (var milkCoffee in orderList2)
            {
                Console.WriteLine(milkCoffee.ToString());
            }


        }
    }
}
