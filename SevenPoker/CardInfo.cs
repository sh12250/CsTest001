using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class CardInfo
    {
        public string cardNum { get; private set; }
        public string cardPattern { get; private set; }

        public CardInfo(int number)
        {
            cardNum = Convert.ToString((number % 13) + 1);

            if(cardNum == "1")
            {
                cardNum = "A";
            }
            else if(cardNum == "11")
            {
                cardNum = "J";
            }
            else if(cardNum == "12")
            {
                cardNum = "Q";
            }
            else if(cardNum == "13")
            {
                cardNum = "K";
            }


            if(number / 13 == 0)
            {
                cardPattern = "♠";
            }
            else if(number / 13 == 1)
            {
                cardPattern = "♡";
            }
            else if (number / 13 == 2)
            {
                cardPattern = "◇";
            }
            else if (number / 13 == 3)
            {
                cardPattern = "♣";
            }
        }
    }
}
