using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_18
    {
        public static void num() {

            int k = 1;
            for (int i = 1; i <= 4; i++)
            { 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }
            
        }
    }
}
