using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using static System.Console;

namespace ConsoleGame

{

    internal class Program

    {

        static void Main(string[] args)

        {

            WriteLine(" spelling an answer wrong kills youv");
 

            WriteLine("Enter Your Name: ");

            string name = ReadLine();

            Player p = new Player(name, 100);

            WriteLine("\nHealth:");

            WriteLine(p);

            WriteLine("\nChoose gun ");

            if (p.decision("mp5", "1911") == true)

            {

                WriteLine("\nYou picked up the mp5");

            }

            else

            {

                WriteLine("\nYou picked up the 1911");

            }

            WriteLine("\nChoose Path");

            if (p.decision("straight Path", "under Path") == true)

            {

                WriteLine("\nYou chose the staright Path");

            }

            else

            {

                WriteLine("\nYou chose the under Path");

            }

            WriteLine("\nThere is a demon in front of you");

            WriteLine("\nAttack?");

            if (p.decision("Yes", "No") == true)

            {

                WriteLine("\nYou dont have what it takes");
 

                p.subHp(100);

            }

            else

            {

                WriteLine("\nrun");

                WriteLine("hide");

                WriteLine("Thanks for playing");

                ReadKey();

                Environment.Exit(0);

            }

            ReadKey();

        }

    }

}

