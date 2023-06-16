using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TheGame;

namespace TheGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            Hi hi = new Hi();

            Map map = new Map();
            Cursor cursor = new Cursor();

            string theNumber = "0";
            string save = "0";
            int moveCount = 0;

            map.InitSize();
            map.MakeMap();
            map.PrintMap();

            cursor.InitCursorPosition(0, 0);

            while(true)
            {
                moveCount++;


                #region 숫자 생성
                Random random = new Random();
                int randIdxY;
                int randIdxX;

                theNumber = Convert.ToString(random.Next(1, 2) * 2);

                for (int i = 0; i < 3; i++)
                {
                    randIdxY = random.Next(0, map.MapSize);
                    randIdxX = random.Next(0, map.MapSize);

                    while (map.TheMap[randIdxY, randIdxX] != "　")
                    {
                        randIdxY = random.Next(0, map.MapSize);
                        randIdxX = random.Next(0, map.MapSize);
                    }

                    map.TheMap[randIdxY, randIdxX] = theNumber;
                }
                #endregion

                cursor.MoveCursor(0, 0);
                map.PrintMap();

                cursor.GetCursorPosition(map.MapSize);


                if (cursor.LastInput == 'w')
                {
                    for (int y = 0; y < map.MapSize; y++)
                    {
                        int temp1 = 0;
                        int temp2 = 0;
                        for (int x = 0; x < map.MapSize; x++)
                        {
                            if (map.TheMap[y, x] != "　")
                            {
                                save = map.TheMap[y, x];
                                map.TheMap[y, x] = "　";

                                if (map.TheMap[0, x] == "　")
                                {
                                    map.TheMap[0, x] = save;
                                    continue;
                                }

                                int.TryParse(map.TheMap[0, x], out temp1);
                                int.TryParse(save, out temp2);
                                temp1 += temp2;
                                if (temp1 < 10)
                                {
                                    map.TheMap[0, x] = Convert.ToString(temp1);
                                    continue;
                                }
                                map.TheMap[0, x] = Convert.ToString(temp1);
                            }
                        }
                    }
                }
                else if (cursor.LastInput == 'a')
                {
                    for (int y = 0; y < map.MapSize; y++)
                    {
                        int temp1 = 0;
                        int temp2 = 0;
                        for (int x = 0; x < map.MapSize; x++)
                        {
                            if (map.TheMap[y, x] != "　")
                            {
                                save = map.TheMap[y, x];
                                map.TheMap[y, x] = "　";

                                if (map.TheMap[y, 0] == "　")
                                {
                                    map.TheMap[y, 0] = save;
                                    continue;
                                }

                                int.TryParse(map.TheMap[y, 0], out temp1);
                                int.TryParse(save, out temp2);
                                temp1 += temp2;
                                if (temp1 < 10)
                                {
                                    map.TheMap[y, 0] = " " + Convert.ToString(temp1);
                                    continue;
                                }
                                map.TheMap[y, 0] = Convert.ToString(temp1);
                            }
                        }
                    }
                }
                else if (cursor.LastInput == 's')
                {
                    for (int y = 0; y < map.MapSize; y++)
                    {
                        int temp1 = 0;
                        int temp2 = 0;
                        for (int x = 0; x < map.MapSize; x++)
                        {
                            if (map.TheMap[y, x] != "　")
                            {
                                save = map.TheMap[y, x];
                                map.TheMap[y, x] = "　";

                                if (map.TheMap[map.MapSize - 1, x] == "　")
                                {
                                    map.TheMap[map.MapSize - 1, x] = save;
                                    continue;
                                }

                                int.TryParse(map.TheMap[map.MapSize - 1, x], out temp1);
                                int.TryParse(save, out temp2);
                                temp1 += temp2;
                                if (temp1 < 10)
                                {
                                    map.TheMap[map.MapSize - 1, x] = " " + Convert.ToString(temp1);
                                    continue;
                                }
                                map.TheMap[map.MapSize - 1, x] = Convert.ToString(temp1);
                            }
                        }
                    }
                }
                else if (cursor.LastInput == 'd')
                {
                    for (int y = 0; y < map.MapSize; y++)
                    {
                        int temp1 = 0;
                        int temp2 = 0;
                        for (int x = 0; x < map.MapSize; x++)
                        {
                            if (map.TheMap[y, x] != "　")
                            {
                                save = map.TheMap[y, x];
                                map.TheMap[y, x] = "　";

                                if (map.TheMap[y, map.MapSize - 1] == "　")
                                {
                                    map.TheMap[y, map.MapSize - 1] = save;
                                    continue;
                                }

                                int.TryParse(map.TheMap[y, map.MapSize - 1], out temp1);
                                int.TryParse(save, out temp2);
                                temp1 += temp2;
                                if (temp1 < 10)
                                {
                                    map.TheMap[y, map.MapSize - 1] = " " + Convert.ToString(temp1);
                                    continue;
                                }
                                map.TheMap[y, map.MapSize - 1] = Convert.ToString(temp1);
                            }
                        }
                    }
                }       // if('d')
            }


            // hello.Start();      // Start() 함수를 실행 시키면, 이후 자동으로 코어가 실행됩니다.
            // hi.Start();         // Start() 함수를 실행 시키면, 이후 자동으로 코어가 실행됩니다.
        }
    }


    /// <summary>
    /// 사용 예시 클래스입니다.
    /// </summary>
    public class Hello : Core       // Core를 사용하려면 상속을 받아야합니다.
    {
        public override void Start()
        {
            // TODO: 프로그램 실행 시, 1회만 실행하고 싶은 코드를 넣어주세요.
            Console.WriteLine("Hey 초기화");

            base.Start();       // 지우면 동작이 멈춥니다.
        }

        public override void Update()
        {
            // TODO: 60프레임마다 실행하고 싶은 코드를 넣어주세요.
            Console.WriteLine("Hey, Hey You!");
        }
    }

    /// <summary>
    /// 사용 예시 클래스입니다.
    /// </summary>
    public class Hi : Core          // Core를 사용하려면 상속을 받아야합니다.
    {
        public override void Start()
        {
            // TODO: 프로그램 실행 시, 1회만 실행하고 싶은 코드를 넣어주세요.
            Console.WriteLine("Yeah 초기화");

            base.Start();       // 지우면 동작이 멈춥니다.
        }

        public override void Update()
        {
            // TODO: 60프레임마다 실행하고 싶은 코드를 넣어주세요.
            Console.WriteLine("Yeah~ You~");
        }
    }
}
