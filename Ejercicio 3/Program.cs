using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
            por consola.
            Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

            Console.Title = "Ejercicio 3";

            //Pedimos al usuario que ingrese el numero
            int numero;
            string input;
            bool isNumber;
            int ignoreMe;
            //Ingresamos un número
            Console.WriteLine("Bienvenido!!!Ingrese un número: ");
            input = Console.ReadLine();
            //Parseamos
            while(!double.TryParse(input, out numero)){
            Console.WriteLine("ERROR!!!!!Ingrese un número: ");
            input = Console.ReadLine();
            }

            //Realizamos las operaciones
            

            for (int i = 2; i <= numero; i++) 
            {
                bool esPrimo = validarNumeroPrimo(i);
                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        static bool validarNumeroPrimo(int numero)
        {
            
            for (int i = 2; i < numero; i++)
            {

                //Validamos si es primo
                if ((numero % i == 0))
                {
                    //No es primo
                    return false;
                }
            }
            //Si es primo, lo mostramos
            return true;
        }
    }
}
