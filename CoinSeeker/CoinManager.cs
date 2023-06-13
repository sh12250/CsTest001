using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinSeeker
{
    public class CoinManager
    {
        private int _turnCount;


        public void CountCoin(string[,] map, int size, int userYPos, int userXPos)
        {
            if(_turnCount == 3)
            {
                _turnCount = 0;
                RotateCoin(map, size, userYPos, userXPos);
            }
            else
            {
                _turnCount++;
            }
        }

        public void RotateCoin(string[,] map, int size, int userYPos, int userXPos)
        {
            Random random = new Random();

            int y = random.Next(1, size - 2);
            int x = random.Next(1, size - 2);

            while (true)
            {
                if (y == userYPos && x == userXPos)
                {
                    y = random.Next(1, size - 2);
                    x = random.Next(1, size - 2);
                }
                else
                {
                    break;
                }
            }

            map[y, x] = "ⓒ";
        }
    }
}
