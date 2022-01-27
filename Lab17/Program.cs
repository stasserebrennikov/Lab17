using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score<int> score1 = new Score<int>();
            score1.Input();
            Console.WriteLine(score1.GetInfo());

            Score<string> score2 = new Score<string>();
            score2.Input();
            Console.WriteLine(score2.GetInfo());
            Console.ReadKey();  
        }

    }
}
