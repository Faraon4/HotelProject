namespace MyHotel.Web.Models
{
    /// <summary>
    /// ErrorViewModel class.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets of the requestId.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether show request Id.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}
