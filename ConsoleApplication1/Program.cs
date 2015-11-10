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
            Console.WriteLine("hello world");
            //test!!!
            Enumerable.Range(1, 199).ToList()
                .ForEach(x => Console.WriteLine("{0}", x));

            Console.ReadKey();

        }
    }
}
