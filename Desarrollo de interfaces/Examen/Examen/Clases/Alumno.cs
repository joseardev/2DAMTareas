using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Clases
{
    public class Alumno
    {

        private string nombre;
        private string apellidos;
        private string dni;
        private DateTime fechaNacimiento;
        private string cursos;
        private float notaMedia;

        public Alumno()
        {
        }

        public Alumno(string nombre, string apellidos, string dni, DateTime fechaNacimiento, string cursos, float notaMedia)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.cursos = cursos;
            this.notaMedia = notaMedia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Cursos { get => cursos; set => cursos = value; }
        public float NotaMedia { get => notaMedia; set => notaMedia = value; }

        public override string ToString()
        {
            return "Nombre " + this.nombre + " Apellidos " + this.apellidos + " fecha nacimiento " + this.fechaNacimiento +" DNI " + this.dni +" NOTA MEDIA " + this.notaMedia + " Curso " + this.cursos;
        }

    }


}
