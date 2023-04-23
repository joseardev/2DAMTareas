using Ejercicio2;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    [TableName("Actores")]
    [PrimaryKey("Actor", AutoIncrement = false)]
    class Actores
    {
        public int ID { get; set; }
        public string Actor { get; set; }



        public override string ToString()
        {
            return this.Actor;
        }
    }
}
