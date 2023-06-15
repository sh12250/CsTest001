using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushRock
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cursor cursor = new Cursor();
            Player player = new Player();
            Map map = new Map();

            int rockCount = 0;
            int score = 0;

            map.InitSize();

            map.MakeMap();
            player.InsertPlayer(map.TheMap, map.MapSize);

            cursor.MoveCursor(0, 0);
            map.PrintMap();
            Console.WriteLine("{0}점", score);

            cursor.InitCursorPosition(1, 1);
            cursor.MoveCursor();

            Rock rock1 = new Rock();
            Rock rock2 = new Rock();
            Rock rock3 = new Rock();

            while (true)
            {
                if(score == 10)
                {
                    score = 0;
                    break;
                }

                cursor.GetCursorPosition(map.MapSize - 1);

                if (map.TheMap[cursor.yPosition,cursor.xPosition] != "□")
                {
                    cursor.MoveCursor();
                    player.MovePlayer(map.TheMap, cursor.xPosition, cursor.yPosition);
                }
                else
                {
                    if(cursor.xPosition == rock1.RockXPos && cursor.yPosition == rock1.RockYPos)
                    {
                        rock1.SlideRock(map.TheMap, map.MapSize);
                    }
                    else if(cursor.xPosition == rock2.RockXPos && cursor.yPosition == rock2.RockYPos)
                    {
                        rock2.SlideRock(map.TheMap, map.MapSize);
                    }
                    else if(cursor.xPosition == rock3.RockXPos && cursor.yPosition == rock3.RockYPos)
                    {
                        rock3.SlideRock(map.TheMap, map.MapSize);
                    }

                    cursor.InitCursorPosition(player.PlayerXPos, player.PlayerYPos);
                }


                if (rockCount != 3)
                {
                    rock1.GetRockPosition(map.TheMap, map.MapSize);
                    rock1.PlaceRock(map.TheMap);

                    rock2.GetRockPosition(map.TheMap, map.MapSize);
                    rock2.PlaceRock(map.TheMap);

                    rock3.GetRockPosition(map.TheMap, map.MapSize);
                    rock3.PlaceRock(map.TheMap);

                    rockCount = 3;
                }

                if(rock1.IsTripleRock(map.TheMap))
                {
                    rock2.DeleteRock = rock1.IsTripleRock(map.TheMap);
                    rock3.DeleteRock = rock1.IsTripleRock(map.TheMap);
                    rock1.CrashRock(map.TheMap);
                    rock2.CrashRock(map.TheMap);
                    rock3.CrashRock(map.TheMap);
                    score++;
                }
                else if(rock2.IsTripleRock(map.TheMap))
                {
                    rock1.DeleteRock = rock2.IsTripleRock(map.TheMap);
                    rock3.DeleteRock = rock2.IsTripleRock(map.TheMap);
                    rock1.CrashRock(map.TheMap);
                    rock2.CrashRock(map.TheMap);
                    rock3.CrashRock(map.TheMap);
                    score++;
                }
                else if(rock3.IsTripleRock(map.TheMap))
                {
                    rock1.DeleteRock = rock3.IsTripleRock(map.TheMap);
                    rock2.DeleteRock = rock3.IsTripleRock(map.TheMap);
                    rock1.CrashRock(map.TheMap);
                    rock2.CrashRock(map.TheMap);
                    rock3.CrashRock(map.TheMap);
                    score++;
                }

                cursor.MoveCursor(0, 0);
                map.PrintMap();
                Console.WriteLine("{0}점", score);
            }
        }
    }
}
