using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    class Logica
    {
        private LinkedList<Empleado> lista = new LinkedList<Empleado>();
        Boolean validar = false;
        Boolean validar2 = false;
        int salario = 0;
        int telefono = 0;
        public void agregarEmpleado()
        {
            Console.WriteLine("Ingrese la cedula");
            string cedula =Console.ReadLine();
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese los apellidos");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese la puesto");
            string puesto = Console.ReadLine();
            Console.WriteLine("Ingrese el departamento");
            string departemento = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de entrada");
            DateTime fechaEntrada = DateTime.Parse( Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese el telefono");
                validar = int.TryParse(Console.ReadLine(), out telefono);
                int digitos = (int)Math.Floor(Math.Log10(telefono) + 1);
                if (!validar)
                {
                    Console.WriteLine("No puede tener caracteres" + Environment.NewLine);
                    
                }if(digitos < 8)
                {
                    Console.WriteLine("El numero debe de tener 8 valores o mas");
                }
                else
                {
                    validar = true;
                }
                
            } while (!validar);

            do
            {
                Console.WriteLine("Ingrese el salario");
                validar2 = int.TryParse(Console.ReadLine(), out salario);

                if (!validar2)
                {
                    Console.WriteLine("No puede tener caracteres" + Environment.NewLine);

                }
                else if (salario < 450000)
                {
                    Console.WriteLine("El salario no puede ser menor que 450000");
                }
                else
                {
                    validar2 = true;
                }
            } while (!validar2);

            Empleado emp = new Empleado(cedula, nombre, apellidos, direccion, puesto, departemento, fechaEntrada, salario, telefono);
            lista.AddLast(emp);
        }

        public void imprimirEmpleados()
        {
            foreach (Empleado emple in lista)
            {
                Console.WriteLine(emple.imprimir());
            }

        }
        public void aumentarCedula()
        {
            Console.WriteLine("Ingrese la cedula: ");
            String cod = Console.ReadLine();

            foreach (Empleado emple in lista)
            {
                if(emple.cedula == cod)
                {
                    Console.WriteLine("Ingrese el incremento de salario: ");
                    int sal = int.Parse(Console.ReadLine());
                    emple.sueldo += sal;


                }
                else
                {
                    Console.WriteLine("La cedula no coincide con ninguna");
                }

            }
        }

        public void aumentoPorcentual()
        {
            foreach (Empleado employee in lista)
            {
                if (!employee.puesto.Equals("jefe"))
                {
                    if(employee.sueldo < 600000)
                    {
                        employee.sueldo += (employee.sueldo * 0.02);
                    }
                    else
                    {
                        employee.sueldo += (employee.sueldo * 0.05);

                    }
                }
            }
            {

            }
        }
        private string nombreArchivo()
        {

            string nombre = "";
            nombre = "Log_ " + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + ".txt";

            return nombre;
        }

    }
}
