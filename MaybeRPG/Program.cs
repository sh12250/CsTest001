using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Cursor cursor = new Cursor();
            Player player = new Player();
            Shop shop = new Shop();
            Inventory inventory = new Inventory();


            map.InitSize();
            map.MakeMap();

            // 6, 3 상점

            // 3, 7 몬스터
            
            // 6, 11 카드게임

            player.InsertPlayer(map.theMap);
            cursor.InitCursorPosition(player.pXPos, player.pYPos);


            while(true)
            {
                cursor.MoveCursor(0, 0);
                map.PrintMap();

                cursor.GetCursorPosition(map.mapSize);

                if (map.theMap[cursor.cYPos, cursor.cXPos] == "￦")
                {
                    cursor.InitCursorPosition(player.pXPos, player.pYPos);
                    Console.Clear();
                    cursor.MoveCursor(0, 0);

                    Random random = new Random();

                    while (true)
                    {
                        string userInput = default;
                        int inputNum = default;

                        Console.Clear();
                        Console.WriteLine("1. 상점");
                        Console.WriteLine("2. 가방");
                        Console.WriteLine("3. 귀가");
                        Console.WriteLine("=========================");

                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out inputNum);

                        if (inputNum == 1)
                        {
                            shop.ReadyItem();
                            while (true)
                            {
                                Console.Clear();
                                shop.PrintItems();
                                Console.WriteLine("4. 나간다");
                                Console.WriteLine("=========================");
                                Console.WriteLine("소지 골드 : {0}", player.pMoney);
                                userInput = Console.ReadLine();
                                int.TryParse(userInput, out inputNum);

                                if (inputNum == 1)
                                {
                                    if (player.pMoney < shop.ReturnItemPrice(inputNum))
                                    {
                                        Console.WriteLine("골드가 부족하다");
                                        Console.ReadLine();

                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}", shop.ReturnItemName(inputNum));
                                        Console.ReadLine();

                                        player.SetPlayerMoney(player.pMoney - shop.ReturnItemPrice(inputNum));
                                        inventory.AddItem(shop.BuyItem(inputNum));
                                    }
                                }
                                else if (inputNum == 2)
                                {
                                    if (player.pMoney < shop.ReturnItemPrice(inputNum))
                                    {
                                        Console.WriteLine("골드가 부족하다");
                                        Console.ReadLine();

                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}", shop.ReturnItemName(inputNum));
                                        Console.ReadLine();

                                        player.SetPlayerMoney(player.pMoney - shop.ReturnItemPrice(inputNum));
                                        inventory.AddItem(shop.BuyItem(inputNum));
                                    }
                                }
                                else if (inputNum == 3)
                                {
                                    if (player.pMoney < shop.ReturnItemPrice(inputNum))
                                    {
                                        Console.WriteLine("골드가 부족하다");
                                        Console.ReadLine();

                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0}", shop.ReturnItemName(inputNum));
                                        Console.ReadLine();

                                        player.SetPlayerMoney(player.pMoney - shop.ReturnItemPrice(inputNum));
                                        inventory.AddItem(shop.BuyItem(inputNum));
                                    }
                                }
                                else if (inputNum == 4)
                                {
                                    break;
                                }
                            }       // while()
                        }
                        else if (inputNum == 2)
                        {
                            inventory.OpenInventory();
                            Console.WriteLine("소지 골드 : {0}", player.pMoney);
                            Console.ReadLine();
                        }
                        else if (inputNum == 3)
                        {
                            break;
                        }
                    }       // while()

                    Console.Clear();
                    Console.WriteLine("본 점을 이용해 주셔서 감사합니다");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("당신은 상점을 나왔다");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (map.theMap[cursor.cYPos, cursor.cXPos] == "♠")
                {
                    cursor.InitCursorPosition(player.pXPos, player.pYPos);
                    Console.Clear();
                    cursor.MoveCursor(0, 0);
                    CardGame game = new CardGame();
                    game.RunCardGame(player.pMoney);
                    player.SetPlayerMoney(game.ReturnMoney());
                    continue;
                }
                else if (map.theMap[cursor.cYPos, cursor.cXPos] == "▣")
                {
                    cursor.InitCursorPosition(player.pXPos, player.pYPos);
                    Console.Clear();
                    cursor.MoveCursor(0, 0);
                    Battle battle = new Battle();
                    battle.InitStatus(player.healthPoint, player.atkPoint, player.pMoney);
                    battle.RunBattle();
                    player.SetPlayerMoney(battle.ReturnMoney());
                    continue;
                }

                player.MovePlayer(map.theMap, cursor.cXPos, cursor.cYPos);
            }


        }
    }
}
