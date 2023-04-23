using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db;
            db = new PetaPoco.Database("ConnectionString");
        }

        private void btActores_Click(object sender, EventArgs e)
        {
            FormActores formActores = new FormActores();
            formActores.ShowDialog();
        }

        private void btPeliculas_Click(object sender, EventArgs e)
        {
            FormPeliculas formPeliculas = new FormPeliculas();
            formPeliculas.ShowDialog();
        }
    }
}
