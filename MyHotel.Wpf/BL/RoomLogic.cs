namespace MyHotel.Wpf.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight.Messaging;
    using MyHotel.Logic;
    using MyHotel.Models;
    using MyHotel.Repository;

    /// <summary>
    /// Class that will imlpement the CRUD methods.
    /// </summary>
    public class RoomLogic : IRoomLogic
    {
       private IEditorService editorService;
       private IMessenger messengerService;
       private HotelDbContext ctx;
       private RoomRepository repo;
       private Managers logic;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomLogic"/> class.
        /// Constructor to declare the parameters.
        /// </summary>
        /// <param name="editorService">editor service parameter.</param>
        /// <param name="messengerService">messenger service parameter.</param>
       public RoomLogic(IEditorService editorService, IMessenger messengerService)
       {
            this.editorService = editorService;
            this.messengerService = messengerService;
            this.ctx = new HotelDbContext();
            this.repo = new RoomRepository(this.ctx);
            this.logic = new Managers(this.repo);
       }

        /// <summary>
        /// Method to make the convertion of the room from the db to the vm.
        /// </summary>
        /// <param name="dbList">list of parameters from the database.</param>
        /// <returns>list of the vm rooms.</returns>
       public static IList<RoomVM> FromDbToVM(IList<Rooms> dbList)
       {
            IList<RoomVM> converted = new List<RoomVM>();
            foreach (var room in dbList)
            {
                RoomVM current = new RoomVM();
                current.Id = room.Id;
                current.Type = room.RoomsType;
                current.Amount = room.RoomsAmount;
                current.Available = room.RoomsAvailable;
                current.Price = room.RoomsPrice;
                current.View = room.RoomsView;
                converted.Add(current);
            }

            return converted;
       }

        /// <summary>
        /// Method to convert room vm from vm to db.
        /// </summary>
        /// <param name="roomVM">room vm parameter.</param>
        /// <returns>type room.</returns>
       public static Rooms FromVMtoDb(RoomVM roomVM)
       {
            Rooms roomDb = new Rooms();
            roomDb.Id = roomVM.Id;
            roomDb.RoomsType = roomVM.Type;
            roomDb.RoomsAmount = roomVM.Amount;
            roomDb.RoomsAvailable = roomVM.Available;
            roomDb.RoomsPrice = roomVM.Price;
            roomDb.RoomsView = roomVM.View;

            return roomDb;
       }

        /// <summary>
        /// Implementing the Add method from the IRoomLogic.
        /// </summary>
        /// <param name="list">list of the rooms.</param>
       public void AddRoom(IList<RoomVM> list)
       {
            RoomVM newRoom = new RoomVM();
            if (this.editorService.EditRoom(newRoom) == true)
            {
                list.Add(newRoom);
                this.logic.AddNewRoom(FromVMtoDb(newRoom));
                this.messengerService.Send("ADD OK", "LogicResult");
            }
            else
            {
                this.messengerService.Send("ADD Fail", "LogicResult");
            }
       }

        /// <summary>
        /// Implementing the delete all method from the IRoomLogic.
        /// </summary>
        /// <param name="list">list of the room that have to be deleted.</param>
       public void DellAll(IList<RoomVM> list)
       {
            list.Clear();
       }

        /// <summary>
        /// Implementing the delete room method from the IRoomLogic.
        /// </summary>
        /// <param name="list">list of the rooms.</param>
        /// <param name="room">room that have to be deleted.</param>
       public void DelRoom(IList<RoomVM> list, RoomVM room)
       {
            Rooms roomDb = FromVMtoDb(room);
            if (room != null && list.Remove(room))
            {
                this.logic.DeleteRoom(roomDb.Id);
                this.messengerService.Send("DELETE OK", "LogicResult");
            }
            else
            {
                this.messengerService.Send("DELETE FAILED", "LogicResult");
            }
       }

        /// <summary>
        /// Implementing the get all rooms method from the IRoomLogic.
        /// </summary>
        /// <param name="list">list of rooms.</param>
       public void GetAllRooms(IList<RoomVM> list)
       {
            var q = from room in this.repo.GetAll()
                    select new RoomVM
                    {
                        Id = room.Id,
                        Type = room.RoomsType,
                        Amount = room.RoomsAmount,
                        Available = room.RoomsAvailable,
                        Price = room.RoomsPrice,
                        View = room.RoomsView,
                    };
            list.Clear();
            foreach (var room in q)
            {
                list.Add(room);
            }
       }

        /// <summary>
        /// Implementing the modify method from the IRoomLogic.
        /// </summary>
        /// <param name="roomToModify">room that need to be modified.</param>
       public void ModRoom(RoomVM roomToModify)
       {
            if (roomToModify == null)
            {
                this.messengerService.Send("EDIT FAILED", "LogicResult");
                return;
            }

            RoomVM clone = new RoomVM();
            clone.CopyFrom(roomToModify);

            if (this.editorService.EditRoom(clone) == true)
            {
                roomToModify.CopyFrom(clone);
                Rooms room = FromVMtoDb(roomToModify);
                this.logic.ChangeRoomPrice(room.Id, room.RoomsPrice);
                this.ctx.SaveChanges();
                this.messengerService.Send("Edited OK", "LogicResult");
            }
            else
            {
                this.messengerService.Send("Edited Fail", "LogicResult");
            }
       }
    }
}
