namespace MyHotel.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Moq;
    using MyHotel.Logic;
    using MyHotel.Models;
    using MyHotel.Repository;
    using NUnit.Framework;

    /// <summary>
    /// Class for testing NON-CRUD operations.
    /// </summary>
    public class NON_CRUD_Test
    {
       private Mock<IPeopleRepository> peopleRepo;
       private Mock<IRoomRepository> roomRepo;
       private Mock<IExtraRepository> extraRepo;
       private List<TotalPrice> expectedResultTotal;
       private List<RoomNr> expectedResultRoomNr;
       private List<ExtraNumber> extraResultExtraNumber;

        /// <summary>
        /// Creaing the logic with mocks.
        /// </summary>
        /// <returns>reception.</returns>
       public Reception CreateLogicWithMocks()
        {
            this.extraRepo = new Mock<IExtraRepository>();
            this.peopleRepo = new Mock<IPeopleRepository>();
            this.roomRepo = new Mock<IRoomRepository>();
            List<People> people = new List<People>()
            {
             new People() { Id = 120, PeopleName = "John", PeopleRoomid = 111, PeopleExtraid = 1234, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") },
             new People() { Id = 121, PeopleName = "Dean", PeopleRoomid = 112, PeopleExtraid = 1232, Country = "England", PeopleCheckin = Convert.ToDateTime("2019-12-05"), PeopleCheckout = Convert.ToDateTime("2019-12-20") },
             new People() { Id = 122, PeopleName = "Jake", PeopleRoomid = 114, PeopleExtraid = 1237, Country = "Germany", PeopleCheckin = Convert.ToDateTime("2020-01-04"), PeopleCheckout = Convert.ToDateTime("2020-01-11") },
             new People() { Id = 131, PeopleName = "Drake", PeopleRoomid = 112, PeopleExtraid = 1231, Country = "Poland", PeopleCheckin = Convert.ToDateTime("2020-01-13"), PeopleCheckout = Convert.ToDateTime("2020-01-20") },
             new People() { Id = 123, PeopleName = "Alfred", PeopleRoomid = 114, PeopleExtraid = 1238, Country = "Spain", PeopleCheckin = Convert.ToDateTime("2019-12-20"), PeopleCheckout = Convert.ToDateTime("2019-12-27") },
            };

            List<Extra> extra = new List<Extra>()
            {
              new Extra() { Id = 1234, ExtraType = "Excursion", ExtraPrice = 140, ExtraDays = "Monday", ExtraNrpeople = 30, ExtraTicket = "yes" },
              new Extra() { Id = 1232, ExtraType = "Parachute", ExtraPrice = 90, ExtraDays = "Every Day", ExtraNrpeople = 2, ExtraTicket = "yes" },
              new Extra() { Id = 1237, ExtraType = "Banana", ExtraPrice = 50, ExtraDays = "Every Day", ExtraNrpeople = 7, ExtraTicket = "yes" },
              new Extra() { Id = 1231, ExtraType = "Muzeum", ExtraPrice = 10, ExtraDays = "Sunday", ExtraNrpeople = 100, ExtraTicket = "yes" },
              new Extra() { Id = 1238, ExtraType = "Night Excursion", ExtraPrice = 10, ExtraDays = "Wednesday", ExtraNrpeople = 40, ExtraTicket = "yes" },
            };

            List<Rooms> rooms = new List<Rooms>()
            {
                new Rooms() { Id = 111, RoomsType = "Double", RoomsAmount = 10, RoomsAvailable = 8, RoomsPrice = 240, RoomsView = "Seaside" },
                new Rooms() { Id = 112, RoomsType = "Triple", RoomsAmount = 15, RoomsAvailable = 11, RoomsPrice = 300, RoomsView = "Pool" },
                new Rooms() { Id = 114, RoomsType = "Twin", RoomsAmount = 7, RoomsAvailable = 4, RoomsPrice = 475, RoomsView = "Aqua-Park" },
            };

            this.expectedResultTotal = new List<TotalPrice>()
            {
                new TotalPrice() { Name = "John", Extra = "Excursion", Room = "Double", Price = 380 },
                new TotalPrice() { Name = "Dean", Extra = "Parachute", Room = "Triple", Price = 390 },
                new TotalPrice() { Name = "Jake", Extra = "Banana", Room = "Twin", Price = 525 },
                new TotalPrice() { Name = "Drake", Extra = "Muzeum", Room = "Triple", Price = 310 },
                new TotalPrice() { Name = "Alfred", Extra = "Night Excursion", Room = "Twin", Price = 485 },
            };

            this.expectedResultRoomNr = new List<RoomNr>()
            {
                new RoomNr { RoomType = "Double", Nr = 1 },
                new RoomNr { RoomType = "Triple", Nr = 2 },
                new RoomNr { RoomType = "Twin", Nr = 2 },
            };

            this.extraResultExtraNumber = new List<ExtraNumber>()
            {
                new ExtraNumber() { Extra = "Excursion", Nr = 1 },
                new ExtraNumber() { Extra = "Parachute", Nr = 1 },
                new ExtraNumber() { Extra = "Banana", Nr = 1 },
                new ExtraNumber() { Extra = "Muzeum", Nr = 1 },
                new ExtraNumber() { Extra = "Night Excursion", Nr = 1 },
            };

            this.extraRepo.Setup(repo => repo.GetAll()).Returns(extra.AsQueryable());
            this.peopleRepo.Setup(repo => repo.GetAll()).Returns(people.AsQueryable());
            this.roomRepo.Setup(repo => repo.GetAll()).Returns(rooms.AsQueryable());

            return new Reception(this.extraRepo.Object, this.peopleRepo.Object, this.roomRepo.Object);
        }

        /// <summary>
        /// Testing the non-crud operation of how many people pay for their holiday.
        /// </summary>
       [Test]
       public void TestTotalPrice()
        {
            var logic = this.CreateLogicWithMocks();

            var totalPrice = logic.TotalPrice();

            Assert.That(totalPrice, Is.EquivalentTo(this.expectedResultTotal));
            Assert.That(totalPrice.Count(), Is.EqualTo(5));
            Assert.That(totalPrice.Count(), Is.GreaterThan(0));

            this.extraRepo.Verify(repo => repo.GetAll(), Times.Once);
            this.peopleRepo.Verify(repo => repo.GetAll(), Times.Once);
            this.roomRepo.Verify(repo => repo.GetAll(), Times.Once);
        }

        /// <summary>
        /// Testing the non-crud operation of how many room of each type are used.
        /// </summary>
       [Test]
       public void RoomNr()
        {
            var logic = this.CreateLogicWithMocks();

            var roomNr = logic.RoomNr();

            Assert.That(roomNr.Count(), Is.EqualTo(3));
            Assert.That(roomNr, Is.EquivalentTo(this.expectedResultRoomNr));

            this.extraRepo.Verify(repo => repo.GetAll(), Times.Never);
            this.peopleRepo.Verify(repo => repo.GetAll(), Times.Once);
            this.roomRepo.Verify(repo => repo.GetAll(), Times.Once);
        }

        /// <summary>
        /// Testing the non-crud operation of how many extra activity are picked by people.
        /// </summary>
       [Test]
       public void PeopleExtra()
        {
            var logic = this.CreateLogicWithMocks();

            var extranr = logic.ExtraNumber();

            Assert.That(extranr.Count(), Is.EqualTo(5));
            Assert.That(extranr, Is.EquivalentTo(this.extraResultExtraNumber));

            this.extraRepo.Verify(repo => repo.GetAll(), Times.Once);
            this.peopleRepo.Verify(repo => repo.GetAll(), Times.Once);
            this.roomRepo.Verify(repo => repo.GetAll(), Times.Never);
        }
    }
}
