using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cursor cursor = new Cursor();

            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            cursor.Init(12, 2);

            while (true)
            {
                cursor.Input();
                cursor.MoveCursor();
                Console.WriteLine("a");
            }
        }
    }
}
