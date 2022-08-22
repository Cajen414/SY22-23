using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            ShowQuestion("What is 1+2?", " a)1", " b)3", " c) 0", " d) 6", "b");
            ShowQuestion("What is 4+1?", " a)1", " b)5", " c) 0", " d) 6", "b");
            ShowQuestion("What is 3+1?", " a)1", " b)4", " c) 0", " d) 6", "b");
            Console.ReadKey();

            ;
        }
        public static void ShowQuestion(string question,
                                        string answer1,
                                        string answer2,
                                        string answer3,
                                        string answer4,
                                        string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
                Console.WriteLine("You Got it Correct");
        }
    }
}