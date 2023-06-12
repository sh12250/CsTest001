using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._12_JungProgram
{
    public class MonsterBase
    {
        // 캡슐화
        // 필드를 private로 처리해서 외부에서 접근 불가능하도록 하겠다
        // protected는 상속받은 자식 클래스에서만 쓸 수 있도록 하겠다는 뜻
        protected string name;
        protected int maxHp;
        protected int maxMp;
        protected string type;
        protected int damage;
        protected int defence;
        // 필드

        public virtual void Initialize(string name, int hp, int mp, int damage, int defence, string type)
        {
            this.name = name;
            this.maxHp = hp; 
            this.maxMp = mp;
            this.damage = damage;
            this.defence = defence;
            this.type = type;
        }

        public virtual void Print_MonsterStat()
        {
            Console.WriteLine("{0}", name);
            Console.WriteLine();
            Console.WriteLine("체력 {0} / {1}", maxHp, maxHp);
            Console.WriteLine("마력 {0} / {1}", maxMp, maxMp);
            Console.WriteLine("타입 {0}", type);
            Console.WriteLine("공격력 {0}", damage);
            Console.WriteLine("방어력 {0}", defence);
        }
    }
}
