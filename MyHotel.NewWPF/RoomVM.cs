// <copyright file="RoomVM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// Class for the VM of room.
    /// </summary>
    public class RoomVM : ObservableObject
    {
        private int id;
        private string type;
        private int amount;
        private int available;
        private int price;
        private string view;
        private string selection;

        /// <summary>
        /// Gets or sets of id.
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.Set(ref this.id, value); }
        }

        /// <summary>
        /// Gets or sets of type.
        /// </summary>
        public string RoomsType
        {
            get { return this.type; }
            set { this.Set(ref this.type, value); }
        }

        /// <summary>
        /// Gets or sets of amount.
        /// </summary>
        public int RoomsAmount
        {
            get { return this.amount; }
            set { this.Set(ref this.amount, value); }
        }

        /// <summary>
        /// Gets or sets of availability of room.
        /// </summary>
        public int RoomsAvailable
        {
            get { return this.available; }
            set { this.Set(ref this.available, value); }
        }

        /// <summary>
        /// Gets or sets of price of room.
        /// </summary>
        public int RoomsPrice
        {
            get { return this.price; }
            set { this.Set(ref this.price, value); }
        }

        /// <summary>
        /// Gets or sets of view.
        /// </summary>
        public string RoomsView
        {
            get { return this.view; }
            set { this.Set(ref this.view, value); }
        }

        /// <summary>
        /// Gets or sets of selection.
        /// </summary>
        public string Selection
        {
            get { return this.selection; }
            set { this.Set(ref this.selection, value); }
        }

        /// <summary>
        /// Method to copy from properties of room.
        /// </summary>
        /// <param name="other">other room vm.</param>
        public void CopyFrom(RoomVM other)
        {
            if (other == null)
            {
                return;
            }

            this.Id = other.Id;
            this.RoomsType = other.RoomsType;
            this.RoomsAmount = other.RoomsAmount;
            this.RoomsAvailable = other.RoomsAvailable;
            this.RoomsPrice = other.RoomsPrice;
            this.RoomsView = other.RoomsView;
            this.Selection = other.Selection;
        }

        /// <summary>
        /// Overriding the To string method.
        /// </summary>
        /// <returns>string.</returns>
        public override string ToString()
        {
            return $"ID: {this.Id} , Type: {this.RoomsType} , Amount: {this.RoomsAmount} , Available: {this.RoomsAvailable} , Price: {this.RoomsPrice} , View: {this.RoomsView}, Selection: {this.Selection}";
        }
    }
}
