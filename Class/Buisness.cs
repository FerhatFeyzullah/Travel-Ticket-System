using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Ticket_System.Class
{
    public static class Buisness // static yapalım ki her yerden erişebilesin
    {
        public static List<Company> Firmalar = new List<Company>();

        

        static Buisness()
        {
            Company C1 = new Company("Metro", "Otobus");
            Firmalar.Add(C1);
        }


    }

    

}
