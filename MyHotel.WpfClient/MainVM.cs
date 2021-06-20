namespace MyHotel.WpfClient
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

    /// <summary>
    /// MainVM class.
    /// </summary>
    public class MainVM : ViewModelBase
    {
        private IMainLogic logic;
        private RoomVM selectedRoom;
        private ObservableCollection<RoomVM> allRooms;

        /// <summary>
        /// Gets or sets of the AllRooms.
        /// </summary>
        public ObservableCollection<RoomVM> AllRooms
        {
            get { return this.allRooms; }
            set { this.Set(ref this.allRooms, value); }
        }

        /// <summary>
        /// Gets or sets of the SelectedRoom.
        /// </summary>
        public RoomVM SelectedRoom
        {
            get { return this.selectedRoom; }
            set { this.Set(ref this.selectedRoom, value); }
        }

        /// <summary>
        /// Gets of the Add comand.
        /// </summary>
        public ICommand AddCmd { get; private set; }

        /// <summary>
        /// Gets of the Delete command.
        /// </summary>
        public ICommand DelCmd { get; private set; }

        /// <summary>
        /// Gets of the Modify command.
        /// </summary>
        public ICommand ModCmd { get; private set; }

        /// <summary>
        /// Gets of the Load Command.
        /// </summary>
        public ICommand LoadCmd { get; private set; }

        /// <summary>
        /// Gets or sets of the Editor Function.
        /// </summary>
        public Func<RoomVM, bool> EditorFunc { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVM"/> class.
        /// </summary>
        /// <param name="logic">Logic parameter.</param>
        public MainVM(IMainLogic logic)
        {
            this.logic = logic;

            this.LoadCmd = new RelayCommand(() => this.AllRooms = new ObservableCollection<RoomVM>(this.logic.ApiGetRooms()));
            this.DelCmd = new RelayCommand(() => this.logic.ApiDelRoom(this.SelectedRoom));
            this.AddCmd = new RelayCommand(() => this.logic.EditRoom(null, this.EditorFunc));
            this.ModCmd = new RelayCommand(() => this.logic.EditRoom(this.SelectedRoom, this.EditorFunc));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVM"/> class.
        /// </summary>
        public MainVM()
            : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<IMainLogic>())
        {
        }
    }
}
