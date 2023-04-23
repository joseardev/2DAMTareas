using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02.Clases
{
    public class Coche
    {

        //string nombre;
        public int velocidad { get; set; }

        public string estado { get; set; }       

        public  Coche(int velocidad, string estado){ 

            this.velocidad = velocidad;
            this.estado = estado;
           
      
        }

        public int getVelocidad()
        {
            return this.velocidad;
        }
        public string getEstado()
        {
            return this.estado;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }

    }
}
