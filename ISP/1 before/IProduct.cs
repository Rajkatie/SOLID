using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP._1
{
    public interface IProduct
    {
         decimal Price { get; set; }
         int  Stock { get; set; }
         int RunningTime { get; set; }
         int Certificate { get; set; }

    }
}
