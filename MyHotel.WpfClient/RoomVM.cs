// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

namespace MyHotel.WpfClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// VM for the room.
    /// </summary>
    public class RoomVM : ObservableObject
    {
        private int id;
        private string roomsType;
        private int roomsAmount;
        private int roomsAvailable;
        private int roomsPrice;
        private string roomsView;

        /// <summary>
        /// Gets or sets of the Id.
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.Set(ref this.id, value); }
        }

        /// <summary>
        /// Gets or sets of the Room type.
        /// </summary>
        public string RoomsType
        {
            get { return this.roomsType; }
            set { this.Set(ref this.roomsType, value); }
        }

        /// <summary>
        /// Gets or sets of the Room amount.
        /// </summary>
        public int RoomsAmount
        {
            get { return this.roomsAmount; }
            set { this.Set(ref this.roomsAmount, value); }
        }

        /// <summary>
        /// Gets or sets of the room available.
        /// </summary>
        public int RoomsAvailable
        {
            get { return this.roomsAvailable; }
            set { this.Set(ref this.roomsAvailable, value); }
        }

        /// <summary>
        /// Gets or sets of the room price.
        /// </summary>
        public int RoomsPrice
        {
            get { return this.roomsPrice; }
            set { this.Set(ref this.roomsPrice, value); }
        }

        /// <summary>
        /// Gets or sets of the room view.
        /// </summary>
        public string RoomsView
        {
            get { return this.roomsView; }
            set { this.Set(ref this.roomsView, value); }
        }

        /// <summary>
        /// Method that will copy the information  from the other RoomVM.
        /// </summary>
        /// <param name="other">other parameter for copying the information.</param>
        public void Copyfrom(RoomVM other)
        {
            if (other == null)
            {
                return;
            }

            this.Id = other.Id;
            this.RoomsType = other.RoomsType;
            this.RoomsAmount = other.RoomsAmount;
            this.roomsAvailable = other.RoomsAvailable;
            this.RoomsPrice = other.RoomsPrice;
            this.RoomsView = other.RoomsView;
        }
    }
}
