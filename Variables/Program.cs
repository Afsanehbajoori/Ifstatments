using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter your age!");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age>18)
            {
                Console.WriteLine("Welcom!");
            }
            else
            {
                Console.WriteLine("You are not allow to continue!");
            }


            Console.WriteLine("Please inter a number!");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2 ==0)
            {
                Console.WriteLine("The number that you inter is event number! ");
            }
            else
            {
                Console.WriteLine("The number that you inter is odd number! ");
            }

            Console.ReadKey(true);
        }
    }
}
