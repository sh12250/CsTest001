using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 출력부
            // {        문자열 속에 문자 찾기를 수행하는 함수
            //string mainString = Console.ReadLine();
            //string subString = Console.ReadLine();

            //Console.WriteLine("{0}", ReturnFirstIndex(mainString, subString));
            // }        문자열 속에 문자 찾기를 수행하는 함수

            // {        문자열을 입력받으면 단어의 갯수를 출력하는 함수
            //string word = Console.ReadLine();
            //Console.WriteLine("{0}", ReturnWordCount(word));
            // }        문자열을 입력받으면 단어의 갯수를 출력하는 함수

            // {        주어진 숫자가 소수인지 판별하는 solution
            //if (IsPrime(15))
            //{
            //    Console.WriteLine("소수");
            //}
            //else
            //{
            //    Console.WriteLine("소수 아님");
            //}
            // }        주어진 숫자가 소수인지 판별하는 solution

            // {        사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution
            //Console.WriteLine("{0}", SumOfDigits(100000));
            // }        사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution

            // {        k개의 정렬된 배열에서 공통항목을 찾는 Solution
            //int[] arr1 = { 1, 5, 10, 20 };
            //int[] arr2 = { 3, 4, 5, 10, 20 };
            //int[] arr3 = { 5, 5, 10, 20 };

            //int[] commonArr = FindCommonItems(arr1, arr2, arr3);

            //for (int i = 0; i < commonArr.Length; i++)
            //{
            //    Console.Write("{0}", commonArr[i]);
            //    if(i + 1 != commonArr.Length)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.WriteLine();
            // }        k개의 정렬된 배열에서 공통항목을 찾는 Solution
            #endregion 출력부

            //UpDownGame();
            //SlidePuzzle();
            //BingoGame();
        }
        #region 함수
        // {        문자열 속에 문자 찾기를 수행하는 함수
        static int ReturnFirstIndex(string main, string sub)
        {
            int sameCount = 0;
            for (int i = 0; i < main.Length; i++)
            {
                for (int j = 0; j < sub.Length; j++)
                {
                    if (main[i + j] == sub[j])
                    {
                        sameCount++;
                    }
                }
                if (sameCount == sub.Length)
                {
                    return i;
                }
                else
                {
                    sameCount = 0;
                }
            }

            return -1;
        }
        // }        문자열 속에 문자 찾기를 수행하는 함수

        // {        문자열을 입력받으면 단어의 갯수를 출력하는 함수
        static int ReturnWordCount(string word)
        {
            int wordCount = 1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    wordCount += 1;
                }
            }

            return wordCount;
        }
        // }        문자열을 입력받으면 단어의 갯수를 출력하는 함수

        // {        주어진 숫자가 소수인지 판별하는 solution
        static bool IsPrime(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count += 1;
                }
            }

            if (count == 2)
            {
                return true;
            }
            return false;
        }
        // }        주어진 숫자가 소수인지 판별하는 solution

        // {        사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution
        static int SumOfDigits(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
        // }        사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 Solution

        // {        k개의 정렬된 배열에서 공통항목을 찾는 Solution
        static int[] FindCommonItems(int[] arr1, int[] arr2, int[] arr3)
        {
            int[] commons;
            List<int> temp = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (temp.Count != 0)
                {
                    if (temp.Contains(arr1[i]))
                    {
                        continue;
                    }
                }

                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        for (int k = 0; k < arr3.Length; k++)
                        {
                            if (arr2[j] == arr3[k])
                            {
                                if (!temp.Contains(arr1[i]))
                                {
                                    temp.Add(arr1[i]);
                                }
                            }
                        }
                    }
                }
            }

            commons = new int[temp.Count];

            for (int i = 0; i < temp.Count; i++)
            {
                commons[i] = temp[i];
            }

            return commons;
        }
        // }        k개의 정렬된 배열에서 공통항목을 찾는 Solution
        #endregion 함수

        #region 게임
        // {        Up&Down
        static void UpDownGame()
        {
            Random random = new Random();
            string userInput = "0";
            int inputNum = 0;

            while (true)
            {
                int life = 10;
                bool isWin = false;
                int hideNum = random.Next(0, 1000);

                while (true)
                {
                    Console.WriteLine("Up&Down 게임");
                    Console.WriteLine("기회 : {0}", life);
                    Console.WriteLine("숫자를 입력하세요");

                    userInput = Console.ReadLine();
                    int.TryParse(userInput, out inputNum);

                    if (inputNum == hideNum)
                    {
                        Console.WriteLine("정답입니다");

                        Task.Delay(1000).Wait();
                        Console.Clear();
                        isWin = true;
                        break;
                    }
                    else if (inputNum > hideNum)
                    {
                        Console.WriteLine("그것보단 작습니다");

                        Task.Delay(1000).Wait();
                        Console.Clear();
                        life -= 1;
                    }
                    else if (inputNum < hideNum)
                    {
                        Console.WriteLine("그것보단 큽니다");

                        Task.Delay(1000).Wait();
                        Console.Clear();
                        life -= 1;
                    }

                    if (life <= 0)
                    {
                        Console.WriteLine("정답은 {0}입니다", hideNum);
                        break;
                    }
                }

                if (life <= 0 || isWin)
                {
                    Console.WriteLine("다시 해보시겠습니까?");
                    Console.WriteLine("1. 예");
                    Console.WriteLine("2. 아니오");

                    userInput = Console.ReadLine();
                    int.TryParse(userInput, out inputNum);

                    if (inputNum == 2)
                    {
                        Console.WriteLine("게임을 종료합니다");

                        Task.Delay(1000).Wait();
                        Console.Clear();
                        break;
                    }
                    else if (inputNum == 1)
                    {
                        Console.WriteLine("게임을 다시 시작합니다");

                        Task.Delay(1000).Wait();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("다시 시작합니다?");

                        Task.Delay(1000).Wait();
                        Console.Clear();
                    }
                }
            }
        }
        // }        Up&Down

        // {        슬라이드 퍼즐
        static void SlidePuzzle()
        {
            Random random = new Random();
            const int SIZE = 5;

            int[,] board = new int[SIZE, SIZE];

            for (int y = 0; y < SIZE; y++)
            {
                for (int x = 0; x < SIZE; x++)
                {
                    board[y, x] = (y * 5) + (x + 1);
                }
            }

            int userY = SIZE - 1;
            int userX = SIZE - 1;

            board[userY, userX] = 0;

            int direct = 0;

            for (int i = 0; i < 100; i++)
            {
                direct = random.Next(0, 4);

                switch (direct)
                {
                    case 0:
                        if (userY != 0)
                        {
                            board[userY, userX] = board[userY - 1, userX];
                            userY -= 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case 1:
                        if (userX != SIZE - 1)
                        {
                            board[userY, userX] = board[userY, userX + 1];
                            userX += 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case 2:
                        if (userY != SIZE - 1)
                        {
                            board[userY, userX] = board[userY + 1, userX];
                            userY += 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case 3:
                        if (userX != 0)
                        {
                            board[userY, userX] = board[userY, userX - 1];
                            userX -= 1;
                            board[userY, userX] = 0;
                        }
                        break;
                }
            }

            ConsoleKeyInfo userInput;

            while (true)
            {
                for (int y = 0; y < SIZE; y++)
                {
                    for (int x = 0; x < SIZE; x++)
                    {
                        Console.SetCursorPosition(x * 10, y * 5);
                        if (board[y, x] < 10)
                        {
                            Console.Write("{0} ", board[y, x]);
                            continue;
                        }
                        Console.Write("{0}", board[y, x]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("화살표 키로 이동");
                Console.WriteLine("플레이어 : {0}", board[userY, userX]);

                userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (userY != 0)
                        {
                            board[userY, userX] = board[userY - 1, userX];
                            userY -= 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (userX != 0)
                        {
                            board[userY, userX] = board[userY, userX - 1];
                            userX -= 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (userY != SIZE - 1)
                        {
                            board[userY, userX] = board[userY + 1, userX];
                            userY += 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (userX != SIZE - 1)
                        {
                            board[userY, userX] = board[userY, userX + 1];
                            userX += 1;
                            board[userY, userX] = 0;
                        }
                        break;
                }
            }
        }
        // }        슬라이드 퍼즐

        // {        빙고 게임
        static void BingoGame()
        {
            Random random = new Random();
            const int SIZE = 5;

            int[,] board = new int[SIZE, SIZE];

            for (int y = 0; y < SIZE; y++)
            {
                for (int x = 0; x < SIZE; x++)
                {
                    board[y, x] = (y * 5) + (x + 1);
                }
            }

            int userY = SIZE - 1;
            int userX = SIZE - 1;

            board[userY, userX] = 0;

            int direct = 0;

            for (int i = 0; i < 200; i++)
            {
                direct = random.Next(0, 4);

                switch (direct)
                {
                    case 0:
                        if (userY != 0)
                        {
                            board[userY, userX] = board[userY - 1, userX];
                            userY -= 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case 1:
                        if (userX != SIZE - 1)
                        {
                            board[userY, userX] = board[userY, userX + 1];
                            userX += 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case 2:
                        if (userY != SIZE - 1)
                        {
                            board[userY, userX] = board[userY + 1, userX];
                            userY += 1;
                            board[userY, userX] = 0;
                        }
                        break;
                    case 3:
                        if (userX != 0)
                        {
                            board[userY, userX] = board[userY, userX - 1];
                            userX -= 1;
                            board[userY, userX] = 0;
                        }
                        break;
                }
            }

            string userInput = "0";
            int inputNum = 0;

            while (true)
            {
                int bingoCount = 0;

                #region 빙고 체크
                if (board[0, 0] == 35 && board[0, 1] == 35 && board[0, 2] == 35 && board[0, 3] == 35 && board[0, 4] == 35)
                {
                    bingoCount += 1;
                }
                if (board[1, 0] == 35 && board[1, 1] == 35 && board[1, 2] == 35 && board[1, 3] == 35 && board[1, 4] == 35)
                {
                    bingoCount += 1;
                }
                if (board[2, 0] == 35 && board[2, 1] == 35 && board[2, 2] == 35 && board[2, 3] == 35 && board[2, 4] == 35)
                {
                    bingoCount += 1;
                }
                if (board[3, 0] == 35 && board[3, 1] == 35 && board[3, 2] == 35 && board[3, 3] == 35 && board[3, 4] == 35)
                {
                    bingoCount += 1;
                }
                if (board[4, 0] == 35 && board[4, 1] == 35 && board[4, 2] == 35 && board[4, 3] == 35 && board[4, 4] == 35)
                {
                    bingoCount += 1;
                }

                if (board[0, 0] == 35 && board[1, 0] == 35 && board[2, 0] == 35 && board[3, 0] == 35 && board[4, 0] == 35)
                {
                    bingoCount += 1;
                }
                if (board[0, 1] == 35 && board[1, 1] == 35 && board[2, 1] == 35 && board[3, 1] == 35 && board[4, 1] == 35)
                {
                    bingoCount += 1;
                }
                if (board[0, 2] == 35 && board[1, 2] == 35 && board[2, 2] == 35 && board[3, 2] == 35 && board[4, 2] == 35)
                {
                    bingoCount += 1;
                }
                if (board[0, 3] == 35 && board[1, 3] == 35 && board[2, 3] == 35 && board[3, 3] == 35 && board[4, 3] == 35)
                {
                    bingoCount += 1;
                }
                if (board[0, 4] == 35 && board[1, 4] == 35 && board[2, 4] == 35 && board[3, 4] == 35 && board[4, 4] == 35)
                {
                    bingoCount += 1;
                }

                if (board[0, 0] == 35 && board[1, 1] == 35 && board[2, 2] == 35 && board[3, 3] == 35 && board[4, 4] == 35)
                {
                    bingoCount += 1;
                }
                if (board[0, 4] == 35 && board[1, 3] == 35 && board[2, 2] == 35 && board[3, 1] == 35 && board[4, 0] == 35)
                {
                    bingoCount += 1;
                }
                #endregion 빙고 체크

                if (bingoCount == 3)
                {
                    Console.Clear();
                    Console.SetCursorPosition(18, 10);
                    Console.WriteLine("승리");
                    Console.SetCursorPosition(0, 20);
                    break;
                }

                for (int y = 0; y < SIZE; y++)
                {
                    for (int x = 0; x < SIZE; x++)
                    {
                        Console.SetCursorPosition(x * 10, y * 5);

                        if (board[y, x] == 35)
                        {
                            Console.Write("# ");
                            continue;
                        }

                        if (board[y, x] < 10)
                        {
                            Console.Write("{0} ", board[y, x]);
                            continue;
                        }
                        Console.Write("{0}", board[y, x]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("원하는 위치의 숫자를 입력하세요");

                userInput = Console.ReadLine();
                int.TryParse(userInput, out inputNum);

                for (int y = 0; y < SIZE; y++)
                {
                    for (int x = 0; x < SIZE; x++)
                    {
                        if (board[y, x] == inputNum)
                        {
                            board[y, x] = 35;
                        }
                    }
                }
            }
        }
        // }        빙고 게임
        #endregion 게임
    }
}
