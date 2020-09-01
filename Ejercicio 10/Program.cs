using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
            una pirámide como la siguiente:

                *
               ***
              *****
             *******
            *********
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            Console.Title = "Ejercicio 10";

            //Variables
            int altura;

            Console.WriteLine("Ingrese la altura:");
            while (!int.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Error. Ingrese la altura:");
                Console.ReadLine();
            }
            //imprimimos, necesitamos que los * impresos sean impares, por lo que validamos el modulo distinto a 0
            int a;
            int espacios;
            for (int i = 1; i <= altura; i++)
            {
                StringBuilder piramide = new StringBuilder();

                espacios = altura - i;
                a = i + (i - 1);
                
                
                for (int i1 = 0; i1 < espacios; i1++)
                    piramide.Append(" ");
                for (int i2= 0; i2 < a; i2++)
                    {
                        piramide.Append("*");
                    }
             
                Console.WriteLine(piramide.ToString());
            }
            
            Console.ReadKey();

        }
    }
}
