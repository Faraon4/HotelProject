namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MyHotel.Models;

    /// <summary>
    /// People Repository.
    /// </summary>
    public class PeopleRepository : RepositoryClass<People>, IPeopleRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleRepository"/> class.
        /// </summary>
        /// Constructor.
        /// <param name="ctx">ctx parameter as a HotelDbContext.</param>
        public PeopleRepository(HotelDbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Implementing the AddNewPeople from IPoepleRepository interface, that add new people..
        /// </summary>
        /// <param name="people">people parameter.</param>
        public void AddNewPeople(People people)
        {
            this.ctx.Add(people);
            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the Change People Room method from IPeopleRepository interface, that changes the room for the people.
        /// </summary>
        /// <param name="peopleId">id of the people.</param>
        /// <param name="newRoomId">id of the room.</param>
        public void ChangePeopleRoom(int peopleId, int newRoomId)
        {
            RoomRepository roomRepository = new RoomRepository(this.ctx);
            int count = 0;
            var q = roomRepository.GetAll();
            var people = this.GetOne(peopleId);
            if (people == null)
            {
                throw new PeopleRepException("People  not found");
            }
            else
            {
                foreach (var item in q)
                {
                    if (item.Id == newRoomId)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    people.PeopleRoomid = newRoomId;
                }
                else
                {
                    throw new PeopleRepException("Room not found");
                }
            }

            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the ChangePeopleExtra() method from the IPeopleRepository interface, that changed the extra activity of the people.
        /// </summary>
        /// <param name="peopleId">id of the people.</param>
        /// <param name="newExtraId">id of the extra activity.</param>
        public void ChangePeopleExtra(int peopleId, int newExtraId)
        {
            ExtraRepository extraRepository = new ExtraRepository(this.ctx);
            int count = 0;
            var q = extraRepository.GetAll();
            var people = this.GetOne(peopleId);
            if (people == null)
            {
                throw new PeopleRepException("People not found");
            }
            else
            {
                foreach (var item in q)
                {
                    if (item.Id == newExtraId)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    people.PeopleExtraid = newExtraId;
                }
                else
                {
                    throw new PeopleRepException("Extra not found");
                }
            }

            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the DeletePeople From IPeopleRepository, that delete people.
        /// </summary>
        /// <param name="peopleID">id of the people.</param>
        public void DeletePeople(int peopleID)
        {
            var people = this.GetOne(peopleID);
            if (people == null)
            {
                throw new PeopleRepException("People not found");
            }

            this.ctx.Remove(people);
            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Get one object of type People.
        /// </summary>
        /// <param name="id">id parameter.</param>
        /// <returns>people with the current id.</returns>
        public override People GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.Id == id);
        }
    }
}
