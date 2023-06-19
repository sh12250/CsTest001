using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class CardDeck
    {
        public List<int> serialNum {  get; private set; }
        public Dictionary<int, CardInfo> cardInfos { get; private set; }

        public CardDeck()
        {
            serialNum = new List<int>();
            cardInfos = new Dictionary<int, CardInfo>();

            for (int num = 0; num < 52; num++)
            {
                serialNum.Add(num);
            }

            for(int num = 0; num < 52; num++)
            {
                cardInfos.Add(num, new CardInfo(num));
            }
        }
        
    }
}
