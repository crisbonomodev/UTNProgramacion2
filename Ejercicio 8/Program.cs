using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
            trabajadas en el mes de N empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
            valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
            descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ejercicio 8";
            //Variables
            bool validarNuevoEmpleado = true;
            List<Empleado> empleados = new List<Empleado>();
            int valorHora = 0;
            while (validarNuevoEmpleado==true)
            {
                string nombreApellido;
                int antiguedad;
                int horasTrabajadas;
                string input;
                Console.WriteLine("Nombre del empleado:");
                nombreApellido = Console.ReadLine();
                Console.WriteLine("Antiguedad:");
                while (!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("Error, ingrese un numero:");
                    Console.ReadLine();
                }
                Console.WriteLine("Horas trabajadas:");
                while (!int.TryParse(Console.ReadLine(), out horasTrabajadas))
                {
                    Console.WriteLine("Error, ingrese un numero:");
                    Console.ReadLine();
                }
                Console.WriteLine("Valor por hora:");
                while (!int.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("Error, ingrese un numero:");
                    Console.ReadLine();
                }
                empleados.Add(new Empleado(nombreApellido, antiguedad, horasTrabajadas, valorHora));
                Console.WriteLine("Desea ingresar otro empleado? Y/N");
                input = Console.ReadLine().ToUpper();
                
                if (input.StartsWith("Y"))
                {
                    validarNuevoEmpleado = true;
                }
                else if (input.StartsWith("N"))
                {
                    validarNuevoEmpleado = false;
                }

            }
            //Realizamos las operaciones
            Empleado[] empleadoDB = empleados.ToArray();

            foreach (Empleado empleado in empleadoDB)
            {
                float valorBruto = empleado.horasTrabajadas * empleado.valorHora;
                double aportes = valorBruto * 0.13;
                Console.WriteLine("---------RECIBO----------");
                Console.WriteLine($"Apellido y Nombre: {empleado.nombreApellido}");
                Console.WriteLine($"Antiguedad: {empleado.antiguedad}");
                Console.WriteLine($"Horas trabajadas: {empleado.horasTrabajadas}");
                Console.WriteLine($"Monto bruto: {valorBruto}");
                Console.WriteLine($"Aportes: {aportes}");
                Console.WriteLine($"Total a cobrar: {valorBruto + (empleado.antiguedad*150) - aportes}");
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}