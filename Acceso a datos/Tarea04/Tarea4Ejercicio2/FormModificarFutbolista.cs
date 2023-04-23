using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4Ejercicio2
{
    public partial class FormModificarFutbolista : Form
    {
        public FormModificarFutbolista()
        {
            InitializeComponent();
        }

        private void FormModificarFutbolista_Load(object sender, EventArgs e)
        {
            var formOwner = (Form1)this.Owner;

            //Obtenemos el futbolista 
            var futbolista = formOwner.GetFutbolistaLista();
            
            tbCodigoFut.Text = futbolista.Codigo;
            tbNombre.Text = futbolista.Nombre;
            tbPosicion.Text = futbolista.Posicion;
            tbCodigoEquipo.Text = futbolista.CodigoEquipo;            
        }


        private void btModificarFutbolista_Click(object sender, EventArgs e)
        {
            var futbolista = new Futbolista
            {
                Codigo = tbCodigoFut.Text,
                Nombre = tbNombre.Text,
                CodigoEquipo = tbCodigoEquipo.Text,
                Posicion = tbPosicion.Text,
                Edad = 0,
                Goles = 0,
                TA = 0,
                TR = 0,
                Minutos = 0,
                PrecioMercado = "",
                Dorsal = 0,
                Peso = 0
            };

            var formOwner = (Form1)this.Owner;            
            formOwner.ModificarFutbolista(futbolista);
            this.Close();
        }

    }
}
