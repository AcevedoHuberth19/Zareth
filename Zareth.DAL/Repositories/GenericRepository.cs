using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zareth.DAL.Context;
using Zareth.DAL.IRepositories;

namespace Zareth.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ZarethContext db = new ZarethContext();

        public bool Actualizar(T obj)
        {
            try
            {
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Eliminar(int Id)
        {
            var obj = db.Set<T>().Find(Id);

            if (obj != null)
            {
                db.Entry(obj).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Insertar(T obj)
        {
            try
            {
                db.Entry(obj).State = EntityState.Added;
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<T> Listar()
        {
            return db.Set<T>();
        }
    }
}