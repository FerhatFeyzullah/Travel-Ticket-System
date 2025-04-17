using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Ticket_System.Class
{
     class LoginManager
    {
        public class Admin : Login
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public Admin(string name, string pass)
            {
                Username = name;
                Password = pass;
            }
            public bool GirisYap(string username, string password)
            {
                return this.Username == username && this.Password == password;
            }

        }


    }
}
