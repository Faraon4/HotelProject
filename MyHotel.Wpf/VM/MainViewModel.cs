namespace MyHotel.Wpf.VM
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
    using GalaSoft.MvvmLight.Command;
    using MyHotel.Wpf.BL;

    /// <summary>
    /// Class that will be used in the Main window.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
       private IRoomLogic logic;
       private RoomVM roomSelected;

        /// <summary>
        /// Gets or sets of the roomSelected.
        /// </summary>
       public RoomVM RoomSelected
       {
            get { return this.roomSelected; }
            set { this.Set(ref this.roomSelected, value); }
       }

        /// <summary>
        /// Gets observable collection of the room.
        /// </summary>
       public ObservableCollection<RoomVM> Room { get; private set; }

        /// <summary>
        /// Gets the command of adding new roomo.
        /// </summary>
       public ICommand AddCmd { get; private set; }

        /// <summary>
        /// Gets the command of delete a room.
        /// </summary>
       public ICommand DelCmd { get; private set; }

        /// <summary>
        /// Gets the command of deleting all room.
        /// </summary>
       public ICommand DelAll { get; private set; }

        /// <summary>
        /// Gets the coomand of getting all rooms.
        /// </summary>
       public ICommand GetAll { get; private set; }

        /// <summary>
        /// Gets the command of modifing the room.
        /// </summary>
       public ICommand ModCmd { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="logic">roomlogic parameter to access the CRUD method.</param>
       public MainViewModel(IRoomLogic logic)
       {
            this.logic = logic;
            this.Room = new ObservableCollection<RoomVM>();
            if (this.IsInDesignMode)
            {
                RoomVM room1 = new RoomVM() { Id = 12, Type = "KINGTRIPLE", Amount = 10, Available = 5, Price = 324, View = "Pool" };
                RoomVM room2 = new RoomVM() { Id = 12, Type = "TRIPLEKING", Amount = 13, Available = 2, Price = 387, View = "Garden" };
                this.Room.Add(room1);
                this.Room.Add(room2);
            }

            this.AddCmd = new RelayCommand(() => this.logic.AddRoom(this.Room));
            this.DelCmd = new RelayCommand(() => this.logic.DelRoom(this.Room, this.RoomSelected));
            this.DelAll = new RelayCommand(() => this.logic.DellAll(this.Room));
            this.GetAll = new RelayCommand(() => this.logic.GetAllRooms(this.Room));
            this.ModCmd = new RelayCommand(() => this.logic.ModRoom(this.RoomSelected));
       }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
       public MainViewModel()
            : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<IRoomLogic>())
       {
       }
    }
}
