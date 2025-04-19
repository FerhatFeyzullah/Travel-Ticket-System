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

            //Firmalar//

            Company C1 = new Company("YHT", "YHT", "YHT123");
            Company C2 = new Company("Metro", "Metro", "Metro123");
            Company C3 = new Company("VIB", "VIB", "VIB123");
            Company C4 = new Company("THY", "THY", "THY123");
            Firmalar.Add(C1);
            Firmalar.Add(C2);
            Firmalar.Add(C3);
            Firmalar.Add(C4);

            //Araclar//

            C1.AracEkle(new Train { Plaka = "54TRN54 (Tren)" });
            C1.AracEkle(new Train { Plaka = "34TRN34 (Tren)" });
            C1.AracEkle(new Train { Plaka = "61TRN61 (Tren)" });

            C2.AracEkle(new Bus { Plaka = "54MTR54 (Otobüs)" });
            C2.AracEkle(new Bus { Plaka = "34MTR34 (Otobüs)" });
            C2.AracEkle(new Bus { Plaka = "61MTR61 (Otobüs)" });

            C3.AracEkle(new Bus { Plaka = "54VIB54 (Otobüs)" });
            C3.AracEkle(new Bus { Plaka = "34VIB34 (Otobüs)" });
            C3.AracEkle(new Bus { Plaka = "61VIB61 (Otobüs)" });

            C4.AracEkle(new Bus { Plaka = "TK2954 (Uçak)" });
            C4.AracEkle(new Bus { Plaka = "TK2934 (Uçak)" });
            C4.AracEkle(new Bus { Plaka = "TK2961 (Uçak)" });
            
            //Seferler//


            C1.SeferEkle("Sakarya", "Kocaeli", new DateTime(2025, 04, 20,12,30,00), C1.Araclar[0],"YHT");
            C1.SeferEkle("Kocaeli", "Sakarya", new DateTime(2025, 04, 20,15,00,00), C1.Araclar[1], "YHT");
            C1.SeferEkle("Sakarya", "Istanbul", new DateTime(2025, 04, 20,18,45,00), C1.Araclar[2], "YHT");

            C2.SeferEkle("Istanbul", "Kocaeli", new DateTime(2025, 04, 20, 12, 30, 00), C2.Araclar[0], "Metro");
            C2.SeferEkle("Ankara", "Sakarya", new DateTime(2025, 04, 20, 15, 00, 00), C2.Araclar[1], "Metro");
            C2.SeferEkle("Sakarya", "Istanbul", new DateTime(2025, 04, 20, 18, 45, 00), C2.Araclar[2], "Metro");

            C3.SeferEkle("Ankara", "Trabzon", new DateTime(2025, 04, 20, 12, 30, 00), C3.Araclar[0], "VIB");
            C3.SeferEkle("Istanbul", "Ankara", new DateTime(2025, 04, 20, 15, 00, 00), C3.Araclar[1], "VIB");
            C3.SeferEkle("Sakarya", "Trabzon", new DateTime(2025, 04, 20, 18, 45, 00), C3.Araclar[2], "VIB");

            C4.SeferEkle("Istanbul", "Trabzon", new DateTime(2025, 04, 20, 12, 30, 00), C4.Araclar[0], "THY");
            C4.SeferEkle("Trabzon", "Sakarya", new DateTime(2025, 04, 20, 15, 00, 00), C4.Araclar[1], "THY");
            C4.SeferEkle("Sakarya", "Ankara", new DateTime(2025, 04, 20, 18, 45, 00), C4.Araclar[2], "THY");







        }




    }

}
