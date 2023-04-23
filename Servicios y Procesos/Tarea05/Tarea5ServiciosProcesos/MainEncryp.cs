using System.ComponentModel;

namespace Tarea5ServiciosProcesos
{
    public partial class MainEncryp : Form
    {
        BindingList<String> logEncryp = new BindingList<String>();
        //
        private string rutaFicheroOrigen;
        private string rutaCarpetaDestino;

        private string rutaFicheroEncryptado;
        private string rutaCarpetaEncryptadoDestino;

        public MainEncryp()
        {
            InitializeComponent();
            lbLog.DataSource = logEncryp;
        }

        private void btEncryp_Click(object sender, EventArgs e)
        {
            EncryptarFichero();
        }

        private void EncryptarFichero()
        {
            if (tbFicheroSelecionado.Text.Length > 0 && cbTipoEncriptacion.Text.Length > 0 && rutaCarpetaDestino.Length > 0 && tbPasswordEncriptado.Text.Length > 0)
            {
                var resultado = Criptografia.Encryptar(rutaFicheroOrigen, tbCarpetaDestino.Text, cbTipoEncriptacion.Text, tbPasswordEncriptado.Text);
                logEncryp.Add(" Encriptado " + resultado);
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }

        }




        private void btSelecionarFichero_Click(object sender, EventArgs e)
        {
            SelectFicheroOrigen();
        }

        private void SelectFicheroOrigen()
        {
            var fichero = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFicheroOrigen = openFileDialog.FileName;
                tbFicheroSelecionado.Text = openFileDialog.FileName;

            }
        }

        private void btCarpetaDestinoDesencriptar_Click(object sender, EventArgs e)
        {
            SelectCarpetaDestino();
        }
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

        private void btSelecionarFicheroEncriptado_Click(object sender, EventArgs e)
        {
            SelectCarpetaEncriptado();
        }

        private void SelectCarpetaEncriptado()
        {

            var fichero = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                rutaFicheroEncryptado = openFileDialog.FileName;
                tbFicheroEncryptado.Text = openFileDialog.FileName;

            }
        }

        private void btRutaDes_Click(object sender, EventArgs e)
        {
            SelectCarpetaDestinoDes();
        }
        private void SelectCarpetaDestinoDes()
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != null)
                {
                    rutaCarpetaEncryptadoDestino = folderBrowserDialog.SelectedPath;
                    tbRutaDes.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btDesencriptarFichero_Click(object sender, EventArgs e)
        {
            DesEncrypta();
        }
        private void DesEncrypta()
        {
            if (tbRutaDes.Text.Length > 0 && cbTypoDes.Text.Length > 0 && rutaFicheroEncryptado.Length > 0 && tbPasswordDes.Text.Length > 0)
            {
                var resultado = Criptografia.Descryptar(rutaFicheroEncryptado, tbRutaDes.Text, cbTypoDes.Text, tbPasswordDes.Text);
                logEncryp.Add(resultado);
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }

        }

        private void btEncryptarText_Click(object sender, EventArgs e)
        {
            if (tbTextoAEncriptar.Text.Length > 0 && tbClaveEncriptacionTexto.Text.Length > 0 && cbEncriptadoTexto.Text.Length > 0)
            {
                tbTextoEncriptado.Text = Criptografia.EncriptarTexto(tbTextoAEncriptar.Text, tbClaveEncriptacionTexto.Text, cbEncriptadoTexto.Text);
                logEncryp.Add("Resultado encryptado => " + tbTextoEncriptado.Text);
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }

        private void btDesencriptar_Click(object sender, EventArgs e)
        {
            if (tbTextoAEncriptar.Text.Length > 0 && tbClaveEncriptacionTexto.Text.Length > 0 && cbEncriptadoTexto.Text.Length > 0)
            {
                tbTextoEncriptado.Text = Criptografia.DEsEncriptarTexto(tbTextoEncriptado.Text, tbClaveEncriptacionTexto.Text, cbEncriptadoTexto.Text);
                logEncryp.Add("Resultado Desencriptar => " + tbTextoEncriptado.Text);
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }

        }
    }
}