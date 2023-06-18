using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class Map
    {
        public string[,] theMap {  get; private set; }
        public int mapSize { get; private set; }

        public void InitSize()
        {
            mapSize = 15;
        }

        public void MakeMap()
        {
            string[,] map = new string[mapSize, mapSize];
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    if (y == 0 || x == 0 || y == mapSize - 1 || x == mapSize - 1)
                    {
                        map[y, x] = "■";
                    }
                }
            }

            for (int y = 1; y < mapSize - 1; y++)
            {
                for (int x = 1; x < mapSize - 1; x++)
                {
                    if(y == 3 && x == 7)
                    {   // 몬스터
                        map[y, x] = "▣";
                        continue;
                    }
                    if(y == 6 && x == 3)
                    {   // 상점
                        map[y, x] = "￦";
                        continue;
                    }
                    if(y == 6 && x == 11)
                    {   // 카드 게임
                        map[y, x] = "♠";
                        continue;
                    }
                    map[y, x] = "　";
                }
            }

            theMap = map;
        }

        public void PrintMap()
        {
            for (int y =0; y < mapSize; y++)
            {
                for(int x=0; x < mapSize; x++)
                {
                    if(theMap[y, x] == "◎")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(theMap[y, x]);
                    }
                    else if(theMap[y, x] == "￦")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(theMap[y, x]);
                    }
                    else if(theMap[y, x] == "▣")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(theMap[y, x]);
                    }
                    else if(theMap[y, x] == "♠")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(theMap[y, x]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(theMap[y, x]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
