using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp_VendingMachine.Class1;

namespace ConsoleApp_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine(500, 200, 100, 100);

            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Welcome to Coffee Machine");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1: Black Coffee");
                Console.WriteLine("2: Mocha");
                Console.WriteLine("3: Latte");
                Console.WriteLine("4: Chocolate");
                Console.WriteLine("5: Show stock");
                Console.WriteLine("0: Exit program");
                Console.WriteLine("--------------------------------");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        machine.BuyBlackCoffee();
                        break;
                    case "2":
                        machine.BuyMocha();
                        break;
                    case "3":
                        machine.BuyLatte();
                        break;
                    case "4":
                        machine.BuyChocolate();
                        break;
                    case "5":
                        machine.ShowStock();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;
                }
            }
        }
    }
}
