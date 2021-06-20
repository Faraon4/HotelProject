namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class that will show id of extra and number of it.
    /// </summary>
    public class ExtraNrID
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
        /// <returns>a string as following format.</returns>
        public override string ToString()
        {
            return $"  ExtraType = {this.ID}, Number = {this.Nr}";
        }

        /// <summary>
        /// Overriding the Equals method, that checks if 2 objects are the same or no.
        /// </summary>
        /// <param name="obj">obj as parameter, that will help to see if 2 objects are equal. </param>
        /// <returns>should be true/false , depending if 2 objects are equal or no.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ExtraNrID)
            {
                ExtraNrID other = obj as ExtraNrID;
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
        /// <returns>zero, so it force the Equal() method.</returns>
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
