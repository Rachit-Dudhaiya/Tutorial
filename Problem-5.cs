using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tutorial
{
    internal class Problem_5
    {
        public static void factorial()
        {
            //Write the output of the following program. Also write a comment for each line of the code

            int n, fact = 1; // initialize variables n, fact with 1

            Console.WriteLine("Enter Number : "); // print the message
            string str = Console.ReadLine(); // getting value from user
            n = Convert.ToInt32(str); // convert to integer
            for (int i = 1; i <= n; i++) // loop from 1 to n and increment by 1
            {
                fact = fact * i; // logical part for multiplying value of i for fact variable
            }
            Console.WriteLine("Factorial : {0}", fact); // print the final factorial value
        }
    }
}
