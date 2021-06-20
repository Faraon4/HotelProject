namespace MyHotel.Wpf.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MyHotel.Wpf.BL;

    /// <summary>
    /// Editor service window, that will implement the IEditorService interface.
    /// </summary>
    public class EditorServiceViaWindow : IEditorService
    {
        /// <summary>
        /// Implementing the EditRoom method from the IEditorService interface.
        /// </summary>
        /// <param name="roomVM">room parameter.</param>
        /// <returns>true or false.</returns>
        public bool EditRoom(RoomVM roomVM)
        {
            EditorWindow win = new EditorWindow(roomVM);
            return win.ShowDialog() ?? false;
        }
    }
}
