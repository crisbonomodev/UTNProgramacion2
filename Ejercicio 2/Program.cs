using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
            mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/
            
            Console.Title = "Ejercicio Nro 02";
            double numero;
            double cuadrado;
            double cubo;
            string input;
            //Ingresamos un número
            Console.WriteLine("Bienvenido!!!Ingrese un número: ");

            input = Console.ReadLine();
            //Parseamos
            while(!double.TryParse(input, out numero)){
            Console.WriteLine("ERROR!!!!!Ingrese un número: ");
            input = Console.ReadLine();
            }

            //Realizamos las operaciones
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            //Imprimimos por pantalla

            Console.WriteLine($"Para los datos ingresados, los valores son: {numero}^2: {cuadrado}, {numero}^3: {cubo}");
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();

        }
    }
}
