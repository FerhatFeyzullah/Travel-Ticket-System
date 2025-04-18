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


        public List<Vehicle> Araclar = new List<Vehicle>();

        public Company(string companyIsim, string name, string pass)
        {
            companyName = companyIsim;
           
            Username = name;
            Password = pass;
        }
        public Company()
        {               

        }

        public bool GirisYap(string username, string password)
        {
            return this.Username == username && this.Password == password;
        }

        public override string ToString()
        {

            return $"{companyName} (Turizm)";
        }
       

        public void AracEkle(Vehicle arac)
        {
            Araclar.Add(arac);
        }


    }
}
