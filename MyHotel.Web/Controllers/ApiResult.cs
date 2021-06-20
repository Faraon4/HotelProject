namespace MyHotel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Helper class for the RoomsApiController.
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets a value indicating the operationResult.
        /// </summary>
        public bool OperationResult { get; set; }

        /// <summary>
        /// Gets or sets of values indicating , number of selected or unselected rooms.
        /// </summary>
        public int Number { get; set; }
    }
}
