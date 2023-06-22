using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Monster : Status
    {
        public Monster() 
        {
            Random random = new Random();

            name = "늑대";
            level = 1;
            healthMax = random.Next(30, 41);
            health = healthMax;
            attack = random.Next(4, 8);
            defence = 1;
            exp = random.Next(10, 16);
        }


    }



    public class Boss
    {
        public int hp;

        public Boss()
        {
            hp = 100;
        }
    }
}


