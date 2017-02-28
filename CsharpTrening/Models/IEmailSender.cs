using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    public interface IEmailSender
    {
         void SendMessage(string reciver, string title, string message);

         bool IsSend { get; set; }
    }
    
    public interface IDatabase
    {
        bool IsConected { get; }

        void Connect();

        User GetUser(string email);

        Order GetOrder(int id);

        void SaveChanges();

    }

    public interface IORderProcesor
    {
        void ProcesOrder(string Email, int orderId);
    }

    class EmailSender : IEmailSender
    {
    public  bool IsSend { get; set; }
    public void SendMessage(string reciver, string title, string message)
        {

        }       
              
    }

    class Database : IDatabase
    {
       public bool IsConected { get; }

       public void Connect()
        {

        }

        public Order GetOrder(string email)
        {
            
        }

        public User GetUser(int id)
        {

        }

        public  void SaveChanges()
        {

        }
    }


    class OrderProcessor : IORderProcesor
    {
        private readonly IDatabase _database;
        private readonly IEmailSender _emailsender;


        public OrderProcessor(IDatabase database, IEmailSender emailSender)
        {
            _database = database;
            _emailsender = emailSender;

        }
        public void ProcesOrder(string email, int orderId)
        {
            User user = _database.GetUser(email);
            Order order = _database.GetOrder(orderId);

            user.PurchaseOrder(order);
            _database.SaveChanges();
            _emailsender.SendMessage("tekst","test","test");
        }

        public class shop
        {
            public void CompleatOrder()
            {
                IDatabase database = new Database();

                IEmailSender emailsender = new EmailSender();
                         
                IORderProcesor orderProcesor = new OrderProcessor(database, emailsender);
            }


        }
    }

}
