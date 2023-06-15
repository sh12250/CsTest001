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


        public void GetRockPosition(string[,] theMap, int size)
        {
            Random random = new Random();

            RockImage = "□";
            RockXPos = random.Next(2, size - 2);
            RockYPos = random.Next(2, size - 2);
            DeleteRock = false;

            while (theMap[RockYPos, RockXPos] == "◎" || theMap[RockYPos, RockXPos] == "□")
            {
                RockXPos = random.Next(1, size - 1);
                RockYPos = random.Next(1, size - 1);
            }

            PlaceRock(theMap);
        }

        public void PlaceRock(string[,] theMap)
        {
            theMap[RockYPos, RockXPos] = RockImage;
        }

        public void SlideRock(string[,] theMap, int size)
        {
            if (theMap[RockYPos - 1, RockXPos] == "◎")
            {
                while (theMap[RockYPos + 1, RockXPos] != "■" && theMap[RockYPos + 1, RockXPos] != RockImage)
                {
                    theMap[RockYPos, RockXPos] = theMap[RockYPos + 1, RockXPos];
                    theMap[RockYPos + 1, RockXPos] = RockImage;
                    RockYPos++;
                }
            }
            else if (theMap[RockYPos, RockXPos - 1] == "◎")
            {
                while (theMap[RockYPos, RockXPos + 1] != "■" && theMap[RockYPos, RockXPos + 1] != RockImage) // "■"
                {
                    theMap[RockYPos, RockXPos] = theMap[RockYPos, RockXPos + 1];
                    theMap[RockYPos, RockXPos + 1] = RockImage;
                    RockXPos++;
                }
            }
            else if (theMap[RockYPos + 1, RockXPos] == "◎")
            {
                while (theMap[RockYPos - 1, RockXPos] != "■" && theMap[RockYPos - 1, RockXPos] != RockImage)
                {
                    theMap[RockYPos, RockXPos] = theMap[RockYPos - 1, RockXPos];
                    theMap[RockYPos - 1, RockXPos] = RockImage;
                    RockYPos--;
                }
            }
            else if (theMap[RockYPos, RockXPos + 1] == "◎")
            {
                while (theMap[RockYPos, RockXPos - 1] != "■" && theMap[RockYPos, RockXPos - 1] != RockImage)
                {
                    theMap[RockYPos, RockXPos] = theMap[RockYPos, RockXPos - 1];
                    theMap[RockYPos, RockXPos - 1] = RockImage;
                    RockXPos--;
                }
            }
        }

        public bool IsTripleRock(string[,] theMap)
        {
            if(theMap[RockXPos - 1, RockYPos] == RockImage && theMap[RockXPos + 1, RockYPos] == RockImage)
            {
                DeleteRock = true;
                return DeleteRock;
            }
            else
            if (theMap[RockXPos, RockYPos - 1] == RockImage && theMap[RockXPos, RockYPos + 1] == RockImage)
            {
                DeleteRock = true;
                return DeleteRock;
            }

            return DeleteRock;
        }

        public void CrashRock(string[,] theMap)
        {
            if(DeleteRock == true)
            {
                theMap[RockXPos, RockYPos] = "　";
            }
        }
    }
}
