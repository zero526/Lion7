using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float SP = 3.14f;
            //double DP = 3.141592;
            //decimal HP = 3.14159265389793236264m;

            //Console.WriteLine(SP);
            //Console.WriteLine(DP);
            //Console.WriteLine(HP);

            //int integerValue = 100; //기본 정수형(int)
            //long longValue = 100L; //정수형(long)
            //float floatValue = 3.14f; //실수형(float)
            //double doubleValue = 3.14; //기본 실수형(double)
            //decimal decimalValue = 3.14m; //고정밀도 실수형(decimal)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            float ms = 5.5f;
            double attackSpeed = 1.25;
            decimal itemPrise = 12.99m;

            Console.WriteLine("===캐릭터 능력치===");
            Console.WriteLine($"이동속도 : {ms}");
            Console.WriteLine($"공격속도 : {attackSpeed}");
            Console.WriteLine($"아이템 가격: {itemPrise}");
        }
    }
}
