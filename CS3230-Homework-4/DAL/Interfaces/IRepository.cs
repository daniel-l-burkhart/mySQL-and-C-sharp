using System.Collections.Generic;

namespace CS3230ExploringTheRepositoryPattern.DAL.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IList<T> GetAll();
        IList<T> GetAllEmployeesBySupervisor(string superSsn);
    }
}