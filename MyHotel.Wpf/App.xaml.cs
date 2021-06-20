namespace MyHotel.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;
    using CommonServiceLocator;
    using GalaSoft.MvvmLight.Messaging;
    using MyHotel.Wpf.BL;
    using MyHotel.Wpf.UI;

    /// <summary>
    /// Interaction logic for App.xaml.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            ServiceLocator.SetLocatorProvider(() => MyIOC.Instance);

            MyIOC.Instance.Register<IEditorService, EditorServiceViaWindow>();
            MyIOC.Instance.Register<IMessenger>(() => Messenger.Default);
            MyIOC.Instance.Register<IRoomLogic, RoomLogic>();
        }
    }
}
