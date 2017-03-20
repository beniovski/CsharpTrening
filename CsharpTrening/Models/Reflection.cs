using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class Reflection
    {
        public void Test()
        {
            var user = new User("test", "test");
            var type = user.GetType();

            var method = type.GetMethods();
            
            foreach (var name in method)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"{type.Name}, {type.Namespace}, {type.FullName}");
            Console.WriteLine($"Is active : {user.IsActive}");

            var deactivateMethod = method.First(x => x.Name == "Deactivate");
            var SetEmailMethod = type.GetMethod("SetEmail");
            SetEmailMethod.Invoke(user, new[] {"nowyadres@gmail.com"});

            var email = type.GetProperty("Email").GetValue(user);
            Console.WriteLine($"email : {email}");

            Console.WriteLine($"email :{user.Email}");



            var user2 = Activator.CreateInstance(typeof(User), new[] {"user@email.com, secret"});
          //  Console.WriteLine($"{user2.E}");

        }

    }
}
