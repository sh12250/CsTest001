using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._06._21_JungProgram
{
    public class Program
    {
        static void Main(string[] args)
        {


        }
        #region 이론
        // 함수에는 타인이 읽을 수 있도록 설명을 추가할 수 있다
        // 1. attribute 기능
        [Obsolete("이 함수는 아무런 기능이 없는 테스트 함수입니다.")]
        static void MyFunc01()
        {
            Console.WriteLine();
        }

        // 2. summary 기능
        /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        /// </summary>
        /// <param name="str">이 변수는 문자열로 이루어진 설명를 받아서 저장하는 변수입니다.</param>
        static void MyFunc02(string str)
        {
            Console.WriteLine("함수 콜, 매개 변수 : {0}", str);
        }

        /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        /// </summary>
        /// <param name="str">이 변수는 문자열로 이루어진 설명를 받아서 저장하는 변수입니다.</param>
        /// <returns>함수가 정상 동작했을 때 true를 리턴합니다.</returns>
        static bool MyFunc03(string str)
        {
            Console.WriteLine("함수 콜, 매개 변수 : {0}", str);
            return true;
        }
        #endregion
    }
}
