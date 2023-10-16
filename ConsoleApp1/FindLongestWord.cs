using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FindLongestWord
    {
        // программа для поиска самого большого слова в строке
        // program to find largest word from string
        static void FindLargets()
        {
            string text, maxword = "", stringList = "";
            int n = 0, max = 0;
            
            Console.WriteLine("Enter String");
            text = Console.ReadLine();
            
            foreach (char c in text)
            {
                if (c==' ')
                {
                    if (n < max)
                    {
                        n = max;
                        max = 0;
                        maxword = stringList;
                        stringList = "";
                    }
                    else
                    {
                        max = 0;
                        stringList = "";
                    }
                }
                else
                {
                    stringList = stringList + c.ToString();
                    max++;
                }
            }
            
            Console.WriteLine("Longest word in {0} is string is {1} ", text, maxword);
        }
        
        public static void Main(String[] arg)
        {
            FindLargets();
            System.Console.ReadLine();
        }
    }
}
