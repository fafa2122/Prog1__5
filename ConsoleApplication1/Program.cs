using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random r = new Random();
             int g = 0;
             string code = "";
             for (int i = 0; i < 6; i++)
             {
                 if (r.Next(0, 3) == 0)
                 {
                     g = r.Next(0, 10);
                     code += g;
                 }
                 else
                 {
                 }
             }
             Console.WriteLine(code);*/
            /*string s = "abac";
            
            Console.WriteLine(s);
            //char[] ca = { 'a', 'b', 'a', 'c' };
            char c1 = 'a', c2 = 'x';
            string newS ="";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                    newS += c2;
                else newS += s[i]; 
            }
            
            Console.WriteLine(newS);*/
            /*string s = "A friend is need is a friend indeed";
            Console.WriteLine(s);
            Console.Write("Old?"); string s1 = Console.ReadLine();
            Console.Write("New?"); string s2 = Console.ReadLine();
            string newS = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s1[0] && i + s1.Length <= s.Length)
                {
                    int j = 0;
                    for (j = 0; j < s1.Length && s[i + j] == s1[j]; j++) ;
                    if (j == s1.Length)
                    {
                        newS += s2;
                        i += j - 1;
                    }
                    else
                        newS += s[i];
                }
                else newS += s[i];
            }*/
            string s = "a n y a";
            Console.WriteLine(s);
            char space = ' ';
            string newS = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == space)
                {
                    newS += "";
                }
                else
                    newS += s[i];
            }
            /*Console.WriteLine("s= *"+ s +"*");
            Console.WriteLine("Change "+ s1 + " to "+ s2 );
            Console.WriteLine("Result is=*" + newS+"*");*/
            Console.WriteLine(newS);
            Console.ReadKey();

        }
        static string cutLeftSpeces(string s)
        {
            if (s.Length == 0) return "";
        }
    }
}
