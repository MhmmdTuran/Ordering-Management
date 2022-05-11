using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYOrderManagementSystem
{
    public class Check : Payment
    {
        public string Name { get; set; }
        public string BankId { get; set; }

        public bool Authorized(string bankId)
        {
            if(bankId.Length == 6)
            {
                return true;
            }
            return false;
        }
    }
}
