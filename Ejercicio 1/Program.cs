using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1: Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
            valor máximo, el valor mínimo y el promedio.*/
            //Nombre del ejercicio en el título de la consola
            Console.Title = "Ejercicio Nro 01";
            //Declaramos la variable
            int[] arrayNumeros;
            arrayNumeros = new int[5];
            //Pedimos los datos
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                string input;
                //Validamos si es un numero
                bool isNumber;
                Console.WriteLine($"{i} - Ingrese un número: ");

                    input = Console.ReadLine();
                    while(!int.TryParse(input, out arrayNumeros[i])){
                    Console.WriteLine("ERROR!!!!!Ingrese un número: ");
                    input = Console.ReadLine();
                    }
            }

            //Calculamos los datos solicitados
            int min = 0;
            int max = 0;
            float promedio = 0;
            //Mostramos resultados

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                //Si es la primera iteracion, guardamos valores de minimo y maximo
                if (i == 0)
                {
                    min = arrayNumeros[i];
                    max = arrayNumeros[i];
                }
                //Verificamos si es mayor o menor
                if (arrayNumeros[i] > max)
                {
                    max = arrayNumeros[i];
                }
                if (arrayNumeros[i] < min)
                {
                    min = arrayNumeros[i];
                }
                //sumamos el promedio
                promedio += arrayNumeros[i];
            }
            //Calculamos el promedio
            promedio = promedio / arrayNumeros.Length;
            //Imprimimos por pantalla
            Console.WriteLine($"Para los datos ingresados, los valores son: Mínimo: {min}, Máximo {max}, Promedio {promedio}");
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}

