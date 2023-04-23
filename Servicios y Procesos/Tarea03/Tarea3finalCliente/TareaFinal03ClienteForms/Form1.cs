using System.Text;

namespace TareaFinal03ClienteForms
{
    public partial class Form1 : Form
    {
        private string matricula;
        delegate void delegado();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            tbMensajeCliente.Enabled = false;
            tbPrecioParking.Visible = false;
            tbSalir.Visible = false;
            btPagar.Visible = false;
            btSalir.Visible = false;
            generaMatricula();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            matricula = tbMensajeCliente.Text;
            enviarMensaje();
        }
        /// 
        /// Envia mensaje al cliente y muestra respuesta
        /// 
        private void enviarMensaje()
        {
            string mensaje;
            try
            {
                if (tbMensajeCliente.Text != "")
                {
                    //Necesitamos usar la matricula como id
                    mensaje = getIdCliente();
                    string respuesta = ConsoleApp1.Cliente.EnviarMensajeCliente(mensaje, 11000);
                    //Mostramos respuesta server
                    lbLogMensajes.Items.Add(respuesta);
                    //
                    CompruebaRespuesta(respuesta);
                }
                else
                {
                    string message = "Matricula incorrecta";
                    string caption = "Datos incorrectos";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
            catch (Exception)
            {
                string message = "Parking cerrado";
                string caption = "ERROR";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

            }
        }
        //Comprobamos las diferentes respuestas que nos puede mandar el servidor
        // mensaje => Respuesta  cliente
        private void CompruebaRespuesta(string mensaje)
        {
            string claveMensaje = mensaje.Substring(0, 7);
            string respuestaServer = mensaje.Substring(7);

            if (claveMensaje == "PRECIO:")
            {
                tbPrecioParking.Visible = true;
                btPagar.Visible = true;
                tbPrecioParking.Text = respuestaServer;
            }
            else if (claveMensaje == "Aparcad")
            {
                btSalir.Visible = true;
            }
        }
        private void btPagar_Click(object sender, EventArgs e)
        {
            //Pagar Parking 
            string respuesta = ConsoleApp1.Cliente.EnviarMensajeCliente(getIdCliente() + tbPrecioParking.Text, 11000);
            //Mostrar respuesta
            lbLogMensajes.Items.Add(respuesta);
            //Comprobamos respuesta
            if (respuesta == "Pagado")
            {
                tbMensajeCliente.Enabled = false;
                tbPrecioParking.Visible = false;
                tbSalir.Visible = false;
                btPagar.Visible = false;
                btSalir.Visible = false;
            }
        }
        //Obtener ID Cliente.
        private string getIdCliente()
        {
            return "MATRIC:" + matricula;
        }
        //Genera matricula
        public void generaMatricula()
        {
            int logitud = 2;

            // crea StringBuilder
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < logitud; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            tbMensajeCliente.Text = "547" + str_build;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            enviarMensaje();
        }
    }
}
