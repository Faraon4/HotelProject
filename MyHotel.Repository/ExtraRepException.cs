namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Custom Exeption to throw when you cannot find an extra activity by id.
    /// </summary>
    public class ExtraRepException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraRepException"/> class.
        /// Constructor without parameters.
        /// </summary>
        public ExtraRepException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraRepException"/> class.
        /// Constructor that take parameter as argument message (string).
        /// </summary>
        /// <param name="message">message parameter , that will display when this exception occurs.</param>
        public ExtraRepException(string message)
              : base(message)
        {
        }
    }
}
