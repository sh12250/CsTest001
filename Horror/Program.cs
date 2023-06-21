using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horror
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Cursor cursor = new Cursor();

            Console.CursorVisible = false;
            Console.SetWindowSize(62, 40);

            int turn = 0;
            int score = 0;
            int bestScore = score;


            while (true)
            {
                Map map = new Map();
                Player player = new Player();
                List<Enemy> enemies = new List<Enemy>();

                turn = 0;
                score = 0;

                int randX = random.Next(1, map.mapSize - 1);
                int randY = random.Next(1, map.mapSize - 1);

                while (map.theMap[randX, randY] != "　")
                {
                    randX = random.Next(1, map.mapSize - 1);
                    randY = random.Next(1, map.mapSize - 1);
                }

                cursor.SetCursorPosition(randX, randY);
                player.SetPlayerPosition(randY, randX);
                player.InsertPlayer(map.theMap);

                while (true)
                {
                    cursor.MoveCursor(0, 0);
                    map.PrintMap();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("현재 점수 : {0}", score);
                    Console.WriteLine("최고 점수 : {0}", bestScore);

                    if (map.theMap[player.pYPos - 1, player.pXPos] == "◆")
                    {
                        Task.Delay(1000).Wait();
                        Console.Clear();
                        cursor.MoveCursor(27, 15);
                        Console.WriteLine("YOU DIED");
                        cursor.MoveCursor(0, 32);
                        Console.ReadLine();
                        break;
                    }
                    else if (map.theMap[player.pYPos, player.pXPos - 1] == "◆")
                    {
                        Task.Delay(1000).Wait();
                        Console.Clear();
                        cursor.MoveCursor(27, 15);
                        Console.WriteLine("YOU DIED");
                        cursor.MoveCursor(0, 32);
                        Console.ReadLine();
                        break;
                    }
                    else if (map.theMap[player.pYPos + 1, player.pXPos] == "◆")
                    {
                        Task.Delay(1000).Wait();
                        Console.Clear();
                        cursor.MoveCursor(27, 15);
                        Console.WriteLine("YOU DIED");
                        cursor.MoveCursor(0, 32);
                        Console.ReadLine();
                        break;
                    }
                    else if (map.theMap[player.pYPos, player.pXPos + 1] == "◆")
                    {
                        Task.Delay(1000).Wait();
                        Console.Clear();
                        cursor.MoveCursor(27, 15);
                        Console.WriteLine("YOU DIED");
                        cursor.MoveCursor(0, 32);
                        Console.ReadLine();
                        break;
                    }

                    cursor.GetCursorPosition();
                    turn++;

                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].MoveEnemy(map.theMap, player.pXPos, player.pYPos);
                    }

                    if (map.theMap[cursor.cYPos, cursor.cXPos] == map.wall)
                    {
                        cursor.SetCursorPosition(player.pXPos, player.pYPos);
                    }
                    else
                    {
                        player.MovePlayer(map.theMap, cursor.cXPos, cursor.cYPos);
                        score++;
                        if(bestScore <= score)
                        {
                            bestScore = score;
                        }
                    }

                    if (turn % 10 == 0)
                    {
                        enemies.Add(new Enemy());

                        randX = random.Next(1, map.mapSize - 1);
                        randY = random.Next(1, map.mapSize - 1);

                        while (map.theMap[randX, randY] != "　")
                        {
                            randX = random.Next(1, map.mapSize - 1);
                            randY = random.Next(1, map.mapSize - 1);
                        }

                        enemies[enemies.Count - 1].SetEnemyPosition(randX, randY);
                        enemies[enemies.Count - 1].InsertEnemy(map.theMap);
                    }
                }
            }
        }
    }
}
