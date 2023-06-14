using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._14_JungProgram
{
    public class ItemInfo
    {
        public string _name;
        public int _count;
        public int _price;

        public void InitItem(string name, int count, int price)
        {
            _name = name;
            _count = count;
            _price = price;
        }
    }
}
