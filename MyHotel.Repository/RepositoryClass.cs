namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using MyHotel.Models;

    /// <summary>
    /// Abstract Repository Class.
    /// </summary>
    /// <typeparam name="T">This class is generic.</typeparam>
    public abstract class RepositoryClass<T> : IRepository<T>
         where T : class
    {
        /// <summary>
        /// Making the connection to the HotelDbContext.
        /// </summary>
        private protected HotelDbContext ctx;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryClass{T}"/> class.
        /// </summary>
        /// <param name="ctx">ctx parameter.</param>
        public RepositoryClass(HotelDbContext ctx)
        {
            this.ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        /// <summary>
        /// Method to get all of something (rooms, people, extra).
        /// </summary>
        /// <returns>a query of entities.</returns>
        public IQueryable<T> GetAll()
        {
            return this.ctx.Set<T>();
        }

        /// <summary>
        /// Making GetOne method from IRepository to abstract.
        /// </summary>
        /// <param name="id">id parameter.</param>
        /// <returns>type that we need.</returns>
        public abstract T GetOne(int id);
    }
}
