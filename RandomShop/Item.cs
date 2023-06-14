using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomShop
{
    public class Item
    {
        private List<string> _itemNames;
        private List<int> _itemPrice;


        public Item()
        {
            _itemNames = new List<string>();
            _itemPrice = new List<int>();
            
            _itemNames.Add("발걸음 분쇄기");
            _itemPrice.Add(3300);
            _itemNames.Add("선혈포식자");
            _itemPrice.Add(3200);
            _itemNames.Add("신성한 파괴자");
            _itemPrice.Add(3300);
            _itemNames.Add("삼위일체");
            _itemPrice.Add(3333);
            _itemNames.Add("구인수의 격노검");
            _itemPrice.Add(3200);
            _itemNames.Add("돌풍");
            _itemPrice.Add(3400);
            _itemNames.Add("무한의 대검");
            _itemPrice.Add(3400);
            _itemNames.Add("나보리 신속검");
            _itemPrice.Add(3400);
            _itemNames.Add("요우무의 유령검");
            _itemPrice.Add(3100);
            _itemNames.Add("드락사르의 황혼검");
            _itemPrice.Add(3100);
            _itemNames.Add("월식");
            _itemPrice.Add(3100);
            _itemNames.Add("부서진 여왕의 왕관");
            _itemPrice.Add(2800);
            _itemNames.Add("만년서리");
            _itemPrice.Add(2800);
            _itemNames.Add("영겁의 지팡이");
            _itemPrice.Add(2800);
            _itemNames.Add("리안드리의 고뇌");
            _itemPrice.Add(3200);
            _itemNames.Add("루덴의 폭풍");
            _itemPrice.Add(3200);
            _itemNames.Add("밤의 수확자");
            _itemPrice.Add(3200);
            _itemNames.Add("마법공학 로켓 벨트");
            _itemPrice.Add(3200);
            _itemNames.Add("균열 생성기");
            _itemPrice.Add(3200);
            _itemNames.Add("광휘의 미덕");
            _itemPrice.Add(2700);
            _itemNames.Add("얼어붙은 건틀릿");
            _itemPrice.Add(3000);
            _itemNames.Add("해신 작쇼");
            _itemPrice.Add(3200);
            _itemNames.Add("강철심장");
            _itemPrice.Add(3200);
            _itemNames.Add("슈렐리아의 군가");
            _itemPrice.Add(2300);
            _itemNames.Add("월석 재생기");
            _itemPrice.Add(2300); 
            _itemNames.Add("헬리아의 메아리");
            _itemPrice.Add(2300);
            _itemNames.Add("저녁갑주");
            _itemPrice.Add(2300);
            _itemNames.Add("강철의 솔라리 펜던트");
            _itemPrice.Add(2300);
        }

        public int ReturnPrice(int idx)
        {
            return _itemPrice[idx];
        }

        public virtual string ReturnName(int idx)
        {
            return _itemNames[idx];
        }

        public int ReturnCount()
        {
            return _itemNames.Count();
        }
    }
}
