using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 14; i > 10;)
            {
                i++;
                sum += i;
            }
            Console.WriteLine("the sum is : {0}"+sum);
            Console.ReadLine();
        }
    }
    }

