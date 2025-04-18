using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Ticket_System.Class
{
    public class Business // static yapalım ki her yerden erişebilesin
    {
        public List<Company> Firmalar = new List<Company>();

        public Business()
        {
            Company C1 = new Company("YHT", "YHT", "YHT123");
            Company C2 = new Company("Metro", "Metro", "Metro123");
            Company C3 = new Company("VIB", "VIB", "VIB123");
            Company C4 = new Company("THY", "THY", "THY123");
            Firmalar.Add(C1);
            Firmalar.Add(C2);
            Firmalar.Add(C3);
            Firmalar.Add(C4);

            C1.AracEkle(new Train { Plaka = "54TRN54" });
            C1.AracEkle(new Train { Plaka = "34TRN34" });
            C1.AracEkle(new Train { Plaka = "61TRN61" });

            C2.AracEkle(new Bus { Plaka = "54MTR54" });
            C2.AracEkle(new Bus { Plaka = "34MTR34" });
            C2.AracEkle(new Bus { Plaka = "61MTR61" });

            C3.AracEkle(new Bus { Plaka = "54VIB54" });
            C3.AracEkle(new Bus { Plaka = "34VIB34" });
            C3.AracEkle(new Bus { Plaka = "61VIB61" });

            C4.AracEkle(new Bus { Plaka = "TK2954" });
            C4.AracEkle(new Bus { Plaka = "TK2934" });
            C4.AracEkle(new Bus { Plaka = "TK2961" });





        }




    }

}
