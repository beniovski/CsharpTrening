using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{

    public class Result<T>
    {
        public T Item { get; set; }

        public bool IsValid { get; set; }

        public string Error { get; set; }

    }
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
         
        public TSecond Second { get; set; }
        
    }

    public class Triple<TFirst, TSecond,TThird> : Pair <TFirst, TSecond>
    {
      
        public TThird Third { get; set; }
    }



    public class GenericOrderProcesor
    {
        public Result<Order> ProcesOrder(string email, int orderId)
        {
            Order order = new Order(1, 100);
            return new Result<Order>
            {
                Item = order
            };
        }

        public void LogOrder<T>(T order) where T : IOrder
        {

        }
    }



    class Generics
    {
        
        public void Test()
        {
            GenericOrderProcesor orderProcesor = new GenericOrderProcesor();
            Result<Order> result = orderProcesor.ProcesOrder("email", 1);

            Pair<int, string> pair = new Pair<int, string>();


            Triple<int, int, string> triple = new Triple<int, int, string>();

            Tuple<int, int, int> tuple;

            KeyValuePair<Order, User> orderUser;

            orderProcesor.LogOrder(new Order(1, 100));


        }



    }




}
