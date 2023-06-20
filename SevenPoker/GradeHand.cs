using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenPoker
{
    public class GradeHand
    {
        public int handValue { get; private set; }
        public int[] tempNum { get; private set; }
        public int[] tempPatt { get; private set; }

        public void SetNumPatt(List<int> theHand) 
        {
            tempNum = new int[theHand.Count];
            tempPatt = new int[theHand.Count];


            for(int i = 0; i < theHand.Count(); i++)
            {
                tempNum[i] = theHand[i] % 13;  // 숫자
                tempPatt[i] = theHand[i] / 13; // 무늬
            }
        }

        public void GradeTheHand()
        {

        }




        public void TwoPair()
        {
            bool isEqual = false;

            int idx = 0;
            int idxNum = 0;

            int pair1Chk = 0;
            int pair2Chk = 0;

            for (int i = 1; i + 1 < tempNum.Length; i++)
            {
                if (tempNum[i] == tempNum[i + 1])
                {
                    isEqual = true;
                }

                if (isEqual)
                {
                    idx = i + 2;
                    if(idx >= tempNum.Length - 1)
                    {
                        idx = tempNum.Length - 2;
                    }

                    idxNum = tempNum[idx];

                    pair1Chk++;
                    isEqual = false;
                    break;
                }
            }

            for (int i = idx; i + 1 < tempNum.Length; i++)
            {
                if (tempNum[i] == tempNum[i + 1] && tempNum[i] != idxNum)
                {
                    isEqual = true;
                }

                if (isEqual)
                {
                    pair2Chk++;
                    break;
                }
            }

            if (pair1Chk == 1 && pair2Chk == 1)
            {
                Console.WriteLine("투페어");
            }
        }
        public void OnePair()
        {
            bool isEqual = false;
            int pairChk = 0;

            for(int i = 1; i < tempNum.Length; i++)
            {
                if (tempNum[i] == tempNum[i + 1])
                {
                    isEqual = true;
                }

                if(isEqual)
                {
                    pairChk++;
                    break;
                }
            }

            if(pairChk == 1)
            {
                Console.WriteLine("원페어");
            }


            /*
            int isEqual = 0;
            int numChk1 = 0;
            int numChk2 = 0;
            int checkedNum = 0;

            for(int i = 0; i < tempNum.Length; i++)
            {
                isEqual = 0;
                for (int j = 0; j < tempNum.Length; j++)
                {
                    if (tempNum[i] == tempNum[j] && tempNum[i] != checkedNum)
                    {
                        isEqual++;
                    }
                    else if (tempNum[i] == tempNum[j])
                    {
                        isEqual++;
                    }

                }

                if (isEqual != 0 && numChk1 != 1) // 0이 아닐때 점프
                {
                    if(numChk1 != 1)
                    {
                        numChk2 = isEqual;
                    }
                    else 
                    {
                        numChk1 = isEqual;
                        checkedNum = tempNum[i];
                        i += isEqual - 1;
                    }
                }
            }


            if(numChk1 == 4 && numChk2 == 0)
            {
                Console.WriteLine("포카드");
                handValue = 3;
            }
            else if(numChk1 == 3 && numChk2 == 2 || numChk1 == 2 && numChk2 == 3)
            {
                Console.WriteLine("풀 하우스");
                handValue = 4;
            }
            else if(numChk1 == 3 && numChk2 == 0)
            {
                Console.WriteLine("트리플");
                handValue = 7;
            }
            else if(numChk1 == 2 && numChk2 == 2)
            {
                Console.WriteLine("투페어");
                handValue = 8;
            }
            else if(numChk1 == 2 && numChk2 == 0)
            {
                Console.WriteLine("원페어");
                handValue = 9;
            }
            */
        }
    }
}
