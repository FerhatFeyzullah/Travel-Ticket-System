using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Travel_Ticket_System.Class
{
    public class Company : Login
    {
        public string companyName;
        //public string companyType;

        public string Username { get; set; }
        public string Password { get; set; }



        

        

        public Company(string companyIsim, string name, string pass)
        {
            companyName = companyIsim;
           // companyType = companyTip;
            Username = name;
            Password = pass;
        }


        public bool GirisYap(string username, string password)
        {
            return this.Username == username && this.Password == password;
        }

        public override string ToString()
        {

            return $"{companyName} (Turizm)";
        }

        public static List<Vehicle> Araclar = new List<Vehicle>();

        public void AracEkle(Vehicle arac)
        {
            Araclar.Add(arac);
        }



    }
}
