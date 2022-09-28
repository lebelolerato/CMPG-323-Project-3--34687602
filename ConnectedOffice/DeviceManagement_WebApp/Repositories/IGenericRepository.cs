using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DeviceManagement_WebApp.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //Used to get an item using its Id and displays it
        T GetById(Guid? id);

        //Displays all the data I have in a Table
        IEnumerable<T> GetAll();

        //Used to find Items in my already existing data
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        //Used to add new Items in my Tables
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        //Used to Delete Items from my data
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        //Updates my tables or data after I have made a change or added a new Item
        public void Update(T entity);

        //Checks if the Item with a certain Id exists
        bool Exist(Guid? id);

        //This method is used by the DeviceController to show data from Categories and Zones when adding a new device
        IEnumerable<C> GetList<C>() where C : class;
    }
}
