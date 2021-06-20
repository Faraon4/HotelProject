namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Custom Exeption to be thrown when there is no such room by id.
    /// </summary>
    public class RoomRepException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomRepException"/> class
        /// Constructor without parameters.
        /// </summary>
        public RoomRepException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomRepException"/> class
        /// Constructor with parameter.
        /// </summary>
        /// <param name="mes">message to display.</param>
        public RoomRepException(string mes)
                : base(mes)
        {
        }
    }
}
