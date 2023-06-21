using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horror
{
    public class Player
    {
        public string character { get; private set; }
        public int pXPos { get; private set; }
        public int pYPos { get; private set; }

        public Player()
        {
            character = "◎";
        }

        public void SetPlayerPosition(int yPos, int xPos)
        {
            pYPos = yPos;
            pXPos = xPos;
        }

        public void SetPlayerPosition(int size)
        {
            Random random = new Random();

            pYPos = random.Next(1, size - 1);
            pXPos = random.Next(1, size - 1);
        }

        public void InsertPlayer(string[,] theMap)
        {
            theMap[pYPos, pXPos] = character;
        }

        public void MovePlayer(string[,] theMap, int xPos, int yPos)
        {
            theMap[pYPos, pXPos] = theMap[yPos, xPos];
            theMap[yPos, xPos] = character;
            pXPos = xPos;
            pYPos = yPos;
        }

        public void RemovePlayer(string[,] theMap)
        {
            theMap[pYPos, pXPos] = "　";
        }
    }
}
