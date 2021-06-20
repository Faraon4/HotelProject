namespace MyHotel.Wpf.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Editor service interface.
    /// </summary>
    public interface IEditorService
    {
        /// <summary>
        /// Method that check if it is possible to edit the room.
        /// </summary>
        /// <param name="roomVM">room parameter.</param>
        /// <returns>true or false.</returns>
        bool EditRoom(RoomVM roomVM);
    }
}
