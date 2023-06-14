using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            
            var autoEvent = new AutoResetEvent(false);

            var timeChecker = new TimeChecker(10);

            Console.WriteLine("{0:h:mm:ss.fff} Creating timer.\n", DateTime.Now);

            var stateTimer = new Timer(timeChecker.CheckTime, autoEvent, 1000, 1000);

            // Console.WriteLine("{0}", stateTimer);

            // autoEvent.WaitOne();
            // stateTimer.Change(0, 1000);
            // Console.WriteLine("\nChanging period to .5 seconds.\n");
             
            // autoEvent.WaitOne();
            // stateTimer.Dispose();
            // Console.WriteLine("\nDestroying timer.");

            Random random = new Random();

            string userInput;
            int mapSize;
            int timeNow;
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

                int.TryParse(DateTime.Now.ToString(), out timeNow);
                Console.WriteLine("0", timeNow);

                if (score == 10)
                {
                    break;
                }

                Task.Delay(50).Wait();
                user.Input(map.ReturnMap(), map.ReturnSize(), ref score);

                if(1 == 10)
                {

                }
                manager.CountCoin(map.ReturnMap(), map.ReturnSize(), user.ReturnY(), user.ReturnX());
            }       // while()
        }       // Main()

        class TimeChecker
        {
            private int invokeCount;
            private int maxCount;

            public TimeChecker(int count)
            {
                invokeCount = 0;
                maxCount = count;
            }

            public void CheckTime(object timeInfo)
            {
                AutoResetEvent autoEvent = (AutoResetEvent)timeInfo;
                // Console.WriteLine("{0} 시간 체크 {1,2}.", DateTime.Now.ToString("h:mm:ss.fff"), (++invokeCount).ToString());

                if(invokeCount == maxCount)
                {
                    invokeCount = 0;
                    autoEvent.Set();
                }
            }
        }
    }       // Program()
}
