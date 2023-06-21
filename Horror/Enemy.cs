using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horror
{
    public class Enemy
    {
        public string character { get; private set; }
        public int enemyXPos { get; private set; }
        public int enemyYPos { get; private set; }

        public Enemy()
        {
            character = "◆";
        }

        public void SetEnemyPosition(int xPos, int yPos)
        {
            enemyXPos = xPos;
            enemyYPos = yPos;
        }

        public void InsertEnemy(string[,] theMap)
        {
            theMap[enemyYPos, enemyXPos] = character;
        }

        public void MoveEnemy(string[,] theMap, int xPos, int yPos)
        {
            int nextX = enemyXPos;
            int nextY = enemyYPos;

            if(nextX == xPos)
            {
                if (nextY > yPos)
                {
                    nextY--;
                }
                else if (nextY < yPos)
                {
                    nextY++;
                }
            }
            else if(nextY == yPos)
            {
                if (nextX > xPos)
                {
                    nextX--;
                }
                else if (nextX < xPos)
                {
                    nextX++;
                }
            }
            else if(nextX > xPos)
            {   // enemyXPos--;
                if(nextY > yPos)
                {   // enemyYPos--;
                    if (nextX - xPos > nextY - yPos)
                    {
                        nextX--;
                    }
                    else if(nextX - xPos < nextY - yPos)
                    {
                        nextY--;
                    }
                }
                else if(nextY < yPos)
                {
                    if (nextX - xPos > yPos - nextY)
                    {
                        nextX--;
                    }
                    else if (nextX - xPos < yPos - nextY)
                    {
                        nextY++;
                    }
                }
            }
            else if(nextX < xPos)
            {   // enemyXPos++;
                if (nextY > yPos)
                {
                    if(xPos - nextX > nextY - yPos)
                    {
                        nextX++;
                    }
                    else if(xPos - nextX < nextY - yPos)
                    {
                        nextY--;
                    }
                }
                else if (nextY < yPos)
                {
                    if(xPos - nextX > yPos - nextY)
                    {
                        nextX++;
                    }
                    else if(xPos - nextX < yPos - nextY)
                    {
                        nextY++;
                    }
                }
            }

            if (theMap[nextY, nextX] == "■" || theMap[nextY, nextX] == character)
            {   /* PASS */   }
            else
            {
                theMap[enemyYPos, enemyXPos] = "　";
                theMap[nextY, nextX] = character;
                enemyXPos = nextX;
                enemyYPos = nextY;
            }
        }
    }
}
