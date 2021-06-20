// <copyright file="IMainLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// interface for the main logic.
    /// </summary>
    public interface IMainLogic
    {
        /// <summary>
        /// Method to make room unselected.
        /// </summary>
        /// <param name="id">id of the room.</param>
        void UnselectLogic(int id);

        /// <summary>
        /// Method to select room.
        /// </summary>
        /// <param name="id">id of the room.</param>
        void SelectLogic(int id);

        /// <summary>
        /// Method to get one randomo room.
        /// </summary>
        /// <returns>RoomVM.</returns>
        RoomVM GetOneRoom();

        /// <summary>
        /// Method to delete the room.
        /// </summary>
        /// <param name="id">id of the room to delete.</param>
        void DeleteRoom(int id);
    }
}
