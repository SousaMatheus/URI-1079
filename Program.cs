﻿using System;
using System.Globalization;

namespace URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i =0; i <n ; i ++){
                string [] vet = Console.ReadLine().Split(' ');

                double n1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1],CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2],CultureInfo.InvariantCulture);

                double resultado = ((n1 *2.0) + (n2 * 3.0) + (n3 *5.0)) / 10.0;

                Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));

            }
        }
    }
}
