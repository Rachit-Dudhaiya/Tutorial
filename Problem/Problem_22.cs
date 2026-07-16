using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Problem
{
    internal class Problem_22
    {
        public static void prefect()
        {
            for(int i = 1; i<=10; i++)
            {
                for(int j = 1; j<=10-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k<i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
