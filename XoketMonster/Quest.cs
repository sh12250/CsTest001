using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Quest
    {
        public string name { get; private set; }
        public int currentValue { get; private set; }
        public int targetValue { get; private set; }
        public int rewardExp { get; private set; }

        public Quest()
        {
            name = "늑대를 잡아줘";
            currentValue = 0;
            targetValue = 5;
            rewardExp = 100;
        }

        public void PerformQuest()
        {
            currentValue++;
        }
    }
}
