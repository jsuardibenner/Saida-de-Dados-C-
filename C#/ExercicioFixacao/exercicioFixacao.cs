﻿using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class exercicioFixacao
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ",  cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ",  cujo preço é $ " + preco2);
            Console.WriteLine("");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genero: " + genero);
            Console.WriteLine(" ");
            Console.WriteLine(medida.ToString("F8"));
            Console.WriteLine(medida.ToString("F3"));
            Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
