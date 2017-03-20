using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class LampdaExpressions
    {
        public delegate void write(string message);

        public delegate int Add(int x, int y);

        public delegate void alert(int change);



        public void Test()
        {
            Action<int, string> logger = (temperatrura, wiadomosc) =>
            {
                Console.WriteLine($"Temperatur is at {temperatrura}. {wiadomosc}");

            };
            Action writer = () => Console.WriteLine("Writing.....");
            Action<string, int> advencedWriter = (messsage, number) => Console.WriteLine($"{messsage}, {number}"); 
            writer();

            Func<int, int, int> adder = (x, y) => x + y;

            CheckTemperatures(t=>logger(t, "too low"), t=>logger(t, "optimal"), t=>logger(t, " to high") );


            var sum = adder(3, 4);    
                
                advencedWriter("sum", sum);
        }



        public static void CheckTemperatures(Action<int> tooLow, Action<int> optimal, Action<int> toHigh)
        {
            var temperatures = 10;
            var random = new Random();

            while (true)
            {
                var change = random.Next(-5, 5);
                temperatures += change;
                Console.WriteLine($"Temperature is at : {temperatures} C.");


                if (temperatures <= 0)
                {
                    tooLow(change);
                }
                else if (temperatures > 0 && temperatures <= 10)
                {
                    optimal(change);
                }
                if (temperatures > 10)
                {
                    toHigh(change);
                }

                Thread.Sleep(500);

            }
        }

    }
}
