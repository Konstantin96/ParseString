using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Please wait
            //   in progress |* * * * * * * * * * _ _ _ _ _ _|
            Console.WriteLine("Please wait");
            do
            {
                Console.Write("*");
                System.Threading.Thread.Sleep(100);

            } while (true);

        }
    }
}
