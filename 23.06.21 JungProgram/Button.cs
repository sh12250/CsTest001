using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._21_JungProgram
{
    public class Button : IClickable, IDamagable
    {
        public void TestFunc01()
        {
            Console.WriteLine("함수 테스트");
        }

        public void ClickThisObject(bool isClick)
        {
            Console.WriteLine("이제는 에러가 없다");
        }

        public void Damaged(int damage)
        {
            // None Damage
        }
    }
}
