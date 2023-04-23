using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarea5.Servicios
{
    class UsuarioDAO<TEntity, Tkey> : IUsuarioRepository<TEntity, Tkey> where TEntity : class
    {
        public void Delete(TEntity entity)
        {
            ISession session = this.GetISession();
            ITransaction tx = session.BeginTransaction();

            try
            {
                session.Delete(entity);
                tx.Commit();
                session.Close();                
            }
            catch (Exception)
            {
                tx.Rollback();
                session.Close();
                throw;

            }
        }

        public List<TEntity> GetAll()
        {
            ISession session = this.GetISession();
            List<TEntity> lista = session.Query<TEntity>().ToList();
            session.Close();
            return lista;
        }

        public TEntity GetById(Tkey id)
        {
            ISession session = this.GetISession();
            TEntity entity = session.Get<TEntity>(id);
            session.Close();
            return entity;
        }

        public Tkey Save(TEntity entity)
        {
            ISession session = this.GetISession();
            ITransaction tx = session.BeginTransaction();

            try
            {
                Tkey tkey = (Tkey)session.Save(entity);
                tx.Commit();
                session.Close();
                return tkey;
            }
            catch(Exception) 
            { 
                tx.Rollback();
                session.Close();
                throw;
            
            }
        }

        public void Update(TEntity entity)
        {
            ISession session = this.GetISession();
            ITransaction tx = session.BeginTransaction();

            try
            {
                session.Update(entity);
                tx.Commit();
                session.Close();                
            }
            catch (Exception)
            {
                tx.Rollback();
                session.Close();
                throw;
            }
        }

        protected ISession GetISession()
        {
            return Configuraciones.NHibernateUtil.GetISessionFactory().OpenSession();
        }

       
    }
}
