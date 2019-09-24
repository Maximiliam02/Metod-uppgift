using System;

namespace Metoder_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
                BytPlats(ref a,ref b);
                
                Console.WriteLine(a + " " + b );
        }





        static void BytPlats(ref int a,ref int b)
        {
            int tal1 = a;
            int tal2 = b;
            b = tal1;
            a = tal2;
            



        }
    }
}
