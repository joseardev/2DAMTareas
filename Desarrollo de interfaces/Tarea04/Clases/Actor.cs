using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Clases
{
    public  class Actor
    {

        private DateTime fecha_nacimiento;

        private int edad;
        private string nombre;
        private string nif;

        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nif { get => nif; set => nif = value; }

        //Comprueba DNI correcto
        // Devuelve true si es correcto
        public static bool CompruebaDNI(string dni)
        {
            //Comprobamos si tiene 9 caracteres
            if (dni.Length != 9)
            {                
                return false;
            }

            //Extraemos numeros
            string dniNumeros = dni.Substring(0, dni.Length - 1);
            //Extraemos letra
            string dniLetras = dni.Substring(dni.Length - 1, 1);

            //Comprobamos si los numeros son correctos
            var numerosValidos = int.TryParse(dniNumeros, out int dniInteger);
            if (!numerosValidos)
            {               
                return false;
            }
            //Comprobamos que la letras concuarda
            if (CompruebaLetraDNI(dniInteger) != dniLetras)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido 
            return true;
        }

        static string CompruebaLetraDNI(int numeroDNI)
        {
            //Cargamos los digitos de control
            string[] letrasDNI = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var modulo = numeroDNI % 23;
            return letrasDNI[modulo];
        }
        //Calcula la edad según la fecha
        // fechaNacimiento => Fecha de nacimiento
        // Return int Edad
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            //fecha actual:
            DateTime fechaActual = DateTime.Today;

            // la fecha de nacimiento es mayor a la fecha actual          
            if (fechaNacimiento > fechaActual)
            {                
                return 0;
            }
            else
            {
                //Restamos los años de las dos fechas
                int edad = fechaActual.Year - fechaNacimiento.Year;

                // Comprueba que el mes de la fecha de nacimiento es mayor 
                // que el mes de la fecha actual:
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }
    }
}
