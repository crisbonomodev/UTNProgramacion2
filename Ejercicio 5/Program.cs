using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
            dos grupos de números, cuyas sumas son iguales.
            El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
            cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
            49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
            usuario ingrese por consola.
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ejercicio Nro 05";

            //Pedimos al usuario que ingrese el numero por consola
            int numeroLimite;
            int numero = 1;
            string input;
            int sumador1 = 0;
            int sumador2 = 0;

            Console.WriteLine("Bienvenido!!!Ingrese un número: ");
            input = Console.ReadLine();
            //Parseamos
            while(!int.TryParse(input, out numeroLimite)){
            Console.WriteLine("ERROR!!!!!Ingrese un número: ");
            input = Console.ReadLine();
            }
            //Realizamos las operaciones

            do
            {
                for (int i = 1; i < numero; i++)
                {
                    sumador1 += i;
                }
                for (int j = numero + 1; j < numero * 2; j++)
                {
                    if (sumador1 == sumador2)
                    {//Encontramos un centro numerico 
                        Console.WriteLine($"Centro numérico encontrado:{numero}");
                        break;
                    }
                    else
                    {
                        sumador2 += j;
                    }
                }
                numero++;
                sumador1 = 0;
                sumador2 = 0;
            } while (numero < numeroLimite + 1);
            Console.ReadKey();
        }
    }
}
