using System.IO.Pipes;
using System.Text;

namespace TareafinalCliente
{
    public partial class Form1 : Form
    {
        string mensajeRecibidoAsync = "";
        string EstadoServidorAsync = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            IniciarClientePipe();
        }
        private void btActivar_Click(object sender, EventArgs e)
        {
            IniciarServidorPipe();
        }
        private void IniciarServidorPipe()
        {
            try
            {
                // Creación del servidor:
                NamedPipeServerStream servidor = new NamedPipeServerStream("servidor_cliente");
                // A espera de conexiones:
                bool apagar = true;
                while (apagar)
                {
                    //Esperamos cliente
                    servidor.WaitForConnection();

                    //recepcion de datos
                    byte[] buffer = new byte[255];
                    servidor.Read(buffer, 0, buffer.Length);
                    string recibido = ASCIIEncoding.ASCII.GetString(buffer);

                    // Recepción de datos:               
                    lbRecibidos.Items.Add(recibido);
                    Refresh();
                    servidor.Disconnect();

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


        private void IniciarClientePipe()
        {
            bool apagar = true;
            try
            {
                while (apagar)
                {
                    // Creación del cliente:
                    NamedPipeClientStream cliente = new NamedPipeClientStream("servidor");
                    // Conexión con el servidor:
                    cliente.Connect(60);
                    txtStatusServer.Text = "Conectado";
                    txtStatusServer.BackColor = Color.Green;

                    byte[] buffer = ASCIIEncoding.ASCII.GetBytes(txtMensaje.Text);

                    // Recepción de datos:
                    cliente.Write(buffer, 0, buffer.Length);

                    // Cierre del cliente:
                    cliente.Close();
                    apagar = false;
                }

            }
            catch (Exception e)
            {
                txtStatusServer.Text = "Server off";
                txtStatusServer.BackColor = Color.Red;
            }
        }
        private void IniciarClientePipeAsyc()
        {
            bool apagar = true;
            try
            {
                while (apagar)
                {
                    // Creación del cliente:
                    NamedPipeClientStream cliente = new NamedPipeClientStream("servidor");
                    // Conexión con el servidor:
                    cliente.Connect(60);
                    txtStatusServer.Text = "Conectado";
                    txtStatusServer.BackColor = Color.Green;

                    // envío y recepción de datos:                 

                    byte[] buffer = ASCIIEncoding.ASCII.GetBytes(txtMensaje.Text);

                    // Recepción de datos:
                    cliente.Write(buffer, 0, buffer.Length);

                    // Cierre del cliente:
                    cliente.Close();
                    apagar = false;
                }

            }
            catch (Exception e)
            {
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

        private void btEnviarAsync_Click(object sender, EventArgs e)
        {
            IniciarServidorPipeAsync();
        }

        private void IniciarServidorPipeAsync()
        {
            try
            {
                // Creación del servidor:
                NamedPipeServerStream servidor = new NamedPipeServerStream("servidor_cliente");
                EstadoServidorAsync = "Listo";
                //actualizaUI();
                servidor.WaitForConnection();
                // envío y recepción de datos:                 
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

        }


        private void actualizaUI()
        {
            lbRecibidos.Items.Add(mensajeRecibidoAsync);
            setupAsync();
        }


    }
}