namespace MyHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// People Entity.
    /// </summary>
    public class People
    {
        /// <summary>
        /// Gets or sets of Id property.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets of Peoplename property.
        /// </summary>
        public string PeopleName { get; set; }

        /// <summary>
        /// Gets or sets of PeopleRoomid property.
        /// </summary>
        public int PeopleRoomid { get; set; }

        /// <summary>
        /// Gets or sets of PeopleExtraId property.
        /// </summary>
        public int? PeopleExtraid { get; set; }

        /// <summary>
        /// Gets or sets of Country property.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets of PeopleCheckin property.
        /// </summary>
        public DateTime? PeopleCheckin { get; set; }

        /// <summary>
        /// Gets or sets of PeopleCheckout property.
        /// </summary>
        public DateTime? PeopleCheckout { get; set; }

        /// <summary>
        /// Gets or sets Connection to Extra Table.
        /// </summary>
        public virtual Extra PeopleExtra { get; set; }

        /// <summary>
        /// Gets or sets Connection to Room Table.
        /// </summary>
        public virtual Rooms PeopleRoom { get; set; }
    }
}
