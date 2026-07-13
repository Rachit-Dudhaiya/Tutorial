using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_6
    {
        public static void fix()
        {
            int a, b, c, result;
            Console.Write("Enter Number 1 : ");
            string str1 = Console.ReadLine();
            a = Convert.ToInt32(str1);

            Console.Write("Enter Number 2 : ");
            string str2 = Console.ReadLine();
            b = Convert.ToInt32(str2);

            Console.Write("Enter Number 3 : ");
            string str3 = Console.ReadLine();
            c = Convert.ToInt32(str3);

            result = Sum(a, b, c);
        }

        public static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            Console.WriteLine("Sum : " + res);
            return res;
        }
    }
}
