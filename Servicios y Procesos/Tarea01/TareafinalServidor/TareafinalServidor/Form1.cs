using System.IO.Pipes;
using System.Text;

namespace TareafinalServidor
{
    public partial class Servidor : Form
    {
        string mensajeRecibidoAsync = "";
        string EstadoServidorAsync = "";
        public Servidor()
        {
            InitializeComponent();
        }

        private void btActivar_Click(object sender, EventArgs e)
        {
            IniciarServidorPipe();
        }
        private void IniciarServidorPipe()
        {

            try
            { // Creación del servidor:
                NamedPipeServerStream servidor = new NamedPipeServerStream("servidor");
                // A espera de conexiones:
                bool apagar = true;
                while (apagar)
                {
                    servidor.WaitForConnection();
                    //Esperando cliente
                    byte[] buffer = new byte[255];
                    servidor.Read(buffer, 0, 255);
                    //Dato recibido
                    string recibido = ASCIIEncoding.ASCII.GetString(buffer);

                    lbRecibidos.Items.Add(recibido);
                    Refresh();
                    servidor.Disconnect();
                    //apagar = false;
                }

                // Cierra el servidor:
                servidor.Close();
            }
            catch (Exception e)
            {
                txtStatusServer.Text = "Server Error";
                txtStatusServer.BackColor = Color.Red;
            }
        }
        private void btEnviar_Click(object sender, EventArgs e)
        {
            IniciarClientePipe();
        }

        private void IniciarClientePipe()
        {
            bool apagar = true;
            try
            {
                while (apagar)
                {
                    // Creación del cliente:
                    NamedPipeClientStream cliente = new NamedPipeClientStream("servidor_cliente");
                    // Conexión con el servidor:
                    cliente.Connect(60);
                    txtStatusServer.Text = "Conectado";
                    txtStatusServer.BackColor = Color.Green;

                    // Recepción de datos:
                    byte[] buffer = ASCIIEncoding.ASCII.GetBytes(txtMensaje.Text);
                    cliente.Write(buffer, 0, buffer.Length);
                    // Cierre del cliente:
                    cliente.Close();
                    apagar = false;
                }
            }
            catch (TimeoutException e)
            {
                //En caso de que el servidor no este en escucha
                txtStatusServer.Text = "Server off";
                txtStatusServer.BackColor = Color.Red;
            }
        }

        private void btActivaServidorAsync_Click(object sender, EventArgs e)
        {
            setupAsync();

        }

        private async void setupAsync()
        {
            //Lanzamos funcion en asincrono
            await cargarServidorAsync();

            //Actualizar listbox
            actualizaUI();
        }



        private Task cargarServidorAsync()
        {
            return Task.Run(() =>
            {
                IniciarServidorPipeAsync();
            });
        }


        private void IniciarServidorPipeAsync()
        {

            try
            {// Creación del servidor:

                NamedPipeServerStream servidor = new NamedPipeServerStream("servidor");
                //Esperando cliente
                servidor.WaitForConnection();

                // Recepción de datos:
                byte[] buffer = new byte[255];
                servidor.Read(buffer, 0, 255);
                mensajeRecibidoAsync = ASCIIEncoding.ASCII.GetString(buffer);

                servidor.Disconnect();
                servidor.Close();
            }
            catch (AggregateException)
            {
                Console.WriteLine("Connection failed.");
            }

            // return recibido;
        }


        private void actualizaUI()
        {
            lbRecibidos.Items.Add(mensajeRecibidoAsync);
            setupAsync();
        }


    }
}