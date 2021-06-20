namespace MyHotel.Wpf.VM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;
    using MyHotel.Wpf.BL;

    /// <summary>
    /// Class that will be used for the Editing Window.
    /// </summary>
    public class EditorViewModel : ViewModelBase
    {
       private RoomVM room;

        /// <summary>
        /// Gets or sets of the room.
        /// </summary>
       public RoomVM Room
       {
            get { return this.room; }
            set { this.Set(ref this.room, value); }
       }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorViewModel"/> class.
        /// </summary>
       public EditorViewModel()
       {
            this.room = new RoomVM();
            if (this.IsInDesignMode)
            {
                this.room.Id = 49;
                this.room.Type = "KingTripleRoom";
                this.room.Amount = 10;
                this.room.Available = 8;
                this.room.Price = 300;
                this.room.View = "Pool";
            }
       }
    }
}
