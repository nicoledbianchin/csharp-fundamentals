﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;

            Console.WriteLine("");
            Console.WriteLine("Resultado da soma: " + resultado);
            Console.WriteLine($"Resultado da soma: {resultado}");
            Console.WriteLine($"Resultado da soma: {valor1 + valor2}");
            Console.WriteLine("Resultado da soma: " + (valor1 + valor2));
        }
    }
}
