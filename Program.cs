using System;

namespace Cirkel_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omrekts: "+ Omkrets(radie));
            Console.WriteLine("Cirkelns area: "+ Area(radie));

        }


        static double Area(double r)
        {
            double a = r * r * Math.PI ;
            return a;
        }

        static double Omkrets(double r)
        {
            double b = r * 2 * Math.PI;
            return b;
        }
    }
}
