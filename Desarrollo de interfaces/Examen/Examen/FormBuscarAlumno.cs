using Examen.Clases;
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
    public partial class FormBuscarAlumno : Form
    {
        public FormBuscarAlumno()
        {
            InitializeComponent();
        }

        private void btBuscarInstituto_Click(object sender, EventArgs e)
        {

            getListaAlumnosPorInstituto();
        }

        private void FormBuscarAlumno_Load(object sender, EventArgs e)
        {
            var formOwner = (Main)this.Owner;
            cbNombreInstitutos.DataSource = formOwner.getListaInstitutos();

        }
        private void getListaAlumnosPorInstituto()
        {
            var formOwner = (Main)this.Owner;
            formOwner.GetListaAlumnosFromInstituto(cbNombreInstitutos.Text);
            ListaAlumnosInstituto.DataSource = formOwner.GetListaAlumnosFromInstituto(cbNombreInstitutos.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formOwner = (Main)this.Owner;
            ListaAlumnosInstituto.DataSource = formOwner.buscarAlumnoPorDni(tbDni.Text);

           

        }

       
        private void btModificarAlumno_Click(object sender, EventArgs e)
        {
            modificarAlumno();


        }
        private void modificarAlumno()
        {
            var isNumber = float.TryParse(tbNotaMedia.Text, out float notaMedia);

            if (tbNombreAlumno.Text.Length > 0 && tbApellidos.Text.Length > 0 && tbDniAlumno.Text.Length > 0 && dtFechaNacimiento.Text.Length > 0 && tbCurso.Text.Length > 0)
            {
                if (dtFechaNacimiento.Value < DateTime.Now)
                {
                    if (isNumber)
                    {
                        Alumno alumno = new Alumno(tbNombreAlumno.Text, tbApellidos.Text, tbDniAlumno.Text, dtFechaNacimiento.Value, tbCurso.Text, notaMedia);
                        modificarAlumnoSelecionado(alumno);
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


        private void modificarAlumnoSelecionado(Alumno alumno)
        {
            var formOwner = (Main)this.Owner;
            formOwner.modificarDatosAlumno(alumno);
        }

        private void ListaAlumnosInstituto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alumno = (Alumno)ListaAlumnosInstituto.SelectedItem;
           tbNombreAlumno.Text = alumno.Nombre;
           tbApellidos.Text = alumno.Apellidos;
           tbDniAlumno.Text = alumno.Dni;
           tbDniAlumno.Enabled = false;
           dtFechaNacimiento.Value = alumno.FechaNacimiento;
           tbCurso.Text = alumno.Cursos;
           tbNotaMedia.Text = alumno.NotaMedia.ToString();
           
        }

        private void ListaAlumnosInstituto_DoubleClick(object sender, EventArgs e)
        {
            var alumno = (Alumno)ListaAlumnosInstituto.SelectedItem;

            MessageBox.Show(alumno.ToString());
        }

        private void btBorrarAlumno_Click(object sender, EventArgs e)
        {
            var alumno = (Alumno)ListaAlumnosInstituto.SelectedItem;
            var formOwner = (Main)this.Owner;
           
            DialogResult boton = MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                formOwner.borrarAlumno(alumno);
            }
            


        }
    }
}
