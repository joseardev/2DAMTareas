using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02.Clases
{
    public class Alumno
    {

        //string nombre;
        public string nombre { get; set; }

        public string apellidos { get; set; }
        public string dni { get; set; }
        public string curso { get; set; }

        public string fecha { get; set; }


        public  Alumno(string nombre, string apellidos, string dni, string curso){ 

            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.curso = curso;
      
        }

        public string getNombre()
        {
            return this.nombre;
        }
    
    }
}
