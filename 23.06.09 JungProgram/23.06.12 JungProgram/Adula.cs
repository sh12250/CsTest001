using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._12_JungProgram
{
    public class Adula : MonsterBase
    {
        public override void Initialize(string name, int hp, int mp, int damage, int defence, string type)
        {   // 부모에 정의 되어 있는 메서드를 내려받아서 사용하는 것을
            // overriding 이라고 한다
            base.Initialize(name, hp, mp, damage, defence, type);
        }       // Initialize()

        public override void Print_MonsterStat()
        {
            base.Print_MonsterStat();
        }

        public void Print_OverloadingTest()
        {
            Console.WriteLine("함수 찍힌다");
        }       // overload는 같은 이름의 메서드를 매개변수를 달리 하여 여러개 정의하는 것

        public void Print_OverloadingTest(int textStr)
        {
            Console.WriteLine("함수 찍힌다 -> {0}", textStr);
        }
    }
}
