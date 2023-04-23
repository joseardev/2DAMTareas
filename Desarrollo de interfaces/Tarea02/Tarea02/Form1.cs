using Tarea02.Clases;

namespace Tarea02
{
    public partial class Form1 : Form
    {
        List<Alumno> listAlumnosTotales = new List<Alumno>();
        List<Alumno> listAlumnosAsistencia = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btagregarAlumno_Click(object sender, EventArgs e)
        {
            agregarAlumnmo();
        }

        private void agregarAlumnmo()
        {
            //Creamos el objecto Alumno
            Alumno alumno = new Alumno(tbNombre.Text, tbApellidos.Text, tbDni.Text, cbCurso.Text);
            //Comprobamos si existe dni
            Alumno mismoDni = listAlumnosTotales.Find(x => x.dni == alumno.dni);

            if (mismoDni != null)
            {
                //existe dni
                string message = "El dni ya existe";
                string caption = "Error datos alumno";
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
            else
            {
                //se añade alumno listbox y lista Totales
                lbTotalAlumno.DisplayMember = "nombre";
                lbTotalAlumno.ValueMember = "dni";
                listAlumnosTotales.Add(alumno);
                lbTotalAlumno.Items.Add(alumno);

                //Se añadio nuevo alumno -> movemos los alumnos de asistencia a Alumnos Totales
                foreach (var alumnoArr in listAlumnosAsistencia)
                {
                    lbTotalAlumno.DisplayMember = "nombre";
                    lbTotalAlumno.ValueMember = "dni";
                    lbTotalAlumno.Items.Add(alumnoArr);
                    listAlumnosTotales.Add(alumnoArr);
                }
                //Limpiamos Asistencia
                listAlumnosAsistencia.Clear();
                lbAlumnosAsistentes.Items.Clear();
            }
        }

        private void btMueveUnoTotalAlumnos_Click(object sender, EventArgs e)
        {
            mueveTotalAlumnoToAsistente();
        }
        private void mueveTotalAlumnoToAsistente()
        {
            //Obtenemos Alumno seleccionado listbox
            Alumno selectedItem = (Alumno)lbTotalAlumno.SelectedItem;
            //Obtenemos posicion listbox
            var posicion = lbTotalAlumno.SelectedIndex;

            if (selectedItem != null)
            {
                var alumnoActual = listAlumnosTotales.SingleOrDefault(x => x.dni == selectedItem.dni);
                //borrar object en la lista
                listAlumnosTotales.Remove(alumnoActual);
                //Añadir object en la lista
                listAlumnosAsistencia.Add(selectedItem);

                lbTotalAlumno.Items.RemoveAt(posicion);
                lbAlumnosAsistentes.DisplayMember = "nombre";
                lbAlumnosAsistentes.ValueMember = "dni";
                lbAlumnosAsistentes.Items.Add(selectedItem);
            }
        }
        private void btMueveUnAsistente_Click(object sender, EventArgs e)
        {
            mueveAsistenteToAlumnoTotales();
        }
        private void mueveAsistenteToAlumnoTotales()
        {
            //recogemos valor de alumno de la lb           
            Alumno selectedItem = (Alumno)lbAlumnosAsistentes.SelectedItem;
            var posicion = lbAlumnosAsistentes.SelectedIndex;

            //si existe 
            if (selectedItem != null)
            {
                //recogemos alumno de la lista
                var alumnoActual = listAlumnosAsistencia.SingleOrDefault(x => x.dni == selectedItem.dni);
                //borramos alumno
                listAlumnosAsistencia.Remove(alumnoActual);
                //Añadimos nuevo alumno
                listAlumnosTotales.Add(selectedItem);
                lbAlumnosAsistentes.Items.RemoveAt(posicion);

                lbTotalAlumno.DisplayMember = "nombre";
                lbTotalAlumno.ValueMember = "dni";
                lbTotalAlumno.Items.Add(selectedItem);
            }
        }
        private void btMueveTodosTotalAlumnos_Click(object sender, EventArgs e)
        {
            moverAlumnosTotales();
        }

        private void moverAlumnosTotales()
        {
            //mover alumnos de listaAlumnostotales a Asistentes
            foreach (var alumno in listAlumnosTotales)
            {
                lbAlumnosAsistentes.DisplayMember = "nombre";
                lbAlumnosAsistentes.ValueMember = "dni";
                lbAlumnosAsistentes.Items.Add(alumno);
                listAlumnosAsistencia.Add(alumno);
            }
            listAlumnosTotales.Clear();
            lbTotalAlumno.Items.Clear();
        }

        private void btMueveTodosAsistente_Click(object sender, EventArgs e)
        {
            moverAlumnosAsistencia();
        }
        private void moverAlumnosAsistencia()
        {
            //mover alumnos de listAlumnosAsistencia a Totales
            foreach (var alumno in listAlumnosAsistencia)
            {
                lbTotalAlumno.DisplayMember = "nombre";
                lbTotalAlumno.ValueMember = "dni";
                lbTotalAlumno.Items.Add(alumno);
                listAlumnosTotales.Add(alumno);

            }
            listAlumnosAsistencia.Clear();
            lbAlumnosAsistentes.Items.Clear();
        }


        private void btFinalizarAsistencia_Click(object sender, EventArgs e)
        {
            finalizarAsistencia();
        }
        private void finalizarAsistencia()
        {
            //Mostramos historico
            string historico = "El día " + dtFechaAsistencia.Value
               + " vinieron " + listAlumnosAsistencia.Count
               + " alumnos a clase y hubo "
               + (listAlumnosTotales.Count - listAlumnosAsistencia.Count) + " ausencias";
            lbHistorico.Items.Add(historico);

            //Vaciamos alumnosAsistencia
            foreach (var alumno in listAlumnosAsistencia)
            {
                lbTotalAlumno.DisplayMember = "nombre";
                lbTotalAlumno.ValueMember = "dni";
                lbTotalAlumno.Items.Add(alumno);
                listAlumnosTotales.Add(alumno);
            }
            listAlumnosAsistencia.Clear();
            lbAlumnosAsistentes.Items.Clear();
        }
    }
}