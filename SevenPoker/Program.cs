using MaybeRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cursor cursor = new Cursor();

            int userInput = 0;

            int dumpCard = 0;

            while(true)
            {
                CardDeck deck = new CardDeck();
                Hands comCard = new Hands(deck.serialNum, 7);
                Hands myCard = new Hands(deck.serialNum, 5);

                cursor.MoveCursor(0, 0);

                comCard.PrintHand(deck.cardInfos);

                Console.WriteLine();

                myCard.PrintHand(deck.cardInfos);


                while(true)
                {
                    if (myCard.handSize == 3)
                    {
                        break;
                    }

                    cursor.MoveCursor(50, 20);
                    userInput = GetPlayerInput();

                    if(userInput == 0)
                    {
                        break;
                    }

                    if (userInput - 1 < myCard.handSize && userInput - 1 >= 0)
                    {
                        dumpCard++;

                        myCard.SetHandSize(myCard.handSize - 1);
                        myCard.hand.Remove(myCard.hand[userInput - 1]);

                        Console.Clear();
                        cursor.MoveCursor(0, 0);
                        comCard.PrintHand(deck.cardInfos);
                        Console.WriteLine();
                        myCard.PrintHand(deck.cardInfos);
                    }
                }

                if(dumpCard > 0)
                {
                    cursor.MoveCursor(0, 4);
                    myCard.SetHandSize(myCard.handSize + dumpCard);
                    myCard.Mulligan(myCard.hand, deck.serialNum, dumpCard);
                    Console.ReadLine();

                    dumpCard = 0;
                }

                Console.Clear();
                cursor.MoveCursor(0, 0);
                comCard.PrintHand(deck.cardInfos);
                Console.WriteLine();
                myCard.PrintHand(deck.cardInfos);
                Console.ReadLine();








            }       // while(true)
        }                                       // main()

        static int GetPlayerInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.KeyChar)
            {
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                default:
                    return 0;
            }
        }



        // 함수 기능은 이름의 직역이다
        static void PrintMyCard(string[] card)
        {
            for (int i = 0; i < card.Length; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine(card[i]);
                    Console.WriteLine(card[i]);
                    Console.WriteLine(card[i]);
                    Console.WriteLine(card[i]);
                }
                else
                {
                    Console.WriteLine(card[i]);
                }
            }
        }

        static void PrintComCard(string[] card1, string[] card2)
        {
            string twoCards = "0";

            for (int i = 0; i < card1.Length; i++)
            {
                twoCards = card1[i] + card2[i];

                if (i == 3)
                {
                    Console.WriteLine(twoCards);
                    Console.WriteLine(twoCards);
                    Console.WriteLine(twoCards);
                    Console.WriteLine(twoCards);
                }
                else
                {
                    Console.WriteLine(twoCards);
                }
            }
        }

        static string[] MakeCard(string pattern, int cardNum)
        {
            string[] card = new string[7];

            string[] numTop = new string[5];
            string[] numBot = new string[5];


            card[0] = "┌───────────┐";
            card[1] = "│ " + pattern + "        │";
            card[2] = "│  " + cardNum + "        │";
            card[3] = "│           │"; // 4번
            card[4] = "│         " + cardNum + " │";
            card[5] = "│        " + pattern + " │";
            card[6] = "└───────────┘";

            numTop[0] = "│  A        │";
            numTop[1] = "│ 10        │";
            numTop[2] = "│  J        │";
            numTop[3] = "│  Q        │";
            numTop[4] = "│  K        │";

            numBot[0] = "│         A │";
            numBot[1] = "│        10 │";
            numBot[2] = "│         J │";
            numBot[3] = "│         Q │";
            numBot[4] = "│         K │";

            switch (cardNum)
            {
                case 1:
                    card[2] = numTop[0];
                    card[4] = numBot[0];

                    return card;
                case 10:
                    card[2] = numTop[1];
                    card[4] = numBot[1];

                    return card;
                case 11:
                    card[2] = numTop[2];
                    card[4] = numBot[2];

                    return card;
                case 12:
                    card[2] = numTop[3];
                    card[4] = numBot[3];

                    return card;
                case 13:
                    card[2] = numTop[4];
                    card[4] = numBot[4];

                    return card;
                default:
                    return card;
            }
        }

        static void ShuffleCard(int startNum, int[] intArr)
        {
            Random random = new Random();
            int randIdx1, randIdx2 = 0;

            for (int i = 0; i < 300; i++)
            {
                randIdx1 = random.Next(startNum, intArr.Length);
                randIdx2 = random.Next(startNum, intArr.Length);

                Swap(intArr, randIdx1, randIdx2);
            }
        }

        static void Swap(int[] intArr, int firstIdx, int SecondIdx)
        {
            int temp = 0;

            temp = intArr[firstIdx];
            intArr[firstIdx] = intArr[SecondIdx];
            intArr[SecondIdx] = temp;
        }
    }
}
