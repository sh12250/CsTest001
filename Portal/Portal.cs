using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class Portal
    {
        public string graphic { get; private set; }
        public int portalXPos { get; private set; }
        public int portalYPos { get; private set; }

        public Portal()
        {
            graphic = "♨";
        }

        public void SetPortalPosition(string[,] theMap, int size)
        {
            Random random = new Random();

            int randIdxX = random.Next(2, size - 2);
            int randIdxY = random.Next(2, size - 2);

            while (theMap[randIdxY,randIdxX] != "　")
            {
                randIdxX = random.Next(2, size - 2); 
                randIdxY = random.Next(2, size - 2);
            }

            portalXPos = randIdxX;
            portalYPos = randIdxY;
        }

        public void InsertPortal(string[,] theMap)
        {
            theMap[portalYPos, portalXPos] = graphic;
        }
    }
}
