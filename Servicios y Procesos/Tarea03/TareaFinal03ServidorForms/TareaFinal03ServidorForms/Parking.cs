using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TareaFinal03ServidorForms.Clases;


namespace TareaFinal03ServidorForms
{
    public partial class Parking : Form
    {
        //Listas 
        private BindingList<Plaza> listPlazas = new BindingList<Plaza>();
        public BindingList<string> logParking = new BindingList<string>();

        //Variables
        private int plazasDisponibles = 0;

        delegate void delegado();
        public Parking()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Valor inicial de plazas
            numericPlazas.Value = 1;
            //Propiedas a mostrar en la lista del obj 
            lbListaAparcados.DisplayMember = "matricula";
            lbListaAparcados.DataSource = listPlazas;
        }

        //Se crean dos hilos uno para gestionar las plazas y otro que calcula el precio seg�n el tiempo
        // que esta aparcado
        private void btAbrirParking_Click(object sender, EventArgs e)
        {
            abrirParking();
            calculoPrecioAparcados();
        }


        private void abrirParking()
        {
            //estados iniciales
            tbEstadoParking.Text = "Libre";
            tbEstadoParking.ForeColor = Color.Green;
            //Comprobar numero plazas es correcto
            bool isNumber = int.TryParse(numericPlazas.Text, out plazasDisponibles);
            if (isNumber)
            {
                Thread parking = new Thread(iniciarHilo);
                //Iniciamos hilo
                parking.Start();
            }
            else
            {
                string message = "error plazas disponibles";
                string caption = "ERROR";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }


        private void iniciarHilo()
        {
            //iniciar();
            delegado IniciarParking = new delegado(iniciar);
            //Iniciamos carrera
            IniciarParking.Invoke();

        }
        private void iniciar()
        {
            //Direci�n servidor
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            //Puerto Servidor
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(localEndPoint);
            //Esperamos conexi�n
            listener.Listen(100);
            listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
        }


        //Cada vez que aceptemos una conexi�n, crearemos un nuevo socket as�ncrono
        //para atender nuevas peticiones y recibiremos datos de la conexi�n aceptada
        //(tambi�n de forma as�ncrona)        
        public void AcceptCallback(IAsyncResult ar)
        {
            Socket listener = (Socket)ar.AsyncState;

            // Iniciar otro socket as�crono a la escucha de otras conexiones
            listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);

            // Aceptar conexi�n entrante
            Socket handler = listener.EndAccept(ar);

            // Recibir datos de forma as�ncrona
            StateObject state = new StateObject();
            state.workSocket = handler;

            //Comprobamos respuesta
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                   new AsyncCallback(ReadCallback), state);
        }

        //La recepci�n de datos se realiza de forma similar a los ejemplos anteriores, 
        //si bien cada operaci�n de E/S se realizar� de forma as�ncrona (de ah� lo de volver
        //a invocar a BeginReceive si a�n no han llegado todos los datos del cliente): 
        public void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Leemos datos 
            int bytesRead = handler.EndReceive(ar);
            if (bytesRead > 0)
            {
                // Almacenar los datos recibidos hasta el momento
                state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                content = state.sb.ToString();

                setTextoMostrar(content);
                //obtener respuesta segun plazas disponibles
                content = comprobarPlazas(content);

                //Enviar respuesta
                Send(handler, content);
                //Cambiar tb el estado del parking
                estadoParking();
            }
        }
        private void setTextoMostrar(string mensaje)
        {
            lbLogMensajes.Items.Add(mensaje);
            logParking.Add(mensaje);
        }
        //cambia el valor en la vista del estodo parking segun plazas disponibles
        private void estadoParking()
        {
            if (listPlazas.Count == plazasDisponibles)
            {
                tbEstadoParking.Text = "Completo";
                tbEstadoParking.ForeColor = Color.Red;
            }
            else
            {
                tbEstadoParking.Text = "Libre";
                tbEstadoParking.ForeColor = Color.Green;
            }
        }

        //Crear el objecto Plaza y completa con matricula y estado segun la respuesta
        //content => respuesta cliente.
        //Hacemos un subtring para obtener campos clave del mensaje
        // claveMensaje => Indica que tipo de mensaje acabamos de recibir
        // matricula  => Indica la matricula del cliente que usaremos que id
        // respuesta del cliente a la peticion
        private string comprobarPlazas(String content)
        {
            string claveMensaje = content.Substring(0, 7);
            string matricula = content.Substring(7, 5);
            string respuestaCliente = content.Substring(12);
            string mensaje = "";
            int plazaLibra = 0;

            //Comprobamos existe matricula            
            bool existeMatricula = listPlazas.Any(item => item.Matricula == matricula);
            if (existeMatricula)
            {
                //En caso de existir recogemos el objecto
                var item = listPlazas.SingleOrDefault(x => x.Matricula == matricula);
                //Comprobamos los distintos estado APARCADO ,P_PAGO
                if (item.Estado == "APARCADO")
                {
                    item.Estado = "P_PAGO";
                    listPlazas.Remove(item);
                    listPlazas.Add(item);
                    mensaje = "PRECIO:" + item.Precio;
                }
                else if (item.Estado == "P_PAGO")
                {
                    bool isNumber = int.TryParse(respuestaCliente, out int pagoCliente);
                    if (item.Precio == pagoCliente)
                    {
                        mensaje = "Pagado";
                        listPlazas.Remove(item);
                    }
                    else
                    {
                        mensaje = "Importe incorrecto. Precio=>" + item.Precio;
                    }
                }
            }
            else
            {
                //No existe 
                bool isNumber = int.TryParse(numericPlazas.Text, out plazasDisponibles);
                //Comprobamos que no supera el numero de plazas
                if (listPlazas.Count < plazasDisponibles)
                {
                    //Creamos objecto y a�adimos a la lista. Avisamos que esta aparcado
                    plazaLibra += listPlazas.Count;
                    Plaza nuevaPlaza = new Plaza();
                    nuevaPlaza.Matricula = matricula;
                    nuevaPlaza.Estado = "APARCADO";
                    listPlazas.Add(nuevaPlaza);
                    mensaje = "Aparcado";
                }
                else
                {
                    mensaje = "ocupado";
                }
            }
            return mensaje;
        }

        //Implementar la parte del servidor que le devuelve al
        //cliente lo que �ste le haya enviado. Una vez m�s, lo
        //hacemos de forma as�ncrona: 
        private static void Send(Socket handler, String data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            handler.BeginSend(byteData, 0, byteData.Length, 0,
                               new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;
                // Completar el env�o de los datos
                int bytesSent = handler.EndSend(ar);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void calculoPrecioAparcados()
        {
            Thread parking = new Thread(calculoPrecioTiempo);
            //Iniciamos hilo
            parking.Start();

        }
        //Calcula el precio seg�n el tiempo que esta aparcado
        //funcion recursiva 
        private void calculoPrecioTiempo()
        {
            foreach (var item in listPlazas)
            {
                item.Precio = item.Precio + 1;
            }
            System.Threading.Thread.Sleep(10000);
            calculoPrecioTiempo();
        }
    }

    // Objeto de estado para leer datos del cliente de forma asincr�nica
    //Con los m�todos Begin... realizaremos las operaciones de E/S de nuestro servidor
    //de forma as�ncrona. Para ello, tendremos que definir una clase auxiliar que se encargue
    //de mantener el estado de cada operaci�n as�ncrona de E/S
    public class StateObject
    {
        // Cliente  socket.
        public Socket workSocket = null;
        // Tama�o del b�fer de recepci�n.
        public const int BufferSize = 1024;
        // B�fer de recpci�n de datos.
        public byte[] buffer = new byte[BufferSize];
        // Array de datos recibidos.
        public StringBuilder sb = new StringBuilder();
    }
}