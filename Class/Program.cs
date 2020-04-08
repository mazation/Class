using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(1, 15, 0xB);
            Counter c2 = c++;
            Counter c3 = c--;
            Console.WriteLine(c.Value);
            Console.WriteLine(c2.Value);
            Console.WriteLine(c3.Value);
            Console.WriteLine(c3.currentState());
            Console.ReadLine();
        }
    }
}
