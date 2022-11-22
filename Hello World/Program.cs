using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word which is to be tested for palindrome");
            string testWord = Console.ReadLine();

            if(!testWord.Contains('e'))
            {
                Console.WriteLine("Doesn't contain");
                return;
            }

            var output = testWord.Replace('e', 'z');
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
