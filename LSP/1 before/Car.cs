using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Car
    {
        protected decimal _gas;
        protected bool _isOn;

        public virtual void Start()
        {
            _isOn = true;
        }

        public virtual void GetGas(decimal gallons)
        {
            _gas = _gas + gallons;
        }
  
          
    }
}
