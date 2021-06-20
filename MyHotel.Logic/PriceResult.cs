namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class to show the id and the type of room and room's price.
    /// </summary>
    public class PriceResult
    {
        /// <summary>
        /// Gets or sets of the Room's ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets of the Room Type.
        /// </summary>
        public string RoomType { get; set; }

        /// <summary>
        /// Gets or sets of the Price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Overriding the ToString() method.
        /// </summary>
        /// <returns>returns a string as following format.</returns>
        public override string ToString()
        {
            return $"ID = {this.ID}, Room Type = {this.RoomType} ,  Price = {this.Price}";
        }

        /// <summary>
        /// Overriding the Equals method, that checks if 2 objects are the same or no.
        /// </summary>
        /// <param name="obj">obj as parameter, that will help to see if 2 objects are equal. </param>
        /// <returns>should be true/false , depending if 2 objects are equal or no.</returns>
        public override bool Equals(object obj)
        {
            if (obj is PriceResult)
            {
                PriceResult other = obj as PriceResult;
                return this.ID == other.ID &&
                        this.RoomType == other.RoomType &&
                        this.Price == other.Price;
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
            return this.ID + this.RoomType.GetHashCode() + this.Price;
        }
    }
}
