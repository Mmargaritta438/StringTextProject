using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Show first interrogative and then exclamation sentences (Покажите сначала вопросительные, а затем восклицательные предложения)
 */

namespace ConsoleApp1
{
    class Interrogative
    {
        static void Main(string[] args)
        {
            string data;
            string tada;


            data = Console.ReadLine();

            Console.WriteLine("Hello" + "!!! " + data );

            tada = Console.ReadLine();

            Console.WriteLine("How are you" + "??? " + tada );
        }
    }
}
