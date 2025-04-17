using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Ticket_System.Class
{
    public interface Login
    {
        string Username { get; set; }
        string Password { get; set; }

        bool GirisYap(string username, string password);

    }
}
