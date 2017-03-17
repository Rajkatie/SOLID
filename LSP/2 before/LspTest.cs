using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._2_before
{

    public class LspTest
    {
        public static Rectangle getNewRectangle()
        {
            // it can be an object returned by some factory ... 
            return new Square();
        }

    }
}
