using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session04_oop
{
   
        public class Complex
        {
            public int Real { get; set; }        
            public int Imaginary { get; set; }   

            
            public Complex(int real, int imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

        public Complex Add(Complex other)
        {
            int newReal = this.Real + other.Real;
            int newImaginary = this.Imaginary + other.Imaginary;
            return new Complex(newReal, newImaginary);
        }


        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }


        public static Complex operator ++(Complex c)
        {
            return new Complex(c.Real + 1, c.Imaginary + 1);
        }

        public static Complex operator --(Complex c)
        {
            return new Complex(c.Real - 1, c.Imaginary - 1);
        }

    }
}
