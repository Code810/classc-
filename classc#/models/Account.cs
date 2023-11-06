using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classc_.models
{
    internal class Account
    {
        public string UserName;
        public string Password;
       
            public Account(string username, string password)
        {
            UserName = username;
            Password = password;
           
        }
        public void Condition()
        {

            if (UserName == "Admin123" && Password == "12345a")
                Console.WriteLine("girisiniz tesdiqlendi");
            else
            {

                Console.WriteLine("duzgun daxil etmediniz");

            }
        }


    }
}
