using _09_Katman.DataAccesLayer.Abstract;
using _09_Katman.DataAccesLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Katman.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        
        KampContext c = new KampContext();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var deleteEntity = c.Entry(p);
            deleteEntity.State = EntityState.Deleted;
            c.SaveChanges();
          
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T p)
        {
            var entityAdd = c.Entry(p);
            entityAdd.State = EntityState.Added;
            c.SaveChanges();
        }

        public void Update(T p)
        {
           var entityUpdate = c.Entry(p);
            entityUpdate.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
