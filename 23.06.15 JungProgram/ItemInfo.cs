using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._15_JungProgram
{
    public class ItemInfo
    {
        private string _itemName;
        public int ItemCount { get; private set; } // 이게 property다
        private int _itemPrice;

        public int ItemPrice
        {   // property는 메서드에 가깝다
            get
            {
                return _itemPrice;
            }
            // built in (내장한) 기능이다, custom (사용자 정의) 기능이 아니다 
            private set
            {
                // value : 예약어, 오토로 생성되서 나온 변수다
                _itemPrice = value;
            }
        }

        public void InitItem(string name, int count, int price)
        {
            _itemName = name;
            ItemCount = count;
            _itemPrice = price;
        }

        // Getter 함수 : 외부에서 멤버 변수의 값을 사용할 수 있도록 해주는 함수
        public string Get_ItemName()
        {
            return _itemName;
        }
        // public int Get_ItemCount()
        // {
        //     return _itemCount;
        // }
        public int Get_ItemPrice()
        {
            return _itemPrice;
        }

        // Setter 함수 : 외부에서 멤버 변수의 값을 변경할 수 있게 해주는 함수
        public void Set_ItemName(string changedName)
        {
            _itemName = changedName;
        }
        public void Set_ItemCount(int changedCount)
        {
            ItemCount = changedCount;
        }
        public void Set_ItemPrice(int changedPrice)
        {
            _itemPrice = changedPrice;
        }
    }
}
