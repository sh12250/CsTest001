using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._22_JungProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            // 깊은 복사는 참조형 복사로 원본이 바뀌면 복사본도 바뀐다
            CustomChild customChild = new CustomChild();
            CustomChild customChild2 = default;

            customChild2 = customChild;

            customChild.InitNumber(0, 1);

            // 얕은 복사는 값형 복사로 원본을 바꿔도 복사본이 바뀌지 않는다
            customChild2 = new CustomChild();

            customChild2.InitNumber(customChild.xPos, customChild.yPos);

            customChild.InitNumber(0, 0);

            customChild2.PrintPosition();
            //


            // 튜플의 선언법
            (int xPos, int yPos) playerPosition = (22, 22);

            // 튜플의 대입법
            playerPosition.xPos = 11;
            playerPosition.yPos = 33;

            // 튜플의 값 교환법
            (playerPosition.xPos, playerPosition.yPos) = (playerPosition.yPos, playerPosition.xPos);
            Console.WriteLine("playerPosition : ( {0}, {1} )", playerPosition.xPos, playerPosition.yPos);
            //


            // string.Split()
            string strValue = "I am a boy";
            string[] strArray = strValue.Split(' ');

            Console.WriteLine("몇 개로 Split 되었는가 : {0}", strArray.Count());

            foreach(string str_ in strArray)
            {
                Console.WriteLine(str_);
            }

            List<int> intList = new List<int>();
            CustomClass customCalss = new CustomClass();
            CustomChild customChild = new CustomChild();

            customChild.InitNumber(22, 22);

            PrintValue(customChild);
            //


            // nullable
            // 내용을 비워준다
            customChild = null;

            // 보통 이렇게 if문으로 쓴다
            if(customChild == null)
            {
                Console.WriteLine("customChild는 null입니다");
            }
            else
            {
                customChild.PrintPosition();
            }

            // 이렇게도 사용할 수 있지만 가끔 작동을 안한다
            customChild?.PrintPosition();

            // 값 타입은 ?를 붙여야 null이 들어간다
            int? number = null;
            //
            */
        }

        // 함수에서만 사용한다
        // 제네릭에는 제한을 걸 수 있다
        static void PrintValue<AnyDataType>(AnyDataType anyValue) where AnyDataType : CustomClass
        {
            anyValue.PrintPosition();
        }
        //static void PrintValue(int intValue)
        //{
        //    Console.WriteLine("매개변수로 넘겨받은 값을 출력했다 : {0}", intValue);
        //}
        //static void PrintValue(float floatValue)
        //{
        //    Console.WriteLine("매개변수로 넘겨받은 값을 출력했다 : {0}", floatValue);
        //}
        //static void PrintValue(string strValue)
        //{
        //    Console.WriteLine("매개변수로 넘겨받은 값을 출력했다 : {0}", strValue);
        //}
    }
}
