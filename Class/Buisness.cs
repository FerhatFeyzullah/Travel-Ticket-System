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
            Company C1 = new Company("YHT","Tren","YHT","YHT123");
            Company C2 = new Company("Metro", "Otobüs", "Metro", "Metro123");
            Company C3 = new Company("VIB","Otobüs", "VIB","VIB123");
            Company C4 = new Company("THY", "Uçak", "THY", "THY123");
            Firmalar.Add(C1);
            Firmalar.Add(C2);
            Firmalar.Add(C3);
            Firmalar.Add(C4);



        }


    }

    

}
