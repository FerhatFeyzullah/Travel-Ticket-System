using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Ticket_System.Class
{
    public class Sefer
    {
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public DateTime Tarih { get; set; }
        public Vehicle Arac { get; set; }
        public string FirmaIsmi { get; set; }

        public override string ToString()
        {
            return $"{Nereden} → {Nereye} - {Tarih.ToString("g")} - {Arac.Plaka}";
        }
    }
}
