using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYOrderManagementSystem
{
    public class Cash : Payment
    {
        public ulong CashTendred { get; set; }
    }
}
