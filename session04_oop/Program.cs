namespace session04_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-1

            /*1. Define Class Duration To include Three Attributes Hours,
              Minutes and Seconds.
             

            2. Define All Required Constructors to Produce this output:
                Duration D1 =new Duration (1,10,15);
                D1.ToString();
                Output: Hours: 1, Minutes :10, Seconds :15
                Duration D1 =new Duration (3600);
                D1.ToString();
                Output: Hours: 1, Minutes :0, Seconds :0
                Duration D2 =new Duration (7800);
                D2.ToString();
                Output: Hours: 2, Minutes :10, Seconds :0
                Duration D3 =new Duration (666);
                D3.ToString();
                Output: Minutes :11, Seconds :6
            */

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);

            // D1 = new Duration(3600);
            //Console.WriteLine(D1);


            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2);

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3);


            /*
            3. Implement All required Operators overloading to enable this
               Code:
                D3=D1+D2
                D3=D1 + 7800
                D3=666+D3
                D3= ++D1 (Increase One Minute)
                D3 = --D2 (Decrease One Minute)
                D1= D1 -D2
                If (D1>D2)

            */
            //0-D3=D1 + D2;
            //Console.WriteLine(D3);
            // D3=D1 + 7800 xxxxxxxxxxxx
            //D3 = 666 + D3  xxxxxxxxxxxx
            //D3 = D1 + D3;
            //Console.WriteLine(D3);
            //D3 = ++D1;
            //D3 = --D2
            //D1= D1 - D2
            //if(D1 > D2)
            //{
            //    Console.WriteLine("time in D1 bigger than D2");
            //}



            #endregion

            #region Q2
            ///*
            // Define Class Maths that has four methods: Add, Subtract, Multiply,
            //  and Divide, each of them takes two parameters. Call each method in
            //  Main ().
            //  Modify the program so that you do not have to create an instance of
            //  class to call the four methods.


            //*/

            //Console.WriteLine(Arithmetic.sum(5, 6));
            //Console.WriteLine(Arithmetic.Subtract(16, 9));
            //Console.WriteLine(Arithmetic.Multiply(5, 2));
            //Console.WriteLine(Arithmetic.Divide(8, 4));




            #endregion

            #region V1
            //abstraction


            #endregion
            #region V3
            //operator overloading
            Complex c1 = new Complex(2, 3);   // 2 + 3i
            Complex c2 = new Complex(1, 4);   // 1 + 4i

            Complex result = c1.Add(c2);      // 3 + 7i
            Console.WriteLine("Result: " + result);



        
        #endregion


    }
    }
}
