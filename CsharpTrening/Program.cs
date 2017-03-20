using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CsharpTrening.Models;

namespace CsharpTrening
{
    class Program
    {
        static void Main(string[] args)
        {
          
          Asynchronus asynchronus = new Asynchronus();
            asynchronus.Test().Wait();

            Console.ReadKey();
        }
    }
}
