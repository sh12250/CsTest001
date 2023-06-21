using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horror
{
    public class Map
    {
        public string[,] theMap { get; private set; }
        public string wall { get; private set; }
        public int mapSize { get; private set; }

        public Map()
        {
            Random random = new Random();

            wall = "■";
            mapSize = 31;

            int wallRate = 0;

            string[,] map = new string[mapSize, mapSize];

            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    if (y == 0 || x == 0 || y == mapSize - 1 || x == mapSize - 1)
                    {
                        map[y, x] = wall;
                    }
                }
            }

            for (int y = 1; y < mapSize - 1; y++)
            {
                for (int x = 1; x < mapSize - 1; x++)
                {
                    wallRate = random.Next(0, 100);

                    if(wallRate < 25)
                    {
                        map[y, x] = wall;
                        continue;
                    }

                    map[y, x] = "　";
                }
            }

            theMap = map;
        }

        public void InitSize()
        {
            Random random = new Random();

            mapSize = random.Next(9, 15) + 2;
        }

        public void PrintMap()
        {
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    if (theMap[y, x] == "◎")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(theMap[y, x]);
                    }
                    else if (theMap[y, x] == "◆")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(theMap[y, x]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(theMap[y, x]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
