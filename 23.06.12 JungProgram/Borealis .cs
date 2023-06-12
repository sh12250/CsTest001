using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._12_JungProgram
{
    public class Borealis : MonsterBase
    {
        public override void Initialize(string name, int hp, int mp, int damage, int defence, string type)
        {
            base.Initialize(name, hp, mp, damage, defence, type);
        }       // Initialize()

        public override void Print_MonsterStat()
        {
            base.Print_MonsterStat();
        }
    }
}
