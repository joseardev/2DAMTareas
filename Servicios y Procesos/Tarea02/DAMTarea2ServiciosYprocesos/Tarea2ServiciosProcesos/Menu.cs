using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2ServiciosProcesos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void brCaballos_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
        }
    }
}
