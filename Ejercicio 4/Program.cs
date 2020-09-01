using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";

            /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Nota: Utilizar estructuras repetitivas y selectivas.
*/

            int numero = 2; //El 1 no cuenta
            int contador = 0;
            do
            {
                bool esPerfecto = verificarNumeroPerfecto(numero);

                if (esPerfecto)
                {   //Si es perfecto, mostramos por pantalla, sumamos al contador y al numero
                    Console.WriteLine($"{numero} es perfecto");
                    contador++;
                    numero++;
                }
                else
                {   //NO es perfecto, sumamos al numero
                    
                    numero++;
                }
            } while (contador < 4);
            Console.ReadKey();

        }
        static bool verificarNumeroPerfecto(int numero) //Modulo que recibe un numero y valida si es perfecto o no.
        {
            int acumulador = 0;
            for (int i = 1; i < numero; i++)
            {
                //Si el modulo es 0, guardamos el valor de i en el acumulador
                if ((numero % i) == 0)
                {
                    acumulador += i;
                }

            }
            //Si el acumulador y el numero son iguales, sumamos 1 al contador e imprimimos
            if (numero == acumulador)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
