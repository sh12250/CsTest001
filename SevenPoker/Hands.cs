using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class Hands
    {
        public List<int> hand { get; private set; }
        public int handSize { get; private set; }
        public int grade { get; set; }

        public Hands(List<int> serialNum, int cards)
        {
            hand = new List<int>();
            handSize = cards;

            Random random = new Random();
            int randIdx = 0;

            for (int i =  0; i < handSize; i++)
            {
                randIdx = random.Next(serialNum.Count);
                hand.Add(serialNum[randIdx]);
                serialNum.Remove(serialNum[randIdx]);
            }
            SortHand();
        }

        public void PrintHand(Dictionary<int, CardInfo> info)
        {
            for (int i = 0; i < handSize; i++)
            {
                Console.Write(info[hand[i]].cardNum + info[hand[i]].cardPattern + " ");
            }
            Console.WriteLine();
        }

        public void Mulligan(List<int> serialNum, int num)
        {
            Random random = new Random();
            int randIdx = 0;

            for (int i = 0; i < num; i++)
            {
                randIdx = random.Next(serialNum.Count);
                hand.Add(serialNum[randIdx]);
                serialNum.Remove(serialNum[randIdx]);
            }
            SortHand();
        }

        public void SortHand()
        {
            int i, j, least, temp;

            // 마지막 숫자는 자동으로 정렬되기 때문에 (숫자 개수-1) 만큼 반복한다.
            for (i = 0; i < handSize - 1; i++)
            {
                least = i;

                // 최솟값을 탐색한다.
                for (j = i + 1; j < handSize; j++)
                {
                    if ((hand[j]) % 13 < (hand[least]) % 13)
                    {
                        least = j;
                    }
                }

                // 최솟값이 자기 자신이면 자료 이동을 하지 않는다.
                if (i != least)
                {
                    temp = hand[least];
                    hand[least] = hand[i];
                    hand[i] = temp;
                }
            }
        }

        public void SetHandSize(int size)
        {
            handSize = size;
        }
    }
}
