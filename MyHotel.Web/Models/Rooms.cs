namespace MyHotel.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Model class for the rooms.
    /// </summary>
    public class Rooms
    {
        /// <summary>
        /// Gets or sets of Id.
        /// </summary>
        [Display(Name = "Room Id")]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets of RoomsType.
        /// </summary>
        [Display(Name = "Room Type")]
        [Required]
        public string RoomsType { get; set; }

        /// <summary>
        /// Gets or sets of RoomsAmount.
        /// </summary>
        [Display(Name = "Room Amount")]
        [Required]
        public int RoomsAmount { get; set; }

        /// <summary>
        /// Gets or sets of RoomsAvailable.
        /// </summary>
        [Display(Name = "Room Available")]
        [Required]
        public int RoomsAvailable { get; set; }

        /// <summary>
        /// Gets or sets of RoomsPrice.
        /// </summary>
        [Display(Name = "Room Price")]
        [Required]
        public int RoomsPrice { get; set; }

        /// <summary>
        /// Gets or sets of RoomsView.
        /// </summary>
        [Display(Name = "Room View")]
        [Required]
        public string RoomsView { get; set; }

        /// <summary>
        /// Gets or sets of Selection.
        /// </summary>
        [Display(Name ="Selection")]
        public string Selection { get; set; }
    }
}
