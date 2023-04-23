using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Datos : Form
    {
        private List<int> listResultadosTiradas;
        BindingList<string> listResultados = new BindingList<string>();
        private static readonly object value = 5;

        int[] resultadosRepetidos = new int[7];
        public Datos()
        {
            InitializeComponent();
        }

        public Datos(List<int> listResultadosTiradas)
        {
            InitializeComponent();
            lbResultados.DataSource = listResultados;
            this.listResultadosTiradas = listResultadosTiradas;
            recorrerArrayDados();

        }
        private void recorrerArrayDados()
        {
            try
            {
                foreach (var item in listResultadosTiradas)
                {
                    listResultados.Add("" + item);
                    calculaDuplicados(1, item);
                    calculaDuplicados(2, item);
                    calculaDuplicados(3, item);
                    calculaDuplicados(4, item);
                    calculaDuplicados(5, item);
                    calculaDuplicados(6, item);
                }
                tbDado1.Text = "" + resultadosRepetidos[1];
                tbDado2.Text = "" + resultadosRepetidos[2];
                tbDado3.Text = "" + resultadosRepetidos[3];
                tbDado4.Text = "" + resultadosRepetidos[4];
                tbDado5.Text = "" + resultadosRepetidos[5];
                tbDado6.Text = "" + resultadosRepetidos[6];
                sumaTiradas();
            }
            catch (Exception)
            {
                mensajeEmergenteError("Error", "Error Datos");
            }
        }
        private void calculaDuplicados(int numeroDuplicado, int numeroLista)
        {
            try
            {
                int actual = resultadosRepetidos[numeroDuplicado];

                if (numeroDuplicado == numeroLista)
                {
                    resultadosRepetidos[numeroDuplicado] = resultadosRepetidos[numeroDuplicado] + 1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                resultadosRepetidos[numeroDuplicado] = 0;
            }

        }

        private void sumaTiradas()
        {
            int suma = 0;
            int numero = 0;
            try
            {
                for (int i = 0; i < resultadosRepetidos.Length; i++)
                {
                    suma = suma + (resultadosRepetidos[i] * i);

                    if (resultadosRepetidos[i] > numero)
                    {
                        numero = i;
                    }
                }
                tbSuma.Text = "" + suma;
                tbTiradaFrecuente.Text = "" + numero;
            }
            catch (ArgumentOutOfRangeException)
            {
                suma = 0;
                numero = 0;
            }
        }

        private void mensajeEmergenteError(string mensaje, string texto_ventana)
        {
            // Displays the MessageBox.
            MessageBox.Show(mensaje, texto_ventana);
        }
    }
}
