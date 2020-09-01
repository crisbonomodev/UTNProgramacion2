using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
            con DateTime.Now).
            Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. */

            Console.Title = "Ejercicio 7";
            //Inicializamos variables
            string input;
            DateTime fechaActual = DateTime.Now;
            int[] arrayNacimiento = new int[3];
            DateTime fNacimiento = new DateTime();
            Console.WriteLine(fechaActual);
            //Pedimos por pantalla la fecha de nacimiento

            Console.WriteLine("Ingrese su fecha de nacimiento(dd / MM / yyyy): ");

                input = Console.ReadLine();
                //validamos que podamos parsear y la fecha sea valida
                while(!DateTime.TryParseExact(input, "dd/MM/yyyy",null, DateTimeStyles.None,out fNacimiento))
                {

                    Console.WriteLine("Error, ingrese una fecha válida:  ");
                    input = Console.ReadLine();
                }
            //Crea
            TimeSpan edad = fechaActual.Subtract(fNacimiento);
            Console.WriteLine($"Usted ha vivido {edad.Days} días.");
            Console.ReadKey();

        }
    }
}
