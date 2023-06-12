using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownGame
{
    public class GamePlay : SecretCode
    {
        public override void Init()
        {
            base.Init();
        }

        public void PlayGame()
        {
            char userInput = '0';
            char code = OutCode();

            const int SCORE = 10;
            int scoreNow = SCORE;

            while(scoreNow != 0)
            {
                Console.WriteLine("{0}점 ", scoreNow);

                userInput = Console.ReadLine()[0];

                if(userInput == code) 
                {
                    break;
                }
                else if (userInput > code)
                {
                    Console.WriteLine("더 앞쪽 알파벳입니다");
                    Console.WriteLine();
                    scoreNow--;
                }
                else if (userInput < code)
                {
                    Console.WriteLine("더 뒤쪽 알파벳입니다");
                    Console.WriteLine();
                    scoreNow--;
                }
            }

            if(scoreNow == 0)
            {
                Console.WriteLine("맞추지 못 했습니다");
            }
            else
            {
                Console.WriteLine("정답! {0}점 획득하셨습니다", scoreNow);
            }
        }
    }
}
