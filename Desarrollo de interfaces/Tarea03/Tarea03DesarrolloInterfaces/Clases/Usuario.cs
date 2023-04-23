using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03DesarrolloInterfaces.Clases
{
    public class Usuario
    {        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Dni { get; set; }
        public string Sexo { get; set; }
        public string NivelEstudios { get; set; }
        public string Vicios { get; set; }

        public Usuario(string nombre, string apellidos, int telefono, string dni, string sexo, string nivelEstudios, string vicios)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Dni = dni;
            this.Sexo = sexo;
            this.NivelEstudios = nivelEstudios;
            this.Vicios = vicios;
        }
    }
}
