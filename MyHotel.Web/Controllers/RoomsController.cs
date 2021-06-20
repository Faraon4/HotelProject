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
    /// Controller for the Rooms.
    /// </summary>
    public class RoomsController : Controller
    {
       private IManagement logic;
       private IMapper mapper;
       private RoomsListViewModel model;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsController"/> class.
        /// </summary>
       public RoomsController()
        {
            MyHotel.Models.HotelDbContext ctx = new MyHotel.Models.HotelDbContext();
            RoomRepository roomRepo = new RoomRepository(ctx);
            this.logic = new Managers(roomRepo);
            this.mapper = MapperFactory.CreateMapper();

            this.model = new RoomsListViewModel();
            this.model.EditedRoom = new MyHotel.Web.Models.Rooms();

            var rooms = this.logic.GetAllRooms();
            this.model.ListOfRooms = this.mapper.Map<IList<MyHotel.Models.Rooms>, List<MyHotel.Web.Models.Rooms>>(rooms);
       }

        /// <summary>
        /// Private method to the the room model.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <returns>room as MyHotel.Web.Models.</returns>
       private MyHotel.Web.Models.Rooms GetRoomModel(int id)
        {
            MyHotel.Models.Rooms oneRoom = this.logic.GetOneRoom(id);
            return this.mapper.Map<MyHotel.Models.Rooms, MyHotel.Web.Models.Rooms>(oneRoom);
        }

        /// <summary>
        /// Method to return the Index page.
        /// </summary>
        /// <returns>ActionResult.</returns>
       public ActionResult Index()
        {
            this.ViewData["editAction"] = "AddNew";
            return this.View("RoomsIndex", this.model);
        }

        /// <summary>
        /// Method to return the Details page.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <returns>Details page.</returns>
       public ActionResult Details(int id)
        {
            return this.View("RoomsDetails", this.GetRoomModel(id));
        }

        /// <summary>
        /// Method to return the Remove page.
        /// </summary>
        /// <param name="id">id of the room that you want to delete.</param>
        /// <returns>the remove page.</returns>
       public ActionResult Remove(int id)
        {
            this.TempData["editResult"] = "Delete FAIL";
            if (this.logic.DeleteRoom(id) == id)
            {
                this.TempData["editResult"] = "Delete OK";
            }

            return this.RedirectToAction(nameof(this.Index));
        }

        /// <summary>
        /// Method to return the Edit Page.
        /// </summary>
        /// <param name="id">id of the room for editing.</param>
        /// <returns>the Page for editig.</returns>
       public ActionResult Edit(int id)
        {
            this.ViewData["editAction"] = "Edit";
            this.model.EditedRoom = this.GetRoomModel(id);
            return this.View("RoomsIndex", this.model);
        }

        /// <summary>
        /// HttpPost method to post the edited room.
        /// </summary>
        /// <param name="room">room that will be edit.</param>
        /// <param name="editAction">editAction.</param>
        /// <returns>The edited table witht edited room.</returns>
       [HttpPost]
       public ActionResult Edit(MyHotel.Web.Models.Rooms room, string editAction)
        {
            MyHotel.Models.Rooms roomDb = new MyHotel.Models.Rooms();
            roomDb.Id = room.Id;
            roomDb.RoomsType = room.RoomsType;
            roomDb.RoomsAmount = room.RoomsAmount;
            roomDb.RoomsAvailable = room.RoomsAvailable;
            roomDb.RoomsPrice = room.RoomsPrice;
            roomDb.RoomsView = room.RoomsView;
            if (this.ModelState.IsValid && room != null)
            {
                this.TempData["editResult"] = "Edit Ok";
                if (editAction == "AddNew")
                {
                    try
                    {
                        this.logic.AddNewRoom(roomDb);
                    }
                    catch (ArgumentException ex)
                    {
                        this.TempData["editResult"] = $"Insert FAIL:\n {ex.Message}";
                    }
                }
                else
                {
                    if (this.logic.ChangeRoomPrice(room.Id, room.RoomsPrice) != room.Id)
                    {
                        this.TempData["editResult"] = "Edit FAIL";
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }
            else
            {
                this.ViewData["editAction"] = "Edit";
                this.model.EditedRoom = room;
                return this.View("RoomsIndex", this.model);
            }
        }
    }
}
