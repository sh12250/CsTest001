using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Cursor cursor = new Cursor();
            List<Map> maps = new List<Map>();
            List<Portal> portals = new List<Portal>();

            Random rand = new Random();

            string userInput = "0";

            int totalMap = 0;
            int currMap = 0;

            userInput = Console.ReadLine();
            int.TryParse(userInput, out totalMap);

            for(int i = 0; i < totalMap; i++)
            {
                maps.Add(new Map(rand.Next(9, 15)));
                portals.Add(new Portal());
            }

            for (int i = 0; i < totalMap; i++)
            {
                portals[i].SetPortalPosition(maps[i].theMap, maps[i].mapSize);
                portals[i].InsertPortal(maps[i].theMap);
            }


            player.SetPlayerPosition(maps[currMap].mapSize);
            cursor.SetCursorPosition(player.pXPos, player.pYPos);
            player.InsertPlayer(maps[currMap].theMap);

            while (true)
            {
                char direction = '0';

                cursor.MoveCursor(0, 0);
                for(int i = 0; i < 20; i++)
                {
                    Console.WriteLine("　　　　　　　　　　　　　　　　　　　　");
                }
                cursor.MoveCursor(0, 0);
                maps[currMap].PrintMap();

                cursor.GetCursorPosition(maps[0].mapSize);
                direction = cursor.lastInput;
                if (maps[currMap].theMap[cursor.cYPos, cursor.cXPos] == "♨")
                {
                    player.RemovePlayer(maps[currMap].theMap);

                    currMap++;
                    if(currMap >= totalMap)
                    {
                        currMap = 0;
                    }

                    switch (direction)
                    {
                        case 'w':
                            cursor.SetCursorPosition(portals[currMap].portalXPos, portals[currMap].portalYPos - 1);
                            break;
                        case 'a':
                            cursor.SetCursorPosition(portals[currMap].portalXPos - 1, portals[currMap].portalYPos);
                            break;
                        case 's':
                            cursor.SetCursorPosition(portals[currMap].portalXPos, portals[currMap].portalYPos + 1);
                            break;
                        case 'd':
                            cursor.SetCursorPosition(portals[currMap].portalXPos + 1, portals[currMap].portalYPos);
                            break;
                    }
                    player.SetPlayerPosition(cursor.cYPos, cursor.cXPos);
                    player.InsertPlayer(maps[currMap].theMap);
                }
                else if (maps[currMap].theMap[cursor.cYPos, cursor.cXPos] == "■")
                {
                    cursor.SetCursorPosition(player.pXPos, player.pYPos);
                }
                else
                {
                    player.MovePlayer(maps[currMap].theMap, cursor.cXPos, cursor.cYPos);
                }
            }
        }
    }
}
