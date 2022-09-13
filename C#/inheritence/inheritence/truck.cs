using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    internal class truck: vechile
    {
        public void Stop()
        {
            Console.WriteLine("truck stop");
        }
        public void fill()
        {
            Console.WriteLine("truck fill ");
        }
  
    }
}
