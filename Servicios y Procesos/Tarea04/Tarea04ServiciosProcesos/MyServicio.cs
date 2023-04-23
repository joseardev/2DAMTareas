using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace Tarea04ServiciosProcesos
{
    public partial class MyServicio : ServiceBase
    {
        private int eventId = 1;
        delegate void delegado();
        public MyServicio()
        {
            InitializeComponent();
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart.");
            // Configurar un temporizador que se active cada minuto
            /* Timer timer = new Timer();
             timer.Interval = 60000; // 60 seconds
             timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
             timer.Start();*/

            iniciarHilo();
            Console.WriteLine("ok");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnStop.");
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // Insertar las actividades de monitoreo aquí.
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }

        ///SERVER <summary>               
        /// </summary>
        private void iniciarHilo()
        {
            //iniciar();
            delegado IniciarParking = new delegado(iniciar);
            //Iniciamos carrera
            IniciarParking.Invoke();

        }
        private void iniciar()
        {
            //Direción servidor
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            //Puerto Servidor
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(localEndPoint);
            //Esperamos conexión
            listener.Listen(100);
            listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
        }
        //Cada vez que aceptemos una conexión, crearemos un nuevo socket asíncrono
        //para atender nuevas peticiones y recibiremos datos de la conexión aceptada
        //(también de forma asíncrona)        
        public void AcceptCallback(IAsyncResult ar)
        {
            Socket listener = (Socket)ar.AsyncState;

            // Iniciar otro socket asícrono a la escucha de otras conexiones
            listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);

            // Aceptar conexión entrante
            Socket handler = listener.EndAccept(ar);

            // Recibir datos de forma asíncrona
            StateObject state = new StateObject();
            state.workSocket = handler;

            //Comprobamos respuesta
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                   new AsyncCallback(ReadCallback), state);
        }

        //La recepción de datos se realiza de forma similar a los ejemplos anteriores, 
        //si bien cada operación de E/S se realizará de forma asíncrona (de ahí lo de volver
        //a invocar a BeginReceive si aún no han llegado todos los datos del cliente): 
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
                try
                {
                    //content = "hola";
                    var SubstringTextoLinea = content.Substring(0,2);
                    var numero = content.Substring(2);

                    int result;

                    if (int.TryParse(numero, out result))
                    {
                        if (SubstringTextoLinea == "F-")
                        {                       
                            content = obtenerCalculoCaF(result).ToString();
                        }
                        else if (SubstringTextoLinea == "C-")
                        {
                            content = obtenerCalculoFac(result).ToString();
                        }

                        // content = obtenerCalculoCaF(result).ToString();
                    }
                    else
                    {
                        content = "dato erroneo";
                    }                    
                }
                catch (Exception e)
                {
                    content = e.ToString();
                }

                //Enviar respuesta
                Send(handler, content);
            }


            //Send(handler, content);
        }

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
                // Completar el envío de los datos
                int bytesSent = handler.EndSend(ar);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// SERVER

        private double obtenerCalculoFac(int temperatura)
        {
            Temperatura.Conversor Proxy = new Temperatura.Conversor();
            var resultado = Proxy.FaC(temperatura);
            return resultado;
        }

        private double obtenerCalculoCaF(int temperatura)
        {
            Temperatura.Conversor Proxy = new Temperatura.Conversor();
            var resultado = Proxy.CaF(temperatura);
            return resultado;
        }
        void CallServicioWeb()
        {
            //Proxy
            Temperatura.Conversor Proxy = new Temperatura.Conversor();
            DateTime Tini;
            TimeSpan Tdif;
            try
            {
                //Tiempo de inicio de la llamada
                Tini = DateTime.Now;
                //llamada al servicio
                var resultado = Proxy.FaC(30);

                //Tiempo de respuesta
                Tdif = Tini.Subtract(DateTime.Now);
                if (Tdif.Seconds < -10)
                {
                    // Log("Servicio Lento: " + Tdif.Seconds.ToString()+ "[S]");
                }
            }
            catch (Exception X)
            {
                // Log(X.Message);
            }
        }
    }
    public class StateObject
    {
        // Cliente  socket.
        public Socket workSocket = null;
        // Tamaño del búfer de recepción.
        public const int BufferSize = 1024;
        // Búfer de recpción de datos.
        public byte[] buffer = new byte[BufferSize];
        // Array de datos recibidos.
        public StringBuilder sb = new StringBuilder();
    }
}
