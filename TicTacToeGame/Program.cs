using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput;
                int userInputY;
                int userInputX;

                GameManager gM = new GameManager();
                Board board = new Board();
                Ai ai = new Ai();
                User user = new User();

                while (true)
                {
                    while (true)
                    {
                        board.PrintTheBoard();
                        Console.WriteLine("행과 열을 입력해 주세요 ( 0 ~ 2 )");

                        Console.Write("행 : ");
                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out userInputX);

                        Console.Write("열 : ");
                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out userInputY);

                        if(userInputY > 2 || userInputY < 0 || userInputX > 2 || userInputX < 0)
                        {
                            Console.WriteLine("턴을 포기했습니다");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else if (board._gameBoard[userInputY, userInputX] != "  ")
                        {
                            Console.WriteLine("이미 채워진 칸입니다");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            user.UserSelet(userInputX, userInputY);
                            user.Action(board._gameBoard);
                            board.PrintTheBoard();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    }       // while()

                    if (gM.CheckUserWin(board._gameBoard))
                    {
                        break;
                    }

                    board.PrintTheBoard();
                    Console.WriteLine("상대의 차례입니다");
                    Task.Delay(1000).Wait();
                    ai.AiSelect(board._gameBoard);
                    ai.Action(board._gameBoard);

                    if (gM.CheckAiWin(board._gameBoard))
                    {
                        break;
                    }

                    board.PrintTheBoard();
                    Console.ReadLine();
                    Console.Clear();
                }       // while()

                if (gM.CheckUserWin(board._gameBoard))
                {
                    board.PrintTheBoard();
                    Console.WriteLine("승리!!!");
                }
                else if (gM.CheckAiWin(board._gameBoard))
                {
                    board.PrintTheBoard();
                    Console.WriteLine("패배...");
                }

                Console.WriteLine("다음 게임을 하시겠습니까?");
                Console.WriteLine("  1. 예    2. 아니오  ");

                userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("다음 게임을 시작합니다");
                    continue;
                }
                else if(userInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("게임을 종료합니다");
                    break;
                }
            }       // while()
        }
    }
}
