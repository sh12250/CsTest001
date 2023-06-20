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
            Cursor cursor = new Cursor();
            List<Map> maps = new List<Map>();

            string userInput = "0";

            int totalMap = 0;

            userInput = Console.ReadLine();
            int.TryParse(userInput, out totalMap);

            for(int i = 0; i < totalMap; i++)
            {
                maps.Add(new Map());
            }

            cursor.MoveCursor(0, 0);
            maps[0].PrintMap();
        }
    }
}
