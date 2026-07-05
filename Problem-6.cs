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
            // Missing statement
            Console.Write("Enter Number 1 : ");
            String str1 = Console.ReadLine();
            a = Convert.ToInt32(str1);

            // Missing statement
            Console.Write("Enter Number 2 : ");
            String str2 = Console.ReadLine();
            b = Convert.ToInt32(str2);

            // Missing statement
            Console.Write("Enter Number 3 : ");
            String str3 = Console.ReadLine();
            c = Convert.ToInt32(str3);


            result = Sum(a, b, c);
        }
            // Missing statement
           public static int Sum(int x, int y, int z)
           {
                int res;
                res = x + y + z;
                 Console.WriteLine("Sum : "+res);
                return res;
           }

        }
       
    }

