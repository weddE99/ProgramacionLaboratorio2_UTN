using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 01";
            int suma=0, min=0, max=0, numero, i=0;
            float prom;
            String aux;

            Console.WriteLine("Ingrese 5 numeros: ");

            do
            {
                aux = Console.ReadLine();
                if(int.TryParse(aux, out numero))
                {
                    if (numero > max || i==0) max = numero;

                    if (numero < min || i==0) min = numero;
                    suma += numero;
                    i++;
                }
                else
                {
                    Console.WriteLine("ERROR!: ingrese un numero");
                }
            } while (i < 5);
            prom = suma / 5;

            Console.WriteLine("\nEl promedio es: {0:#,####.00}", prom);
            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
        }
    }
}
