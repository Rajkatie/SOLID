using LSP._1_before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    
    public class NissanLeaf:Car
    {
        public override void GetGas(decimal gallons)
        {
            // NissanLeaf does not use gas
            ChargeBattery(ChargePercent.OneThousand);
        }

        private void ChargeBattery(ChargePercent chargePercent)
        {
            //...
        }
        
    }
}
