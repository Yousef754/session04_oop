using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session04_oop
{
    internal class Arithmetic
    {
        public int firstnum {  get; set; }
        public int secondnum { get; set; }


        public static int sum(int a, int b) { 
        
        return a + b;
        }
        public static int Subtract(int a, int b)
        {

            return a - b;
        }


        public static int Multiply(int a, int b) 
        { 

        return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }









    }
}
