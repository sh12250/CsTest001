using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._22_JungProgram
{
    public class CustomClass
    {
        public int xPos;
        public int yPos;

        public void InitNumber(int xPos_, int yPos_)
        {
            xPos = xPos_;
            yPos = yPos_;
        }

        public virtual void PrintPosition()
        {
            Console.WriteLine("현재 위치 : ( {0} , {1} )", xPos, yPos);
        }
    }
}
