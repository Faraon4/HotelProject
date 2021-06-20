namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MyHotel.Models;
    using MyHotel.Repository;

    /// <summary>
    /// Management class -> this is the Logic of the program.
    /// </summary>
    public class Managers : IManagement
    {
        private IExtraRepository extraRepo;
        private IPeopleRepository peopleRepo;
        private IRoomRepository roomRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Managers"/> class.
        /// Constructor that take as parameter all 3 repository.
        /// </summary>
        /// <param name="extraRepo">parameter to connect to the extra repository.</param>
        /// <param name="peopleRepo">parameter to connect to people repository.</param>
        /// <param name="roomRepo">parameter to connect to room repository.</param>
        public Managers(IExtraRepository extraRepo, IPeopleRepository peopleRepo, IRoomRepository roomRepo)
        {
            this.extraRepo = extraRepo;
            this.peopleRepo = peopleRepo;
            this.roomRepo = roomRepo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Managers"/> class.
        /// Constructor that take as parameter room repository.
        /// </summary>
        /// <param name="roomRepo">parameter to connect to room repository.</param>
        public Managers(IRoomRepository roomRepo)
        {
            this.roomRepo = roomRepo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Managers"/> class.
        /// Constructor that take as parameter extra repository.
        /// </summary>
        /// <param name="extraRepo">parameter to connect to extra repository.</param>
        public Managers(IExtraRepository extraRepo)
        {
            this.extraRepo = extraRepo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Managers"/> class.
        /// Constructor that take as parameter people repository.
        /// </summary>
        /// <param name="peopleRepo">parameter to connect to extra repository.</param>
        public Managers(IPeopleRepository peopleRepo)
        {
            this.peopleRepo = peopleRepo;
        }

        // Create

        /// <summary>
        /// Implementing the method for adding new extra activity from IManagement interface.
        /// </summary>
        /// <param name="newExtra">new extra activity for being added.</param>
        /// <returns>id of the new added extra activity.</returns>
        public int AddNewExtra(Extra newExtra)
        {
            this.extraRepo.AddNewExtra(newExtra);
            return newExtra.Id;
        }

        /// <summary>
        /// Implementing the method for adding new people from IManagement interface.
        /// </summary>
        /// <param name="newPeople">new people for being added.</param>
        /// <returns>id of the new added people.</returns>
        public int AddNewPeople(People newPeople)
        {
            this.peopleRepo.AddNewPeople(newPeople);
            return newPeople.Id;
        }

        /// <summary>
        /// Implementing the method for adding new room from IManagement interface.
        /// </summary>
        /// <param name="newRoom">new room for being added.</param>
        /// <returns>id of the new added room.</returns>
        public int AddNewRoom(Rooms newRoom)
        {
            this.roomRepo.AddNewEntity(newRoom);
            return newRoom.Id;
        }

        // Update

        /// <summary>
        /// Method to change the price of extra activit.
        /// </summary>
        /// <param name="extraId">id of the extra activity.</param>
        /// <param name="price">new price.</param>
        /// <returns>id of the extra activity that changed the price.</returns>
        public int ChangeExtraPrice(int extraId, int price)
        {
            this.extraRepo.ChangePriceExtra(extraId, price);
            return extraId;
        }

        /// <summary>
        /// Method that will change the room of the people.
        /// </summary>
        /// <param name="peopleID">id of the people.</param>
        /// <param name="newRoomId">id of the new room.</param>
        /// <returns>id of the people that just changed the room.</returns>
        public int ChangeRoomPeople(int peopleID, int newRoomId)
        {
            this.peopleRepo.ChangePeopleRoom(peopleID, newRoomId);
            return peopleID;
        }

        /// <summary>
        /// Method that will change the room of the people.
        /// </summary>
        /// <param name="peopleID">id of the people.</param>
        /// <param name="newExtraId">id of the new room.</param>
        /// <returns>id of the people that just changed the room.</returns>
        public int ChangeExtraPeople(int peopleID, int newExtraId)
        {
            this.peopleRepo.ChangePeopleExtra(peopleID, newExtraId);
            return peopleID;
        }

        /// <summary>
        /// Method to change the price of the room.
        /// </summary>
        /// <param name="roomId">id of the room .</param>
        /// <param name="price">new price for the room.</param>
        /// <returns>id of the room that changed the price.</returns>
        public int ChangeRoomPrice(int roomId, int price)
        {
            this.roomRepo.ChangePrice(roomId, price);
            return roomId;
        }

        /// <summary>
        /// Implementing the method from the IManagement.
        /// </summary>
        /// <param name="roomId">id of the room.</param>
        /// <returns>id of the room changed.</returns>
        public int ChangeRoomAvailable(int roomId)
        {
            this.roomRepo.ChangeAvailableRoom(roomId);
            return roomId;
        }

        /// <summary>
        /// Implementing the change selction of the room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <param name="text">textto be changed.</param>
        /// <returns>true or false.</returns>
        public bool ChangeSelection(int id, string text)
        {
            return this.roomRepo.ChangeSelection(id, text);
        }

        // Delete

        /// <summary>
        /// Method that delete an extra activity.
        /// </summary>
        /// <param name="extraId">id of the activity that want to delete.</param>
        /// <returns>id of the deleted extra.</returns>
        public int DeleteExtra(int extraId)
        {
            this.extraRepo.DeleteExtraRepository(extraId);
            return extraId;
        }

        /// <summary>
        /// Method that delete people.
        /// </summary>
        /// <param name="peopleId">id of the people that want to delete.</param>
        /// <returns>id of the deleted people.</returns>
        public int DeletePeople(int peopleId)
        {
            this.peopleRepo.DeletePeople(peopleId);
            return peopleId;
        }

        /// <summary>
        /// Method that delete the room.
        /// </summary>
        /// <param name="roomdId">id of the room that want to delete.</param>
        /// <returns>id of the deleted room.</returns>
        public int DeleteRoom(int roomdId)
        {
            this.roomRepo.DeleteRoom(roomdId);
            return roomdId;
        }

        /// <summary>
        /// Method to get one room.
        /// </summary>
        /// <param name="id">id of the room that you want to get.</param>
        /// <returns>the room.</returns>
        public Rooms GetOneRoom(int id)
        {
            return this.roomRepo.GetOne(id);
        }

        /// <summary>
        /// Method to get all rooms.
        /// </summary>
        /// <returns>list of rooms.</returns>
        public IList<Rooms> GetAllRooms()
        {
            return this.roomRepo.GetAll().ToList();
        }
    }
}
