using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_VendingMachine
{
    internal class Class1
    {
        public class CoffeeMachine
        {
            int water;
            int coffee;
            int milk;
            int chocolate;

            public CoffeeMachine(int water, int coffee, int milk, int chocolate)
            {
                this.water = water;
                this.coffee = coffee;
                this.milk = milk;
                this.chocolate = chocolate;
            }

            void CheckAndFill(int w, int c, int m, int choco)
            {
                if (water < w)
                {
                    Console.WriteLine("Water not enough → refill");
                    water += 500;
                }
                if (coffee < c)
                {
                    Console.WriteLine("Coffee not enough → refill");
                    coffee += 200;
                }
                if (milk < m)
                {
                    Console.WriteLine("Milk not enough → refill");
                    milk += 200;
                }
                if (chocolate < choco)
                {
                    Console.WriteLine("Chocolate not enough → refill");
                    chocolate += 200;
                }
            }

            public void BuyBlackCoffee()
            {
                CheckAndFill(300, 20, 0, 0);
                water -= 300;
                coffee -= 20;
                Console.WriteLine("Black coffee is ready ");
            }

            public void BuyMocha()
            {
                CheckAndFill(300, 20, 0, 10);
                water -= 300;
                coffee -= 20;
                chocolate -= 10;
                Console.WriteLine("Mocha is ready ");
            }

            public void BuyLatte()
            {
                CheckAndFill(300, 20, 10, 0);
                water -= 300;
                coffee -= 20;
                milk -= 10;
                Console.WriteLine("Latte is ready ");
            }

            public void BuyChocolate()
            {
                CheckAndFill(300, 0, 0, 20);
                water -= 300;
                chocolate -= 20;
                Console.WriteLine("Chocolate is ready ");
            }

            public void ShowStock()
            {
                Console.WriteLine("Water: " + water + " g");
                Console.WriteLine("Coffee: " + coffee + " g");
                Console.WriteLine("Milk: " + milk + " g");
                Console.WriteLine("Chocolate: " + chocolate + " g");
            }
        }
    }
}