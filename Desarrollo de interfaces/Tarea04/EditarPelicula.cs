using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea4.Clases;

namespace Tarea4
{
    public partial class EditarPelicula : Form
    {
        private Pelicula peliculaSelecionada;

        public EditarPelicula()
        {
            InitializeComponent();
        }

        public EditarPelicula(Pelicula peliculaSelecionada)
        {
            InitializeComponent();
            //No permitimos cambiar codigo 
            tbCodigo.Enabled = false;
            //Cargamos los datos de la pelicula que queremos modificar
            this.peliculaSelecionada = peliculaSelecionada;
            tbActor.Text    = this.peliculaSelecionada.Actor;
            tbCodigo.Text   = this.peliculaSelecionada.Codigo;
            tbDirector.Text = this.peliculaSelecionada.Director;
            tbEstado.Text   = this.peliculaSelecionada.Estado;
            tbGenero.Text   = this.peliculaSelecionada.Genero; 
            tbTitulo.Text   = this.peliculaSelecionada.Titulo;           
            mcFecha.SetDate(this.peliculaSelecionada.FechaDevolucion);
           
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            editarPelicula();
        }
        private void editarPelicula()
        {
            //Comprobamos que tenemos todos los datos
            if (tbTitulo.Text.Length > 0 && tbCodigo.Text.Length > 0 && tbDirector.Text.Length > 0 && tbEstado.Text.Length > 0 && tbGenero.Text.Length > 0)
            {
                Pelicula pelicula = new Pelicula(tbActor.Text, tbCodigo.Text, tbDirector.Text);
                pelicula.Actor = tbActor.Text;
                pelicula.Estado = tbEstado.Text;
                pelicula.FechaDevolucion = mcFecha.SelectionRange.Start;
                pelicula.Genero = tbGenero.Text;
                MainPeliculas.EditarPelicula(pelicula);
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }
    }
}
