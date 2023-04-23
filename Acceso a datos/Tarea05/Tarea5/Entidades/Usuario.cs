using NHibernate.Mapping;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5.Entidades
{
    [Serializable]
    [Class(Schema = "dbo" ,Table = "Usuario", NameType = typeof(Usuario))]
    public class Usuario
    {

        //Crear una clase de entidad Usuario que contendrá todas las propiedades de un usuario,
        //como el nombre, apellido, correo electrónico, nombre de usuario y contraseña.La clase
        //también debe tener una propiedad de ID única para identificar a cada usuario.
        [Id(Name = "IdUsuario", Column = "IdUsuario", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdUsuario { get; set; }
        [Property(Column = "Nombre", Type = "string", NotNull = true)]
        public virtual string Nombre { get; set; }
        [Property(Column = "Apellido", Type = "string", NotNull = true)]
        public virtual string Apellido { get; set; }
        [Property(Column = "Mail", Type = "string", NotNull = true)]
        public virtual string Mail { get; set; }
        [Property(Column = "NombreUsuario", Type = "string", NotNull = false)]
        public virtual string NombreUsuario { get; set; }
        [Property(Column = "Password", Type = "string", NotNull = false)]
        public virtual string Password { get; set; }







    }
}
