﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP._2_after
{
    interface IProduct
    {
        decimal Price { get; set; }
        int Stock { get; set; }
        
    }
}
