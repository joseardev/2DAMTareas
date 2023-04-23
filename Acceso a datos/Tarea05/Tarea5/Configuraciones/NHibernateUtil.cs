using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Reflection;
using Tarea5.Entidades;

namespace Tarea5.Configuraciones
{
    public class NHibernateUtil
    {
        //Variablee para establecer la conexión la base de datos
        private static ISessionFactory sessionFactory;

        //
        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                if (NHibernateUtil.sessionFactory == null)
                {
                    //Configuracion de la sesión1
                    Configuration configuration = new Configuration();
                    configuration.Configure();

                    HbmSerializer.Default.Validate = true;
                    configuration.AddInputStream(HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly()));
                    //Tablas a mapear
                    configuration.AddAssembly(typeof(Usuario).Assembly);
                    //Actualizamos la base de datos
                    new SchemaUpdate(configuration);

                    NHibernateUtil.sessionFactory = configuration.BuildSessionFactory();
                }
                return NHibernateUtil.sessionFactory;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ISessionFactory GetISessionFactory()
        {
            if (sessionFactory == null)
            {
                return BuildSessionFactory();
            }
            else
            {
                return sessionFactory;
            }
        }

        public static void Start()
        {
            BuildSessionFactory();
        }

        public static void Stop()
        {
            GetISessionFactory().Close();
        }
    }

}
