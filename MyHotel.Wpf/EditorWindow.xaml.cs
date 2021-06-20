namespace MyHotel.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using MyHotel.Wpf.BL;
    using MyHotel.Wpf.VM;

    /// <summary>
    /// Interaction logic for EditorWindow.xaml.
    /// </summary>
    public partial class EditorWindow : Window
    {
       private EditorViewModel VM;

        /// <summary>
        /// Gets of the room vm.
        /// </summary>
       public RoomVM Room
        {
            get { return this.VM.Room; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorWindow"/> class.
        /// </summary>
       public EditorWindow()
       {
            this.InitializeComponent();
            this.VM = this.FindResource("VM") as EditorViewModel;
       }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorWindow"/> class.
        /// </summary>
        /// <param name="newRoom">new room parameter.</param>
       public EditorWindow(RoomVM newRoom)
            : this()
       {
            this.VM.Room = newRoom;
       }

        /// <summary>
        /// Ok click event.
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="e">e event.</param>
       private void OK_Click(object sender, RoutedEventArgs e)
       {
            this.DialogResult = true;
       }

        /// <summary>
        /// Cancel click event.
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="e">e event.</param>
       private void Cancel_Click(object sender, RoutedEventArgs e)
       {
            this.DialogResult = false;
       }
    }
}
