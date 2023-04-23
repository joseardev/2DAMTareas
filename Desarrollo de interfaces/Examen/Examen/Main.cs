using Examen.Clases;
using System.ComponentModel;

namespace Examen
{
    public partial class Main : Form
    {
        Instituto instituto_principal = new Instituto("Montecastelo","Vigo",0);
        Instituto instituto_primaria = new Instituto("Pazo da merce", "Vigo", 0);
        Instituto instituto_eso = new Instituto("Daniel castelao", "Vigo", 0);

        Alumno AlummnoPorDefecto1 = new Alumno("Jose", "Alonso", "35585183C", DateTime.Today, "1DAM", 5);
        Alumno AlummnoPorDefecto2 = new Alumno("luis", "Perez", "35585183A", DateTime.Today, "2DAM", 6);
        Alumno AlummnoPorDefecto3 = new Alumno("Ismael", "Fernandez", "35585183B", DateTime.Today, "1DAM", 7);

        Alumno AlummnoPorDefecto4 = new Alumno("Jesus", "Besteiro", "35585183P", DateTime.Today, "2DAM", 4);
        Alumno AlummnoPorDefecto5 = new Alumno("David", "Alonso", "35585183D", DateTime.Today, "1DAM", 2);
        Alumno AlummnoPorDefecto6 = new Alumno("Alex", "Alonso", "35585183H", DateTime.Today, "3DAM", 8);

        Alumno AlummnoPorDefecto7 = new Alumno("Esther", "Casquero", "35585183L", DateTime.Today, "5DAM", 6);
        Alumno AlummnoPorDefecto8 = new Alumno("Sebas", "Alonso", "35585183I", DateTime.Today, "6DAM", 7);
        Alumno AlummnoPorDefecto9 = new Alumno("Alberto", "Gonzalez", "35585183X", DateTime.Today, "1DAM", 6);


        private BindingList<Instituto> listaInstitutos = new BindingList<Instituto>();


        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //Cargamos los institutos que tendremos por defecto y los alumnos
            instituto_principal.addNuevoAlumno(AlummnoPorDefecto1);
            instituto_principal.addNuevoAlumno(AlummnoPorDefecto2);
            instituto_principal.addNuevoAlumno(AlummnoPorDefecto3);

            //Segundo instituto
            instituto_primaria.addNuevoAlumno(AlummnoPorDefecto4);
            instituto_primaria.addNuevoAlumno(AlummnoPorDefecto5);
            instituto_primaria.addNuevoAlumno(AlummnoPorDefecto6);
            //tercer instituto
            instituto_eso.addNuevoAlumno(AlummnoPorDefecto7);
            instituto_eso.addNuevoAlumno(AlummnoPorDefecto8);
            instituto_eso.addNuevoAlumno(AlummnoPorDefecto9);

            //añadimos los institutos a la lista
            listaInstitutos.Add(instituto_principal);
            listaInstitutos.Add(instituto_primaria);
            listaInstitutos.Add(instituto_eso);


        }
        private void btAddAlumno_Click(object sender, EventArgs e)
        {
            FormAddAlumno formAddAlumno = new FormAddAlumno();
            formAddAlumno.Owner = this;
            formAddAlumno.ShowDialog();
        }

        private void btAddInstituto_Click(object sender, EventArgs e)
        {
            FormAddInstituto formAddInstituto = new FormAddInstituto();
            formAddInstituto.Owner = this;
            formAddInstituto.ShowDialog();
        }
        private void btBuscarAlumno_Click(object sender, EventArgs e)
        {
            FormBuscarAlumno formBuscarAlumno = new FormBuscarAlumno();
            formBuscarAlumno.Owner = this;
            formBuscarAlumno.ShowDialog();
        }

        public void addAlumnoNuevo(Alumno alumno, Instituto instituto)
        {
            foreach (var intitutoLista in listaInstitutos)
            {
                if(intitutoLista.Nombre == instituto.Nombre)
                {
                    intitutoLista.addNuevoAlumno(alumno);
                    MessageBox.Show("Alumno añadido");
                };
            }
        }

        public BindingList<Instituto> getListaInstitutos()
        {
            return listaInstitutos;
        }

        public void addInstitutoNuevo(Instituto instituto)
        {
            listaInstitutos.Add(instituto);
            MessageBox.Show("instituto añadido");
        }

        public BindingList<Alumno> GetListaAlumnosFromInstituto(string Nombreinstituto)
        {
            var institutoExiste = listaInstitutos.SingleOrDefault(peli => peli.Nombre == Nombreinstituto);
            if (institutoExiste != null)
            {
                return institutoExiste.ListaAlumnos;
            }
            return null;

        }

        public BindingList<Alumno> buscarAlumnoPorDni(string dniAlumno)
        {
            BindingList<Alumno> alumnoActual = new BindingList<Alumno>();
            //BindinAlumno alumno = new Alumno();
            foreach (var intitutoLista in listaInstitutos)
            {
                foreach (var alumnoLista in intitutoLista.ListaAlumnos)
                {
                    if(alumnoLista.Dni == dniAlumno)
                    {
                        //alumno = alumnoLista;
                        alumnoActual.Add(alumnoLista);
                    }
                }

            }
            return alumnoActual;
        }

        public void modificarDatosAlumno(Alumno alumno)
        {
            foreach (var intitutoLista in listaInstitutos)
            {
                foreach (var alumnoLista in intitutoLista.ListaAlumnos)
                {
                    if (alumnoLista.Dni == alumno.Dni)
                    {
                        intitutoLista.ListaAlumnos.Remove(alumnoLista);
                        intitutoLista.ListaAlumnos.Add(alumno);
                        MessageBox.Show("Alumno modificado");
                        break;
                    }
                }

            }
        }
        public void borrarAlumno(Alumno alumno)
        {
            foreach (var intitutoLista in listaInstitutos)
            {
                foreach (var alumnoLista in intitutoLista.ListaAlumnos)
                {
                    if (alumnoLista.Dni == alumno.Dni)
                    {
                        intitutoLista.ListaAlumnos.Remove(alumnoLista);
                        MessageBox.Show("Alumno borrado");
                        break;
                    }
                }

            }
        }

    }
}