using System.ComponentModel;
using Tarea03DesarrolloInterfaces.Clases;

namespace Tarea03DesarrolloInterfaces
{
    public partial class Contactos : Form
    {
        public BindingList<Usuario> listPlazas = new BindingList<Usuario>();
        public string? dniAmodificar;

        Usuario usuarioPruebas = new Usuario("Jose", "Alonso", 662054444, "35222225D", "M", "ESO", "Tabaco");

        public Contactos()
        {
            InitializeComponent();
            setupContactos();
        }
        //Cargamos lista y campo  obj a mostrar
        public void setupContactos()
        {
            lbContactos.DisplayMember = "nombre";
            lbContactos.DataSource = listPlazas;
            listPlazas.Add(usuarioPruebas);
        }

        private void btModificarContacto_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos usuario selecionado
                Usuario usuarioSelecionado = (Usuario)lbContactos.SelectedItem;
                if (usuarioSelecionado != null)
                {
                    //Llamada formulario modificar Usuario
                    ModificarContacto formModificarContacto = new ModificarContacto(usuarioSelecionado);
                    formModificarContacto.Owner = this;
                    formModificarContacto.ShowDialog();
                }
            }
            catch (NullReferenceException)
            {
                mensajeEmergenteError("Error datos", "ERROR");
            }
        }

        private void btAddContacto_Click(object sender, EventArgs e)
        {
            //Llamada formulario añadir contacto
            AddContacto formAddContacto = new AddContacto();
            formAddContacto.Owner = this;
            formAddContacto.ShowDialog();
        }

        private void btBorrarContacto_Click_1(object sender, EventArgs e)
        {
            //Obtenemos usuario selecionado
            Usuario usuarioSelecionado = (Usuario)lbContactos.SelectedItem;
            if (usuarioSelecionado != null)
            {
                //Llamada formulario borrar contacto
                BorrarContacto formBorrarContacto = new BorrarContacto(usuarioSelecionado);
                formBorrarContacto.Owner = this;
                formBorrarContacto.ShowDialog();
            }
        }
        private void mensajeEmergenteError(string mensaje, string texto_ventana)
        {
            // Displays the MessageBox.
            MessageBox.Show(mensaje, texto_ventana);
        }
    }
}