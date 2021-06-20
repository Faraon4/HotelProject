namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class that find number of each extra activity.
    /// </summary>
    public class ExtraNumber
    {
        /// <summary>
        /// Gets or sets number of the extra activity.
        /// </summary>
        public int Nr { get; set; }

        /// <summary>
        /// Gets or sets extra type.
        /// </summary>
        public string Extra { get; set; }

        /// <summary>
        /// Overriding the ToString() Method.
        /// </summary>
        /// <returns>a string as following format.</returns>
        public override string ToString()
        {
            return $"ExtraType = {this.Extra} , NrOfPeople = {this.Nr}";
        }

        /// <summary>
        /// Overriding the Equals method, that checks if 2 objects are the same or no.
        /// </summary>
        /// <param name="obj">obj as parameter, that will help to see if 2 objects are equal. </param>
        /// <returns>should be true/false , depending if 2 objects are equal or no.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ExtraNumber)
            {
                ExtraNumber other = obj as ExtraNumber;
                return this.Extra == other.Extra &&
                       this.Nr == other.Nr;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Getting the Hash Code, but return 0 and this will force the Equal method.
        /// </summary>
        /// <returns>integer.</returns>
        public override int GetHashCode()
        {
            return this.Extra.GetHashCode() + this.Nr;
        }
    }
}
