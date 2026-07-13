using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_9
    {
        public static void ToggleCase()
        {
            string name, result = "";
            Console.Write("Enter string to convert in ToggleCase:");
            name = Console.ReadLine();
            foreach (char ch in name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }

            }
            Console.WriteLine("Input: "+name);
            Console.WriteLine("Output: " + result);

        }
    }
}
