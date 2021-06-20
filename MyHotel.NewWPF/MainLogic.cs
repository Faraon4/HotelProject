// <copyright file="MainLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight.Messaging;
    using MyHotel.Logic;

    /// <summary>
    /// Clas for the main logic.
    /// </summary>
    public class MainLogic : IMainLogic
    {
        private string url = "http://localhost:56443/Random/";
        private HttpClient client = new HttpClient();
        private JsonSerializerOptions jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

        /// <summary>
        /// Implementing the method to get one random room.
        /// </summary>
        /// <returns>room vm.</returns>
        public RoomVM GetOneRoom()
        {
            string json = this.client.GetStringAsync(this.url + "GetOne").Result;
            var list = JsonSerializer.Deserialize<RoomVM>(json, this.jsonOptions);
            return list;
        }

        /// <summary>
        /// Method to call the Random/Select.
        /// </summary>
        /// <param name="id">id of the room.</param>
        public void SelectLogic(int id)
        {
            string json = this.client.GetStringAsync(this.url + "Select/" + id).Result;
        }

        /// <summary>
        /// Method to call Random/Unselect.
        /// </summary>
        /// <param name="id">id of the room.</param>
        public void UnselectLogic(int id)
        {
            string json = this.client.GetStringAsync(this.url + "Unselect/" + id).Result;
        }

        /// <summary>
        /// Method to delete the added random room.
        /// </summary>
        /// <param name="id">id of the room to be deleted.</param>
        public void DeleteRoom(int id)
        {
           string url1 = "http://localhost:56443/RoomsApi/";
           this.client.GetStringAsync(url1 + "del/" + $"{id}");
        }
    }
}
