using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class Inventory : Item
    {
        Dictionary<string, int> _itemsInInven;

        public Inventory()
        {
            _itemsInInven = new Dictionary<string, int>();

            for (int i = 0; i < ReturnCount(); i++)
            {
                _itemsInInven.Add(ReturnName(i), 0);
            }
        }

        public void OpenInventory()
        {
            int maxCount = ReturnCount();
            int count = default;

            Console.WriteLine("내 인벤토리");
            foreach(KeyValuePair<string, int> item in _itemsInInven)
            {

                if(item.Value > 0)
                {
                    Console.WriteLine("이름 : {0}", item.Key);
                    Console.WriteLine("소지 수 : {0}", item.Value);
                }
                else 
                {
                    count++;
                }
            }

            if(count == maxCount)
            {
                Console.WriteLine("가진게 없다");
            }
        }

        public void AddItem(string key)
        {
            _itemsInInven[key]++;
        }
    }
}
