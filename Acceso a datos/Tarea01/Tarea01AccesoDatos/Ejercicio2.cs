using System.Text;

namespace Tarea01AccesoDatos
{
    public partial class Ejercicio2 : Form
    {
        private string rutaFicheroOrigen;        
        private string nombreFicheroOrigen;
        private OpenFileDialog openFicheroDialog;
       
        private string rutaCarpetaDestino;        

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btSelectFicheroOrigen_Click(object sender, EventArgs e)
        {
            SelectFicheroOrigen();
        }
        //Selecionar fichero origen
        private void SelectFicheroOrigen()
        {
            var fichero = string.Empty;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                char resultadoBorra;
                rutaFicheroOrigen = openFileDialog.FileName;
                //var fileStream = openFileDialog.OpenFile();
                openFicheroDialog = openFileDialog;
                nombreFicheroOrigen = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                //fileStreamOrigen = fileStream;

            }
            tbRutaFicheroOrigen.Text = rutaFicheroOrigen;


        }

        private void btSelecionarCarpetaDestino_Click(object sender, EventArgs e)
        {
            SelectCarpetaDestino();
        }

        //Seleciona carpeta destino
        private void SelectCarpetaDestino()
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != null)
                {
                    rutaCarpetaDestino = folderBrowserDialog.SelectedPath;
                    tbCarpetaDestino.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btCopiaFichero_Click(object sender, EventArgs e)
        {
            CopiarFichero();
        }

        //Copiamos fichero
        private void CopiarFichero()
        {
            try
            {
                //Comprobamos no faltan valores
                if (tbCarpetaDestino.Text.Length > 0 && tbRutaFicheroOrigen.Text.Length > 0)
                {

                    var rutaFichero = tbCarpetaDestino.Text + "/" + nombreFicheroOrigen + "_Copia.TXT";
                    char textoLinea;
                    string saltoDeLinea = "\n";
                    string retornoCarro = "\r";
                    string textoActual;
                    string textFinal = "";
                    //abrimos fichero
                    using (StreamReader reader = new StreamReader(openFicheroDialog.OpenFile(), Encoding.UTF8))
                    {
                        while (reader.Peek() > -1)
                        {
                            //leeamos caracter a caracter
                            textoLinea = (Char)reader.Read();
                            //pasamos char a string
                            textoActual = textoLinea.ToString();

                            //Comprobamos si tiene retorno de carro
                            if (retornoCarro.Contains(textoActual))
                            {
                                textoActual = " ";
                            }
                            //comprobamos si es salto de linea
                            if (saltoDeLinea.Contains(textoActual))
                            {
                                GuardarLinea(rutaFichero, textFinal);
                                textFinal = "";
                            }
                            else
                            {
                                //Add nueva linea
                                textFinal = textFinal + textoActual;

                            }
                        }
                        //Guardamos texto
                        GuardarLinea(rutaFichero, textFinal);
                    }
                    MessageBox.Show("Fichero copiado");
                }
                else
                {
                    MessageBox.Show("Faltan datos");
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }


        }
        //Genera linea nuevo o crea el fichero si no existe
        //rutaFichero => ruta del fichero
        //texto => texto nuevo
        private void GuardarLinea(string rutaFichero, string texto)
        {
            try
            {
                StreamWriter fichero;

                if (File.Exists(rutaFichero))
                {
                    fichero = File.AppendText(rutaFichero);
                    fichero.WriteLine(texto);
                    fichero.Close();
                    // MessageBox.Show("Linea añadida");
                }
                else
                {
                    fichero = File.CreateText(rutaFichero);
                    fichero.WriteLine(texto);
                    fichero.Close();
                    //MessageBox.Show("Fichero creado");
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
