using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Empleado
    {
        //propiedades
        public string nombreApellido;
        public int antiguedad;
        public int horasTrabajadas;
        public int valorHora;
        public Empleado( string nombre, int antiguedad, int horasTrabajadas, int valorHora)
        {
            this.nombreApellido = nombre;
            this.antiguedad = antiguedad;
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }
    
    }

}
