using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This buid should fail");

            int i = 1;

            Console.WriteLine(i);

            if (i == 1)
            {
                Console.WriteLine("YAY");
            }
        }
    }
}
