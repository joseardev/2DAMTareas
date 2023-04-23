using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dados : Form
    {
        Random random = new Random();

        List<int> listResultadosTiradas = new List<int>();

        public Dados()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"dados\dado.gif");
                            ///pictureBox2.Image = Image.FromFile(@"dados\dado.gif");
        }

        private void btTirarDado_Click(object sender, EventArgs e)
        {
            var resultado = random.Next(1, 6);
            listResultadosTiradas.Add(resultado);
            mostrarDado(pictureBox1, resultado);
        }

        private void btResultados_Click(object sender, EventArgs e)
        {

            Datos form = new Datos(listResultadosTiradas);
              form.Show();
        }
       
        private void mostrarDado(PictureBox pictureBox, int resultadoTirada)
        {

            if (resultadoTirada == 1)
            {
                pictureBox.Image = Image.FromFile(@"dados\dado1.png");

            }
            else if (resultadoTirada == 2)
            {
                pictureBox.Image = Image.FromFile(@"dados\dado2.png");

            }
            else if (resultadoTirada == 3)
            {
                pictureBox.Image = Image.FromFile(@"dados\dado3.png");

            }
            else if (resultadoTirada == 4)
            {
                pictureBox.Image = Image.FromFile(@"dados\dado4.png");

            }
            else if (resultadoTirada == 5)
            {
                pictureBox.Image = Image.FromFile(@"dados\dado5.png");

            }
            else if (resultadoTirada == 6)
            {
                pictureBox.Image = Image.FromFile(@"dados\dado6.png");
            }

        }
    }
}