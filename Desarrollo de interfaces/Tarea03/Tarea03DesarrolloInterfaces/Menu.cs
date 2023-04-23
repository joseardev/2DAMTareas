using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Tarea03DesarrolloInterfaces
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btContactos_Click(object sender, EventArgs e)
        {
            Contactos form1 = new Contactos();
            form1.Show();
        }

        private void btDados_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            dados.Show();
        }
    }
}
