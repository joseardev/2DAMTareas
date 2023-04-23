using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea5.Entidades;
using Tarea5.Servicios;
using Tarea5.vistas;

namespace Tarea5
{
    public partial class FormGeneral : Form
    {        
        public FormGeneral()
        {
            InitializeComponent();         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarFormUsuario();            
        }

        private void MostrarFormUsuario()
        {
            pnlUsuario.Controls.Clear();
            FormUsuario viewListCarrera = new FormUsuario();
            viewListCarrera.TopLevel = false;
            viewListCarrera.Dock = DockStyle.Fill;
            //Se add al panel creado
            this.pnlUsuario.Controls.Add(viewListCarrera);
            viewListCarrera.Show();
        }
    }
}
