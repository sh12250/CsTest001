using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Map
    {
        public string[,] theMap { get; private set; }
        public string wall { get; private set; }
        public string grassField { get; private set; }
        public string field { get; private set; }
        public int mapSize { get; private set; }

        public Map()
        {
            Random random = new Random();

            wall = "■";
            grassField = "…";
            field = "　";
            mapSize = 31;

            int grassRangeLeft = random.Next(5, mapSize / 2 - 5);
            int grassRangeRight = random.Next(mapSize / 2 + 5, mapSize - 4);
            int grassRangeTop = random.Next(5, mapSize / 2 - 5);
            int grassRangeBottom = random.Next(mapSize / 2 + 5, mapSize - 4);

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
                    if (y > grassRangeTop && y < grassRangeBottom)
                    {
                        if (x > grassRangeLeft && x < grassRangeRight)
                        {
                            map[y, x] = grassField;
                            continue;
                        }
                    }

                    map[y, x] = field;
                }
            }

            theMap = map;
        }

        public void InitSize()
        {
            Random random = new Random();

            mapSize = random.Next(9, 16) + 2;
        }

        public void InitMap(string[,] map)
        {
            for(int y = 0; y < mapSize; y++)
            {
                for(int x = 0; x < mapSize; x++)
                {
                    theMap[y,x] = map[y,x];
                }
            }
        }

        public void PrintMap()
        {
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    if (theMap[y, x] == "◎")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(theMap[y, x]);
                    }
                    else if (theMap[y, x] == "○")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(theMap[y, x]);
                    }
                    else if (theMap[y, x] == grassField)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
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
