namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for returning the Type of extra and Price of it.
    /// </summary>
    public class PriceResultExtra
    {
        /// <summary>
        /// Gets or sets of the Extra ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets property for returning the Name of the Extra Activity.
        /// </summary>
        public string ExtraType { get; set; }

        /// <summary>
        /// Gets or sets property for returning the Price of the Extra Activity.
        /// </summary>
        public int PriceRes { get; set; }

        /// <summary>
        /// Overriding the ToString() Method.
        /// </summary>
        /// <returns>return a string, as the following format.</returns>
        public override string ToString()
        {
            return $"ID = {this.ID} , ExtraType = {this.ExtraType} , Price = {this.PriceRes}";
        }

        /// <summary>
        /// Overriding the Equal method for checking two values that are equal.
        /// </summary>
        /// <param name="obj">obj parameter, that will help to find if 2 objects are equal or no.</param>
        /// <returns>return a bool value , depending if this 2 values are equal with each other or no.</returns>
        public override bool Equals(object obj)
        {
           if (obj is PriceResultExtra)
            {
                PriceResultExtra other = obj as PriceResultExtra;
                return this.ID == other.ID &&
                       this.ExtraType == other.ExtraType &&
                       this.PriceRes == other.PriceRes;
            }
           else
            {
                return false;
            }
        }

        /// <summary>
        /// Getting the Hash Code, but return 0 and this will force the Equal method.
        /// </summary>
        /// <returns> 0.</returns>
        public override int GetHashCode()
        {
            return 0; // this.ExtraType.GetHashCode() + this.PriceRes;
        }
    }
}
