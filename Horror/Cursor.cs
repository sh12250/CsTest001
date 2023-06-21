using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horror
{
    public class Cursor
    {
        public int cXPos { get; private set; }
        public int cYPos { get; private set; }
        public char lastInput { get; private set; }

        public void SetCursorPosition(int xPos, int yPos)
        {
            cXPos = xPos;
            cYPos = yPos;
        }

        public void GetCursorPosition()
        {
            MoveCursor(0, 33);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.KeyChar)
            {
                case 'w':
                    cYPos--;
                    lastInput = 'w';
                    break;
                case 'a':
                    cXPos--;
                    lastInput = 'a';
                    break;
                case 's':
                    cYPos++;
                    lastInput = 's';
                    break;
                case 'd':
                    cXPos++;
                    lastInput = 'd';
                    break;
                case 'r':
                    lastInput = 'r';
                    break;
            }
        }

        public void MoveCursor()
        {
            Console.SetCursorPosition(cXPos, cYPos);
        }

        public void MoveCursor(int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
        }
    }
}
