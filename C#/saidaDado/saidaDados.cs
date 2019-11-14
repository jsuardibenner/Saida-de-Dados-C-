using System;

// incluindo para as casas decimais ser com " . "
using System.Globalization;

namespace saidaDado
{
    class saidaDados
    {
        static void Main(string[] args)
        {
            // Imprimir na saida padrão (Console)

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            // Casas decimais com " . "
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            
        }
    }
}
