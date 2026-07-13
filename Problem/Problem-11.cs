using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_11
    {
        public static void gender()
        {
            string name;
            char gender;
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.Write("Enter your gender (M/F):");
            gender = Convert.ToChar(Console.ReadLine());
            if (gender == 'm' || gender == 'M')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'f' || gender == 'F')
            {
                Console.WriteLine("Miss. " + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
        }
    }
}
