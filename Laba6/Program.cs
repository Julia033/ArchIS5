using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Program
    {
        private static Controllers.ViewController VC = new Controllers.ViewController();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Нажмите 1, чтобы вывести всех участников");
                Console.WriteLine("Нажмите 2, чтобы вывести все города");
                Console.WriteLine("Нажмите 3, чтобы вывести всех, кто живет в том же городе, что и выбранный участник");
                Console.WriteLine("Нажмите ESC для выхода");
                Console.WriteLine();
                var btn = Console.ReadKey(true).Key;
                switch (btn)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.D1:
                        VC.PrintHouse();
                        break;
                    case ConsoleKey.D2:
                        VC.PrintCity();
                        break;
                    case ConsoleKey.D3:
                        VC.PrintHouseCity();
                        break;
                    default:
                        Console.Write("Неизвестный ввод");
                        Console.WriteLine();
                        break;
                }
            }


        }
    }
}
