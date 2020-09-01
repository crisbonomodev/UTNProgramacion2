using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un array de 10 alumnos
            Alumno[] alumnos = new Alumno[10];

            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].nombre = "Juan";
                alumnos[i].legajo = i;
            }

        }
    }
}
