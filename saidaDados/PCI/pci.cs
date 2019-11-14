using System;

namespace PCI
{
    class pci
    {
        static void Main(string[] args)
        {
            // Placeholders, concatenação e interpolação

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // Placehouder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);


            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais ");

            // Concatenação - Com 2 casas decimais
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais ");

        }
    }
}
