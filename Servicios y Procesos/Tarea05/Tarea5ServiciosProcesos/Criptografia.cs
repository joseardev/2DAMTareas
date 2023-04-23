using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5ServiciosProcesos
{
    public class Criptografia
    {

        public static string Encryptar(string rutaFichero, string rutaDestino, string tipoEncryotacion, string password)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "openssl.exe",
                Arguments = tipoEncryotacion + " -salt -k " + password + " -in " + rutaFichero + " -out " + rutaDestino + "\\" + "file.encrypted ",
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            // Iniciar el proceso de OpenSSL
            using (Process process = Process.Start(startInfo))
            {
                // Leer la salida del proceso
                string output = process.StandardOutput.ReadToEnd();

            }

            return startInfo.Arguments;
        }
        public static string Descryptar(string rutaFichero, string rutaDestino, string tipoEncryotacion, string password)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "openssl.exe",
                Arguments = tipoEncryotacion + " -d -k " + password + " -in " + rutaFichero + " -out " + rutaDestino + "\\" + "file.txt ",
                UseShellExecute = false,
                RedirectStandardOutput = true
            };

            // Iniciar el proceso de OpenSSL
            using (Process process = Process.Start(startInfo))
            {
                // Leer la salida del proceso
                string output = process.StandardOutput.ReadToEnd();
            }
            return startInfo.Arguments;
        }

        public static string EncriptarTexto(string texto, string password, string tipoEncriptacion)
        {           
            // Crear el proceso de OpenSSL
            var openssl = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "openssl",
                    Arguments = $"enc -{tipoEncriptacion} -base64 -salt -A -k {password}",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            // Iniciar el proceso
            openssl.Start();

            // Escribir el texto a encriptar en el proceso
            using (var sw = openssl.StandardInput)
            {
                sw.Write(texto);
            }

            // Esperar a que el proceso finalice
            openssl.WaitForExit();

            // Leer la salida del proceso (texto encriptado en base64)
            var salida = openssl.StandardOutput.ReadToEnd();

            // Mostrar el texto encriptado
            return salida;
        }

        public static string DEsEncriptarTexto(string texto, string password, string tipoEncriptacion)
        {
            // Crear el proceso de OpenSSL
            var openssl = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "openssl",
                    Arguments = $"enc -d -{tipoEncriptacion} -base64 -salt -A -k {password}",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            // Iniciar el proceso
            openssl.Start();

            // Escribir el texto a encriptar en el proceso
            using (var sw = openssl.StandardInput)
            {
                sw.Write(texto);
            }

            // Esperar a que el proceso finalice
            openssl.WaitForExit();

            // Leer la salida del proceso (texto encriptado en base64)
            var salida = openssl.StandardOutput.ReadToEnd();

            // Mostrar el texto encriptado
            return salida;
        }
    }
}
