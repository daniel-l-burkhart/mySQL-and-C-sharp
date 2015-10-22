using System.Collections.Generic;

namespace CS3230_Homework_4.DAL.Interfaces
{
    /// <summary>
    ///     The interface that contains methods that would be used by all table connections.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        #region Interface Methods

        /// <summary>
        ///     Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(T entity);

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        ///     Gets all.
        /// </summary>
        /// <returns></returns>
        IList<T> GetAll();

        /// <summary>
        ///     Gets all employees by supervisor.
        /// </summary>
        /// <param name="superSsn">The super SSN.</param>
        /// <returns></returns>
        IList<T> GetAllEmployeesBySupervisor(string superSsn);

        #endregion
    }
}