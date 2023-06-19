using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public class Parent
    {
        protected int number = default;
        protected string strValue = default;

        public virtual void PrintInfos()
        {
            number = 1; 
            strValue = "I'm your Father";

            Console.WriteLine("부모 클래스의 number : {0}, strValue : {1}", number, strValue);
        }
    }
}
