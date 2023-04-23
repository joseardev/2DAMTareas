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
    public partial class FormModificarEquipo : Form
    {
        public FormModificarEquipo()
        {
            InitializeComponent();
        }

        private void FormModificarEquipo_Load(object sender, EventArgs e)
        {
            var formOwner = (Form1)this.Owner;

            var equipo = formOwner.GetEquipoLista();

            tbCodigoEquipo.Text = equipo.Codigo;
            tbNombreEquipo.Text = equipo.Nombre;
            tbPais.Text = equipo.Pais;
            tbGoles.Text = equipo.Goles.ToString();            

        }

        private void btModificar_Click(object sender, EventArgs e)
        {          
                 
            int golesEquipo;
            bool success = int.TryParse(tbGoles.Text, out golesEquipo);
            if (success)
            {
                var equipo = new Equipo
                {
                    Codigo = tbCodigoEquipo.Text,
                    Nombre = tbNombreEquipo.Text,
                    Pais = tbPais.Text,
                    Goles = golesEquipo,
                    Puntos = 0,
                    PJ = "0",
                    PG = 0,
                    PE = 0,
                    PP = 0                    
                };
                var formOwner = (Form1)this.Owner;
                formOwner.UpdateEquipo(equipo);
                MessageBox.Show("Modificado");
                this.Close();
            }
        }

    }
}
