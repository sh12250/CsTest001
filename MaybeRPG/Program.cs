using PushRock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Cursor cursor = new Cursor();
            Player player = new Player();

            map.InitSize();
            map.MakeMap();

            // 6, 3 상점

            // 3, 7 몬스터
            
            // 6, 11 카드게임

            player.InsertPlayer(map.theMap);
            cursor.InitCursorPosition(player.pXPos, player.pYPos);

            map.PrintMap();

            while(true)
            {
                cursor.GetCursorPosition(map.mapSize);
                player.MovePlayer(map.theMap, cursor.cXPos, cursor.cYPos);

                cursor.MoveCursor(0, 0);
                map.PrintMap();
            }


        }
    }
}
