using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_17
    {
        public static void number()
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
}
