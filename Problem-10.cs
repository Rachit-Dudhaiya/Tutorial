using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_10
    {
        public static void digits()
        {
            string mobli;
            Console.Write("Enter Mobile Number:");
            mobli = Console.ReadLine();

            if (mobli.Length>=5)
            {
                string index = mobli.Substring(0,mobli.Length-5)+"xxxxxx";
                Console.WriteLine(index);

            }

        }
    }
}
