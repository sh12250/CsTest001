using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");

            GamePlay gamePlay = new GamePlay();
            gamePlay.Init();
            gamePlay.PlayGame();
        }
    }
}
