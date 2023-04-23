using Tarea4.Clases;

namespace Tarea4
{
    public partial class AddPelicula : Form
    {
        Pelicula pelicula = new Pelicula();
        Actor newActor = new Actor();

        public AddPelicula()
        {
            InitializeComponent();
        }

        private void btAddPelicula_Click(object sender, EventArgs e)
        {
            creaNuevaPelicula();
        }

        //Creamos pelicula nueva       
        public void creaNuevaPelicula()
        {
            //Mostramos la edad según la fecha de nacimiento
            tbEdad.Text = Actor.CalcularEdad(mcFechaActor.SelectionRange.Start).ToString();
            //Comprobamos que valores faltan por introducir 
            if (tbTitulo.Text.Length > 0 && tbCodigo.Text.Length > 0 && tbDirector.Text.Length > 0 && tbEstado.Text.Length > 0 && tbGenero.Text.Length > 0)
            {
                //Comprobamos que tenemos actor
                if (tbActor.Text.Length > 0)
                {
                    //Comprobamos que el dni intriducido es correcto
                    if (Actor.CompruebaDNI(tbDNI.Text))
                    {
                        pelicula = new Pelicula(tbTitulo.Text, tbCodigo.Text, tbDirector.Text);
                        newActor.Nif = tbDNI.Text;
                        pelicula.Actor = tbActor.Text;
                        pelicula.Estado = tbEstado.Text;
                        pelicula.FechaDevolucion = mcFecha.SelectionRange.Start;
                        pelicula.Genero = tbGenero.Text;

                        if (tbActor.Text != null)
                        {
                            newActor.Nombre = tbActor.Text;
                            newActor.Edad = Actor.CalcularEdad(mcFechaActor.SelectionRange.Start);

                        }
                        pelicula.ActorPelicula = newActor;
                        MainPeliculas.AddPelicula(pelicula);
                    }
                    else
                    {
                        
                        MessageBox.Show("Falta Actor");
                    }
                }
                else
                {
                    MessageBox.Show("DNI INCORRECTO");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }

        }

        //Calculamos la fecha cuando se seleciona una fecha en el calendario
        private void mcFechaActor_DateChanged(object sender, DateRangeEventArgs e)
        {         
            tbEdad.Text = Actor.CalcularEdad(mcFechaActor.SelectionRange.Start).ToString();
        }
    }
}
