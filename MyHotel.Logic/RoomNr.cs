namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class that will help us to find the number of rooms of each  type.
    /// </summary>
    public class RoomNr
    {
        /// <summary>
        /// Gets or sets Room type.
        /// </summary>
        public string RoomType { get; set; }

        /// <summary>
        /// Gets or sets Number of rooms.
        /// </summary>
        public int Nr { get; set; }

       /// <summary>
       /// Overriding the ToString() method.
       /// </summary>
       /// <returns> string as the following format.</returns>
        public override string ToString()
        {
            return $"RoomType = {this.RoomType}, Number = {this.Nr}";
        }

        /// <summary>
        /// Overriding the Equal() method , that checks 2 objects if they are the same.
        /// </summary>
        /// <param name="obj">obj parameter, that will help to check 2 objects.</param>
        /// <returns>true or false , depending if the objects are equals.</returns>
        public override bool Equals(object obj)
        {
            if (obj is RoomNr)
            {
                RoomNr other = obj as RoomNr;
                return this.RoomType == other.RoomType &&
                       this.Nr == other.Nr;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overriding the GetHashCode().
        /// </summary>
        /// <returns> an integer.</returns>
        public override int GetHashCode()
        {
            return this.RoomType.GetHashCode() + this.Nr;
        }
    }
}
