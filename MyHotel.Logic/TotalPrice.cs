namespace MyHotel.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class that will be used to find how many $ people pay, with non-crud operation.
    /// </summary>
    public class TotalPrice
    {
        /// <summary>
        /// Gets or sets the Name of person.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Room of person.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// Gets or sets the extra activity of person.
        /// </summary>
        public string Extra { get; set; }

        /// <summary>
        /// Gets or sets the price of person that they pay.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Overriding the ToString() method.
        /// </summary>
        /// <returns>string of following format.</returns>
        public override string ToString()
        {
            return $"Name = {this.Name},ExtraType = {this.Extra} , Room = {this.Room}, Total = {this.Price}";
        }

        /// <summary>
        /// Overriding the Equla method, that checks the properties.
        /// </summary>
        /// <param name="obj">obj parameter that will be used to compare 2 objects.</param>
        /// <returns>true or false, depending if properties of 2 different objects are the same.</returns>
        public override bool Equals(object obj)
        {
            if (obj is TotalPrice)
            {
                TotalPrice other = obj as TotalPrice;
                return this.Name == other.Name &&
                        this.Room == other.Room &&
                        this.Extra == other.Extra &&
                       this.Price == other.Price;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overriding the GetHashCode(), returnong 0 and force to execute Equals() method.
        /// </summary>
        /// <returns>an integer.</returns>
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
