using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            String aux;
            int num;
            Console.Title = "Ejercicio nro 02";
            Console.WriteLine("Ingrese un numero: ");

            do
            {
                aux = Console.ReadLine();
                if (int.TryParse(aux, out num))
                {
                    if(num > 0)
                    {
                        Console.WriteLine("^2 {0}", Math.Pow(num, 2));
                        Console.WriteLine("^3 {0}", Math.Pow(num, 3));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. ¡Reingresar Numero!\n");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar Numero!\n");
                }
            } while (true);
        }
    }
}
