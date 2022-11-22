using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
     class Program
    {
        static string Method1(string alias = "Haramai", int age = 42 ) 
        {
            return (alias + age);
        }
        //static int add(int x, int y)
        //{
        //    return x + y;
        //}
        static double add(double x, int y) { return x + y; }
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the word which is to be tested for palindrome");
             string testword = Console.ReadLine();
             testword = testword.ToUpper();
             string reversedstr = string.Empty;
             for(int i=testword.Length-1;i>-1;i--)
             {
                 reversedstr += testword[i];  
             }
             Console.WriteLine((reversedstr == testword) ? "Word is Palindrome" : "Word is not Palindrome");*/


            Console.WriteLine(add(42, 42));
            Console.WriteLine(add(y:1, x:2.0));
            
            //Console.WriteLine(Method1("Byob", 45));
           // Console.WriteLine(Method1());
           // Method1("Drunia", 12);

            
            //for(i=)
            /*string fruit = "Apple";
            Console.WriteLine(fruit.IndexOf("e"));
            Console.WriteLine(fruit[3]);
            string sub = fruit.Substring(4);
            Console.WriteLine(fruit.Substring(2));
            Console.WriteLine(sub);
            int index = fruit.IndexOf("l");
            Console.WriteLine(index==3);
             //bool decider; */
            /*if (20==18)
                Console.WriteLine("Puka");
            else
                Console.WriteLine("Chut");
            Console.WriteLine(result);  
           // if(4 == 5) {Console.WriteLine(decider)};*/
        }
    }
}
