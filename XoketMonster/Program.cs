using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cursor cursor = new Cursor();
            Map map = new Map();
            Map mapTemp = new Map();
            NonPlayerCharacter npc = new NonPlayerCharacter();
            Player player = new Player();

            int questCount = 0;

            mapTemp.InitMap(map.theMap);

            Random rand = new Random();

            Console.SetWindowSize(62, 40);
            Console.CursorVisible = false;

            npc.SetNPCPosition(map.mapSize);

            while (map.theMap[npc.npcYPos, npc.npcXPos] != "　")
            {
                npc.SetNPCPosition(map.mapSize);
            }

            npc.InsertNPC(map.theMap);

            player.SetPlayerPosition(map.mapSize);

            while (map.theMap[player.pYPos, player.pXPos] != "　")
            {
                player.SetPlayerPosition(map.mapSize);
            }

            cursor.SetCursorPosition(player.pXPos, player.pYPos);
            player.InsertPlayer(map.theMap);

            while(true)
            {
                cursor.MoveCursor(0, 0);
                map.PrintMap();

                cursor.MoveCursor(5, 32);
                Console.WriteLine("이름 : {0}", player.name);
                cursor.MoveCursor(5, 33);
                Console.WriteLine("체력 : {0} / {1}", player.health, player.healthMax);
                cursor.MoveCursor(5, 34);
                Console.WriteLine("공격력 : {0}  방어력 : {1}", player.attack, player.defence);
                cursor.MoveCursor(5, 35);
                Console.WriteLine("경험치 : {0} / {1}", player.exp, player.expMax);

                if (player.questList.Count > 0)
                {
                    cursor.MoveCursor(35, 32);
                    Console.WriteLine("{0}", player.questList[0].name);
                    cursor.MoveCursor(35, 33);
                    Console.WriteLine("{0} / {1}", player.questList[0].currentValue, player.questList[0].targetValue);
                    cursor.MoveCursor(35, 34);
                    Console.WriteLine("보상 : 경험치 {0}", player.questList[0].rewardExp);
                }

                cursor.GetCursorPosition();

                if (map.theMap[cursor.cYPos, cursor.cXPos] == map.wall || map.theMap[cursor.cYPos, cursor.cXPos] == npc.character)
                {
                    if(map.theMap[cursor.cYPos, cursor.cXPos] == npc.character)
                    {
                        player.RecieveQuest();
                        questCount++;
                    }
                    cursor.SetCursorPosition(player.pXPos, player.pYPos);
                }
                else
                {
                    map.theMap[player.pYPos, player.pXPos] = mapTemp.theMap[player.pYPos, player.pXPos];
                    player.MovePlayer(map.theMap, cursor.cXPos, cursor.cYPos);
                }

                if(mapTemp.theMap[player.pYPos, player.pXPos] == mapTemp.grassField)
                {
                    int incountRate = rand.Next(0, 100);

                    if(incountRate < 36)
                    {
                        Monster monster = new Monster();
                        Battle battle = new Battle(player, monster);
                        battle.RunBattle();

                        if(player.questList.Count > 0)
                        {
                            player.questList[0].PerformQuest();
                        }
                    }
                }

                if (player.questList.Count > 0 && player.questList[0].currentValue == player.questList[0].targetValue)
                {
                    player.exp += player.questList[0].rewardExp;
                    player.questList.Remove(player.questList[0]);
                    questCount--;
                }

                if (player.exp > player.expMax)
                {
                    player.LevelUp();
                }
            }
        }
    }
}
