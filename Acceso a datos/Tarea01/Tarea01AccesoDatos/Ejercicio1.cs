using System.Diagnostics;

namespace Tarea01AccesoDatos
{
    public partial class Ejercicio1 : Form
    {
        private StreamReader ficheroLectura;
        public Ejercicio1()
        {
            InitializeComponent();

        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            GuardarLinea();
        }
        //Crea el fichero si no existe, si existe se genera una linea nueva en el documento
        private void GuardarLinea()
        {
            try
            {
                if (tbLineaNueva.Text.Length > 0)
                {
                    string rutaFichero;
                    StreamWriter fichero;

                    rutaFichero = "FICHERO_EJERCICIO1.TXT";
                    //Comprobamos si ya existe el fichero
                    if (File.Exists(rutaFichero))
                    {
                        fichero = File.AppendText(rutaFichero);
                        fichero.WriteLine(tbLineaNueva.Text);
                        MessageBox.Show("Linea añadida");
                    }
                    else
                    {
                        //No existe. Creamos fichero
                        fichero = File.CreateText(rutaFichero);
                        fichero.WriteLine(tbLineaNueva.Text);
                        MessageBox.Show("Fichero creado");
                    }
                    fichero.Close();
                    CargarFicheroAModificar();
                }
                else
                {
                    MessageBox.Show("Texto incorrecto");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error guardando");
            }


        }

        private void btLeer_Click(object sender, EventArgs e)
        {
            CargarFicheroLista();
        }
        // Muestra los datos guardados en el fichero
        private void CargarFicheroAModificar()
        {
            try
            {                
                string rutaFichero = "FICHERO_EJERCICIO1.TXT";
                string lineasFichero = "";

                ficheroLectura = File.OpenText(rutaFichero);
                lbLineasFichero.Items.Clear();
                //Recorremos fichero abierto
                while (!ficheroLectura.EndOfStream)
                {
                    string linea = ficheroLectura.ReadLine();                    
                    //Add salto de linea para que se muestre el
                    //textbox de la misma forma que el fichero
                    lineasFichero += linea + "\r\n";
                }
                ficheroLectura.Close();
                tbModificarFichero.Clear();
                tbModificarFichero.Text = lineasFichero;
            }
            catch (OutOfMemoryException e)
            {
                MessageBox.Show(e.ToString());
            }catch(FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        private void CargarFicheroLista()
        {
            try
            {
                string rutaFichero = "FICHERO_EJERCICIO1.TXT";
                
                ficheroLectura = File.OpenText(rutaFichero);
                lbLineasFichero.Items.Clear();
                //Recorremos fichero abierto
                while (!ficheroLectura.EndOfStream)
                {
                    string linea = ficheroLectura.ReadLine();
                    lbLineasFichero.Items.Add(linea);                  

                }
                ficheroLectura.Close();
            }
            catch (OutOfMemoryException e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarFichero();
        }

        //Carga del textBox todas las lineas y genera un fichero nuevo remplazando el anterior
        private void ModificarFichero()
        {
            try
            {
                if (tbModificarFichero.Text.Length > 0)
                {
                    string rutaFichero;
                    StreamWriter fichero;

                    rutaFichero = "FICHERO_EJERCICIO1.TXT";
                    //Comprobamos si existe el fichero
                    if (File.Exists(rutaFichero))
                    {
                        //remplazamos el fichero anterior
                        fichero = File.CreateText(rutaFichero);
                        fichero.WriteLine(tbModificarFichero.Text);
                        fichero.Close();
                        MessageBox.Show("Modificado");

                    }
                    else
                    {
                        MessageBox.Show("Fichero no existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error texto a modificar");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error Modificando");
            }
        }

        //Abrir fichero guardado 
        private void btAbrirFichero_Click(object sender, EventArgs e)
        {
            // Obtenemos ruta del proyecto
            string path = Environment.CurrentDirectory;
            var fichero = path + "\\FICHERO_EJERCICIO1.TXT";
            //Si existe abrimos el fichero
            if (File.Exists(fichero))
            {
                Process.Start("notepad.exe", path + "\\FICHERO_EJERCICIO1.TXT");
            }
            else
            {
                MessageBox.Show("No existe el fichero ");
            }
        }


    }
}
