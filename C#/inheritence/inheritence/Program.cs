using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            truck e= new truck();
            e.Stop();
            e.fill();
            e.drive();
            Console.ReadKey();  
        }
    }
}
