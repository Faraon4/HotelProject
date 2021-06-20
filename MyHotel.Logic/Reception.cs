namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MyHotel.Models;
    using MyHotel.Repository;

    /// <summary>
    /// Reception class -> implements the IReception interface.
    /// </summary>
    public class Reception : IReception
    {
        private IExtraRepository extraRepository;
        private IPeopleRepository peopleRepository;
        private IRoomRepository roomRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="Reception"/> class.
        /// Constructor that take as parameter all 3 repository.
        /// </summary>
        /// <param name="extraRepository">parameter to connect to the extra repository.</param>
        /// <param name="peopleRepository">parameter to connect to people repository.</param>
        /// <param name="roomRepository">parameter to connect to room repository.</param>
        public Reception(IExtraRepository extraRepository, IPeopleRepository peopleRepository, IRoomRepository roomRepository)
        {
            this.extraRepository = extraRepository;
            this.peopleRepository = peopleRepository;
            this.roomRepository = roomRepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reception"/> class.
        /// Constructor that take as parameter only 1 repository extraRepository.
        /// </summary>
        /// <param name="extraRepository">extraRepository parameter that will help to make connection to extra Repository.</param>
        public Reception(IExtraRepository extraRepository)
        {
            this.extraRepository = extraRepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reception"/> class.
        /// Constructor that take as parameter only 1 repository peopleRepository.
        /// </summary>
        /// <param name="peopleRepository">peopleRepository parameter that will help to make connection to extra Repository.</param>
        public Reception(IPeopleRepository peopleRepository)
        {
            this.peopleRepository = peopleRepository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reception"/> class.
        /// Constructor that take as parameter only 1 repository roomRepository.
        /// </summary>
        /// <param name="roomRepository">roomRepository paramter that will help to make connection to extra Repository.</param>
        public Reception(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        /// <summary>
        /// Implementing method from IReception interface, to find how many extra activity of each type , people choose.
        /// </summary>
        /// <returns>as a list of extra activity and the number of how many people choose this activity.</returns>
        public IList<ExtraNumber> ExtraNumber()
        {
            var q1 = from people in this.peopleRepository.GetAll()
                     join extra in this.extraRepository.GetAll() on people.PeopleExtraid equals extra.Id
                     group extra by extra.ExtraType into grp
                     select new ExtraNumber
                     {
                         Extra = grp.Key,
                         Nr = grp.Count(),
                     };
            return q1.ToList();
        }

        /// <summary>
        /// Implementing the method from IReception interface, to find how many rooms of each type, people choose.
        /// </summary>
        /// <returns>as a list of rooms and the number of how many room people choose.</returns>
        public IList<RoomNr> RoomNr()
        {
            var q = from room in this.roomRepository.GetAll()
                    join people in this.peopleRepository.GetAll() on room.Id equals people.PeopleRoomid
                    group room by room.RoomsType into grp
                    select new RoomNr
                    {
                        RoomType = grp.Key,
                        Nr = grp.Count(),
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing the method from IReception interface, to find how many rooms of each type by id, people choose.
        /// </summary>
        /// <returns>as a list of id of rooms and the number of how many room people choose.</returns>
        public IList<RoomNrByID> RoomNrID()
        {
            var q = from room in this.roomRepository.GetAll()
                    join people in this.peopleRepository.GetAll() on room.Id equals people.PeopleRoomid
                    group room by room.Id into grp
                    select new RoomNrByID
                    {
                        ID = grp.Key,
                        Nr = grp.Count(),
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing the method from IReception interface, to find how many extras of each type by id, people choose.
        /// </summary>
        /// <returns>as a list of id of extra activity and the number of how many people choose this activity.</returns>
        public IList<ExtraNrID> ExtraNrId()
        {
            var q = from extra in this.extraRepository.GetAll()
                    join people in this.peopleRepository.GetAll() on extra.Id equals people.PeopleExtraid
                    group extra by extra.Id into grp
                    select new ExtraNrID
                    {
                        ID = grp.Key,
                        Nr = grp.Count(),
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing the method from the IReception interface, to count how many $ people pay for their holiday.
        /// </summary>
        /// <returns>as a list of how many $ did every people pay.</returns>
        public IList<TotalPrice> TotalPrice()
        {
            var q = from people in this.peopleRepository.GetAll()
                    join extra in this.extraRepository.GetAll() on people.PeopleExtraid equals extra.Id
                    join room in this.roomRepository.GetAll() on people.PeopleRoomid equals room.Id
                    select new TotalPrice
                    {
                        Name = people.PeopleName,
                        Room = room.RoomsType,
                        Extra = extra.ExtraType,
                        Price = extra.ExtraPrice + room.RoomsPrice,
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing the mehtond from IReception for reading all extras.
        /// </summary>
        /// <returns>list of extras.</returns>
        public IList<Extra> GetAllExtras()
        {
            return this.extraRepository.GetAll().ToList();
        }

        /// <summary>
        /// Implementing the mehtond from IReception for reading all people.
        /// </summary>
        /// <returns>list of people.</returns>
        public IList<People> GetAllPeople()
        {
            return this.peopleRepository.GetAll().ToList();
        }

        /// <summary>
        /// Implementing the mehtond from IReception for reading all rooms.
        /// </summary>
        /// <returns>list of rooms.</returns>
        public IList<Rooms> GetAllRooms()
        {
            return this.roomRepository.GetAll().ToList();
        }

        /// <summary>
        /// Implementing method from IManagement that Read informationa bout people.
        /// </summary>
        /// <returns>list of people and where are they from, what room did they choose and what extra activity did they choose.</returns>
        public IList<PeopleCountry> GetCountryPeople()
        {
            var q = from people in this.peopleRepository.GetAll()
                    select new PeopleCountry
                    {
                        ID = people.Id,
                        PeopleName = people.PeopleName,
                        Country = people.Country,
                        IdOfRoom = people.PeopleRoomid,
                        IdOfExtra = people.PeopleExtraid,
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing method from IReception that Read extra activity and their price.
        /// </summary>
        /// <returns>list of extra activity and their price.</returns>
        public IList<PriceResultExtra> GetExtraPrice()
        {
            var q = from extra in this.extraRepository.GetAll()
                    select new PriceResultExtra
                    {
                        ID = extra.Id,
                        ExtraType = extra.ExtraType,
                        PriceRes = extra.ExtraPrice,
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing method from IReception that Read room and their price.
        /// </summary>
        /// <returns>list of room and their price.</returns>
        public IList<PriceResult> GetRoomsPrice()
        {
            var q = from room in this.roomRepository.GetAll()
                    select new PriceResult
                    {
                        ID = room.Id,
                        RoomType = room.RoomsType,
                        Price = room.RoomsPrice,
                    };
            return q.ToList();
        }

        /// <summary>
        /// Implementing the mehtond from IReception for reading one extra activity by id.
        /// </summary>
        /// <param name="id">id of the extra activity.</param>
        /// <returns>information about extra activity.</returns>
        public Extra GetOneExtra(int id)
        {
            return this.extraRepository.GetOne(id);
        }

        /// <summary>
        /// Implementing the mehtond from IReception for reading one people by id.
        /// </summary>
        /// <param name="id">id of the people.</param>
        /// <returns>information about people.</returns>
        public People GetOnePeople(int id)
        {
            return this.peopleRepository.GetOne(id);
        }

        /// <summary>
        /// Implementing the mehtond from IReception for reading one room by id.
        /// </summary>
        /// <param name="id">id of the room.</param>
        /// <returns>information about room.</returns>
        public Rooms GetOneRoom(int id)
        {
            return this.roomRepository.GetOne(id);
        }

        /// <summary>
        /// Calling the non-crud operation that count how many people pay for their holiday , with the help of the Task.
        /// </summary>
        /// <returns>List of total price.</returns>
        public Task<IList<TotalPrice>> TaskTotalPrice()
        {
            return Task.Run(() => this.TotalPrice());
        }

        /// <summary>
        /// Calling the non-crud operation thatacount how many rooms of each type are used.
        /// </summary>
        /// <returns>List of rooms and the price.</returns>
        public Task<IList<RoomNr>> TaskNumberOfRooms()
        {
            return Task.Run(() => this.RoomNr());
        }

        /// <summary>
        /// Calling the non-crud operation that count how many extra activity, of each type,people choose.
        /// </summary>
        /// <returns>List of extra activity and their price.</returns>
        public Task<IList<ExtraNumber>> TaskNumberOfExtra()
        {
            return Task.Run(() => this.ExtraNumber());
        }
    }
}
