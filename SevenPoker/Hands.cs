using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class Hands
    {
        public List<int> hand { get; private set; }
        public int handSize { get; private set; }


        public Hands(List<int> serialNum, int cards)
        {
            hand = new List<int>();
            handSize = cards;

            Random random = new Random();
            int randIdx = 0;

            for (int i =  0; i < handSize; i++)
            {
                randIdx = random.Next(serialNum.Count);
                hand.Add(randIdx);
                serialNum.Remove(randIdx);
            }
        }

        public void PrintHand(Dictionary<int, CardInfo> info)
        {
            for (int i = 0; i < handSize; i++)
            {
                Console.Write(info[hand[i]].cardNum + info[hand[i]].cardPattern + " ");
            }
            Console.WriteLine();
        }

        public void Mulligan(List<int> hand_, List<int> serialNum, int num)
        {
            Random random = new Random();
            int randIdx = 0;

            for (int i = 0; i < num; i++)
            {
                randIdx = random.Next(serialNum.Count);
                hand_.Add(randIdx);
                serialNum.Remove(randIdx);
            }
        }

        public void SetHandSize(int size)
        {
            handSize = size;
        }
    }
}
