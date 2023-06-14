using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RandomShop
{
    public class Shop : Item
    {
        private Dictionary<string, int> _itemsInShop;
        private int _item1;
        private int _item2;
        private int _item3;


        public Shop()
        {
            _itemsInShop = new Dictionary<string, int>();

            for (int i = 0; i < ReturnCount(); i++)
            {
                _itemsInShop.Add(ReturnName(i), ReturnPrice(i));
            }
        }


        public string BuyItem(int item)
        {
            switch (item)
            {
                case 1:
                    return ReturnName(_item1);
                    case 2:
                    return ReturnName(_item2);
                    case 3:
                    return ReturnName(_item3);
                    default:
                    return "0";
            }
        }

        public void PrintItems()
        {
            Console.WriteLine("1. {0} : {1} 골드", ReturnName(_item1), _itemsInShop[ReturnName(_item1)]);
            Console.WriteLine("2. {0} : {1} 골드", ReturnName(_item2), _itemsInShop[ReturnName(_item2)]);
            Console.WriteLine("3. {0} : {1} 골드", ReturnName(_item3), _itemsInShop[ReturnName(_item3)]);
        }

        public void ReadyItem()
        {
            Random random = new Random();

            _item1 = random.Next(0, ReturnCount());
            _item2 = random.Next(0, ReturnCount());

            while(_item2 == _item1)
            {
                _item2 = random.Next(0, ReturnCount());
            }

            _item3 = random.Next(0, ReturnCount());

            while (_item3 == _item1 || _item3 == _item2)
            {
                _item3 = random.Next(0, ReturnCount());
            }
        }

        public override string ReturnName(int idx)
        {
            return base.ReturnName(idx);
        }
        public string ReturnItemName(int input)
        {
            switch (input)
            {
                case 1:
                    return ReturnName(_item1);
                case 2:
                    return ReturnName(_item2);
                case 3:
                    return ReturnName(_item3);
            }

            return "0";
        }
        public int ReturnItemPrice(int input)
        {
            switch (input)
            {
                case 1:
                    return _itemsInShop[ReturnName(_item1)];
                case 2: 
                    return _itemsInShop[ReturnName(_item2)];
                case 3:
                    return _itemsInShop[ReturnName(_item3)];
            }

            return 0;
        }
    }
}
