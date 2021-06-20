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
    /// Random controller for the homework.
    /// </summary>
    public class RandomController : Controller
    {
        /// <summary>
        /// Get random number.
        /// </summary>
        private static Random rnd = new Random();

        private IManagement logic;
        private IMapper mapper;
        private RoomsListViewModel model;
        private List<MyHotel.Models.Rooms> rooms;
        private List<string> type = new List<string>();
        private List<int> amount = new List<int>();
        private List<int> available = new List<int>();
        private List<int> price = new List<int>();
        private List<string> view = new List<string>();

        private int countSelected;
        private int countUnSELECTED;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomController"/> class.
        /// </summary>
        /// <param name="logic">logic.</param>
        /// <param name="mapper">mapper.</param>
        public RandomController(IManagement logic, IMapper mapper)
        {
            this.logic = logic;
            this.mapper = mapper;
            this.rooms = this.logic.GetAllRooms().ToList();

            this.model = new RoomsListViewModel();
            this.model.ListOfRooms = this.mapper.Map<IList<MyHotel.Models.Rooms>, List<Models.Rooms>>(this.rooms);

            var q = from room in this.logic.GetAllRooms()
                    where room.Selection == "SELECTED"
                    select room;
            foreach (var item in q)
            {
                this.countSelected++;
            }

            var q1 = from room in this.logic.GetAllRooms()
                     where room.Selection == "UNSELECTED"
                     select room;
            foreach (var item in q1)
            {
                this.countUnSELECTED++;
            }
        }

        /// <summary>
        /// Method to generate room.
        /// </summary>
        /// <returns>Models Room.</returns>
        [HttpGet]
        [ActionName("GetOne")]
        public JsonResult GetOne()
        {
            int index = 0;
            int check = 0;

            foreach (var room in this.rooms)
            {
               this.type.Add(room.RoomsType);
               this.amount.Add(room.RoomsAmount);
               this.available.Add(room.RoomsAvailable);
               this.price.Add(room.RoomsPrice);
               this.view.Add(room.RoomsView);
            }

            MyHotel.Models.Rooms roomDb = new ();
            index = rnd.Next(this.type.Count);
            roomDb.RoomsType = this.type[index];
            index = rnd.Next(this.amount.Count);
            roomDb.RoomsAmount = this.amount[index];
            check = this.amount[index];

            index = rnd.Next(this.available.Count);
            while (this.available[index] > check)
            {
                index = rnd.Next(this.available.Count);
            }

            roomDb.RoomsAvailable = this.available[index];
            index = rnd.Next(this.price.Count);
            roomDb.RoomsPrice = this.price[index];
            index = rnd.Next(this.view.Count);
            roomDb.RoomsView = this.view[index];

            index = rnd.Next(0, 2);
            if (index == 0)
            {
                roomDb.Selection = "SELECTED";
            }
            else
            {
                roomDb.Selection = "UNSELECTED";
            }

            this.logic.AddNewRoom(roomDb);

            return this.Json(this.mapper.Map<MyHotel.Models.Rooms, Models.Rooms>(roomDb));
        }

        /// <summary>
        /// Method to add selected to the room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <returns>json.</returns>
        [HttpGet]
        [ActionName("Select")]
        public ApiResult Select(int id)
        {
           // string text = string.Empty;
          //  var room = this.logic.GetOneRoom(id);
            bool result = this.logic.ChangeSelection(id, "SELECTED");
            if (result == true)
            {
                this.countSelected++;
            }

            return new ApiResult() { OperationResult = result, Number = this.countSelected };
        }

        /// <summary>
        /// Method to add unselected to the room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <returns>json.</returns>
        [HttpGet]
        [ActionName("Unselect")]
        public ApiResult UnSelect(int id)
        {
            bool result = this.logic.ChangeSelection(id, "UNSELECTED");
            if (result == true)
            {
                this.countUnSELECTED++;
            }

            return new ApiResult() { OperationResult = result, Number = this.countUnSELECTED };
        }

        /// <summary>
        /// Main View.
        /// </summary>
        /// <returns>IAction.</returns>
        public IActionResult Selections()
        {
            return this.View("Selections", this.model);
        }
    }
}
