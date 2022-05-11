using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYOrderManagementSystem
{
    public class Credit : Payment
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public DateTime expDate { get; set; }

        public bool Authorized(string month , string year)
        {
            bool autho = false;
            if(expDate.Year > Convert.ToInt32(year))
            {
                autho = true;
            }
            else if(expDate.Year == Convert.ToInt32(year))
            {
                if(expDate.Month > Convert.ToInt32(month))
                {
                    autho = true;
                }
            }
            else
            {
                autho = false;
            }
            return autho;
        }
    }
}
