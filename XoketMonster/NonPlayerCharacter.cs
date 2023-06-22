using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class NonPlayerCharacter
    {
        public string character { get; private set; }
        public int npcXPos { get; private set; }
        public int npcYPos { get; private set; }

        public NonPlayerCharacter()
        {
            character = "○";
        }
        public void SetNPCPosition(int size)
        {
            Random random = new Random();

            npcYPos = random.Next(1, size);
            npcXPos = random.Next(1, size);
        }

        public void InsertNPC(string[,] theMap)
        {
            theMap[npcYPos, npcXPos] = character;
        }
    }
}
