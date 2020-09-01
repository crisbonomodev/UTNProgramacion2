using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
            también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            : Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

            Console.Title = "Ejercicio Nro 06";

            /*Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
            int[] anios = new int[2];
            string input;

            for (int i = 0; i < anios.Length; i++)
            {
                Console.WriteLine("Bienvenido!!!Ingrese un año: ");
                input = Console.ReadLine();
                //Parseamos
                while (!int.TryParse(input, out anios[i]))
                {
                    Console.WriteLine("ERROR!!!!!Ingrese un número: ");
                    input = Console.ReadLine();
                }
            }

            //mostrar todos los años bisiestos en ese rango

            for (int i = anios[0]; i <= anios[1]; i++)
            {
            if ((i % 400 == 0)||(i % 4 == 0) && (i % 100 != 0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
