using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositWithBuilder2_Sales
{
    internal class SalesAgent : SalesUnit
    {
        private int _credit;
        public override void PayCommission(int amount)
        {
            _credit += amount;
        }
    }
}
