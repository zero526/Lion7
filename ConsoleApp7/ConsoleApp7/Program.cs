using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade = 'A';
            char symbol = '★';
            int number = '9';

            string playerName = "홍길동";
            string welcomeMessage = "게임에 오신 것을 환영합니다!";
            string emptyString = "";

            Console.WriteLine("=== RPG 게임 ===");
            Console.WriteLine($"플레이어 : {playerName}");
            Console.WriteLine($"등급 : {grade}등급 {symbol}");
            Console.WriteLine(welcomeMessage);
        }
    }
}
