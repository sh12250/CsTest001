using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public class Program
    {
        static void Main(string[] args)
        {



            /*
            ////
            int number = 10;
            string str = "Hello World!";
            char charValue = 'A';


            // 박싱
            object canSaveAll1 = number;
            object canSaveAll2 = charValue;
            object canSaveAll3 = str;
            // 리플렉션
            var canSaveAnything1 = number;
            var canSaveAnything2 = charValue;
            var canSaveAnything3 = str;

            // object는 int, char, string 의 상위 자료형이다
            // 이걸 사용하는 프로그램은 쓰레기 프로그램
            // var는 컴파일 타임에 변수를 추적, 자료형을 추론한다
            // 추적할 수 없는 변수가 있으면 기능하지 않는다

            // 언박싱
            int number2 = (int)canSaveAll1;


            Console.WriteLine("{0}, {1}, {2}, {3}", canSaveAnything1, canSaveAnything2, canSaveAnything3, number2);
            ////
            

            ////
            Parent myParent = new Parent();
            Child myChild = new Child();

            // myParent.PrintInfos();
            // myChild.PrintInfos();

            // 업 캐스팅
            Parent tempParent = myChild;

            // 다운 캐스팅
            Child tempChild = (Child)tempParent; 

            tempParent.PrintInfos();
            tempChild.PrintInfos();
            ////
            

            */


            ////
            // 업캐스팅을 사용한 예시
            List<MonsterBase> monsterList = new List<MonsterBase>();
            Wolf wolf = new Wolf();
            Slime slime = new Slime();
            Orc orc = new Orc();

            monsterList.Add(wolf);
            monsterList.Add(slime);
            monsterList.Add(orc);

            monsterList.Sort();

            foreach (MonsterBase monster_ in monsterList)
            {
                monster_.PrintInfos();
            }

            orc.OrcPrint();

            int number = 10;
            number.PlusAndPrint(5);

            if (monsterList.IsValid())
            {
                Console.WriteLine("Null이 아닌 값이 들어있다");
            }
            else
            {
                Console.WriteLine("값이 들어있지 않다");
            }
            ////
        }
    }
}
