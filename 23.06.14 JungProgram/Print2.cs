using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._14_JungProgram
{
    static class Print2
    {
        // static class는 모든 클래스에서 알 수 있다
        private static string _message = default;

        public static void PrintMessage(string localMessage) // 메서드의 접근 수준도 Public
        {
            _message = localMessage;
            Console.WriteLine("이런걸 출력한다 : {0}", _message);
        }

        public static void PrintMessage()
        {
            Console.WriteLine("이게 왜 되지");
        }
    }
}
