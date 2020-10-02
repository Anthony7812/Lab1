using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Empleado {
        public String cedula { get; set; }
        public String nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string puesto { get; set; }
        public string departemento { get; set; }
        public DateTime fechaIngreso;
        public Double sueldo { get; set; }
        public int telefono { get; set; }

        public Empleado(string cedula, string nombre, string apellidos, string direccion, string puesto, 
            string departemento, DateTime fechaIngreso, Double sueldo, int telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.puesto = puesto;
            this.departemento = departemento;
            this.fechaIngreso = fechaIngreso;
            this.sueldo = sueldo;
            this.telefono = telefono;
        }
        public Empleado()
        {

        }
        

        public DateTime FechaIngreso
        {
            get { return this.FechaIngreso; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("La fecha ingresada no puede ser mayor a la actual");
                }
                else
                {
                    this.fechaIngreso = value;
                }
            }

        }

        public int calculaEdad()
        {
            int annio = DateTime.Now.Year - fechaIngreso.Year;
            int mes = DateTime.Now.Month - fechaIngreso.Month;
            if(mes < 0)
            {
                return annio - 1;
            }
            return annio;
        }

        public String imprimir()
        {
            string mensaje = "Cedula= " + cedula + Environment.NewLine +
                            "Nombre =" + nombre + Environment.NewLine +
                            "Apellidos= " + apellidos + Environment.NewLine +
                            "Direccion= " + direccion + Environment.NewLine +
                            "Puesto= " + puesto + Environment.NewLine +
                            "Departamento= " + departemento + Environment.NewLine +
                            "Años de antiguedad= " + calculaEdad() + Environment.NewLine +
                            "Telefono=" + telefono + Environment.NewLine+
                            "Sueldo= " + sueldo + Environment.NewLine;
                               ;

            return mensaje;

        }


    }
}
