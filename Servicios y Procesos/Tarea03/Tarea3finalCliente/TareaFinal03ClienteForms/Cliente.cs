using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cliente
    {
      
        public static void Conectar()
        {

            Socket socketCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            socketCliente.Connect(miDireccion);

            Console.WriteLine("Conectado con existe ");
            Console.WriteLine("Ingrese la informacion a Enviar ");

            string info = Console.ReadLine();
            byte[] infoEnviar = Encoding.Default.GetBytes(info);

            socketCliente.Send(infoEnviar, 0, infoEnviar.Length, 0);
            socketCliente.Close();
            Console.WriteLine("Presione cualquier tecla");
            Console.ReadKey();
        }
        public static string EnviarMensajeCliente(String mensaje, int puertoCliente)
        {

            string respuesta = null;
            Byte[] SendBytes = Encoding.ASCII.GetBytes(mensaje);
            Byte[] RecvBytes = new Byte[256];
            int bytes;

            // Cliente TCP

            TcpClient client = new TcpClient();

            // Conexión
            try
            {

                client.Connect(Dns.GetHostName(), puertoCliente);
                //envío del mensaje
                client.GetStream().Write(SendBytes, 0, SendBytes.Length);
                //Respuesta del servidor
                bytes = client.GetStream().Read(RecvBytes, 0, RecvBytes.Length);
                respuesta = Encoding.ASCII.GetString(RecvBytes, 0, bytes);
                while (bytes > 0)
                {
                    bytes = client.GetStream().Read(RecvBytes, 0, RecvBytes.Length);
                    respuesta += Encoding.ASCII.GetString(RecvBytes, 0, bytes);
                }
                Console.WriteLine(respuesta);

            }
            catch (Exception error)
            {
                Console.WriteLine("ERROR - " + error);
            }

            return respuesta;
            //      Console.ReadKey();
        }



    }
}
