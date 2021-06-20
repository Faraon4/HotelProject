namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using MyHotel.Models;

    /// <summary>
    /// IReception interface, Here arer the non-crud operation and the Read part from the cRud
    /// I did like this becuase , most of all, at reception you can see information, but not adding, deleating or updating it.
    /// </summary>
    public interface IReception
    {
        /// <summary>
        /// Method to count how many , of each activity , people choose.
        /// </summary>
        /// <returns>as a list of extra activity and number of each.</returns>
        IList<ExtraNumber> ExtraNumber();

        /// <summary>
        /// Method to count how many $ people pay for their holiday.
        /// </summary>
        /// <returns>as a list of total price.</returns>
        IList<TotalPrice> TotalPrice();

        /// <summary>
        /// Method to count how many, of each room, people choose.
        /// </summary>
        /// <returns>list of rooms with the number of each one.</returns>
        IList<RoomNr> RoomNr();

        /// <summary>
        /// Method to count how many, of each room, people choose by id.
        /// </summary>
        /// <returns>list of id of the rooms.</returns>
        IList<RoomNrByID> RoomNrID();

        /// <summary>
        /// Method that will count the extras by id.
        /// </summary>
        /// <returns>list of ids of extra and its number.</returns>
        IList<ExtraNrID> ExtraNrId();

        /// <summary>
        /// Method that will call non-crud method that count total sum, with the help of the TASK.
        /// </summary>
        /// <returns>task of totalprice.</returns>
        public Task<IList<TotalPrice>> TaskTotalPrice();

        /// <summary>
        /// Method that will call non-crud method that count number of rooms, with the help of the TASK.
        /// </summary>
        /// <returns>task of total room number.</returns>
        public Task<IList<RoomNr>> TaskNumberOfRooms();

        /// <summary>
        /// Method that will call non-crud method that count number of extra, with the help of TASK.
        /// </summary>
        /// <returns>task of extra number.</returns>
        public Task<IList<ExtraNumber>> TaskNumberOfExtra();

        // Read operation -> FROM cRud.

        /// <summary>
        /// Read the rooms and their price.
        /// </summary>
        /// <returns> a List of rooms with their price.</returns>
        IList<PriceResult> GetRoomsPrice();

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

        /// <summary>
        /// Mrthod to read all people.
        /// </summary>
        /// <returns>list of people.</returns>
        IList<People> GetAllPeople();

        /// <summary>
        /// Method to get one person.
        /// </summary>
        /// <param name="id">id of the people to read.</param>
        /// <returns>return that people.</returns>
        People GetOnePeople(int id);

        /// <summary>
        /// Get the People  where are they from, what is their room id and extra activity id.
        /// </summary>
        /// <returns>list of information about people.</returns>
        IList<PeopleCountry> GetCountryPeople();

        /// <summary>
        /// Method to get one Extra activity.
        /// </summary>
        /// <param name="id">id of the extra activity that you want to get.</param>
        /// <returns>extra activity by id.</returns>
        Extra GetOneExtra(int id);

        /// <summary>
        /// Method to get all extras.
        /// </summary>
        /// <returns>list of extras.</returns>
        IList<Extra> GetAllExtras();

        /// <summary>
        /// Get extra activity and the price.
        /// </summary>
        /// <returns>list of the extra activity and their price.</returns>
        IList<PriceResultExtra> GetExtraPrice();
    }
}
