using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_13
    {
        public static void series() {
            float n1 = 0;
            float n2 = 1;
            float n3;
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write(n1 + " " + n2 + " ");
            for (int i = 1; i <= n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;
            }





        }
    }
}
