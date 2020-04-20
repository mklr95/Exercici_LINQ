using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercici_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var pares = new ArrayList();
            var impares = new ArrayList();

            for (int i = 0; i < 15; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares.Add(numeros[i]);
                }
                else
                {
                    impares.Add(numeros[i]);
                }
            }

            Console.WriteLine("PARES");
            foreach(var item in pares)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("IMPARES");
            foreach (var item in impares)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("MEDIA " + numeros.Average());

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("MAX " + numeros.Max());

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("MIN " + numeros.Min());


            var sup5 = new ArrayList();
            var men5 = new ArrayList();
            for (int i = 0; i < 15; i++)
            {
                if (numeros[i]>5)
                {
                    sup5.Add(numeros[i]);
                }
                else if(numeros[i]<5)
                {
                    men5.Add(numeros[i]);
                }
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("SUPERIOR 5");
            foreach (var item in sup5)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("MENOR 5");
            foreach (var item in men5)
            {
                Console.WriteLine("{0}", item);
            }

            
            string[] nombres = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("ARRAY NOMBRES");
            foreach (string item in nombres)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("EMPEZANDO CON O");
            var resultList = nombres.Where(r => r.StartsWith("O"));
            foreach (string item in resultList)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("CON MAS DE 6 LETRAS");
            var resultList2 = nombres.Where(r => r.Length>6);
            foreach (string item in resultList2)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("NOMS ORDENATS");
            var resultList3 = nombres.OrderByDescending(r => r);
            foreach (string item in resultList3)
            {
                Console.WriteLine("{0}", item);
            }

        }
    }
}
