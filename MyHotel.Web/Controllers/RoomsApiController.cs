namespace MyHotel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using MyHotel.Logic;
    using MyHotel.Repository;
    using MyHotel.Web.Models;

    /// <summary>
    /// New controller for the RoomsApi.
    /// </summary>
    public class RoomsApiController : Controller
    {
       private IManagement logic;
       private IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApiController"/> class.
        /// </summary>
       public RoomsApiController()
       {
            MyHotel.Models.HotelDbContext ctx = new MyHotel.Models.HotelDbContext();
            RoomRepository roomRepo = new RoomRepository(ctx);
            this.logic = new Managers(roomRepo);
            this.mapper = MapperFactory.CreateMapper();
       }

        /// <summary>
        /// Method to get all information from the database.
        /// </summary>
        /// <returns>Uenumerable of rooms.</returns>
       [HttpGet]
       [ActionName("all")]
       public IEnumerable<Models.Rooms> GetAll()
       {
            var rooms = this.logic.GetAllRooms();
            return this.mapper.Map<IList<MyHotel.Models.Rooms>, List<Models.Rooms>>(rooms);
       }

        /// <summary>
        /// Method to delete the room.
        /// </summary>
        /// <param name="id">id of the room that you want to delete.</param>
        /// <returns>ApiResult - true/false, depending of the situation.</returns>
       [HttpGet]
       [ActionName("del")]
       public ApiResult DelOneRoom(int id)
       {
            int result = this.logic.DeleteRoom(id);
            bool f = false;
            if (result == id)
            {
                f = true;
            }

            return new ApiResult() { OperationResult = f };
       }

        /// <summary>
        /// Method to add new room to the database.
        /// </summary>
        /// <param name="room">room to be added.</param>
        /// <returns>ApiResult - true/false, depending of the situation.</returns>
       [HttpPost]
       [ActionName("add")]
       public ApiResult AddOneRoom(Models.Rooms room)
       {
            MyHotel.Models.Rooms roomDb = new ();
            roomDb.Id = room.Id;
            roomDb.RoomsType = room.RoomsType;
            roomDb.RoomsAmount = room.RoomsAmount;
            roomDb.RoomsAvailable = room.RoomsAvailable;
            roomDb.RoomsPrice = room.RoomsPrice;
            roomDb.RoomsView = room.RoomsView;

            bool success = true;
            try
            {
                this.logic.AddNewRoom(roomDb);
            }
            catch (ArgumentException)
            {
                success = false;
            }

            return new ApiResult() { OperationResult = success };
       }

        /// <summary>
        /// Method to modify the room.
        /// </summary>
        /// <param name="room">room that you want to modify.</param>
        /// <returns>ApiResult - true/false, depending of the situation.</returns>
       [HttpPost]
       [ActionName("mod")]
       public ApiResult ModOneRoom(Models.Rooms room)
       {
            int result = this.logic.ChangeRoomPrice(room.Id, room.RoomsPrice);
            bool f = false;
            if (result == room.Id)
            {
                f = true;
            }

            return new ApiResult() { OperationResult = f };
       }
    }
}
