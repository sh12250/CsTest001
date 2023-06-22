using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoketMonster
{
    public class Battle
    {
        public Player playerState {  get; private set; }
        public Monster monsterState { get; private set; }


        public Battle(Player player, Monster monster)
        {
            playerState = player;
            monsterState = monster;
        }

        public void RunBattle()
        {
            int damage = 0;

            Console.Clear();

            Console.SetCursorPosition(15, 15);
            Console.WriteLine(monsterState.name + "가 나타났다!!!");


            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(15, 15);
                Console.WriteLine("{0}의 공격", playerState.name);
                Task.Delay(250).Wait();

                damage = playerState.attack - monsterState.defence;

                if (damage <= 0)
                {
                    damage = 0;
                }

                Console.SetCursorPosition(15, 16);
                Console.WriteLine("{0}는 {1}의 데미지를 받았다  ", monsterState.name, damage);
                Task.Delay(250).Wait();

                monsterState.health -= damage;

                if(monsterState.health <= 0)
                {
                    monsterState.health = 0;
                }

                Console.SetCursorPosition(15, 17);
                Console.WriteLine("{0}  {1} / {2}", monsterState.name, monsterState.health, monsterState.healthMax);
                Task.Delay(500).Wait();

                if (monsterState.health == 0)
                {
                    break;
                }

                Console.Clear();
                Console.SetCursorPosition(15, 15);
                Console.WriteLine("{0}의 공격  ", monsterState.name);
                Task.Delay(250).Wait();

                damage = monsterState.attack - playerState.defence;

                if (damage <= 0)
                {
                    damage = 0;
                }

                Console.SetCursorPosition(15, 16);
                Console.WriteLine("{0}은 {1}의 데미지를 받았다", playerState.name, damage);
                Task.Delay(250).Wait();

                playerState.health -= damage;

                if (playerState.health <= 0)
                {
                    playerState.health = 0;
                }

                Console.SetCursorPosition(15, 17);
                Console.WriteLine("{0}  {1} / {2}", playerState.name, playerState.health, playerState.healthMax);
                Task.Delay(500).Wait();

                if (playerState.health == 0)
                {
                    break;
                }
            }

            if (playerState.health == 0)
            {
                Console.SetCursorPosition(15, 19);
                Console.WriteLine("{0}는 쓰러졌다  ", playerState.name);
                Console.ReadLine();
            }
            else if (monsterState.health == 0)
            {
                Console.SetCursorPosition(15, 19);
                Console.WriteLine("{0}는 쓰러졌다  ", monsterState.name);
                Console.ReadLine();
                playerState.exp += monsterState.exp;
            }
        }
    }
}
