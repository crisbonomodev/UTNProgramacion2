using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que imprima por pantalla una pirámide como
            la siguiente:
            *
            ***
            *****
            *******
            *********
            El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            ejemplo anterior la altura ingresada fue de 5.
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ejercicio 9";

            //Variables
            int altura;

            Console.WriteLine("Ingrese la altura:");
            while (!int.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Error. Ingrese la altura:");
                Console.ReadLine();
            }
            //imprimimos, necesitamos que los * impresos sean impares, por lo que validamos el modulo distinto a 0
            for (int i = 0; i <= altura*2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            Console.ReadKey();
        }
    }
}
