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
    /// Test class for testing CRUD operations.
    /// </summary>
    [TestFixture]
    public class CRUD_Test
    {
        /// <summary>
        /// Testing to Get One people.
        /// </summary>
        [Test]
        public void TestGetOnePeople()
        {
            Mock<IPeopleRepository> mockrepo = new Mock<IPeopleRepository>();
            List<People> people = new List<People>()
            {
            new People() { Id = 120, PeopleName = "John", PeopleRoomid = 111, PeopleExtraid = 1234, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") },
            new People() { Id = 121, PeopleName = "Dean", PeopleRoomid = 112, PeopleExtraid = 1232, Country = "England", PeopleCheckin = Convert.ToDateTime("2019-12-05"), PeopleCheckout = Convert.ToDateTime("2019-12-20") },
            };

            mockrepo.Setup(repo => repo.GetOne(people[0].Id)).Returns(people[0]);
            Reception logic = new Reception(mockrepo.Object);

            var result1 = logic.GetOnePeople(people[0].Id);

            Assert.That(result1.PeopleName, Is.EquivalentTo("John"));
            Assert.That(result1.PeopleRoomid, Is.EqualTo(111));
            Assert.That(result1.Country, !Is.EquivalentTo("England"));
            Assert.That(result1.Id, Is.EqualTo(people[0].Id));

            mockrepo.Verify(repo => repo.GetAll(), Times.Never);
            mockrepo.Verify(repo => repo.GetOne(people[0].Id), Times.Once);
            mockrepo.Verify(repo => repo.GetOne(people[0].Id), Times.Once);
        }

        /// <summary>
        /// Testing to get all extra activity.
        /// </summary>
        [Test]
        public void TestGeExtraGetAll()
        {
            Mock<IExtraRepository> mockrepo = new Mock<IExtraRepository>();
            List<Extra> people = new List<Extra>()
            {
             new Extra() { Id = 1233, ExtraType = "Underwater Diving", ExtraPrice = 200, ExtraDays = "Tuesday", ExtraNrpeople = 7, ExtraTicket = "yes" },
             new Extra() { Id = 1234, ExtraType = "Excursion", ExtraPrice = 140, ExtraDays = "Monday", ExtraNrpeople = 30, ExtraTicket = "yes" },
             new Extra() { Id = 1235, ExtraType = "Safari", ExtraPrice = 100, ExtraDays = "Friday", ExtraNrpeople = 15, ExtraTicket = "yes" },
             new Extra() { Id = 1236, ExtraType = "Batiskaf", ExtraPrice = 200, ExtraDays = "Saturday", ExtraNrpeople = 20, ExtraTicket = "yes" },
            };

            mockrepo.Setup(repo => repo.GetAll()).Returns(people.AsQueryable());

            Reception logic = new Reception(mockrepo.Object);

            var result = logic.GetAllExtras();
            int count = 0;

            Assert.That(result.Select(x => x.ExtraPrice).Count(), Is.EqualTo(4));
            foreach (var item in result)
            {
                if (item.ExtraPrice > 100)
                {
                    count++;
                }
            }

            Assert.That(count, Is.EqualTo(3));
            Assert.That(result.Where(x => x.ExtraType == "Safari").Count(), Is.EqualTo(1));
            Assert.That(result.Where(x => x.ExtraType != "Safari").Count(), Is.EqualTo(3));
        }

        /// <summary>
        /// Update the price of the room.
        /// </summary>
        [Test]
        public void RoomPriceUpdate()
        {
            List<Rooms> rooms = new List<Rooms>
            {
                new Rooms() { Id = 111, RoomsType = "Double", RoomsAmount = 10, RoomsAvailable = 8, RoomsPrice = 240, RoomsView = "Seaside" },
                new Rooms() { Id = 112, RoomsType = "Triple", RoomsAmount = 15, RoomsAvailable = 11, RoomsPrice = 300, RoomsView = "Pool" },
                new Rooms() { Id = 113, RoomsType = "Quad", RoomsAmount = 4, RoomsAvailable = 3, RoomsPrice = 400, RoomsView = "Seaside" },
                new Rooms() { Id = 114, RoomsType = "Twin", RoomsAmount = 7, RoomsAvailable = 4, RoomsPrice = 475, RoomsView = "Aqua-Park" },
            };

            Mock<IRoomRepository> mockRepo = new Mock<IRoomRepository>();
            mockRepo.Setup(repo => repo.GetAll()).Returns(rooms.AsQueryable());
            Managers logic = new Managers(mockRepo.Object);

            var result = logic.ChangeRoomPrice(rooms[0].Id, 100);

            mockRepo.Verify(repo => repo.ChangePrice(rooms[0].Id, 100), Times.Once);
            mockRepo.Verify(repo => repo.ChangePrice(rooms[0].Id, 110), Times.Never);
        }

        /// <summary>
        /// Testing to add new people.
        /// </summary>
        [Test]
        public void TestPeopleAdd()
        {
            const int MOCK_ID = 129;
            People people = new People() { Id = 130, PeopleName = "Mirabela", PeopleRoomid = 116, PeopleExtraid = 1238, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") };
            People people1 = new People() { Id = 131, PeopleName = "Mirabela", PeopleRoomid = 116, PeopleExtraid = 1238, Country = "Russia", PeopleCheckin = Convert.ToDateTime("2019-12-13"), PeopleCheckout = Convert.ToDateTime("2019-12-20") };

            Mock<IPeopleRepository> peopleRepo = new Mock<IPeopleRepository>();
            peopleRepo.Setup(repo1 => repo1.AddNewPeople(people));
            Managers logic = new Managers(peopleRepo.Object);

            int peopleId = logic.AddNewPeople(people);
            Assert.That(peopleId, Is.EqualTo(130));
            Assert.That(peopleId, !Is.EqualTo(MOCK_ID));
            peopleRepo.Verify(repo0 => repo0.AddNewPeople(people), Times.Once);
            peopleRepo.Verify(repo2 => repo2.AddNewPeople(people1), Times.Never);
        }

        /// <summary>
        /// Testing to delete a room.
        /// </summary>
        [Test]
        public void TestDeleteRoom()
        {
            Mock<IRoomRepository> roomRepo = new Mock<IRoomRepository>();
            Rooms room8 = new Rooms() { Id = 118, RoomsType = "Suite", RoomsAmount = 1, RoomsAvailable = 0, RoomsPrice = 1200, RoomsView = "Pool" };
            roomRepo.Setup(repo => repo.DeleteRoom(It.IsAny<int>()));
            Managers logic = new Managers(roomRepo.Object);
            int deleteId = logic.DeleteRoom(room8.Id);

            roomRepo.Verify(repo => repo.DeleteRoom(room8.Id), Times.Once);
        }
    }
}
