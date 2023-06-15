using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushRock
{
    public class Rock
    {
        private string RockImage { get; set; }
        public int RockXPos { get; private set; }
        public int RockYPos { get; private set; }
        public bool DeleteRock { get; set; }


        public void GetRockPosition(int xPos, int yPos)
        {
            RockXPos = xPos;
            RockYPos = yPos;
        }

        public void PlaceRock(string[,] theMap)
        {
            theMap[RockYPos, RockXPos] = RockImage;
        }

        public void SlideRock(string[,] theMap, int size, char direction)
        {
            switch (direction)
            {
                case 'w':
                    if (RockYPos - 1 != 1)
                    {
                        RockYPos--;
                    }
                    break;
                case 'a':
                    if (RockXPos - 1 != 1)
                    {
                        RockXPos--;
                    }
                    break;
                case 's':
                    if (RockYPos + 1 != size - 1)
                    {
                        RockYPos++;
                    }
                    break;
                case 'd':
                    if (RockXPos + 1 != size - 1)
                    {
                        RockXPos++;
                    }
                    break;
            }
        }
    }
}
