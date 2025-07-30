using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static session04_oop.shape;

namespace session04_oop
{
    
    
        internal class Rectangle : Shape
        {
            public override double Perimeter
            {
                get
                {
                    return (Dim01 + Dim02) * 2;
                }
            }

            public override double GetArea()
            {
                return Dim02 * Dim01;
            }
        }

    
}
