using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session04_oop
{
    internal class shape
    {

        // Abstract Class 
        internal abstract class Shape
        {
            public double Dim01 { get; set; }
            public double Dim02 { get; set; }

            // Abstract Method 
            public abstract double GetArea();

            // Abstract Property
            public abstract double Perimeter { get; }


            public void Print()
            {
                Console.WriteLine("I am Shape");
            }

        }







    }
}
