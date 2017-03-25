using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._2_after
{
    public class Program
    {
        static void Main(string[] args)
        {
            Corvette vette = new Corvette();
            vette.GetGas(35);

            var leaf = new NissanLeaf();
            leaf.ChargeBattery(ChargePercent.Fifty);



        }
    }
}

