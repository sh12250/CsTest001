using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class CardGame
    {
        public int money { get; private set; }


        public void RunCardGame(int playerMoney)
        {
            money = playerMoney;
            int[] cards = new int[52];
            string[] patterns = new string[4];
            Random random = new Random();

            // 문양 초기화
            patterns[0] = "♣";
            patterns[1] = "◇";
            patterns[2] = "♡";
            patterns[3] = "♠";

            // 숫자 초기화
            for (int x = 0; x < cards.GetLength(0); x++)
            {
                cards[x] = x + 1;
            }

            // 어떤 카드인지
            int[] comCard = new int[4];
            int[] myCard = new int[2];

            // 카드 출력용
            string[] theComCard1 = new string[7];
            string[] theComCard2 = new string[7];
            string[] theMyCard = new string[7];



            // 처음에만 출력
            Console.WriteLine("첫 게임");
            Task.Delay(1000).Wait();
            Console.Clear();

            // 실제 플레이
            while (true)
            {
                int betOn = 1;
                string userInput = "0";

                if (money == 0)
                {   // 게임 패배
                    Console.WriteLine("당신은 가진 칩을 모두 사용했습니다");
                    Console.WriteLine("돈 내기는 적당히 하세요 ^^");
                    break;
                }

                // 카드 셔플
                ShuffleCard(0, cards);
                // 컴카드, 0,2에는 문양을 1,3에는 숫자를 세팅
                comCard[0] = (cards[0] - 1) / 13;
                comCard[1] = cards[0] % 13 + 1;
                comCard[2] = (cards[1] - 1) / 13;
                comCard[3] = cards[1] % 13 + 1;

                // 컴카드 출력
                theComCard1 = MakeCard(patterns[comCard[0]], comCard[1]);
                theComCard2 = MakeCard(patterns[comCard[2]], comCard[3]);
                PrintComCard(theComCard1, theComCard2);

                // Console.WriteLine("{0}{2}   {1}{3}", patterns[comCard[0]], patterns[comCard[2]], comCard[1], comCard[3]);
                Task.Delay(1000).Wait();

                // 칩, 판돈, 베팅 여부 출력
                money -= betOn;
                Console.WriteLine("칩 : {0}  판돈 : {1}", money, betOn);

                if (money != 0)
                {
                    Console.WriteLine("베팅할까?");
                    Console.WriteLine("1. YES  2. NO  3. END");

                    // 플레이어의 선택
                    userInput = Console.ReadLine();
                    Console.Clear();
                }
                else if (money == 0)
                {
                    userInput = "1";
                    Console.WriteLine("카드는 까봐야지...");
                    Console.ReadLine();
                    Console.Clear();
                }

                // 선택 결과
                if (userInput == "1")
                {
                    userInput = "0";

                    PrintComCard(theComCard1, theComCard2);

                    if (money != 0)
                    {
                        Console.WriteLine("얼마나 베팅하지?");

                        // 숫자 받아주기
                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out betOn);

                        // 베팅 진행
                        if (betOn == 0 || betOn == 10)
                        {   // 이상한 거 적으면 기본 베팅
                            betOn = 10;
                            money -= betOn;
                            Console.WriteLine("기본으로 베팅하겠습니다");
                            Console.WriteLine("칩을 {0}개 베팅했다", betOn);
                            Task.Delay(1000).Wait();
                            Console.Write("드로우!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (betOn >= money)
                        {   // 현재 점수보다 높으면 올인
                            betOn = money;
                            money = 0;
                            Console.WriteLine("올인!!!", betOn);
                            Console.WriteLine("가진 칩을 모두 베팅했다");
                            Task.Delay(1000).Wait();
                            Console.Write("제발제발제발제발");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {   // 숫자 적으면 그대로 베팅
                            money -= betOn;
                            Console.WriteLine("{0}개 베팅하겠습니다", betOn);
                            Console.WriteLine("칩을 {0}개 베팅했다", betOn);
                            Task.Delay(1000).Wait();
                            Console.Write("드로우!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }           // if(scoreNow != 0)
                    else if (money == 0)
                    {
                        Task.Delay(1000).Wait();
                        Console.Write("제발제발제발제발");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    // 카드 셔플 ( 좀 더 랜덤하게 )
                    ShuffleCard(2, cards);
                    // 내카드, 0에는 문양을 1에는 숫자를 세팅
                    myCard[0] = cards[2] / 13;
                    myCard[1] = cards[2] % 13 + 1;

                    // 컴카드 출력
                    PrintComCard(theComCard1, theComCard2);

                    // 내카드 출력
                    theMyCard = MakeCard(patterns[myCard[0]], myCard[1]);
                    PrintMyCard(theMyCard);

                    Task.Delay(1000).Wait();

                    // 승리 패배 조건
                    if (comCard[1] > comCard[3])
                    {
                        if (myCard[1] < comCard[1] && myCard[1] > comCard[3])
                        {   // 승리
                            money += betOn * 2;
                            Console.WriteLine("내기에서 이겼습니다");
                            Task.Delay(1000).Wait();

                            Console.WriteLine("칩 : {0}", money);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {   // 패배
                            Console.WriteLine("내기에서 졌습니다");
                            Task.Delay(1000).Wait();
                            Console.WriteLine("칩 : {0}", money);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else // comCard[1] <= comCard[3]
                    {
                        if (myCard[1] < comCard[3] && myCard[1] > comCard[1])
                        {   // 승리
                            money += betOn * 2;
                            Console.WriteLine("내기에서 이겼습니다");
                            Task.Delay(1000).Wait();

                            Console.WriteLine("칩 : {0}", money);
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else
                        {   // 패배
                            Console.WriteLine("내기에서 졌습니다");
                            Task.Delay(1000).Wait();
                            Console.WriteLine("칩 : {0}", money);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }       // if(userInput == "1")
                else if (userInput == "2")
                {
                    PrintComCard(theComCard1, theComCard2);
                    Console.WriteLine("죽었습니다");
                    Task.Delay(1000).Wait();
                    Console.WriteLine("칩 : {0}", money);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("본 점을 이용해 주셔서 감사합니다");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("당신은 도박장을 나왔다");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    PrintComCard(theComCard1, theComCard2);
                    Console.WriteLine("죽은 걸로 치겠습니다");
                    Task.Delay(1000).Wait();
                    Console.WriteLine("칩 : {0}", money);
                    Console.ReadLine();
                    Console.Clear();
                }

                if (money > 0 && money < 300)
                {
                    Console.WriteLine("다음 게임");
                    Task.Delay(1000).Wait();
                    Console.Clear();
                }
            }                                       // while()

            Task.Delay(2000).Wait();
            Console.Clear();
        }                                       // main()

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

        public int ReturnMoney()
        {
            return money;
        }
    }
}
