using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2___Ejercicio_1___Cuentas_bancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un objeto de tipo cliente
            string usuario ="";
            string clave = "";
            int opcion=0;
            Cliente cliente1 = new Cliente("Cristian", "Bonomo", 34501326, "cbonomo", "AdarleATOMOS123");
            //Pedir usuario y clave para loguearse
            //Login

                while ((usuario != cliente1.getUsuario()) || (clave != cliente1.getClave()))
                {
                Console.WriteLine("Ingrese su usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su clave:");
                clave = Console.ReadLine();
                 } ;
            //imprimimos por pantalla
                Console.WriteLine("Login exitoso.");
                Console.WriteLine($"Cliente: {cliente1.getNombre()} {cliente1.getApellido()}");
                Console.WriteLine("----------------------------RESUMEN DE CUENTA------------------");
                Console.WriteLine($"Cuenta Numero: {cliente1.getNroCuenta()}");
                Console.WriteLine($"Saldo disponible: {cliente1.getSaldo()}");

            //Ciclo para repetir el menu hasta que el usuario decida salir
            while (opcion != 9)
            {
                Console.WriteLine("----------------------------OPERACIONES------------------------");
                Console.WriteLine("1.Consulta de saldo.");
                Console.WriteLine("2.Depósito.");
                Console.WriteLine("3.Extracción.");
                Console.WriteLine("9.Salir.");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Ingrese una opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ReadLine();
                }
                //Switch para derivar las opciones a las funciones correspondientes

                switch (opcion)
                {
                    case 1: //Consulta de saldo
                        Console.WriteLine($"Saldo:{cliente1.getSaldo()}");
                        break;

                    case 2: //Agregar saldo
                        int saldo;
                        Console.WriteLine("Ingrese monto a depositar: ");
                        while (!int.TryParse(Console.ReadLine(), out saldo))
                        {
                            Console.WriteLine("Error.Ingrese monto a depositar: ");
                            Console.ReadLine();
                        }
                        cliente1.agregarSaldo(saldo);
                        Console.WriteLine($"Su nuevo saldo es de:{cliente1.getSaldo()} ");
                        break;

                    case 3: //Retirar saldo
                        double saldoActual = cliente1.getSaldo();
                        int retiro;
                        
                        Console.WriteLine("Ingrese monto a retirar: ");
                        while (!int.TryParse(Console.ReadLine(), out retiro))
                        {
                            Console.WriteLine("Error.Ingrese monto a retirar: ");
                            Console.ReadLine();
                        }
                        if (retiro > saldoActual)
                        {
                            Console.WriteLine($"No dispone de los fondos solicitados. Saldo: {cliente1.getSaldo()} ");
                            break;
                        }
                        else { 
                        cliente1.retirarSaldo(retiro);
                            Console.WriteLine($"Retiro exitoso. Su saldo en cuenta es de {cliente1.getSaldo()}");
                        }
                        break;
                    default: //nada asignado
                        break;
                }

            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Gracias por operar con nosotros.");
            Console.ReadKey();
        }
                
    }
}
