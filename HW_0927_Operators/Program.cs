using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_0927_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1-9 were completed successfully, then lost during an unfortunate renaming tragedy.

            // #10
            // The sum of three consecutive numbers is 72. What are the smallest of these numbers?
            //int sumNumber = 72;
            //int firstNumber = (sumNumber - 3) / 3;
            //Console.WriteLine("The smallest number is " + firstNumber + ".");

            // #11
            // The sum of three consecutive even numbers is 48. What are the smallest of these numbers?
            //int sumNumber = 48;
            //int firstNumber = (sumNumber - 3) / 3;
            //Console.WriteLine("The smallest number is " + firstNumber + ".");

            // #12
            // Maria bought seven boxes. A week later half of all her boxes were destroyed in a fire. 
            // There are now only 22 boxes left. With how many did she start?
            int currentNumber = 22;
            int preFire = currentNumber * 2;
            int boxPurchase = 7;
            int startNumber = preFire - boxPurchase;
            Console.WriteLine("Maria started with " + startNumber + " boxes.");













        }
    }
}
