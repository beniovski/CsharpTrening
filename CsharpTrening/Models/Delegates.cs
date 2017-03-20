using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class Delegates
    {
        public delegate void write(string message);

        public delegate int Add(int x, int y);

        public delegate void alert(int change);

        public static void TooLowAlert(int change)
        {
            Console.WriteLine($"Temperatures is to low (change {change} C");
        }

        public static void OptimalAlert(int change)
        {
            Console.WriteLine($"Temperatures is optimal (change {change} C");
        }

        public static void TooHighAlert(int change)
        {
            Console.WriteLine($"Temperatures is to high (change {change} C");
        }

        public static void CheckTemperatures(alert toolow, alert optimal, alert toHigh)
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
                    toolow(change);
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

        public static int AddNumbers(int x, int y)
        {
            return x + y;
        }

        public void test()
        {
            Add adder = AddNumbers;

            var sum = adder(3, 4);

            Console.WriteLine(sum);


            write wrtier = writeMessage;
            wrtier("daniel");
            CheckTemperatures(TooLowAlert, OptimalAlert, TooHighAlert);
        }


        public static void writeMessage(string message)
        {
            Console.WriteLine($"hello {message}");

        }


    }

}
