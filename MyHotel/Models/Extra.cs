namespace MyHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Extra Entity.
    /// </summary>
    public class Extra
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extra"/> class.
        /// constructor of the extra.
        /// </summary>
        public Extra()
        {
            this.People = new HashSet<People>();
        }

        /// <summary>
        /// Gets or sets of Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets of ExtraType.
        /// </summary>
        public string ExtraType { get; set; }

        /// <summary>
        /// Gets or sets of ExtraPrice.
        /// </summary>
        public int ExtraPrice { get; set; }

        /// <summary>
        /// Gets or sets of ExtraDays.
        /// </summary>
        public string ExtraDays { get; set; }

        /// <summary>
        /// Gets or sets of ExtraNrpeople.
        /// </summary>
        public int ExtraNrpeople { get; set; }

        /// <summary>
        /// Gets or sets of ExtraTicket..
        /// </summary>
        public string ExtraTicket { get; set; }

        /// <summary>
        /// Gets  of People.
        /// </summary>
        public virtual ICollection<People> People { get; /*set;*/ }
    }
}
