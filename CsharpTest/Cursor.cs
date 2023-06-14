using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    public class Cursor
    {
        private int _xPos;
        private int _yPos;

        public void Init(int xPos, int yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
        }

        public void Input()
        {
            MoveCursor(50, 20);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.KeyChar)
            {
                case 'w':
                    if(_yPos != 0)
                    {
                        _yPos--;
                    }
                    break;
                case 'a':
                    if (_xPos != 0)
                    {
                        _xPos--;
                    }
                    break;
                case 's':
                    _yPos++;
                    break;
                case 'd':
                    _xPos++;
                    break;
            }
        }

        public void MoveCursor()
        {
            Console.SetCursorPosition(_xPos, _yPos);
        }
        public void MoveCursor(int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
        }
    }
}
