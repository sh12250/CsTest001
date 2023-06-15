using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushRock
{
    public class Cursor
    {
        public int xPosition { get; private set; }
        public int yPosition { get; private set; }
        public char LastInput { get; private set; }

        public void InitCursorPosition(int xPos, int yPos)
        {
            xPosition = xPos;
            yPosition = yPos;
        }

        public void GetCursorPosition(int size)
        {
            MoveCursor(50, 20);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.KeyChar)
            {
                case 'w':
                    if (yPosition - 1 != 0)
                    {
                        yPosition--;
                    }
                    LastInput = 'w';
                    break;
                case 'a':
                    if (xPosition - 1 != 0)
                    {
                        xPosition--;
                    }
                    LastInput = 'a';
                    break;
                case 's':
                    if (yPosition + 1 != size)
                    {
                        yPosition++;
                    }
                    LastInput = 's';
                    break;
                case 'd':
                    if (xPosition + 1 != size)
                    {
                        xPosition++;
                    }
                    LastInput = 'd';
                    break;
                case 'r':
                    LastInput = 'r';
                    break;
            }
        }

        public void MoveCursor()
        {
            Console.SetCursorPosition(xPosition, yPosition);
        }

        public void MoveCursor(int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
        }
    }
}
