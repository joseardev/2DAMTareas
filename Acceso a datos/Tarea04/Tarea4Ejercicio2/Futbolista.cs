using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4Ejercicio2
{
    [TableName("Futbolistas")]
    [PrimaryKey("Codigo")]
    public class Futbolista
    {
        [Column("Codigo")]
        public string Codigo { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }
       

        [Column("CodigoEquipo")]
        public string CodigoEquipo { get; set; }

        [Column("Posicion")]
        public string Posicion { get; set; }

        [Column("Edad")]
        public int? Edad { get; set; }

        [Column("Goles")]
        public int? Goles { get; set; }

        [Column("TA")]
        public int? TA { get; set; }

        [Column("TR")]
        public int? TR { get; set; }

        [Column("Minutos")]
        public int? Minutos { get; set; }

        [Column("PrecioMercado")]
        public string PrecioMercado { get; set; }

        [Column("Dorsal")]
        public int? Dorsal { get; set; }

        [Column("Peso")]
        public int? Peso { get; set; }

        public override string ToString() {

            return this.Nombre;
        }


    }
}
