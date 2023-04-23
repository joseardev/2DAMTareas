using Ejercicio1;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    [TableName("Nomina")]
    [PrimaryKey("ID", AutoIncrement = true)]
    public class Nomina
    {
        public int ID { get; set; }
        public string NombreEmpleado { get; set; }
        public string  IDEmpleado { get; set; }
        public string FechaPago { get; set; }
        public int SalarioBase { get; set; }

        public int DiasTrabajados { get; set; }

        public int HorasExtra { get; set; }
        public int SalarioPorHora { get; set; }
        public int SalarioPorHoraExtra { get; set; }

        public int Asignaciones { get; set; }
        public int Deducciones { get; set; }
        public int TotalDevengado { get; set; }


    }
}

