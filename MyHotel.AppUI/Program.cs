namespace MyHotel.AppUI
{
    using System;
    using System.Threading.Tasks;
    using ConsoleTools;
    using MyHotel.Logic;
    using MyHotel.Models;
    using MyHotel.Repository;

    /// <summary>
    /// Main Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Id, Room Type and the price of each room.
        /// </summary>
        /// <param name="reception">logic Parameter to coonect to the reception class and to call method GetRoomPrice().</param>
        private static void PriceUsingLogic(Reception reception)
        {
            foreach (var item in reception.GetRoomsPrice())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Print the Id , Extra Activity and the Price.
        /// </summary>
        /// <param name="reception">reception parameter to connect to the reception class and to call method GetExtraPrice().</param>
        private static void PriceExtraLogic(Reception reception)
        {
            foreach (var item in reception.GetExtraPrice())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Print the information about the people.
        /// </summary>
        /// <param name="reception">reception parameter to connect to the reception class and to call method PeopleCountryLogic().</param>
        private static void PeopleCountryLogic(Reception reception)
        {
            foreach (var item in reception.GetCountryPeople())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Adding new room.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to add new room.</param>
        private static void AddNewRoom(Managers management)
        {
            Rooms room = new Rooms();

            Console.WriteLine("Id of the New Room:");
            room.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Type Of The Room:");
            room.RoomsType = Console.ReadLine();

            Console.WriteLine("Amount of Rooms:");
            room.RoomsAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Available  Rooms:");
            room.RoomsAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Price of Rooms:");
            room.RoomsPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("View of Rooms:");
            room.RoomsView = Console.ReadLine();

            management.AddNewRoom(room);
        }

        /// <summary>
        /// Add New Extra Activity.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to add new extra.</param>
        private static void AddnewExtra(Managers management)
        {
            Extra extra = new Extra();
            Console.WriteLine("ID of the New Extra");
            extra.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Type of New Extra Activity");
            extra.ExtraType = Console.ReadLine();

            Console.WriteLine("Extra Price");
            extra.ExtraPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Available Days");
            extra.ExtraDays = Console.ReadLine();

            Console.WriteLine("Nr of people available");
            extra.ExtraNrpeople = int.Parse(Console.ReadLine());

            Console.WriteLine("Do You Need a ticket yes/no");
            extra.ExtraTicket = Console.ReadLine();

            management.AddNewExtra(extra);
        }

        /// <summary>
        /// Method to add new people.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to add new people.</param>
        private static void AddNewPeople(Managers management)
        {
            People people = new People();
            Console.WriteLine("Id Of People:");
            people.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Name Of People:");
            people.PeopleName = Console.ReadLine();

            Console.WriteLine("Room Of People:");
            people.PeopleRoomid = int.Parse(Console.ReadLine());

            Console.WriteLine("Country Of People:");
            people.Country = Console.ReadLine();

            Console.WriteLine("Check-In-Date: year, month, day");
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            people.PeopleCheckin = new DateTime(year, month, day);

            Console.WriteLine("Check-Out-Date: year, month, day");
            int yearOut = int.Parse(Console.ReadLine());
            int monthOut = int.Parse(Console.ReadLine());
            int dayOut = int.Parse(Console.ReadLine());
            people.PeopleCheckout = new DateTime(yearOut, monthOut, dayOut);

            management.AddNewPeople(people);
        }

        /// <summary>
        /// Method to Change the Price of the Room.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to change the price of the room.</param>
        private static void ChangeRoomPrice(Managers management)
        {
            Console.WriteLine("ID of room that you want to change the price:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The New Price:");
            int newPrice = int.Parse(Console.ReadLine());
            try
            {
                management.ChangeRoomPrice(n, newPrice);
            }
            catch (RoomRepException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method to Change the room of the people.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to change the room of people.</param>
        private static bool ChangeRoomPeople(Managers management)
        {
            Console.WriteLine("ID of people that you want to change the room:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Id of the new room:");
            int newRoomId = int.Parse(Console.ReadLine());
            bool result = false;
            try
            {
                management.ChangeRoomPeople(n, newRoomId);
                management.ChangeRoomAvailable(newRoomId);
                result = true;
            }
           catch (PeopleRepException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (RoomRepException ee)
            {
                Console.WriteLine(ee.Message);
            }

            return result;
        }

        /// <summary>
        /// Method to Change the extra activity of the people.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to change extra activity of the people.</param>
        private static bool ChangeExtraPeople(Managers management)
        {
            bool result = false;
            Console.WriteLine("ID of people that you want to change the extra:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Id of the new extra:");
            int newExtraId = int.Parse(Console.ReadLine());
            try
            {
                management.ChangeExtraPeople(n, newExtraId);
                result = true;
            }
            catch (PeopleRepException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }

        /// <summary>
        /// Method to change the price of extra activity.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to change the price of the extra activity.</param>
        private static void ChangeExtraPrice(Managers management)
        {
            Console.WriteLine("ID of extra that you want to change the price:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The New Price:");
            int newPrice = int.Parse(Console.ReadLine());
            management.ChangeExtraPrice(n, newPrice);
            Console.ReadLine();
        }

        /// <summary>
        /// Method for removing the room.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to delete the room.</param>
        /// <param name="n">id of the room that want to delete.</param>
        private static void RemoveRoom(Managers management, int n)
        {
            try
            {
                management.DeleteRoom(n);
            }
            catch (RoomRepException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method that will delete rooms, by asking the ID of the room that want to delete, to check if this room exists, and then to change the room of people that have this room.
        /// </summary>
        /// <param name="management">management paramter to connect to manager and to be able to delete.</param>
        /// <param name="reception">reception parameter to connect to reception and to read information.</param>
        private static void DeleteRoom(Managers management, Reception reception)
        {
            Console.WriteLine("ID of room that you want to delete");
            int n = int.Parse(Console.ReadLine());
            var q = reception.RoomNrID();
            foreach (var item in q)
            {
                if (item.ID == n)
                {
                    if (item.Nr == 0)
                    {
                        RemoveRoom(management, n);
                    }
                    else
                    {
                        Console.WriteLine("First of all look what people have this room");
                        Console.ReadLine();
                        var q1 = reception.GetCountryPeople();
                        foreach (var items in q1)
                        {
                            if (items.IdOfRoom == n)
                            {
                                Console.WriteLine(items);
                            }
                        }

                        Console.ReadLine();
                        Console.WriteLine("Now Change the room of people");
                        for (int i = 0; i < item.Nr; i++)
                        {
                            while (ChangeRoomPeople(management) == false)
                            {
                                ChangeRoomPeople(management);
                            }

                            if (i == item.Nr - 2)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Now you will remove the room with id : " + n);
            RemoveRoom(management, n);
        }

        /// <summary>
        /// Remove Extra.
        /// </summary>
        /// <param name="management">parameter to connect to manager and to delete the extra activity.</param>
        /// <param name="n">id of the extra.</param>
        private static void RemoveExtra(Managers management, int n)
        {
            try
            {
                management.DeleteExtra(n);
            }
            catch (ExtraRepException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method that will delete rooms, by asking the ID of the extra that want to delete, to check if this extra exists, and then to change the extra activity of people that have this extra.
        /// </summary>
        /// <param name="management">management paramter to connect to manager and to be able to delete.</param>
        /// <param name="reception">reception parameter to connect to reception and to read information.</param>
        private static void DeleteExtra(Managers management, Reception reception)
        {
            Console.WriteLine("ID of extra that you want to delete");
            int n = int.Parse(Console.ReadLine());
            var q = reception.ExtraNrId();
            foreach (var item in q)
            {
                if (item.ID == n)
                {
                    if (item.Nr == 0)
                    {
                        RemoveExtra(management, n);
                    }
                    else
                    {
                        Console.WriteLine("First of all look what people have this extra");
                        Console.ReadLine();
                        var q1 = reception.GetCountryPeople();
                        foreach (var items in q1)
                        {
                            if (items.IdOfExtra == n)
                            {
                                Console.WriteLine(items);
                            }
                        }

                        Console.ReadLine();
                        Console.WriteLine("Now Change the extra of people");
                        for (int i = 0; i < item.Nr; i++)
                        {
                            while (ChangeExtraPeople(management) == false)
                            {
                                ChangeExtraPeople(management);
                            }

                            if (i == item.Nr)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Now you will remove the extra");
            RemoveExtra(management, n);
        }

        /// <summary>
        /// Remove a people.
        /// </summary>
        /// <param name="management">management paramter to connect to manager and to be able to delete.</param>
        private static void RemovePeople(Managers management)
        {
            Console.WriteLine("Id of people that you want to delete");
            int n = int.Parse(Console.ReadLine());
            try
            {
                management.DeletePeople(n);
            }
            catch (PeopleRepException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method that implements the non-crud operation of counting the number of extra activity.
        /// </summary>
        /// <param name="extra">extra parameter, to connect to Reception and to call the method that will do our goal.</param>
        private static void NumberOfExtra(Reception extra)
        {
            foreach (var item in extra.ExtraNumber())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method that implements the non-crud operation of calculating the total price that each people pay for their holiday.
        /// </summary>
        /// <param name="people">people parameter,to connect to Reception and to call the method that will do our goal.</param>
        private static void TotalPrice(Reception people)
        {
            foreach (var item in people.TotalPrice())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method that implements the non-crud operation that will count how many rooms of each kind are used.
        /// </summary>
        /// <param name="rooms">rooms parameter,to connect to Reception and to call the method that will do our goal.</param>
        private static void NumberOfRooms(Reception rooms)
        {
            foreach (var item in rooms.RoomNr())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Task to count how many people pay for their holiday.
        /// </summary>
        /// <param name="reception">reception parameter,to connect to Reception and to call the method that will do our goal, by calling the necessary method.</param>
        private static void TotalPriceTask(Reception reception)
        {
            foreach (var item in reception.TaskTotalPrice().Result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Task to count how many rooms of each type are used.
        /// </summary>
        /// <param name="reception">reception parameter to connect to Reception and to call the method that will do our goal, by calling the necessary method.</param>
        private static void RoomNumbTask(Reception reception)
        {
            foreach (var item in reception.TaskNumberOfRooms().Result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Task to count how many extra of each type are used.
        /// </summary>
        /// <param name="reception">reception parameter to connect to Reception and to call the method that will do our goal, by calling the necessary method.</param>
        private static void ExtraNumbTask(Reception reception)
        {
            foreach (var item in reception.TaskNumberOfExtra().Result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// The main method.
        /// </summary>
        private static void Main()
        {
            HotelDbContext ctx = new HotelDbContext();
            RoomRepository roomRepository = new RoomRepository(ctx);
            PeopleRepository peopleRepository = new PeopleRepository(ctx);
            ExtraRepository extraRepository = new ExtraRepository(ctx);
            Managers management = new Managers(extraRepository, peopleRepository, roomRepository);
            Reception reception = new Reception(extraRepository, peopleRepository, roomRepository);

            var menu = new ConsoleMenu().
                     Add("ID + Room Type + Price", () => PriceUsingLogic(reception)).
                     Add("Id + Extra Type + Price", () => PriceExtraLogic(reception)).
                     Add("Information about People", () => PeopleCountryLogic(reception)).
                     Add("Add New Room", () => AddNewRoom(management)).
                     Add("Add New Extra Activity", () => AddnewExtra(management)).
                     Add("Add New People", () => AddNewPeople(management)).
                     Add("Delete Room", () => DeleteRoom(management, reception)).
                     Add("Delete Extra", () => DeleteExtra(management, reception)).
                     Add("Delete People", () => RemovePeople(management)).
                     Add("Change Room Price", () => ChangeRoomPrice(management)).
                     Add("Change price of extra activity", () => ChangeExtraPrice(management)).
                     Add("Change the room of the people", () => ChangeRoomPeople(management)).
                     Add("Number of each extra activity", () => NumberOfExtra(reception)).
                     Add("Total price that people pay", () => TotalPrice(reception)).
                     Add("Number of each room type", () => NumberOfRooms(reception)).
                     Add("Call with task total price", () => TotalPriceTask(reception)).
                     Add("Call with task number of room", () => RoomNumbTask(reception)).
                     Add("Call with task number of extra", () => ExtraNumbTask(reception)).
                     Add("QUIT", ConsoleMenu.Close);
            menu.Show();
        }
    }
}
