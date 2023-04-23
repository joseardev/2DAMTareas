using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TareaFinal03ServidorForms.Clases
{
    class Plaza
    {
        private string estado;
        private string matricula;

        private int precio;

        public int Precio { get { return precio; } set { precio = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Matricula { get { return matricula; } set { matricula = value; } }


    }
}
