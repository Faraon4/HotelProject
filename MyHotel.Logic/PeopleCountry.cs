namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class that will help to return information about people.
    /// </summary>
    public class PeopleCountry
    {
        /// <summary>
        /// Gets or sets of the  People Id.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets of the Name of people.
        /// </summary>
        public string PeopleName { get; set; }

        /// <summary>
        /// Gets or sets of the Country of people.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets of id of the room of people.
        /// </summary>
        public int IdOfRoom { get; set; }

        /// <summary>
        /// Gets or sets of id of the extra of people.
        /// </summary>
        public int? IdOfExtra { get; set; }

        /// <summary>
        /// overriding the ToString method.
        /// </summary>
        /// <returns>string as following format.</returns>
        public override string ToString()
        {
            return $" ID = {this.ID} , Name = {this.PeopleName} , Country = {this.Country}, RoomId = {this.IdOfRoom} , ExtraId = {this.IdOfExtra}";
        }

        /// <summary>
        /// Overriding the Equals method, that checks if 2 objects are the same or no.
        /// </summary>
        /// <param name="obj">obj as parameter, that will help to see if 2 objects are equal. </param>
        /// <returns>should be true/false , depending if 2 objects are equal or no.</returns>
        public override bool Equals(object obj)
        {
            if (obj is PeopleCountry)
            {
                PeopleCountry other = obj as PeopleCountry;
                return this.ID == other.ID &&
                       this.PeopleName == other.PeopleName &&
                       this.Country == other.Country &&
                       this.IdOfRoom == other.IdOfRoom &&
                       this.IdOfExtra == other.IdOfExtra;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// override GetHashCode.
        /// </summary>
        /// <returns>zero, and force Equals method.</returns>
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
