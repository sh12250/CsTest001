using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// 일정한 주기로 코인이 랜덤한 위치에 떨어진다
// 플레이어 ( 0 )가 코인을 주으면 점수가 상승

// 플레이어와 컴퓨터가 각각 카드를 2장씩 뽑는다
// 두 카드의 합이 더 큰 쪽이 승리, 작은 쪽은 패배한다
// 동일한 숫자가 나올 경우 문양은
// 스페이드, 다이아몬드, 하트, 클로버 순으로 승리한다

namespace _23._06._09_JungProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] cards = new int[4];

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = random.Next(1, 52);
            }

            int myCard1 = cards[0];
            string myPatt1 = ReturnPattern(cards[0] / 13);

            int myCard2 = cards[1];
            string myPatt2 = ReturnPattern(cards[1] / 13);

            int comCard1 = cards[2];
            string comPatt1 = ReturnPattern(cards[2] / 13);

            int comCard2 = cards[3];
            string comPatt2 = ReturnPattern(cards[3] / 13);

            if(myCard1 + myCard2 > comCard1 + comCard2)
            {
                Console.WriteLine("승리");
            }
            else if(myCard1 + myCard2 == comCard1 + comCard2)
            {
                if (myCard1 > myCard2)
                {
                    if(comCard1 > comCard2)
                    {
                        if(myCard1 > comCard1)
                        {

                        }
                    }
                    else if(comCard2 > comCard1 && myCard1 > comCard2)
                    {

                    }
                }
                else if (myCard1 == myCard2)
                {

                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("패배");
            }






            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i] % 13 + 1);
            }


        }           // main()


        static string ReturnPattern(int num)
        {
            switch(num)
            {
                case 0:
                    return "♣";
                case 1:
                    return "♡";
                case 2:
                    return "◇";
                case 3:
                    return "♠";
                default:
                    return "0";
            }
        }
        static void Shuffle(int[] numArr)
        {




        }
    }           // class program()
}
