using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Status
    {
        public int level { get; protected set; }
        public string name { get; protected set; }
        public int healthMax { get; protected set; }
        public int health { get; set; }
        public int attack { get; protected set; }
        public int defence { get; protected set; }
        public int exp { get; set; }
    }
}
