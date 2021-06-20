namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// IRepository of Generic Type, where are methods that will help us to find all models and by one models.
    /// </summary>
    /// <typeparam name="T"> It is a generic type interface.</typeparam>
    public interface IRepository<T>
        where T : class
    {
        /// <summary>
        /// Method to get one of something.
        /// </summary>
        /// <param name="id">id parameter will be used for finding the object.</param>
        /// <returns>It should return of type that we are searching.</returns>
        T GetOne(int id);

        /// <summary>
        /// Method to get all of something (rooms, extra, people).
        /// </summary>
        /// <returns>Should return in a query.</returns>
        IQueryable<T> GetAll();
    }
}
