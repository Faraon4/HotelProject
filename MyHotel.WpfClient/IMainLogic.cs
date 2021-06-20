namespace MyHotel.WpfClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for the main logic.
    /// </summary>
    public interface IMainLogic
    {
        /// <summary>
        /// Method to get all rooms.
        /// </summary>
        /// <returns>list of rooms.</returns>
        List<RoomVM> ApiGetRooms();

        /// <summary>
        /// Method to delete the room.
        /// </summary>
        /// <param name="room">room to be deleted.</param>
        void ApiDelRoom(RoomVM room);

        /// <summary>
        /// Method to edit the room.
        /// </summary>
        /// <param name="room">room to modify.</param>
        /// <param name="editorFunc">true or false.</param>
        void EditRoom(RoomVM room, Func<RoomVM, bool> editorFunc);
    }
}
