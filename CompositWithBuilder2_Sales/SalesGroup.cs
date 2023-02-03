using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositWithBuilder2_Sales
{
    internal class SalesGroup : SalesUnit
    {
        public List<SalesUnit> Units { get; set; } = new List<SalesUnit>();
        public string NameGroup { get; internal set; }

        public SalesGroup(params SalesUnit[] units)
        {
            Units = units.ToList();
        }

        public override void PayCommission(int amount)
        {
            var eachShare = amount / Units.Count;
            foreach (var item in Units)
                item.PayCommission(eachShare);
        }
    }
}
