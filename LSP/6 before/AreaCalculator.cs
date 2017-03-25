using LSP._6_before;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class AreaCalculator
{
	    public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateArea(Square s)
        {
            return s.Height * s.Height;
        }
    
}
