using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushRock
{
    public class Player
    {
        public string Character { get; private set; }
        public int PlayerXPos { get; private set; }
        public int PlayerYPos { get; private set; }


        public Player()
        {
            Character = "◎";
            PlayerXPos = 1;  
            PlayerYPos = 1;
        }



        public void InsertPlayer(string[,] theMap, int size)
        {
            theMap[PlayerYPos, PlayerXPos] = Character;
        }

        public void MovePlayer(string[,] theMap, int xPos, int yPos)
        {
            theMap[PlayerYPos, PlayerXPos] = theMap[yPos, xPos];
            theMap[yPos, xPos] = Character;
            PlayerXPos = xPos;
            PlayerYPos = yPos;
        }
    }
}
