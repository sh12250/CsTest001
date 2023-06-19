using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23._06._19_JungProgram
{
    public static class MyTools
    {
        //! List 안의 Element가 유효한지 검사한다

        public static bool IsValid<T>(this List<T> list_)
        {
            bool isValid = (list_ != null) && (0 < list_.Count);
            return isValid;
        }

        // 부모 클래스에 메서드를 붙여도 상속받지 못한다
        public static void OrcPrint(this Orc orc_)
        {
            orc_.PrintInfos();
        }

        public static int Plus(this int firstValue, int secondValue) 
        {
            return firstValue + secondValue;
        }
        public static int PlusAndPrint(this int firstValue, int secondValue) 
        {
            Console.WriteLine("{0} + {1} = {2}", firstValue, secondValue, firstValue + secondValue);

            return firstValue + secondValue;
        }
    }
}
