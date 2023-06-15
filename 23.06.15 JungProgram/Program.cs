using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 플레이어로부터 사이즈를 입력받아서 해당 사이즈 크기만큼 맵을 만든다
// 플레이어는 wasd등 방향을 입력받아서 맵안을 자유롭게 움직일 수 있다
// 맵에는 일정 시간 or 일정 움직임 마다 돌 3개가 등장한다( 최대 3개까지 존재한다 )
// 플레이어는 돌을 밀 수 있다
// 한번 민 돌은 해당 방향으로 끝까지 쭉 밀린다
// 어떤 방향으로든 돌이 연속으로 3개가 붙어 있을 경우 돌은 사라지고, 점수가 올라간다
// 일정 점수를 획득하면 게임을 종료한다

namespace _23._06._15_JungProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 내가 정의한 enum 타입 변수를 선언해보자
            ItemType_SH itemType = new ItemType_SH();
            ItemInfo itemInfo = new ItemInfo();

            // itemType = ItemType_SH.WEAPON;
            // Console.WriteLine("enum타입은 뭐라고 출력될까  {0} ", (int)itemType);

            itemInfo.InitItem("단검", 3, 1500);
            Console.WriteLine("{0}", itemInfo.Get_ItemName());

            switch (itemType)
            {
                case ItemType_SH.POTION:
                    Console.WriteLine("이 아이템의 타입은 포션 입니다");
                    break;
                case ItemType_SH.GOLD:
                    Console.WriteLine("이 아이템의 타입은 골드 입니다");
                    break;
                case ItemType_SH.WEAPON:
                    Console.WriteLine("이 아이템의 타입은 무기 입니다");
                    break;
                case ItemType_SH.ARMOR:
                    Console.WriteLine("이 아이템의 타입은 방어구 입니다");
                    break;
                default:
                    Console.WriteLine("이 아이템의 타입은 정의되지 않았습니다");
                    break;
            }
        }
    }
}
