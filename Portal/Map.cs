using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class Map
    {
        public string[,] theMap { get; private set; }
        public int mapSize { get; private set; }

        public Map(int size)
        {
            mapSize = size + 2;

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
                    else if (theMap[y, x] == "♨")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
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
