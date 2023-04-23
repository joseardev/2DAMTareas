using Tarea03DesarrolloInterfaces.Clases;

namespace Tarea03DesarrolloInterfaces
{
    public partial class BorrarContacto : Form
    {
        Usuario usuarioSelecionado;
        public BorrarContacto()
        {
            InitializeComponent();
        }

        //Constructor recibe usuario y asigna valores a la vista del usuario recibido
        public BorrarContacto(Usuario usuarioSelecionado)
        {
            InitializeComponent();
            this.usuarioSelecionado = usuarioSelecionado;
            tbNombre.Text = usuarioSelecionado.Nombre;
            tbApellidos.Text = usuarioSelecionado.Apellidos;
            tbTelefono.Text = usuarioSelecionado.Telefono + "";
            tbDni.Text = usuarioSelecionado.Dni;
            tbSexo.Text = usuarioSelecionado.Sexo;
            cbEstudios.Text = usuarioSelecionado.NivelEstudios;
            cbLudopatia.Text = usuarioSelecionado.Vicios;
            tbDni.Enabled = false;
        }

        private void btBorrarContacto_Click(object sender, EventArgs e)
        {
            BorrarUsuario();
            this.Close();
        }
        private void BorrarUsuario()
        {
            //borramos contacto de la lista usando la instancia del Padre
            var formOwner = (Contactos)this.Owner;
            formOwner.listPlazas.Remove(usuarioSelecionado);
        }
    }
}
