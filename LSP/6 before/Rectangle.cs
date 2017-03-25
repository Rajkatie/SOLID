using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP._6_before
{
   public class Rectangle
    {
        public virtual int Height { get; set; }

        public virtual int Width { get; set; }

        public Rectangle(int height,int width)
        {
            Height = height;
            Width = width;
        }

        public int Area()=> Height * Width;
        
    }
}
