using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Archivo
    {
        string path = "";

        public Archivo(string path)
        {
            this.path = path;
        }

        private string nombreArchivo()
        {

            string nombre = "";
            nombre = "Log_ " + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + ".txt";

            return nombre;
        }

        private void directorio()
        {
            try
            {
                if (!Directory.Exists(this.path))
                {
                    Directory.CreateDirectory(this.path);
                }

            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);

                throw;
            }
        }

        public void agregarLog(String evento)
        {
            try
            {
                directorio();
                string nombre = nombreArchivo();
                string cadena = "";
                cadena += "Hora del evento" + DateTime.Now + " Erorr generado: " + evento;
                StreamWriter sw = new StreamWriter(this.path + "/" + nombre, true);
                sw.Write(cadena);
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
