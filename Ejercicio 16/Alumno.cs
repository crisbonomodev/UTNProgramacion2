using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        //propiedades
        byte nota1;
        byte nota2;
        float notaFinal;
        string apellido;
        public int legajo;
        string nombre;

        

        //setters
        public void setNombreApellido(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }

        //getters
        public string getNombre()
        {
        return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public int getLegajo()
        {
            return this.legajo;
        }

        //metodos
        void CalcularFinal()
        {
            if ((nota1 >= 4) && (nota2 >= 4))
            {
                Random rnd = new Random();
                notaFinal = rnd.Next(4,10);
            }
            else 
            {
                notaFinal = -1;
            }
        }
       public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
       public string Mostrar()
        {
            string apellido = this.getApellido();
            string nombre = this.getNombre();
            int legajo = this.getLegajo();
            CalcularFinal();

            if (notaFinal != -1)
            {
                return $"Alumno:{apellido}, {nombre}. Legajo: {legajo} Nota 1: {nota1} , Nota2: {nota2}, Nota Final: {notaFinal}";
            }
            else
            {
                return $"Alumno:{apellido}, {nombre}. Nota 1: {nota1} , Nota2: {nota2}, Alumno desaprobado";
            }
            
        }
    }
}
