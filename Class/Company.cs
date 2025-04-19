using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Travel_Ticket_System.Class
{
    public class Company : Login
    {
        public string companyName;

        public string Username { get; set; }
        public string Password { get; set; }
  

        public Company(string companyIsim, string name, string pass)
        {
            companyName = companyIsim;
           
            Username = name;
            Password = pass;
        }

        public bool GirisYap(string username, string password)
        {
            return this.Username == username && this.Password == password;
        }

        public List<Vehicle> Araclar = new List<Vehicle>();
        public void AracEkle(Vehicle arac)
        {
            Araclar.Add(arac);
        }
        public Company()
        {               

        }      

        public override string ToString()
        {

            return $"{companyName} (Turizm)";
        }

        public List<Sefer> Seferler = new List<Sefer>();

        public void SeferEkle(string nereden, string nereye, DateTime tarih, Vehicle arac,string firmaIsmi)
        {
            Sefer yeniSefer = new Sefer
            {
                Nereden = nereden,
                Nereye = nereye,
                Tarih = tarih,
                Arac = arac,
                FirmaIsmi = firmaIsmi
                
            };
            Seferler.Add(yeniSefer);
        }




    }
}
