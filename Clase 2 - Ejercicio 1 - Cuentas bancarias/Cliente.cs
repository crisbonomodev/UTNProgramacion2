using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2___Ejercicio_1___Cuentas_bancarias
{
    class Cliente
    {
        //
        string nombre;
        string apellido;
        int dni;
        string usuario;
        string clave;
        static int numeroCuenta;
        double saldo =0;

        static Cliente()
        {
            Random rnd = new Random();
            numeroCuenta = rnd.Next(100, 1000);
            
        }
        public Cliente(string nombre, string apellido, int dni, string usuario, string clave) {

            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.usuario = usuario;
            this.clave = clave;
        }
        //getters
        public string getNombre() {
            return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public int getDNI()
        {
            return this.dni;
        }
        public string getUsuario()
        {
            return this.usuario;
        }
        public string getClave()
        {
            return this.clave;
        }
        public int getNroCuenta()
        {
            return numeroCuenta;
        }
        public double getSaldo ()
        {
            return saldo;
        }

        //setters

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setDNI(int DNI)
        {
            this.dni = DNI;
        }
        public void setClave(string clave)
        {
            this.clave = clave;
        }
        public void agregarSaldo(int saldo)
        {
            this.saldo += saldo;
        }
        public void retirarSaldo(int saldo)
        {
            this.saldo -= saldo;
        }

    }
}
