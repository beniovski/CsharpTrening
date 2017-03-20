using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
   public class Order
    {
        public int Id { get; private  set; }

        public decimal Price { get; private set; }

        public decimal TaxRate { get; } = 0.23M;

        public decimal  TotalPrice { get { return (1 + TaxRate) * Price; } }

        public bool IsPurchase { get; private set; }
         

        public Order(int id, decimal price)
        {
            
            if(price <= 0)
            {
                throw new Exception(" price must be greater than 0;");
            }

            Id = id;
            Price = price;


        }
                 
        public void Purchase()
        {
            if(IsPurchase)
            {
                throw new Exception(" Order is already purchase.");
            }

        }        



    }
}
