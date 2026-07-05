using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_3
    {
        public static void Even()
        {
            //Find out whether the given number is odd or even.

            int num;
            Console.Write("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is an Even Number");
            }
            else
            {
                Console.WriteLine(num + " is an Odd Number");
            }
        }

    }
}
