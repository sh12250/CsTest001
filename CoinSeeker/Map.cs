using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSeeker
{
    public class Map
    {
        private string[,] _map;
        private int _mapSize;

        /*
        public void Init(string[,] map)
        {
            _map = map;
        }
        */
        public void MakeMap(int size)
        {
            int boarderLine = size + 2;
            string[,] map = new string[boarderLine, boarderLine];

            for (int y = 0; y < boarderLine; y++)
            {
                for (int x = 0; x < boarderLine; x++)
                {
                    if(x == 0 || y == 0 || x == boarderLine - 1 || y == boarderLine - 1)
                    {
                        map[y, x] = "■";
                    }
                }
            }
            for (int y = 1; y < boarderLine - 1; y++)
            {
                for(int x = 1; x < boarderLine - 1; x++)
                {
                    map[y, x] = "□";
                }
            }

            _map = map;
            _mapSize = boarderLine;
        }

        public void PrintMap()
        {

            string[,] map = new string[_mapSize, _mapSize];
            map = _map;

            for (int y = 0; y < _mapSize; y++)
            {
                for (int x = 0; x < _mapSize; x++)
                {
                    if (map[y, x] == "￦")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(map[y, x]);
                        continue;
                    }
                    else if(map[y, x] == "ⓒ")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(map[y, x]);
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        public string[,] ReturnMap()
        {
            return _map;
        }

        public int ReturnSize()
        {
            return _mapSize;
        }
    }
}
