namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Excception to throw if it is imposible to find people.
    /// </summary>
    public class PeopleRepException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleRepException"/> class.
        /// </summary>
        /// <param name="message">message to be displayed.</param>
        public PeopleRepException(string message)
            : base(message)
        {
        }
    }
}
