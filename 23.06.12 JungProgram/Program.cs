using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._12_JungProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            int width = 80;
            int height = 20;

            Console.WindowWidth = width; // 콘솔 창
            Console.WindowHeight = height;

            Console.BufferWidth = 80; // 버퍼
            Console.BufferHeight = 20;

            Console.SetCursorPosition(20, 10); // 커서 위치 변경( 행, 열 )
            

            string[] str = new string[2] { "Hello", "World" };

            // CallFunc001(str);
            // CallFunc002("Hello", "World", "+", "Hello", "World");
            // CallFunc003(ref str);
            string[] resultString;
            CallFunc004(str, out resultString); 
            foreach(string result_ in resultString)
            {
                Console.Write("{0} ", result_);
            }
            Console.WriteLine();
            // out은 절대로 비지 않았으면 하는 값이 있을 때 사용한다

            int number = 0;
            number += 1;
            Console.WriteLine("number는 무슨 값이 들어 있나? {0}", number);
            

            Dog myDog = new Dog();
            Console.WriteLine("우리집 강아지 이름은 {0}고, 다리 갯수는 {1}개다.", myDog.dogName, myDog.legCount);

            myDog.Print_DogDescription();

            Dog.Print_DogDescription002();
            Console.WriteLine();

            Cat myCat = new Cat(4, "애옹이", "삼색");
            myCat.Print_MyCat();
            myCat.catName = "야옹이";
            myCat.Print_MyCat();
            */

            // 객체 지향의 4가지 요소
            // 캡슐화, 상속, 다형성, 추상화

            Ekzykes myEkzykes = new Ekzykes();
            Borealis myBorealis = new Borealis();
            Adula myAdula = new Adula();

            myEkzykes.Initialize("썩어가는 엑디키스", 10000, 1000, 120, 20, "비룡");
            myEkzykes.Print_MonsterStat();
            Console.WriteLine();

            myBorealis.Initialize("얼어붙는 안개 볼레아리스", 20000, 2000, 150, 50, "비룡");
            myBorealis.Print_MonsterStat();
            Console.WriteLine();
            
            myAdula.Initialize("휘석룡 아듀라", 15000, 2000, 180, 30, "비룡");
            myAdula.Print_MonsterStat();
            Console.WriteLine();
            
        }       // Main()

        static void CallFunc004(string[] str, out string[] outStr)
        {   // call by reference           // out 변수에 값이 무조건 있어야한다( return이랑 비슷한 듯? )
            string[] resultString = new string[str.Length + 1];

            for(int i = 0; i < str.Length; i++)
            {
                resultString[i] = str[i];
            }
            resultString[str.Length] = "!";
            outStr = resultString;
        }

        static void CallFunc003(ref string[] str)
        {   // 매개변수를 call by reference 방식으로 넘기는 법
            foreach (string strElement in str)
            {
                Console.Write("{0} ", strElement);
            }
            Console.WriteLine();
        }

        static void CallFunc002(params string[] str)
        {   // call by value // params : 매개 변수로 받을 때 배열의 크기와 상관없이 받을 수 있다
            foreach (string strElement in str)
            {
                Console.Write("{0} ", strElement);
            }
            Console.WriteLine();
        }

        static void CallFunc001(string[] str)
        {       // 매개변수를 call by value방식으로 넘기는 법
            foreach(string strElement in str)
            { 
                Console.Write("{0} ", strElement);
            }
            Console.WriteLine();
        }
    }       // class Program
}
