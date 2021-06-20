namespace MyHotel.Wpf.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface of the CRUD operations.
    /// </summary>
    public interface IRoomLogic
    {
        /// <summary>
        /// Method that will add a new room.
        /// </summary>
        /// <param name="list">list of the rooms.</param>
        void AddRoom(IList<RoomVM> list);

        /// <summary>
        /// Method that will delete a selected room from the list.
        /// </summary>
        /// <param name="list">list of the rooms from the db.</param>
        /// <param name="room">room that must be deleted.</param>
        void DelRoom(IList<RoomVM> list, RoomVM room);

        /// <summary>
        /// Method that will delete all rooms.
        /// </summary>
        /// <param name="list">list of rooms that have to be deleted.</param>
        void DellAll(IList<RoomVM> list);

        /// <summary>
        /// Method that will get all the rooms.
        /// </summary>
        /// <param name="list">list of the roomsfrom the database.</param>
        void GetAllRooms(IList<RoomVM> list);

       /// <summary>
       /// Method that will modify a room.
       /// </summary>
       /// <param name="roomToModify">room that have to be modified.</param>
        void ModRoom(RoomVM roomToModify);
    }
}
