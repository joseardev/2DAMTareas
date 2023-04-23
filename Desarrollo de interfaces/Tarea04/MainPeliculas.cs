using Microsoft.VisualBasic;
using System.ComponentModel;
using Tarea4.Clases;

namespace Tarea4
{
    public partial class MainPeliculas : Form
    {       
        Pelicula peli = new Pelicula("Piratas del caribe ","P1","asdasd");
        Actor actor = new Actor();
        Videoclub videoclub = new Videoclub();

        public MainPeliculas()
        {
            peli.Estado = "Bien";
            peli.ActorPelicula = actor;
            
            //
            InitializeComponent();           
            lbListaPeliculas.DataSource = Videoclub.ListaPeliculas;
            Videoclub.ListaPeliculas.Add(peli);
           
        }

        private void btEditarPelicula_Click(object sender, EventArgs e)
        {
            //Obtenemos usuario selecionado
            Pelicula peliculaSelecionada = (Pelicula)lbListaPeliculas.SelectedItem;
            Form form = new EditarPelicula(peliculaSelecionada);
            form.ShowDialog();
        }

        private void btAñadirPelicula_Click(object sender, EventArgs e)
        {
            AddPelicula addPelicula = new AddPelicula();
            addPelicula.ShowDialog();
        }

        private void btMostrarPelicula_Click(object sender, EventArgs e)
        {

            var existePelicula = Videoclub.ListaPeliculas.SingleOrDefault(peliList => peliList.Codigo == tbCodigoPelicula.Text);
            if (existePelicula != null)
            {
                existePelicula.MostrarPelicula();
            }
            else
            {
                MessageBox.Show("El codigo indicado no existe");
            }


        }

        public static void AddPelicula(Pelicula pelicula)
        {
            try
            {
                var existePelicula = Videoclub.ListaPeliculas.SingleOrDefault(peliList => peliList.Codigo == pelicula.Codigo);
                if (existePelicula == null)
                {
                    Videoclub.ListaPeliculas.Add(pelicula);
                }
                else
                {
                    MessageBox.Show("El codigo ya existe");
                }
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Error Añadiendo pelicula" + e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Añadiendo pelicula" + e);
            }

        }

        public static void EditarPelicula(Pelicula pelicula)
        {
            try
            {
                if (pelicula != null)
                {
                    var peliculaExiste = Videoclub.ListaPeliculas.SingleOrDefault(peli => peli.Codigo == pelicula.Codigo);
                    Videoclub.ListaPeliculas.Remove(peliculaExiste);
                    Videoclub.ListaPeliculas.Add(pelicula);
                }
            }catch(ArgumentNullException e)
            {
                MessageBox.Show("Error editando pelicula" + e);
            }catch(Exception e)
            {
                MessageBox.Show("Error editando pelicula" + e);
            }
        }
        public static BindingList<Pelicula> GetListaPeliculas() {

            return Videoclub.ListaPeliculas;
        
        }

        private void btMostrarLista_Click(object sender, EventArgs e)
        {
            try
            {            
                MostrarAllPeliculas mostrarLista = new MostrarAllPeliculas();
                mostrarLista.ShowDialog();
            }catch (Exception){
                MessageBox.Show("Error al mostrar la lista de pelicula" );
            }
        }
    }
}