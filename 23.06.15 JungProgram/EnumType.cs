using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._15_JungProgram
{
    enum ItemType_SH
    {   // 0부터 시작하는 숫자에 상수로 이루어진 네임태그를 붙인 구조다
        // 정수를 할당해주면, 그 부분부터 1씩 더해진 수가 순차적으로 할당된다
        POTION = 1_000_000_000, GOLD, WEAPON, ARMOR
            // 언더바로 끊어도 인식한다
    }
}
