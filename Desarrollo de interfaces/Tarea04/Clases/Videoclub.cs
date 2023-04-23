using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Clases
{
    public class Videoclub
    {
        
        private static Random random = new Random();
        static BindingList<Pelicula> listaPeliculas = new BindingList<Pelicula>();

        private string codigo;
        public string Codigo { get => codigo; set => codigo = value; }
        public static BindingList<Pelicula> ListaPeliculas { get => listaPeliculas; set => listaPeliculas = value; }
             
        public void codigoVideoclub()
        {
           Random rnd = new Random();
            int num = rnd.Next(100,999);            
            string letra = RandomStringMayusculas(1);
            string letra_final = RandomStringMinusculas(1);

            this.Codigo = letra + num + letra;
            MessageBox.Show("Codigo del videoclub "+ this.Codigo);
        }
        public static string RandomStringMayusculas(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomStringMinusculas(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
/*    • Una lista con las peliculas
• Géneros
• Código(que debe estar formado por 1 letra mayúscula + 3 dígitos + 1 letra
minúscula.*/
}
