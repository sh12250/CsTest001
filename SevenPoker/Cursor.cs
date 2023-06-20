using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class Cursor
    {
        public int cXPos { get; private set; }
        public int cYPos { get; private set; }
        public char lastInput { get; private set; }

        public void InitCursorPosition(int xPos, int yPos)
        {
            cXPos = xPos;
            cYPos = yPos;
        }

        public void GetCursorPosition(int size)
        {
            MoveCursor(50, 20);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.KeyChar)
            {
                case 'w':
                    if (cYPos - 1 != 0)
                    {
                        cYPos--;
                    }
                    lastInput = 'w';
                    break;
                case 'a':
                    if (cXPos - 1 != 0)
                    {
                        cXPos--;
                    }
                    lastInput = 'a';
                    break;
                case 's':
                    if (cYPos + 1 != size)
                    {
                        cYPos++;
                    }
                    lastInput = 's';
                    break;
                case 'd':
                    if (cXPos + 1 != size)
                    {
                        cXPos++;
                    }
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
