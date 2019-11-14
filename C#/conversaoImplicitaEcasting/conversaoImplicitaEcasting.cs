using System;

namespace conversaoImplicitaEcasting
{
    class conversaoImplicitaEcasting
    {
        static void Main(string[] args)
        {

            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            // casting
            double a;
            float b;

            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);


            int j;
            int k;

            j = 5;
            k = 2;

            double resultado = (double)j / k;

            Console.WriteLine(resultado);
        }
    }
}
