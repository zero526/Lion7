using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte level = 50;
            short attack = 1500;
            int gold = 1234567;
            long experience = 9999999L;

            Console.WriteLine($"{level}");
            Console.WriteLine($"{attack}");
            Console.WriteLine($"{gold:N0}");
            Console.WriteLine($"{experience:N0}");
        }
    }
}
