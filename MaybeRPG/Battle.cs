using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MaybeRPG
{
    public class Battle
    {

        public int playerMaxHp {get; private set;}
        public int playerCurHp {get; private set;}
        public int playerAtk {get; private set;}
        public int playerMoney {get; private set;}


        public int mobMaxHp {get; private set;}
        public int mobCurHp {get; private set;}
        public int mobAtk { get; private set; }


        public void InitStatus(int hP, int atkP, int money)
        {
            playerMaxHp = hP;
            playerCurHp = playerMaxHp;
            playerAtk = atkP;
            playerMoney = money;
        }

        // 전투 출력
        public void RunBattle()
        {
            MonsterStat();
            // 정보 출력
            InfoPrint();

            while (true)
            {
                // 전투 진행
                BattlePrint();

                // 다음 턴 진행 전 정보 출력
                TurnWait();

                // 플레이어가 죽었을 경우
                if (playerCurHp == 0)
                {
                    Console.Clear();
                    Console.WriteLine("당신은 졌습니다...");
                    Console.WriteLine("100골드를 잃어버렸습니다...");
                    Console.ReadLine();
                    playerMoney -= 100;
                    break;
                }
                // 몬스터가 죽었을 경우
                if (mobCurHp == 0)
                {
                    Console.Clear();
                    Console.WriteLine("당신은 승리했습니다!!!");
                    Console.WriteLine("100골드를 얻었습니다");
                    Console.ReadLine();
                    playerMoney += 100;
                    break;
                }
            }
        }

        // 몬스터 스탯 생성
        public void MonsterStat()
        {
            int mobStat = (RandomPercent() % 16 + 15);
            mobMaxHp = mobStat;
            mobCurHp = mobMaxHp;
            mobStat = (RandomPercent() % 6 + 5);
            mobAtk = mobStat;
        }

        // 다음 턴 진행 전 출력
        public void TurnWait()
        {
            Console.SetCursorPosition(0, 0);
            Graphics();
            Console.WriteLine("늑대 ( {0} / {1} ) ", mobCurHp, mobMaxHp);
            Console.WriteLine("============================================================");

            if (mobCurHp <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("늑대를 퇴치했다");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("============================================================");
            Console.WriteLine("나 ( {0} / {1} )", playerCurHp, playerMaxHp);
            
            if(mobCurHp <= 0)
            {
                Task.Delay(1000).Wait();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Task.Delay(1000).Wait();
                Console.WriteLine();
                Console.WriteLine("다음 턴을 진행... ");
                Console.ReadLine();
                Console.Clear();

            }
        }

        // 전투 출력
        public int BattlePrint()
        {
            Console.SetCursorPosition(0, 0);
            Graphics();
            Console.WriteLine("늑대 ( {0} / {1} ) ", mobCurHp, mobMaxHp);
            Console.WriteLine("============================================================");

            Console.WriteLine();
            Console.WriteLine();
            PlayerAtk();

            Console.WriteLine("============================================================");
            Console.WriteLine("나 ( {0} / {1} )", playerCurHp, playerMaxHp);

            if (mobCurHp <= 0)
            {
                mobCurHp = 0;
                return 0;
            }

            Task.Delay(1500).Wait();
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Graphics();
            Console.WriteLine("늑대 ( {0} / {1} ) ", mobCurHp, mobMaxHp);
            Console.WriteLine("============================================================");
            Console.WriteLine("늑대의 공격! {0}의 데미지를 입었다", mobAtk);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("============================================================");
            Console.WriteLine("나 ( {0} / {1} )", playerCurHp, playerMaxHp);
            playerCurHp -= mobAtk;

            if (playerCurHp <= 0)
            {
                playerCurHp = 0;
                return 0;
            }

            Task.Delay(1500).Wait();
            Console.Clear();
            return 0;
        }

        // 싸우기 전 정보 출력
        public void InfoPrint()
        {
            Graphics();
            Console.WriteLine("늑대 ( {0} / {1} ) ", mobCurHp, mobMaxHp);
            Console.WriteLine("============================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("============================================================");
            Console.WriteLine("나 ( {0} / {1} )", playerCurHp, playerMaxHp);

            Console.ReadLine();
            Console.Clear();
        }


        // 플레이어의 공격
        public void PlayerAtk()
        {
            const int CRIRATE = 30;
            const int CRIATKRATE = 2;
            int isCri = RandomPercent();
            int damage = playerAtk;

            if (isCri > 100 - CRIRATE)
            {
                damage *= CRIATKRATE;
                Console.WriteLine("치명타★ {0}의 데미지를 입혔다", damage);

                mobCurHp -= damage;

                if (mobCurHp < 0)
                {
                    mobCurHp = 0;
                }
            }
            else
            {
                Console.WriteLine("공격☆ {0}의 데미지를 입혔다", damage);

                mobCurHp -= damage;

                if (mobCurHp < 0)
                {
                    mobCurHp = 0;
                }
            }
        }


        // 그래픽 출력
        public void Graphics()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("                             . . .,~~::.                    ");
            Console.WriteLine("                        . .~~~.,;*;;!*:#.                   ");
            Console.WriteLine("                     . -.*----~:;$=!!!!$-.                  ");
            Console.WriteLine("                      .,-----~~:*,**!!!:~*:                 ");
            Console.WriteLine("                     ..------~:!#;;!*!!*: ,.                ");
            Console.WriteLine("                    ..---.--- ;!! *#:~:~ =; .               ");
            Console.WriteLine("                   ..--#---~-::!;  :!=!::~-. .              ");
            Console.WriteLine("                  . =:$#~:::,.!!!:!!**!!. , .               ");
            Console.WriteLine("                 . .~:-:::::~::!;$*,!!-!=~,.                ");
            Console.WriteLine("                  . !:-~::::~:=;==-~-;.,$!~ .               ");
            Console.WriteLine("                 . -:::**:::~:;-::~ *; -!*;.                ");
            Console.WriteLine("                  .@:::;::::::*-  ~;!~*~ ;~-.               ");
            Console.WriteLine("                 .-!:::$!::::~=..  ~!!.   :! .              ");
            Console.WriteLine("                  $*:::$;::::,;;.., ,.   .!,                ");
            Console.WriteLine("               . ;*=;::=;;:::~:$, ,~@=-..-:.                ");
            Console.WriteLine("                .:**#::$~,::::::@-.;--..~$.                 ");
            Console.WriteLine("               . $**#:::.. $:::::: ...:!,.                  ");
            Console.WriteLine("              . .#!*=:::-..~~!!:,=~ ..:$- .                 ");
            Console.WriteLine("               . =:*#*:, ~$ ,:!!;!:=.:@.                    ");
            Console.WriteLine("              . !=*!~ :, ,,:!.:;:;;;:$.                     ");
            Console.WriteLine("               .~#$* .*. ;, .....,;,;~ .                    ");
            Console.WriteLine("              . ~@@~. ,..,, .:..  ,,, .                     ");
            Console.WriteLine("                ~!.   ; -,~    :. :,,                       ");
            Console.WriteLine("                      , .,:     - ~,;                       ");
            Console.WriteLine("                      , !.      *. -                        ");
            Console.WriteLine("                    . ~ *..     ;. $.                       ");
            Console.WriteLine("                     . ..,     .-. , .                      ");
            Console.WriteLine("                    . .- -!     .. ~.                       ");
            Console.WriteLine("                     . , !;#     :   .                      ");
            Console.WriteLine("                      .  :,,=    ,  ~ .                     ");
            Console.WriteLine("                       .  -*,.   !:; .                      ");
            Console.WriteLine("                        -,~:     !~.~=                      ");
            Console.WriteLine("                         ,        ;-::                      ");
            Console.WriteLine("============================================================");
        }

        // 1 ~ 100까지의 난수 반환
        public int RandomPercent()
        {
            Random random = new Random();

            return (random.Next(1, 100));
        }

        public int ReturnMoney()
        {
            return playerMoney;
        }
    }
}
