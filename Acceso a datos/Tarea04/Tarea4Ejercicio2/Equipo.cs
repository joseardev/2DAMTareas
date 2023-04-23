using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4Ejercicio2
{
    [TableName("Equipos")]
    [PrimaryKey("Codigo")]
    public class Equipo
    {
        [Column("Codigo")]
        public string Codigo { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Pais")]
        public string Pais { get; set; }

        [Column("Goles")]
        public int? Goles { get; set; }

        [Column("Puntos")]
        public int? Puntos { get; set; }

        [Column("PJ")]
        public string PJ { get; set; }

        [Column("PG")]
        public int? PG { get; set; }

        [Column("PE")]
        public int? PE { get; set; }

        [Column("PP")]
        public int? PP { get; set; }

        [Column("Estadio")]
        public string Estadio { get; set; }

        [Column("Ciudad")]
        public string Ciudad { get; set; }
        public override string ToString()
        {

            return this.Nombre;
        }
    }
}
