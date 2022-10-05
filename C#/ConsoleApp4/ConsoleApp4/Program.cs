using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using static System.Console;

namespace ConsoleGame

{

    internal class Player

    {

        public string m_name;

        public int m_hp;

        public Player(string name, int hp)

        {

            m_name = name;

            m_hp = hp;

        }

        public void adHp(int hp)

        {

            m_hp += hp;

        }

        public void subHp(int hp)

        {

            m_hp -= hp;

            if (m_hp <= 0)

            {

                WriteLine("You Died");

                WriteLine("Game Over");

                ReadKey();

                Environment.Exit(0);

            }

        }

        public override string ToString()

        {

            return m_name + ": " + m_hp;

        }

        public bool decision(string d1, string d2)

        {

            WriteLine(d1);

            WriteLine(d2);

            string Answer = ReadLine();

            if (Answer == d1)

                return true;

            return false;

        }

    }

}
un