using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._14_JungProgram
{
    public class Print          // 클래스의 접근 수준이 Public
    {
        // 멤버 변수, 필드
        public static string staticMessage = default;
        private string _message = "인스턴스 필드에 미리 넣어둔 값";

        // static 에는 인스턴스 값을 넣어줄 수 없다

        // 멤버 함수, 메서드
        public void PrintMessage(string localMessage) // 메서드의 접근 수준도 Public
        {
            Print2.PrintMessage();
            _message = localMessage;
            Console.WriteLine("이런걸 출력한다 : {0}", _message);
        }
    }
}
