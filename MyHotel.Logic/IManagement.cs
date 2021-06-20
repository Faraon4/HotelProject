namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MyHotel.Models;

    /// <summary>
    /// Logic for Management, Here are the CRUD operation except read , because that one are in the reception part.
    /// </summary>
    public interface IManagement
    {
        // Create

        /// <summary>
        /// Method to add new room.
        /// </summary>
        /// <param name="newRoom">parameter to ad.</param>
        /// <returns>id of the new room.</returns>
        int AddNewRoom(Rooms newRoom);

        /// <summary>
        /// Method to add new people.
        /// </summary>
        /// <param name="newPeople">new people to add.</param>
        /// <returns> id of the new people.</returns>
        int AddNewPeople(People newPeople);

        /// <summary>
        /// Method to add new extra activity.
        /// </summary>
        /// <param name="newExtra">new extra to add.</param>
        /// <returns>id of the new extra activity.</returns>
        int AddNewExtra(Extra newExtra);

        // Update

        /// <summary>
        /// Method to Change the Price of the Room.
        /// </summary>
        /// <param name="roomId">id of the room that you want to change.</param>
        /// <param name="price">new price that you want to change.</param>
        /// <returns>id of the room.</returns>
        int ChangeRoomPrice(int roomId, int price);

        /// <summary>
        /// Method to change the room of the people.
        /// </summary>
        /// <param name="peopleID">id of the people.</param>
        /// <param name="newRoomId">id of the new room.</param>
        /// <returns>id of the people that changed the room.</returns>
        int ChangeRoomPeople(int peopleID, int newRoomId);

        /// <summary>
        /// Method to change the available rooms of type.
        /// </summary>
        /// <param name="roomId">id of the room .</param>
        /// <returns>id of the room.</returns>
        int ChangeRoomAvailable(int roomId);

        /// <summary>
        /// Method that change the extra for the people.
        /// </summary>
        /// <param name="peopleID">id of the people.</param>
        /// <param name="newExtraId">id of the new extra.</param>
        /// <returns>id of the people that changed the extra activity.</returns>
        int ChangeExtraPeople(int peopleID, int newExtraId);

        /// <summary>
        /// Method to Change the Price of the Extra Activity.
        /// </summary>
        /// <param name="extraId">id of the extra activity that you want to change.</param>
        /// <param name="price">new price.</param>
        /// <returns>id of the extra activity that you changed the price.</returns>
        int ChangeExtraPrice(int extraId, int price);

        /// <summary>
        ///  Method to change the selection of the room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <param name="text">text to be changed.</param>
        /// <returns>true or false.</returns>
        bool ChangeSelection(int id, string text);

        // Delete

        /// <summary>
        /// Method that delete the room.
        /// </summary>
        /// <param name="roomdId">id of the room that you want to delete.</param>
        /// <returns>id of deleted room.</returns>
        int DeleteRoom(int roomdId);

        /// <summary>
        /// Method that delete people.
        /// </summary>
        /// <param name="peopleId">id of the people that you want to delete.</param>
        /// <returns>id of deleted people.</returns>
        int DeletePeople(int peopleId);

        /// <summary>
        /// Method that delete extra activity.
        /// </summary>
        /// <param name="extraId">id of the extra activity that you want to delete.</param>
        /// <returns>id of the deleted extra activity.</returns>
        int DeleteExtra(int extraId);

        /// <summary>
        /// Method the get one room by one id.
        /// </summary>
        /// <param name="id">id of the room that you want.</param>
        /// <returns>the room by id.</returns>
        Rooms GetOneRoom(int id);

        /// <summary>
        /// Mthod to read all rooms.
        /// </summary>
        /// <returns>list of rooms.</returns>
        IList<Rooms> GetAllRooms();
    }
}
