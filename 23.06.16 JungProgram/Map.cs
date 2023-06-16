using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame
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

            MapSize = size;
        }

        public void MakeMap()
        {
            string[,] map = new string[MapSize, MapSize];

            for (int y = 0; y < MapSize; y++)
            {
                for (int x = 0; x < MapSize; x++)
                {
                    map[y, x] = "　";
                }
            }

            TheMap = map;
        }

        public void PrintMap()
        {
            for (int y = 0; y < MapSize; y++)
            {
                for(int x= 0; x < MapSize; x++)
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
