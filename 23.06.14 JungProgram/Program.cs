using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 이름이 같을 때 충돌이 나지 않도록 해줄 때 쓰면 된다
namespace _23._06._14_JungProgram 
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Print myPrint = new Print();
            // myPrint.PrintMessage("하하하하핳하하하핳하하하");
            // Print2.PrintMessage("하하하하하하하하");
            // Print.staticMessage = "값이 있나?";
            // Console.WriteLine(Print.staticMessage);
            /*
            // List
            List<int> numbers = new List<int>();
            Console.WriteLine("내 리스트의 크기 {0}", numbers.Count);

            for(int i = 0; i < 10; i++)
            {
                numbers.Add(i * i);
            }

            foreach(int n in numbers)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            Console.WriteLine("내 리스트의 크기 {0}", numbers.Count);
            
            for(int  i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0 && numbers[i] % 2 == 0)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (int n in numbers)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            Console.WriteLine("내 리스트의 크기 {0}", numbers.Count);
            // List
            */

            // 정렬해서 쓰지 않으려고 쓰는 자료구조, 비선형 자료구조
            Dictionary<string, int> myInventory = new Dictionary<string, int>();
            myInventory.Add("빨간 포션", 5);
            myInventory.Add("골드", 500);
            myInventory.Add("몰락한 왕의 검", 1);

            // foreach는 무조건 한바퀴돈다
            foreach(KeyValuePair<string, int> item in myInventory)
            {
                Console.WriteLine("아이템 이름 : {0}, 아이템 갯수 : {1}", item.Key, item.Value);
            }

            Console.WriteLine("아이템 갯수 : {0}", myInventory["빨간 포션"]);

            ItemInfo redPotion = new ItemInfo();
            ItemInfo gold = new ItemInfo();
            ItemInfo sword = new ItemInfo();

            redPotion.InitItem("빨간 포션", 5, 500);
            gold.InitItem("골드", 500, 1);
            sword.InitItem("몰락한 왕의 검", 1, 2800);


            Dictionary<string, ItemInfo> shop = new Dictionary<string, ItemInfo>();

            shop.Add("빨간 포션", redPotion);
            shop.Add("골드", gold);
            shop.Add("몰락한 왕의 검", sword);

            foreach (var item in shop)
            {
                Console.WriteLine("아이템 이름 : {0}, 아이템 수량 : {1}, 아이템 가격 : {2}", item.Value._name, item.Value._count, item.Value._price);
            }

            Stack<int> stackNumbers = new Stack<int>();
            stackNumbers.Push(1); // 맨위에 쌓는다
            stackNumbers.Pop();   // 위에서 빼낸다
        }
    }
}
