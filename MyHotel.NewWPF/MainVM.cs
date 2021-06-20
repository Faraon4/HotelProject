// <copyright file="MainVM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using CommonServiceLocator;
    using GalaSoft.MvvmLight;
    using MyHotel.Logic;
    using MyHotel.Models;
    using MyHotel.Repository;

    /// <summary>
    /// Main View Model.
    /// </summary>
    public class MainVM : ViewModelBase
    {
        private IMainLogic logic;
        private int number;
        private ObservableCollection<RoomVM> randomRooms;

        /// <summary>
        /// Gets or sets of Number.
        /// </summary>
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        /// <summary>
        /// Gets or sets of randomRooms list.
        /// </summary>
        public ObservableCollection<RoomVM> RandomRooms
        {
            get { return this.randomRooms; }
            set { this.Set(ref this.randomRooms, value); }
        }

        /// <summary>
        /// Gets of the command to send the input number.
        /// </summary>
        public ICommand SendCmd { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVM"/> class.
        /// </summary>
        /// <param name="logic">logic parameter.</param>
        public MainVM(IMainLogic logic)
        {
            this.logic = logic;
            this.RandomRooms = new ObservableCollection<RoomVM>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVM"/> class.
        /// </summary>
        public MainVM()
             : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<IMainLogic>())
        {
        }

        private static int count;

        /// <summary>
        /// Helper method to call the GetOne room.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">event.</param>
        public void Helper(object sender, EventArgs e)
        {
            if (count < this.Number)
            {
                RoomVM room = this.logic.GetOneRoom();
                this.RandomRooms.Add(room);
                count++;
            }
        }

        /// <summary>
        /// Method to make a room selected.
        /// </summary>
        /// <param name="id">id of the room.</param>
        public void SelectVM(int id)
        {
            this.logic.SelectLogic(id);
        }

        /// <summary>
        ///  Method to make a room unselected.
        /// </summary>
        /// <param name="id">id of the room.</param>
        public void UnselectVM(int id)
        {
            this.logic.UnselectLogic(id);
        }

        /// <summary>
        /// Method to delete the room.
        /// </summary>
        /// <param name="id">id of the room to be deleted.</param>
        public void DeleteVM(int id)
        {
            this.logic.DeleteRoom(id);
        }
    }
}
