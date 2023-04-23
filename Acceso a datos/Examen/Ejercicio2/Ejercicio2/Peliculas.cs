using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    [TableName("Peliculas")]
    [PrimaryKey("ID", AutoIncrement = true)]
    class Peliculas
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Titulo_original { get; set; }
        public int Produccion { get; set; }
        public int Duracion { get; set; }
        public int Calificacion { get; set; }
        public int Bn { get; set; }
        public int Tiene_sinopsis { get; set; }

        public override string ToString()
        {
            return this.Titulo;
        }
    }
}

