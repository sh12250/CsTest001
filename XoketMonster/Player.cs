using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Player : Status
    {
        public List<Quest> questList {  get; set; }
        public string character { get; private set; }
        public int pXPos { get; private set; }
        public int pYPos { get; private set; }
        public int expMax { get; private set; }

        public Player()
        {
            questList = new List<Quest>();

            character = "◎";
            name = "정석환";
            level = 1;
            healthMax = 100;
            health = healthMax;
            attack = 10;
            defence = 2;
            exp = 0;
            expMax = 100;
        }

        public void LevelUp()
        {
            level++;
            healthMax += 10;
            health = healthMax;
            attack++;
            defence++;

            exp -= expMax;
            expMax += (int)(expMax * 1.1f);
        }

        public void RecieveQuest()
        {
            questList.Add(new Quest());
        }

        public void ClearQuest()
        {
            questList.Remove(questList[0]);
        }

        public void SetPlayerPosition(int yPos, int xPos)
        {
            pYPos = yPos;
            pXPos = xPos;
        }

        public void SetPlayerPosition(int size)
        {
            Random random = new Random();

            pYPos = random.Next(1, size);
            pXPos = random.Next(1, size);
        }

        public void InsertPlayer(string[,] theMap)
        {
            theMap[pYPos, pXPos] = character;
        }

        public void MovePlayer(string[,] theMap, int xPos, int yPos)
        {
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
