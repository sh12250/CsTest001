using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSeeker
{
    public class Player
    {
        private string _user;
        private int _yPos;
        private int _xPos;

        public Player()
        {
            _user = "￦";
        }

        public void Init(int yPos, int xPos)
        {
            _yPos = yPos;
            _xPos = xPos;
        }

        public void Input(string[,] map, int size, ref int count)
        {
            ConsoleKeyInfo input = Console.ReadKey();
            int y = _yPos;
            int x = _xPos;

            if (input.KeyChar == 'w' || input.Key == ConsoleKey.UpArrow)
            {
                if (y != 1)
                {
                    y--;
                }
            }
            else if (input.KeyChar == 'a' || input.Key == ConsoleKey.LeftArrow)
            {
                if (x != 1)
                {
                    x--;
                }
            }
            else if (input.KeyChar == 's' || input.Key == ConsoleKey.DownArrow)
            {
                if (y != size - 2)
                {
                    y++;
                }
            }
            else if (input.KeyChar == 'd' || input.Key == ConsoleKey.RightArrow)
            {
                if (x != size - 2)
                {
                    x++;
                }
            }

            MovePlayer(map, y, x, ref count);
        }

        public void RotatePlayer(string[,] map)
        {
            map[_yPos, _xPos] = _user;
        }

        public void MovePlayer(string[,] map, int yPos, int xPos, ref int count)
        {
            string temp;

            temp = map[yPos, xPos];

            if (map[yPos, xPos] == "ⓒ")
            {
                temp = "□";
                count++;
            }

            map[yPos, xPos] = map[_yPos, _xPos];
            map[_yPos, _xPos] = temp;

            _yPos = yPos;
            _xPos = xPos;
        }
        /*
        public string ReturnChara()
        {
            return _user;
        }
        */
        public int ReturnX()
        {
            return _xPos;
        }
        public int ReturnY()
        {
            return _yPos;
        }
    }
}
