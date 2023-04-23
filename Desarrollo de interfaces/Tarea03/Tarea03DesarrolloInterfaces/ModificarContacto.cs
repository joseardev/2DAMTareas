using Tarea03DesarrolloInterfaces.Clases;

namespace Tarea03DesarrolloInterfaces
{
    public partial class ModificarContacto : Form
    {
        public ModificarContacto()
        {
            InitializeComponent();
        }
        //Constructor recibe usuario y asigna valores a la vista del usuario recibido
        public ModificarContacto(Usuario usuarioSelecionado)
        {

            InitializeComponent();
            //Mostramos los datos selecionados 
            tbNombre.Text = usuarioSelecionado.Nombre;
            tbApellidos.Text = usuarioSelecionado.Apellidos;
            tbTelefono.Text = usuarioSelecionado.Telefono + "";
            tbDNI.Text = usuarioSelecionado.Dni;
            tbSexo.Text = usuarioSelecionado.Sexo;
            cbEstudios.Text = usuarioSelecionado.NivelEstudios;
            cbLudopatia.Text = usuarioSelecionado.Vicios;
            tbDNI.Enabled = false;

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
        }
        private void ModificarUsuario()
        {
            try
            {
                if (tbNombre.Text != ""
                    && tbDNI.Text != ""
                    && tbNombre.Text != ""
                    && tbApellidos.Text != ""
                    && tbTelefono.Text != ""
                    && tbSexo.Text != ""
                    && cbEstudios.Text != ""
                    && cbLudopatia.Text != "")
                {
                    //borramos contacto de la lista usando la instancia del Padre
                    var formOwner = (Contactos)this.Owner;
                    //Obtenemos posición del Usuario selecionado
                    var contectoActual = formOwner.listPlazas.SingleOrDefault(contacto => contacto.Dni == tbDNI.Text);

                    bool isNumber = int.TryParse(tbTelefono.Text, out var telefono);
                    //creamos usuario y lo añadimos
                    if (isNumber)
                    {
                        //Generamos usuario nuevo y machacamos el actual
                        formOwner.listPlazas.Remove(contectoActual);
                        Usuario usuario = new Usuario(tbNombre.Text, tbApellidos.Text, telefono, tbDNI.Text, tbSexo.Text, cbEstudios.Text, cbLudopatia.Text);
                        formOwner.listPlazas.Add(usuario);
                        this.Close();
                    }
                    else
                    {
                        mensajeEmergente("Telefono incorrecto", "Error Datos");
                    }
                }
                else
                {
                    mensajeEmergente("Faltan datos", "Error Datos");
                }
            }
            catch (Exception)
            {
                mensajeEmergenteError("Error", "Error Datos");
            }
        }
        private void mensajeEmergente(string mensaje, string texto_ventana)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(mensaje, texto_ventana, buttons);
        }
        private void mensajeEmergenteError(string mensaje, string texto_ventana)
        {
            // Displays the MessageBox.
            MessageBox.Show(mensaje, texto_ventana);
        }
    }
}
