using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public partial class Orc : MonsterBase
    {   // partial 클래스는 특정 클래스가 너무 길어졌을때, 나눠서 관리하기 위해 사용한다 + 자신만의 컨벤션으로 이름을 관리하면 좋다
        public void PrintAnotherThings()
        {
            Console.WriteLine("파일을 2개로 나누었다" + "정말로 Orc 클래스에서 이 함수를 Call할 수 있을까?");
        }
    }
}
