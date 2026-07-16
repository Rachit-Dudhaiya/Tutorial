using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Problem_15
    {
        public static void armstrong()
        {
            Console.Write("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = number;
            int lenght = number.ToString().Length;
            while (temp > 0)
            {
                int reminder = temp % 10;
                int digitpower = 1;
                for(int i = 0; i<lenght; i++)
                {
                    digitpower *= reminder;
                }
                sum += digitpower;
                temp /= 10;
            }
            if(sum == number)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }
    }
}
