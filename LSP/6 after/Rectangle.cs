using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP._6_after
{
   public class Rectangle: Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area()
        {
            return Height * Width;
        }

    }
}
