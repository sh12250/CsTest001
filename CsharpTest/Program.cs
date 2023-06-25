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
            RandomMap  myMap = new RandomMap();

            Console.SetWindowSize(66, 40);

            myMap.PrintTheMap();
        }
    }
}
