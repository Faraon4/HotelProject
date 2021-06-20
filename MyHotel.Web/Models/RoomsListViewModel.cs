namespace MyHotel.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for the viewmodel of the rooms.
    /// </summary>
    public class RoomsListViewModel
    {
        /// <summary>
        /// Gets or sets of the room for editing.
        /// </summary>
        public Rooms EditedRoom { get; set; }

        /// <summary>
        /// Gets or sets of list of rooms.
        /// </summary>
        public List<Rooms> ListOfRooms { get; set; }
    }
}
