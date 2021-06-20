namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  This class is the same as RoomNr, but instead showing the room type and nr of rooms, it will show the id of rooms and its numbers.
    /// </summary>
    public class RoomNrByID
    {
        /// <summary>
        /// Gets or sets the ID of the room.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Nr of the room.
        /// </summary>
        public int Nr { get; set; }

        /// <summary>
        /// Overriding the ToString method.
        /// </summary>
        /// <returns>a string.</returns>
        public override string ToString()
        {
            return $"  RoomType = {this.ID}, Number = {this.Nr}";
        }

        /// <summary>
        /// Overriding the Equal method, that checks 2 objects of the same type.
        /// </summary>
        /// <param name="obj">obj parameter that will be used to compare 2 objects.</param>
        /// <returns>true or false, depends if this 2 objects are equal or no.</returns>
        public override bool Equals(object obj)
        {
            if (obj is RoomNrByID)
            {
                RoomNrByID other = obj as RoomNrByID;
                return this.ID == other.ID &&
                       this.Nr == other.Nr;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overriding the GetHashCode.
        /// </summary>
        /// <returns> an integer.</returns>
        public override int GetHashCode()
        {
            return this.ID + this.Nr;
        }
    }
}
