using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpTrening.Models;

namespace CsharpTrening
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            race.Begin();

            Console.ReadKey();
        }
    }
}
