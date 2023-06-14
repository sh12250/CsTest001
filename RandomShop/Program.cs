using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Shop shop = new Shop();
            Inventory inventory = new Inventory();

            int money = 100000;

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

                if(inputNum == 1)
                {
                    shop.ReadyItem();
                    while (true)
                    {
                        Console.Clear();
                        shop.PrintItems();
                        Console.WriteLine("4. 나간다");
                        Console.WriteLine("=========================");
                        Console.WriteLine("소지 골드 : {0}", money);
                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out inputNum);

                        if (inputNum == 1)
                        {
                            if(money < shop.ReturnItemPrice(inputNum))
                            {
                                Console.WriteLine("골드가 부족하다");
                                Console.ReadLine();

                                continue;
                            }
                            else
                            {
                                Console.WriteLine("{0}", shop.ReturnItemName(inputNum));
                                Console.ReadLine();

                                money -= shop.ReturnItemPrice(inputNum);
                                inventory.AddItem(shop.BuyItem(inputNum));
                            }
                        }
                        else if (inputNum == 2)
                        {
                            if (money < shop.ReturnItemPrice(inputNum))
                            {
                                Console.WriteLine("골드가 부족하다");
                                Console.ReadLine();

                                continue;
                            }
                            else
                            {
                                Console.WriteLine("{0}", shop.ReturnItemName(inputNum));
                                Console.ReadLine();

                                money -= shop.ReturnItemPrice(inputNum);
                                inventory.AddItem(shop.BuyItem(inputNum));
                            }
                        }
                        else if (inputNum == 3)
                        {
                            if (money < shop.ReturnItemPrice(inputNum))
                            {
                                Console.WriteLine("골드가 부족하다");
                                Console.ReadLine();

                                continue;
                            }
                            else
                            {
                                Console.WriteLine("{0}", shop.ReturnItemName(inputNum));
                                Console.ReadLine();

                                money -= shop.ReturnItemPrice(inputNum);
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
                    Console.WriteLine("소지 골드 : {0}", money);
                    Console.ReadLine();
                }
                else if (inputNum == 3)
                {
                    break;
                }
            }       // while()

            Console.WriteLine("쇼핑을 마친 당신은 귀가했다");
        }
    }
}
