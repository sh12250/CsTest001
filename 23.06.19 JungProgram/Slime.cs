using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public class Slime : MonsterBase
    {
        public override void PrintInfos()
        {
            this.name = "슬라임";
            base.PrintInfos();
        }
    }
}
