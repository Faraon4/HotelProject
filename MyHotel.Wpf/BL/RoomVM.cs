namespace MyHotel.Wpf.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// VM of the room.
    /// </summary>
    public class RoomVM : ObservableObject
    {
       private int id;
       private string type;
       private int amount;
       private int available;
       private int price;
       private string view;

        /// <summary>
        /// Gets or sets id of the roomVM.
        /// </summary>
       public int Id
       {
            get { return this.id; }
            set { this.Set(ref this.id, value); }
       }

        /// <summary>
        /// Gets or sets type of the roomVM.
        /// </summary>
       public string Type
       {
            get { return this.type; }
            set { this.Set(ref this.type, value); }
       }

        /// <summary>
        /// Gets or sets amount of the roomVM.
        /// </summary>
       public int Amount
       {
            get { return this.amount; }
            set { this.Set(ref this.amount, value); }
       }

        /// <summary>
        /// Gets or sets available of the roomVM.
        /// </summary>
       public int Available
       {
            get { return this.available; }
            set { this.Set(ref this.available, value); }
       }

        /// <summary>
        /// Gets or sets price of the roomVM.
        /// </summary>
       public int Price
       {
            get { return this.price; }
            set { this.Set(ref this.price, value); }
       }

        /// <summary>
        /// Gets or sets view of the roomVM.
        /// </summary>
       public string View
       {
            get { return this.view; }
            set { this.Set(ref this.view, value); }
       }

        /// <summary>
        /// Method that will copy properties of one roomVM to other room VM.
        /// </summary>
        /// <param name="other">other room parameter.</param>
       public void CopyFrom(RoomVM other)
       {
            this.GetType().GetProperties().ToList().ForEach(property => property.SetValue(this, property.GetValue(other)));
       }
    }
}
