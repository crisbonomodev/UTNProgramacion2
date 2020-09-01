using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titulo en consola
            Console.Title = "Ejercicio 16";
            //Creamos 3 instancias de alumno
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            //Asignamos nombre, apellido y legajo
            alumno1.setNombreApellido("Juan", "Perez");
            alumno1.setLegajo(2234);

            alumno2.setNombreApellido("Julio", "Sanchez");
            alumno2.setLegajo(9898);

            alumno3.setNombreApellido("Paula", "Diaz");
            alumno3.setLegajo(5555);

            //Asignamos las notas y calculamos para mostrar si aprueba o no.
            alumno1.Estudiar(5, 3);
            Console.WriteLine(alumno1.Mostrar());

            alumno2.Estudiar(8, 9);
            Console.WriteLine(alumno2.Mostrar());

            alumno3.Estudiar(2, 2);
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}
