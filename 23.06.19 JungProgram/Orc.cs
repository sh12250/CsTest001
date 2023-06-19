using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public partial class Orc : MonsterBase
    {
        public override void PrintInfos()
        {
            this.name = "오크";
            base.PrintInfos();
        }
    }
}
