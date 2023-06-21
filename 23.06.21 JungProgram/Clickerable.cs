using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._21_JungProgram
{
    /// <summary>
    /// 무언가 클릭이 가능한 오브젝트를 만들고 싶을 때 사용할 클래스임
    /// </summary>
    abstract public class Clickable
    {
        bool isClickOk = false;

        public virtual void ClickThisObject(bool isClick)
        {
            isClickOk = isClick;

            Console.WriteLine("당신은 이 오브젝트를 클릭했습니다.");
        }
    }
}
