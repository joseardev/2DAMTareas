using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Clases
{
    public class Pelicula
    {
        private string titulo;
        private string codigo;
        private string director;
        private string actor;
        private string estado;
        private DateTime fechaDevolucion;
        private string genero;

        private Actor actorPelicula;
        public Pelicula()
        {
        }
        public Pelicula(string titulo, string codigo, string director)
        {
            this.Titulo = titulo;
            this.Codigo = codigo;
            this.Director = director;
        }
        public string Titulo { get => titulo; set => titulo = value; }        
        public string Codigo { get => codigo; set => codigo = value; }
        public string Director { get => director; set => director = value; }
        public string Actor { get => actor; set => actor = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public string Genero { get => genero; set => genero = value; }
        public Actor ActorPelicula { get => actorPelicula; set => actorPelicula = value; }
       
        //Metodo para mostrar los datos de la pelicula
        public void MostrarPelicula()
        {           
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = ToString();
            const string caption = "Datos Pelicula";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK);
        }
        public override string ToString()
        {
            return "Titulo: " +this.Titulo + " Codigo: " + this.Codigo + " Director: " + this.Director 
                + " Estado: " + this.Estado
                + " Genero: " + this.Genero
                + " Fecha Devolucion: " + this.FechaDevolucion;
        }

    }
}
