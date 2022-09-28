using DeviceManagement_WebApp.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace DeviceManagement_WebApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;
        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);

            _context.SaveChangesAsync();
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(Guid? id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChangesAsync();
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChangesAsync();
        }
        public bool Exist(Guid? id)
        {
            if (_context.Set<T>().Find(id) != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<C> GetList<C>() where C: class
        {
            return _context.Set<C>().ToList();
        }

        public void DeleteConfirmed (Guid? id, T entity)
        {
            GetById(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChangesAsync();
        }
    }
}
