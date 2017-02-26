using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class User
    {
        public string Email { get; private set; }

        public string Password { get; private  set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get;private  set; }

        public bool IsActive { get;private  set; }

        public decimal Founds { get; private set; }

        public DateTime upDate { get; set; }

        public User()
        {

        }

        public User(string email, string password)
        {
            SetEmail(email);
            SetPassword(password);

        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorect");
            }
            if(email == Email)
            {
                return;
            }

            Email = email;
            Update();

        }
        public void SetAge(int age)
        {
            if(age<13)
            {
                throw new Exception(" age must be greater or equal 13");
            }
            if(age ==Age)
            {
                return;
            }

            Age = age;
            Update();

        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Email is incorect");
            }
            if (password == Password)
            {
                return;
            }

            Password = password;
            Update();

        }

        public void  Acticate(bool isActive)
        {
            if (IsActive)
                return;

            else IsActive = true;

        }

        public void Deactivate(bool isActive)
        {
            if (IsActive)
                IsActive = false;
            else
                return;

        }

        private void  Update()
        {
            upDate = DateTime.Now;
        }

        public void PurchaseOrder(Order order)
        {
            if (!IsActive)
                throw new Exception(" User is not activated");

            decimal orderPrice = order.TotalPrice;
            if(Founds - orderPrice < 0)
            {
                throw new Exception("you have not enought money");
            }

            order.Purchase();
            Founds -= orderPrice;
            Update();
        }

        public void IncraseFounds( Decimal founds)
        {
            if(founds<0)
            {
                throw new Exception("Founds must be greater than 0 .");

            }
            Founds += founds;
            Update();

        }
        

    }
}
