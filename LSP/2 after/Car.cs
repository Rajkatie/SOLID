using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._2_after
{
    public class Car
    {
        protected bool _isOn;


        public virtual void Start()
        {
            _isOn = true;
        }

        
  
    }
}
