using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public class Child : Parent
    {
        string strChild = default;

        public override void PrintInfos()
        {
            number = 10;
            strValue = "NOOooooooo!!";
            strChild = "Lierrrrrr!!";

            Console.WriteLine("자식 클래스의 number : {0}, strValue : {1}, strChild : {2}", this.number, this.strValue, this.strChild);
            // this. 은 현재 클래스의 변수 값을 보겠다는 것, base. 은 상속받은 변수의 값을 쓰겠다는 것
        }
    }
}
