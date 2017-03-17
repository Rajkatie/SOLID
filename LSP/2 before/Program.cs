using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP._2_before
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = LspTest.getNewRectangle(); // return square

            r.setWidth(5);
            r.setHeight(10);

            // user knows that r it's a rectangle. 

            // It assumes that he's able to set the width and height as for the base class

            r.getArea();
		// now he's surprised to see that the area is 100 instead of 50.
            
        }
    }
}
