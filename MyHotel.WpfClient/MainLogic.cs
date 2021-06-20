namespace MyHotel.WpfClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    /// Main logic class.
    /// </summary>
    public class MainLogic : IMainLogic
    {
        private string url = "http://localhost:56443/RoomsApi/";
        private HttpClient client = new HttpClient();
        private JsonSerializerOptions jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

        /// <summary>
        /// Send message method.
        /// </summary>
        /// <param name="success">if it is true or false.</param>
        private void SendMessage(bool success)
        {
            string msg = success ? "Operation completed successfully" : "Operation failed";
            Messenger.Default.Send(msg, "RoomResult");
        }

        /// <summary>
        /// Method to get rooms.
        /// </summary>
        /// <returns>List of roomVM.</returns>
        public List<RoomVM> ApiGetRooms()
        {
            string json = this.client.GetStringAsync(this.url + "all").Result;
            var list = JsonSerializer.Deserialize<List<RoomVM>>(json, this.jsonOptions);
            return list;
        }

        /// <summary>
        /// Method to delete the room.
        /// </summary>
        /// <param name="room">room that you want to delete.</param>
        public void ApiDelRoom(RoomVM room)
        {
            bool success = false;
            if (room != null)
            {
                string json = this.client.GetStringAsync(this.url + "del/" + room.Id).Result;

                JsonDocument doc = JsonDocument.Parse(json);
                success = doc.RootElement.EnumerateObject().First().Value.GetRawText() == "true";
            }

            this.SendMessage(success);
        }

        /// <summary>
        /// Method to edit room.
        /// </summary>
        /// <param name="room">room that you want to edit.</param>
        /// <param name="isEditing">if it is possible to edit the room.</param>
        /// <returns>true or false.</returns>
        private bool ApiEditRoom(RoomVM room, bool isEditing)
        {
            if (room == null)
            {
                return false;
            }

            string fullUrl = this.url + (isEditing ? "mod" : "add");
            Dictionary<string, string> postData = new Dictionary<string, string>();
            if (isEditing)
            {
                postData.Add("id", room.Id.ToString());
            }

            postData.Add("roomsType", room.RoomsType);
            postData.Add("roomsAmount", room.RoomsAmount.ToString());
            postData.Add("roomsAvailable", room.RoomsAvailable.ToString());
            postData.Add("roomsPrice", room.RoomsPrice.ToString());
            postData.Add("roomsView", room.RoomsView);

            string json = this.client.PostAsync(fullUrl, new FormUrlEncodedContent(postData)).Result.Content.ReadAsStringAsync().Result;
            JsonDocument doc = JsonDocument.Parse(json);
            return doc.RootElement.EnumerateObject().First().Value.GetRawText() == "true";
        }

        /// <summary>
        /// Method to edit the room.
        /// </summary>
        /// <param name="room">room that you want to edit.</param>
        /// <param name="editorFunc">editor Func.</param>
        public void EditRoom(RoomVM room, Func<RoomVM, bool> editorFunc)
        {
            RoomVM clone = new RoomVM();
            if (room != null)
            {
                clone.Copyfrom(room);
            }

            bool? success = editorFunc?.Invoke(clone);

            if (success == true)
            {
                if (room != null)
                {
                    success = this.ApiEditRoom(clone, true);
                }
                else
                {
                    success = this.ApiEditRoom(clone, false);
                }
            }

            this.SendMessage(success == true);
        }
    }
}
