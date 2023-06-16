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
            List<int> rockPositions = new List<int>();
            Cursor cursor = new Cursor();
            Player player = new Player();
            Map map = new Map();

            int rockCount = 0;
            int rockContact = 0;
            int score = 0;            
            string rockImage = "□";

            map.InitSize();

            map.MakeMap();
            player.InsertPlayer(map.TheMap, map.MapSize);

            cursor.MoveCursor(0, 0);
            map.PrintMap();
            Console.WriteLine("{0}점", score);

            cursor.InitCursorPosition(1, 1);
            cursor.MoveCursor();

            while (true)
            {
                if(score == 10)
                {
                    score = 0;
                    break;
                }

                cursor.GetCursorPosition(map.MapSize - 1);

                if(cursor.LastInput == 'r' && rockCount != 0)
                {
                    map.MakeMap();
                    player.InsertPlayer(map.TheMap, map.MapSize);

                    map.TheMap[rockPositions[0], rockPositions[1]] = rockImage;
                    map.TheMap[rockPositions[2], rockPositions[3]] = rockImage;
                    map.TheMap[rockPositions[4], rockPositions[5]] = rockImage;
                }

                if (map.TheMap[cursor.yPosition,cursor.xPosition] != rockImage)
                {
                    cursor.MoveCursor();
                    player.MovePlayer(map.TheMap, cursor.xPosition, cursor.yPosition);
                }
                else if(map.TheMap[cursor.yPosition, cursor.xPosition] == rockImage)
                {
                    if(cursor.LastInput == 'w')
                    {
                        for (int y = cursor.yPosition - 1; y > 0; y--)
                        {
                            if(map.TheMap[y, cursor.xPosition] == rockImage || map.TheMap[y, cursor.xPosition] == "■")
                            {
                                break;
                            }

                            map.TheMap[y + 1, cursor.xPosition] = "　";
                            map.TheMap[y, cursor.xPosition] = rockImage;
                            cursor.MoveCursor(0, 0);
                            map.PrintMap();
                            Task.Delay(50).Wait();
                        }
                    }
                    else if(cursor.LastInput == 'a')
                    {
                        for (int x = cursor.xPosition - 1; x > 0; x--)
                        {
                            if (map.TheMap[cursor.yPosition, x] == rockImage || map.TheMap[cursor.yPosition, x] == "■")
                            {
                                break;
                            }

                            map.TheMap[cursor.yPosition, x + 1] = "　";
                            map.TheMap[cursor.yPosition, x] = rockImage;
                            cursor.MoveCursor(0, 0);
                            map.PrintMap();
                            Task.Delay(50).Wait();
                        }
                    }
                    else if (cursor.LastInput == 's')
                    {
                        for (int y = cursor.yPosition + 1; y < map.MapSize - 1; y++)
                        {
                            if (map.TheMap[y, cursor.xPosition] == rockImage || map.TheMap[y, cursor.xPosition] == "■")
                            {
                                break;
                            }

                            map.TheMap[y - 1, cursor.xPosition] = "　";
                            map.TheMap[y, cursor.xPosition] = rockImage;
                            cursor.MoveCursor(0, 0);
                            map.PrintMap();
                            Task.Delay(50).Wait();
                        }
                    }
                    else if (cursor.LastInput == 'd')
                    {
                        for (int x = cursor.xPosition + 1; x < map.MapSize - 1; x++)
                        {
                            if (map.TheMap[cursor.yPosition, x] == rockImage || map.TheMap[cursor.yPosition, x] == "■")
                            {
                                break;
                            }

                            map.TheMap[cursor.yPosition, x - 1] = "　";
                            map.TheMap[cursor.yPosition, x] = rockImage;
                            cursor.MoveCursor(0, 0);
                            map.PrintMap();
                            Task.Delay(50).Wait();
                        }
                    }

                    cursor.InitCursorPosition(player.PlayerXPos, player.PlayerYPos);
                }

                if(rockCount == 0)
                {
                    Random random = new Random();
                    int randIdxY;
                    int randIdxX;

                    for (int i = 0;  i < 3; i++)
                    {
                        randIdxY = random.Next(2, map.MapSize - 2);
                        randIdxX = random.Next(2, map.MapSize - 2);

                        while(map.TheMap[randIdxY, randIdxX] == rockImage || map.TheMap[randIdxY, randIdxX] == player.Character)
                        {
                            randIdxY = random.Next(2, map.MapSize - 2);
                            randIdxX = random.Next(2, map.MapSize - 2);
                        }

                        map.TheMap[randIdxY, randIdxX] = rockImage;

                        rockPositions.Add(randIdxY);
                        rockPositions.Add(randIdxX);
                    }

                    rockCount = 3;
                    rockContact = 0;
                }

                for(int y = 1; y < map.MapSize - 1; y++)
                {
                    for(int x = 1; x < map.MapSize - 1; x++)
                    {
                        if (map.TheMap[y, x] == rockImage)
                        {
                            if (map.TheMap[y - 1, x] == rockImage)
                            {
                                rockContact++;
                            }
                            if (map.TheMap[y, x - 1] == rockImage)
                            {
                                rockContact++;
                            }
                            if (map.TheMap[y + 1, x] == rockImage)
                            {
                                rockContact++;
                            }
                            if (map.TheMap[y, x + 1] == rockImage)
                            {
                                rockContact++;
                            }

                            if(rockContact == 2)
                            {
                                break;
                            }
                            else
                            {
                                rockContact = 0;
                            }
                        }
                    }

                    if (rockContact == 2)
                    {
                        break;
                    }
                }

                if (rockContact == 2)
                {
                    for (int y = 1; y < map.MapSize - 1; y++)
                    {
                        for (int x = 1; x < map.MapSize - 1; x++)
                        {
                            if (rockCount == 0)
                            {
                                break;
                            }
                            if (map.TheMap[y, x] == rockImage)
                            {
                                map.TheMap[y, x] = "　";
                                rockCount--;
                            }
                        }
                        if (rockCount == 0)
                        {
                            rockPositions.RemoveRange(0, 6);
                            score++;
                            break;
                        }
                    }
                }

                cursor.MoveCursor(0, 0);
                map.PrintMap();
                Console.WriteLine("{0}점", score);
            }
        }
    }
}
