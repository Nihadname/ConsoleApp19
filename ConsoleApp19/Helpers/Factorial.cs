using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Models
{
    internal static class Factorial
    {
        public static int Calculator(this int num)
           
        {
            int counter = 1;
            for (int i = 1; i <= num; i++)
            {
                counter *= i;
            }
            return counter;
        }
    }
}
