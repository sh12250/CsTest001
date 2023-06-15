using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushRock
{
    public class Map
    {
        public string[,] TheMap {  get; private set; }
        public int MapSize { get; private set; }

        public void InitSize()
        {
            int size = 0;
            string input = "0";

            input = Console.ReadLine();
            int.TryParse(input, out size);

            MapSize = size + 2;
        }

        public void MakeMap()
        {
            string[,] map = new string[MapSize, MapSize];
            for (int y = 0; y < MapSize; y++)
            {
                for (int x = 0; x < MapSize; x++)
                {
                    if (y == 0 || x == 0 || y == MapSize - 1 || x == MapSize - 1)
                    {
                        map[y, x] = "■";
                    }
                }
            }

            for (int y = 1; y < MapSize - 1; y++)
            {
                for (int x = 1; x < MapSize - 1; x++)
                {
                    map[y, x] = "　";
                }
            }

            TheMap = map;
        }

        public void PrintMap()
        {
            for (int y =0; y < MapSize; y++)
            {
                for(int x=0; x < MapSize; x++)
                {
                    if(TheMap[y, x] == "◎")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(TheMap[y, x]);
                    }
                    else if(TheMap[y, x] == "□")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(TheMap[y, x]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(TheMap[y, x]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
