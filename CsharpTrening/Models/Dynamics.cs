using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class Dynamics
    {
        public void Test()
        {
            dynamic user = new User("test", "test");

            dynamic anything = new ExpandoObject();
            anything.id = 3;
            anything.name = "nowy name";

            foreach (var property in anything)
            {
                Console.WriteLine($"{property.Key} {property.Value}");
                
            }
            
            

        }

    }
}
