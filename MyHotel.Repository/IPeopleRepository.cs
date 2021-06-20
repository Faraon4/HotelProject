namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MyHotel.Models;

    /// <summary>
    /// Repository interface for people Model.
    /// </summary>
    public interface IPeopleRepository : IRepository<People>
    {
        /// <summary>
        /// Method to add new person.
        /// </summary>
        /// <param name="people">people to add.</param>
        void AddNewPeople(People people);

        /// <summary>
        /// Method to Delete people.
        /// </summary>
        /// <param name="peopleID">id of the people that want to delete.</param>
        void DeletePeople(int peopleID);

        /// <summary>
        /// Method to change the room of a people.
        /// </summary>
        /// <param name="peopleId">id of the people that want to change the room.</param>
        /// <param name="newRoomId">id of the new room.</param>
        void ChangePeopleRoom(int peopleId, int newRoomId);

        /// <summary>
        /// Method to change the extra activity for people.
        /// </summary>
        /// <param name="peopleId">id of the people.</param>
        /// <param name="newExtraId">id of the new extra activity.</param>
        void ChangePeopleExtra(int peopleId, int newExtraId);
    }
}
