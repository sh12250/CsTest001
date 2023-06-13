using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ⓒ
// ￦

namespace CoinSeeker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (Console.BackgroundColor == ConsoleColor.Black)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("ⓒ");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}

            Map map = new Map();
            Player user = new Player();
            CoinManager manager = new CoinManager();

            Random random = new Random();

            string userInput;
            int mapSize;
            int score = 0;

            userInput = Console.ReadLine();
            int.TryParse(userInput, out mapSize);

            user.Init(random.Next(mapSize) + 1, random.Next(mapSize) + 1);

            map.MakeMap(mapSize);

            user.RotatePlayer(map.ReturnMap());


            while (true)
            {
                Console.Clear();
                map.PrintMap();
                Console.WriteLine("코인 {0}개", score);


                if(score == 10)
                {
                    break;
                }

                Task.Delay(50).Wait();
                user.Input(map.ReturnMap(), map.ReturnSize(), ref score);

                manager.CountCoin(map.ReturnMap(), map.ReturnSize(), user.ReturnY(), user.ReturnX());


            }       // while()
        }       // Main()
    }       // Program()
}
