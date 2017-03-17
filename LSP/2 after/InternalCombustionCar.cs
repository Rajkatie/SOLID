using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._2_after
{
   public abstract class InternalCombustionCar
    {
       protected decimal _gas;

       public virtual void GetGas(decimal gallons)
       {
           _gas = _gas + gallons;
       }
  
    }
}
