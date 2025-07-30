using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace session04_oop
{
    internal class Duration
    {
       public int hours {  get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }



        public override string ToString()
        {
            return $"Hours: {hours}, Minutes :{minutes}, Seconds :{seconds}";
        }
        public Duration(int time) {
            hours = time / 3600;
            time %= 3600;
            minutes = time / 60;
            seconds = time % 60;

          

        }
        public Duration(int Hours,int Minutes,int Seconds)
        {
            hours = Hours;
            minutes = Minutes;
            seconds = Seconds;


        }




        public static Duration operator +(Duration a, Duration b) {



            int totalSeconds = a.seconds + b.seconds;
            int totalMinutes = a.minutes + b.minutes + (totalSeconds / 60);
            int totalHours = a.hours + b.hours + (totalMinutes / 60);

            totalSeconds %= 60;
            totalMinutes %= 60;

            return new Duration(totalHours, totalMinutes, totalSeconds);
        }



        public static Duration operator ++(Duration a) {


            a.minutes++;
            return a  ;
        }


        public static Duration operator --(Duration a)
        {


            a.minutes--;
            return a;
        }

            public static bool operator >(Duration a, Duration b)
        {
            int check1 = a.hours * 3600 + a.minutes * 60 + a.seconds;
            int check2 = b.hours * 3600 + b.minutes * 60 + b.seconds;
            return check1 > check2;
        }


        public static bool operator <(Duration a, Duration b)
        {
            int check1 = a.hours * 3600 + a.minutes * 60 + a.seconds;
            int check2 = b.hours * 3600 + b.minutes * 60 + b.seconds;
            return check1 < check2;
        }




    }
    
}
