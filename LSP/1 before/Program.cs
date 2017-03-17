using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vette = new Corvette();
            vette.GetGas(35);

            var leaf = new NissanLeaf();
            leaf.GetGas(0);



        }
    }
}
