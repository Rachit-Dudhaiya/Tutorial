<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_7
    {
        
        public static void table() {
        int num1, res, i;
        Console.WriteLine("Enter a number");
        num1 = Convert.ToInt32(Console.ReadLine());
        i = 1; // Initialization
                // Check whether condition matches or not
        while (i <= 10)
        {
            res = num1 * i;
            Console.WriteLine("{0} x {1} = {2}", num1, i, res);
            i++; // Increment by one
        }
        Console.ReadLine();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_7
    {
        
        public static void table() {
        int num1, res, i;
        Console.WriteLine("Enter a number");
        num1 = Convert.ToInt32(Console.ReadLine());
        i = 1; // Initialization
                // Check whether condition matches or not
        while (i <= 10)
        {
            res = num1 * i;
            Console.WriteLine("{0} x {1} = {2}", num1, i, res);
            i++; // Increment by one
        }
        Console.ReadLine();
        }
    }
}
>>>>>>> 58cec12155ce3dc5b10337c84bb92dcff94a99c4
