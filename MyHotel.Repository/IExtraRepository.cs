 namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MyHotel.Models;

    /// <summary>
    /// Repository interface for extra activity model.
    /// </summary>
    public interface IExtraRepository : IRepository<Extra>
    {
        /// <summary>
        /// Method for changing the price of extra.
        /// </summary>
        /// <param name="id">id of the extra.</param>
        /// <param name="newPrice">new price for the activity.</param>
        void ChangePriceExtra(int id, int newPrice);

       /// <summary>
       /// Method to add new extra activity.
       /// </summary>
       /// <param name="newExtra">new extra activity as a parameter.</param>
        void AddNewExtra(Extra newExtra);

        /// <summary>
        /// Method to delete extra activity.
        /// </summary>
        /// <param name="extraId">id of extra activity.</param>
        void DeleteExtraRepository(int extraId);
    }
}
