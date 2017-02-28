using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
  public abstract class Car
    {
        public double Speed { get;protected set; } = 100;
        public double Acceleration { get; protected set; } = 10;

        public void Start()
        {
            Console.WriteLine("engine start");
            Console.WriteLine($"running at {Speed} km/h");
        }

        public void Stop()
        {
            Console.WriteLine("car stoped");
        }
        public virtual void  Accelerate()
        {
            Console.WriteLine($"Truck accelerate to {Speed + Acceleration}");
        }

        public virtual void Boost()
        {

        }

    }


     class Truck : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine($"Truck accelerate to {Speed + Acceleration}");
        }

        public override void Boost()
        {
            Console.WriteLine($"Boost truck to{Speed + 20}");
        }
    }

    class Sportcar : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine($"Sportcar accelerate to {Speed + Acceleration}");
        }
        public override void Boost()
        {
            Console.WriteLine($"Boost car to{Speed + 50}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("i am sportcar");
        }

    }

    public class Race
    {
        public void Begin()
        {
            Sportcar sportcar = new Sportcar();
            Truck truck = new Truck();

            List<Car> cars = new List<Car>()
            {
                sportcar, truck

            };

            foreach (Car car in cars)
            {
                car.Start();
                car.Accelerate();
                car.Boost();

            }


          
        }

       
        public void Casting()
        {
            Car sportcar = new Sportcar();
            Car truck = new Truck();

            // Sportcar realsportcar = (Sportcar)sportcar;

            /*
            bool isSportcar = sportcar is Sportcar;

            if(isSportcar)
            {
                Car newcar = (Car)sportcar; 
            }
            */

            /*
            Sportcar newcar = sportcar as Sportcar;
            if(newcar != null)
            {
                
            }
              */ 
            


        }

    }

}
