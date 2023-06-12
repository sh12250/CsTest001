using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Cat
{   // 온갖 제한이 있으므로 클래스를 사용하자
    private int legCount;
    public string catName;
    private string catColor;

    public Cat(int  legCount_, string catName_, string catColor_)
    {   
        // 구조체나 클래스에는 자신과 똑같은 이름의 메서드가 있는데
        // 이들을 '생성자', '소멸자'라고 한다
        // 새로 할당할 때 사용되는 것이 생성자고
        // 스코프가 끝날 때 사용되는 것이 소멸자다
        // 특징은 자신과 이름이 똑같고, 리턴 타입이 없다

        legCount = legCount_;
        catName = catName_;
        catColor = catColor_;
    }

    public void Print_MyCat()
    {
        Console.WriteLine("우리집 고양이 이름은 {0} 이고, 색은 {1} 이다", catName, catColor);
    }
}

// 메인보다 먼저 캐싱해서 들고 있다
// 캐싱은 읽어온다는 뜻
namespace _23._06._12_JungProgram
{
    public class Dog
    {
        // 접근 지정자, 접근 제한자
        // public, private, protected
        // 공개   , 비공개  ,          

        // 여기부터 필드
        public int legCount = 4;
        public string dogName = "백구";

        private string dogColor = "흰색";
        private string dogSound = "앜앜";
        // 여기까지 필드

        public void Print_DogDescription()
        {
            Console.WriteLine("강아지 색은 {0}이고, 짖는 소리는 {1} 이다", dogColor, dogSound);
        }

        public static void Print_DogDescription002()
        {
            Console.WriteLine("강아지 이름은 {0}고, 색은 {1}이다", "모름", "모른다");
        }
    }
}
