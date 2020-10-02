using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Class1 {
        private int cedula { get; set; }
        private String nombre { get; set; }
        private string apellidos { get; set; }
        private string direccion { get; set; }
        private string puesto { get; set; }
        private string departemento { get; set; }
        private DateTime fechaIngreso;
        private int sueldo { get; set; }
        private int telefono { get; set; }

        public Class1(int cedula, string nombre, string apellidos, string direccion, string puesto, 
            string departemento, DateTime fechaIngreso, int sueldo, int telefono)
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

        public int calculaEdad(DateTime ingreso)
        {
            int annio = DateTime.Now.Year - ingreso.Year;
            int mes = DateTime.Now.Month - ingreso.Month;
            if(mes < 0)
            {
                return annio - 1;
            }
            return annio;
        }


    }
}
