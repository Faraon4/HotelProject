namespace MyHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    /// <summary>
    /// Rooms Entity.
    /// </summary>
    public class Rooms
    {
        /// <summary>
        /// Gets or sets of Id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets of RoomsType.
        /// </summary>
        public string RoomsType { get; set; }

        /// <summary>
        /// Gets or sets of RoomsAmount.
        /// </summary>
        public int RoomsAmount { get; set; }

        /// <summary>
        /// Gets or sets of RoomsAvailable.
        /// </summary>
        public int RoomsAvailable { get; set; }

        /// <summary>
        /// Gets or sets of RoomsPrice.
        /// </summary>
        public int RoomsPrice { get; set; }

        /// <summary>
        /// Gets or sets of RoomsView.
        /// </summary>
        public string RoomsView { get; set; }

        /// <summary>
        /// Gets or sets of Selection of the Room.
        /// </summary>
        public string Selection { get; set; }

        /// <summary>
        /// Gets  Connection to The People Table.
        /// </summary>
        public virtual ICollection<People> People { get; /*set; */ }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rooms"/> class.
        /// Constructor for the rooms.
        /// </summary>
        public Rooms()
        {
            this.People = new HashSet<People>();
        }
    }
}
