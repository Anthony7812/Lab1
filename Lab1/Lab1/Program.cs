using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logica log = new Logica();
            Archivo arc = new Archivo(@"C:\Users\HP\Documents");
            string mensaje = "";

            try
            {
                Boolean seguir = true;
                while (seguir)
                {
                    Console.WriteLine("Menu de acciones");
                    Console.WriteLine("1)Agregar empleado");
                    Console.WriteLine("2)Ver empleados");
                    Console.WriteLine("3)Aplicar incremento porcentual");
                    Console.WriteLine("4)Incrementar salario por cedula");

                    Console.WriteLine("Ingrese una opcion: ");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            log.agregarEmpleado();
                            break;

                        case 2:
                            log.imprimirEmpleados();
                            break;
                        case 3:

                            log.aumentoPorcentual();
                            break;
                        case 4:
                            log.aumentarCedula();
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("Desea continuar S/N");
                    String continuar = Console.ReadLine();

                    if (continuar.Equals("n"))
                    {
                        seguir = false;
                    }
                }
            }
            catch (Exception ex )
            {
                mensaje = ex.Message + ex.StackTrace; 
                arc.agregarLog(mensaje);

                
            }
        }
    }
}
