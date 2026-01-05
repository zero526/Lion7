using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool T = true;
            //bool F = false;
            //int hp = 80;

            //Console.WriteLine("===게임 상태===");
            //Console.WriteLine($"게임 실행중 : {T}");
            //Console.WriteLine($"일시정지 : {F}");
            //Console.WriteLine($"문 열림 : {F}");
            //Console.WriteLine($"플레이어 생존 : {T} \n");
            //Console.WriteLine("===게임 상태===");
            //Console.WriteLine($"체력 : {hp}");
            //Console.WriteLine($"건강 상태 : {T}");
            //Console.WriteLine($"위험 상태 : {F}");

            int number = 123;
            string numberAsString = number.ToString(); //정수를 문자열로 변환

            bool flag = true;
            string flagAsString = flag.ToString(); //논리값을 문자열로 변화

            Console.WriteLine(numberAsString); //"123"
            Console.WriteLine(flagAsString); //"true"
        }
    }
}
