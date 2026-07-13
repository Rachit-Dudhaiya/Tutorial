using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_8
    {
        public static void Upper()
        {
            Console.Write("Enter String:");
            string name = Console.ReadLine();
            Console.WriteLine("Input:"+name);
            Console.WriteLine("Outut:"+name.ToUpper());
        }
    }
}
