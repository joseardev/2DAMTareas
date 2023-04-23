using System.ComponentModel;
using System.Text;

namespace Tarea01AccesoDatos
{
    public partial class Ejercicio3 : Form
    {
        BindingList<string> ltLogRevisarFicheros = new BindingList<String>();


        private string rutaFicheroOrigen;
        private OpenFileDialog openFicheroDialog;
        public Ejercicio3()
        {
            InitializeComponent();
        }
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lbLogRevisarCarpetas.DataSource = ltLogRevisarFicheros;
        }

        private void btCargarFichero_Click(object sender, EventArgs e)
        {
            SelectFicheroOrigen();
        }
        //Lanza el dialogo de Windows para selecionar el fichero 
        //Guardamos los datos en la variable openFicheroDialog
        private void SelectFicheroOrigen()
        {
            var fichero = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                rutaFicheroOrigen = openFileDialog.FileName;
                tbDirectorioOrigen.Text = openFileDialog.FileName;
                openFicheroDialog = openFileDialog;

            }
        }

        private void btGeneraRutas_Click(object sender, EventArgs e)
        {
            GeneraCarpetasFicheros();
        }

        private void GeneraCarpetasFicheros()
        {
            if (tbDirectorioOrigen.Text.Length > 0)
            {


                string textoLinea;
                string SubstringTextoLinea;
                string rutaActual = "";

                using (StreamReader reader = new StreamReader(openFicheroDialog.OpenFile(), Encoding.UTF8))
                {
                    while (reader.Peek() > -1)
                    {
                        textoLinea = reader.ReadLine();
                        //Comprobamos tenemos datos en la linea actual
                        if (textoLinea.Length > 0 && textoLinea != "")
                        {
                            //Comprobamos el inicio del la linea para saber si es fichero o ruta
                            SubstringTextoLinea = textoLinea.Substring(1, 3);
                            if (SubstringTextoLinea == "---")
                            {
                                //es Fichero
                                SubstringTextoLinea = textoLinea.Substring(4, textoLinea.Length - 4);
                                SubstringTextoLinea = SubstringTextoLinea.Replace("\t", "");
                                createFileIsNotExist(SubstringTextoLinea, rutaActual + "/");
                            }
                            else
                            {
                                //es Ruta
                                rutaActual = textoLinea;
                                createFolderIsNotExist(rutaActual + "/");
                            }
                        }
                    }
                    //Cerramos fichero
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan Fichero");
            }
        }
        //Creamos la ruta de carpetas si no existe
        //rutaCarpetas => ruta completa de carpetas
        private void createFolderIsNotExist(string rutaCarpetas)
        {
            bool existe = System.IO.Directory.Exists(rutaCarpetas);
            try
            {
                if (!existe)
                {
                    System.IO.Directory.CreateDirectory(rutaCarpetas);
                    ltLogRevisarFicheros.Add("Creada la ruta " + rutaCarpetas + "  ");
                }
                else
                {
                    ltLogRevisarFicheros.Add("Ya existe la ruta " + rutaCarpetas + "  ");
                }
            }
            catch (DirectoryNotFoundException e)
            {
                ltLogRevisarFicheros.Add("Error creando directorio " + rutaCarpetas);
            }
            catch (Exception e)
            {
                ltLogRevisarFicheros.Add("Error creando directorio " + rutaCarpetas);

            }
        }
        //Creamos el fichero si no existe
        //fichero => nombre y extensión del fichero
        //rutaFichero => ruta de carpetas
        private void createFileIsNotExist(string fichero, string rutaFichero)
        {
            try
            {
                bool existe = File.Exists(rutaFichero + fichero);

                if (!existe)
                {
                    var fichero_resultado = File.AppendText(rutaFichero + fichero);
                    fichero_resultado.Close();
                    ltLogRevisarFicheros.Add("Creada fichero " + fichero);
                }
                else
                {
                    ltLogRevisarFicheros.Add("Ya existe el fichero " + fichero + "  ");
                }
            }
            catch (DirectoryNotFoundException e)
            {
                ltLogRevisarFicheros.Add("Error creando fichero " + fichero);
            }catch(Exception e)
            {
                ltLogRevisarFicheros.Add("Error creando fichero " + fichero);

            }
        }


    }
}
