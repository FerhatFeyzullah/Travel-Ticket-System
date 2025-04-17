using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Ticket_System.Class
{
    public class Company
    {
        public string companyName;
        public string companyType;

        public Company(string companyIsim, string companyTip)
        {
            companyName = companyIsim;
            companyType = companyTip;
        }

        public override string ToString()
        {

            return $"{companyName} ({companyType})";
        }


    }
}
