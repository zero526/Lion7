using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string L = "Low", N = "Normal", H = "High";
            string O = "On", F = "Off";


            Console.WriteLine("Controls");
            Console.WriteLine("          ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("          ┃ⓡ Camera Controls                            ┃");
            Console.WriteLine("          ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine($"          ☞ Camera Sensitivity           〈{L} 〉");
            Console.WriteLine($"            Horizontal                 〈{N} 〉");
            Console.WriteLine($"            Vertical                   〈{N} 〉");
            Console.WriteLine($"            Use Motion Controls          〈{O} 〉");
            Console.WriteLine($"            Motion Sensitivity           〈{L} 〉");
            Console.WriteLine("          ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("          ┃ HD Rumble                                   ┃");
            Console.WriteLine("          ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine($"            Use Remble                   〈{O} 〉");
            Console.WriteLine($"            Strength                   〈{N} 〉");
            Console.WriteLine("          ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("          ┃ Map Controls                                ┃");
            Console.WriteLine("          ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("           ⅡⅡ                   ⓛ Select ⓨ Reset ⓑ Back ");

        }
    }
}
