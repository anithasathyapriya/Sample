using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class program3
    { 
        public static void Main()
        {

            Console.WriteLine("Enterance ticket :$25");
            Console.WriteLine("please enter the number of tickets you want ");
            string input=Console.ReadLine();
            int numtix = Convert.ToInt32(input);
            Console.WriteLine("Total cost={0}",numtix*25 );


        }
    }
}
