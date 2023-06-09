﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class Player
    {
        public string character { get; private set; }
        public int healthPoint { get; private set; }
        public int atkPoint { get; private set; }
        public int pXPos { get; private set; }
        public int pYPos { get; private set; }
        public int pMoney { get; private set; }

        public Player()
        {
            character = "◎";

            healthPoint = 50;
            atkPoint = 10;

            pXPos = 7;  
            pYPos = 10;
            pMoney = 10000;
        }

        public void SetPlayerMoney(int money)
        {
            pMoney = money;
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
    }
}
