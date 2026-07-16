using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Problem
{
    internal class Problem_21
    {
        public static void nnumber()
        {

            Console.Write("Input the number of terms:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input:");
            int input = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int current = 0;

            for(int i = 1; i<=number; i++)
            {
                current = (current * 10) + input;
                total += current;
            }
            Console.WriteLine(total);
        }
    }
}
