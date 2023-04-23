using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Instituto
    {
        private string nombre;
        private string direccion;
        private float notaMediaAlumnos;
        private BindingList<Alumno> listaAlumnos = new BindingList<Alumno>();

        public Instituto(string nombre, string direccion, int notaMediaAlumnos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.notaMediaAlumnos = notaMediaAlumnos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float NotaMediaAlumnos { get => notaMediaAlumnos; set => notaMediaAlumnos = value; }
        public BindingList<Alumno> ListaAlumnos { get => listaAlumnos; set => listaAlumnos = value; }



        public void addNuevoAlumno(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
            calculaMediaAlumnos();
        }

        public void calculaMediaAlumnos()
        {
            float notaMedia = 0;
            float sumaNotas = 0;
            foreach (var alumnoLista in ListaAlumnos)
            {
                sumaNotas += alumnoLista.NotaMedia;
            }

            this.notaMediaAlumnos = (sumaNotas / (float)this.listaAlumnos.Count);
        }


        public override string ToString()
        {
            return this.nombre;
        }


    }



}
