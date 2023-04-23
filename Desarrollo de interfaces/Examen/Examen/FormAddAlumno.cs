using Examen.Clases;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FormAddAlumno : Form
    {
        
             
        public FormAddAlumno()
        {
            InitializeComponent();
        }

        private void btAddAlumnoNuevo_Click(object sender, EventArgs e)
        {

            var isNumber = float.TryParse(tbNotaMedia.Text, out float notaMedia);

            if (tbNombreAlumno.Text.Length > 0 && tbApellidosAlumno.Text.Length > 0 && tbDniAlumno.Text.Length > 0 && dtFechaNacimiento.Text.Length > 0 && cbCursos.Text.Length > 0)
            {
                if (dtFechaNacimiento.Value < DateTime.Now)
                {
                    if (isNumber)
                    {
                        Alumno alumno = new Alumno(tbNombreAlumno.Text, tbApellidosAlumno.Text, tbDniAlumno.Text, dtFechaNacimiento.Value, cbCursos.Text, notaMedia);
                        addAlumnoNuevo(alumno);
                    }
                    else
                    {
                        MessageBox.Show("Nota Incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Fecha Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
            
        }

        private void addAlumnoNuevo(Alumno alumno)
        {
            var formOwner = (Main)this.Owner;
            formOwner.addAlumnoNuevo(alumno,(Instituto)cbInstitutos.SelectedItem);
        }

        private void FormAddAlumno_Load(object sender, EventArgs e)
        {
            var formOwner = (Main)this.Owner;
            cbInstitutos.DataSource = formOwner.getListaInstitutos();

        }
    }
}
