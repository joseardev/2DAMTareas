using Tarea03DesarrolloInterfaces.Clases;

namespace Tarea03DesarrolloInterfaces
{
    public partial class AddContacto : Form
    {
        public AddContacto()
        {
            InitializeComponent();
        }
        private void btAddUsuario_Click(object sender, EventArgs e)
        {
            AddUsuarioNuevo();

        }
        private void AddUsuarioNuevo()
        {
            //instaciamos formulario padre para poder aceder a los elementos publicos del mismo
            try
            {
                var formOwner = (Contactos)this.Owner;

                if (tbNombre.Text != ""
                    && tbDni.Text != ""
                    && tbNombre.Text != ""
                    && tbApellidos.Text != ""
                    && tbTelefono.Text != ""
                    && tbSexo.Text != ""
                    && cbEstudios.Text != ""
                    && cbLudopatia.Text != "")
                {
                    //Si tenemos DNI => Comprobamos si ya existe en la lista
                    var contactoActual = formOwner.listPlazas.SingleOrDefault(contacto => contacto.Dni == tbDni.Text);
                    if (contactoActual == null)
                    {
                        bool isNumber = int.TryParse(tbTelefono.Text, out var telefono);
                        //creamos usuario y lo añadimos
                        if (isNumber)
                        {
                            Usuario usuario = new Usuario(tbNombre.Text, tbApellidos.Text, telefono, tbDni.Text, tbSexo.Text, cbEstudios.Text, cbLudopatia.Text);
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
                        mensajeEmergente("Ya existe el DNI", "Error Datos");
                    }
                }
                else
                {
                    mensajeEmergente("Faltan Datos", "Error Datos");
                }
            }
            catch (Exception)
            {
                mensajeEmergenteError("Error", "Error Datos");
            }
        }
        //permite enviar Mensaje emergentes
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
