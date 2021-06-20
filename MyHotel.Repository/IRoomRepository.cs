namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MyHotel.Models;

    /// <summary>
    /// Interface Repository for the Room.
    /// </summary>
    public interface IRoomRepository : IRepository<Rooms>
    {
        /// <summary>
        /// Method for Changing the Price of the Room.
        /// </summary>
        /// <param name="id">id  for finding the room.</param>
        /// <param name="newprice">newprice for the room.</param>
        void ChangePrice(int id, int newprice);

        /// <summary>
        /// Method to change the available number of rooms.
        /// </summary>
        /// <param name="id">id of the room.</param>
        void ChangeAvailableRoom(int id);

        /// <summary>
        /// Method for adding new room.
        /// </summary>
        /// <param name="newRoom">newRoom parameter.</param>
        void AddNewEntity(Rooms newRoom);

        /// <summary>
        /// Method for deleting the Room.
        /// </summary>
        /// <param name="roomId">id of room that should be deleted.</param>
        void DeleteRoom(int roomId);

        /// <summary>
        /// Method to change the rooms selection.
        /// </summary>
        /// <param name="id">id if the room.</param>
        /// <param name="text">text that you want to change.</param>
        /// <returns>true or false.</returns>
        bool ChangeSelection(int id, string text);
    }
}
