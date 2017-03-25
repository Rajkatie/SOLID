using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP._6_after
{
   public class Square: Shape
    {
        public int Sides;
        public int Area()
        {
            return Sides * Sides;
        }
    }
}
