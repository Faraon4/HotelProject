namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using MyHotel.Models;

    /// <summary>
    /// Repository for the Room.
    /// </summary>
    public class RoomRepository : RepositoryClass<Rooms>, IRoomRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomRepository"/> class.
        /// </summary>
        /// <param name="ctx">ctx parameter.</param>
        public RoomRepository(HotelDbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Implementing the method from IRoomRepository, that add a new room.
        /// </summary>
        /// <param name="newRoom">newRoom parameter.</param>
        public void AddNewEntity(Rooms newRoom)
        {
            this.ctx.Add(newRoom);
            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implemention the method  ChangingPrice() from IRoomRepository, that change the price of the room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <param name="newprice">newprice for the room.</param>
        public void ChangePrice(int id, int newprice)
        {
            var room = this.GetOne(id);

            if (room == null)
                {
                    throw new RoomRepException("Room not found");
                }
                else
                {
                    room.RoomsPrice = newprice;
                }

            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the method from IRoomRepository, that change how many rooms are available.
        /// </summary>
        /// <param name="id">id of the room.</param>
        public void ChangeAvailableRoom(int id)
        {
            var room = this.GetOne(id);
            if (room == null)
            {
                throw new RoomRepException("Room not found");
            }
            else
            {
                if (room.RoomsAvailable < room.RoomsAmount)
                {
                    room.RoomsAvailable++;
                }
                else
                {
                    throw new RoomRepException("Choose other room, there are no more this kind of rooms.");
                }
            }
        }

        /// <summary>
        /// Implementing the DeleteRoom method from the Interface, that delete room.
        /// </summary>
        /// <param name="roomId">id of the room.</param>
        public void DeleteRoom(int roomId)
        {
           var room = this.GetOne(roomId);
           if (room == null)
           {
              throw new RoomRepException("Room not found");
           }
           else
           {
            this.ctx.Remove(room);
           }

           this.ctx.SaveChanges();
        }

        /// <summary>
        /// Get one room by the id.
        /// </summary>
        /// <param name="id">id that will be used.</param>
        /// <returns>room with all information about this.</returns>
        public override Rooms GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Implementing the method to change the selection of the room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <param name="text">text that you want to change.</param>
        /// <returns>true or false.</returns>
        public bool ChangeSelection(int id, string text)
        {
            var room = this.GetOne(id);
            if (room == null)
            {
                throw new RoomRepException("Room not Found");
            }
            else
            {
                room.Selection = text;
            }

            this.ctx.SaveChanges();
            return true;
        }
    }
}
