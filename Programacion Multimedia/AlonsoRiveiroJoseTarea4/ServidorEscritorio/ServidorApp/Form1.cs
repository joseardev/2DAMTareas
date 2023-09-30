using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorApp
{
    
    public partial class Form1 : Form
    {
        //  public String mensaje;
        comunicacion com = new comunicacion();
         
        public Form1()
        {
            InitializeComponent();
           // com.StartServer();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //comunicacion com = new comunicacion(); 
            com.StartServer(textMensaje.Text);
        }

        public class comunicacion
        {
            TcpListener tcpListener;
            public String mensaje;
            String palabraGenerada = "";

            public bool StartServer(String cadena) {
               

                try {
                    int max = 3; // define el valor máximo del rango
                    palabraGenerada = GenerarPalabra(max);
                    tcpListener = new TcpListener(IPAddress.Any, 1234); 
                    tcpListener.Start(); 
                    tcpListener.BeginAcceptTcpClient(new AsyncCallback(ProcessEvents), tcpListener); 
                    Console.WriteLine("Escuchando el Puerto -> " + 1234);
                    mensaje = cadena;
                } catch (Exception e) { 
                    Console.WriteLine("Error: " + e.ToString()); 
                    return false; 
                } 
                return true; 
            }
            public void ProcessEvents(IAsyncResult asyn) { 
                try { 
                    TcpListener processListen = (TcpListener)asyn.AsyncState; 
                    TcpClient tcpClient = processListen.EndAcceptTcpClient(asyn); 
                    NetworkStream myStream = tcpClient.GetStream(); 
                    if (myStream.CanRead) { 
                        StreamReader readerStream = new StreamReader(myStream); 
                        string myMessage = readerStream.ReadToEnd(); 
                        Console.WriteLine("--------"); 
                        Console.WriteLine("Mensaje recibido: " + myMessage); 
                        Console.WriteLine("Ip: " + (((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString()+":"+ 
                            ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Port.ToString()));

                        myMessage = myMessage.Replace("\n", "");                        
                        if (ExisteLetraEnPalabra(palabraGenerada, myMessage))
                        {
                            if (palabraGenerada == myMessage)
                            {
                                writeData(myStream, "Acertaste !!!");
                            }
                            else
                            {
                                writeData(myStream, "La letra "+ myMessage +" Existe en la palabra");
                                Console.WriteLine("La letra " + myMessage + " Existe en la palabra");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("La letra " + myMessage + " no existe en la palabra.");
                            writeData(myStream, "La letra " + myMessage + " no existe en la palabra.");
                        }
                        readerStream.Close(); 
                    } 
                    myStream.Close(); 
                    tcpClient.Close(); 
                    tcpListener.BeginAcceptTcpClient(new AsyncCallback(ProcessEvents), tcpListener); 
                } catch (Exception e) { 
                    Console.WriteLine("error 2 " + e.ToString()); 
                } 
            }
            public static void writeData(NetworkStream networkStream, string dataToClient)
            {
                Console.WriteLine("Procesando envío..."); 
                Console.WriteLine("Mensaje: " + dataToClient); 
                Byte[] sendBytes = null; 
                try { 
                    sendBytes = Encoding.ASCII.GetBytes(dataToClient); 
                    networkStream.Write(sendBytes, 0, sendBytes.Length); 
                    networkStream.Flush();
                    // consola("Enviado correctamente"); 
                    Console.WriteLine("Enviado al cliente correctamente");
                } catch (SocketException e){
                    // consola("Ocurrio un error"); 
                    Console.WriteLine("Ocurrió un error en el envío al cliente, "+e);
                    throw;
                    
                }
            }
            public void send(Socket handler, String data)
            {
                // Convert the string data to byte data using ASCII encoding.
                byte[] byteData = Encoding.ASCII.GetBytes(data);

                // Begin sending the data to the remote device.
                handler.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), handler);
            }

            public static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    // Retrieve the socket from the state object.  
                    Socket handler = (Socket)ar.AsyncState;

                    // Complete sending the data to the remote device.  
                    int bytesSent = handler.EndSend(ar);
                    Console.WriteLine("Enviando al cliente", bytesSent);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }

     
        private void textMensaje_TextChanged(object sender, EventArgs e)
        {
            com.mensaje = textMensaje.Text;
        }
        public static string GenerarPalabra(int longitud)
        {
            string palabraAleatoria;
            string[] diccionario = new string[] {"perro", "gato", "mesa" };
            return palabraAleatoria = ObtenerPalabraDeDiccionario(diccionario);
        }
        public static string ObtenerPalabraDeDiccionario(string[] diccionario)
        {
            Random rand = new Random();
            int indice = rand.Next(diccionario.Length);
            return diccionario[indice];
        }
        public static bool ExisteLetraEnPalabra(string palabra, String letra)
        {
            return palabra.Contains(letra);
        }
    }
}
