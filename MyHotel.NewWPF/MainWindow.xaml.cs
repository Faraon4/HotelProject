// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
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
    using System.Windows.Threading;

    /// <summary>
    /// Main Window.
    /// </summary>
    public partial class MainWindow : Window
    {
        private SecondWindow second = new SecondWindow();

        private Random rnd = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (this.DataContext as MainVM).Helper;
            timer.Start();

            DispatcherTimer timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(2);
            timer2.Tick += this.SecondWindow;
            timer2.Start();

            DispatcherTimer timer3 = new DispatcherTimer();
            timer3.Interval = TimeSpan.FromSeconds(2);
            timer3.Tick += this.Switch;
            timer3.Start();
        }

        private void Switch(object sender, EventArgs e)
        {
            RoomVM[] rooms = new RoomVM[(this.DataContext as MainVM).RandomRooms.Count];
            int count = 0;
            foreach (var p in (this.DataContext as MainVM).RandomRooms)
            {
                rooms[count] = p;
                count++;
            }

            int nr = this.rnd.Next(0, rooms.Length);
            RoomVM room = rooms[nr];
            if (room.Selection == "UNSELECTED")
            {
                (this.DataContext as MainVM).SelectVM(room.Id);
                room.Selection = "SELECTED";
            }
            else if (room.Selection == "SELECTED")
            {
                (this.DataContext as MainVM).UnselectVM(room.Id);
                room.Selection = "UNSELECTED";
            }
        }

        private void SecondWindow(object sender, EventArgs e)
        {
            this.second.DataContext = this.DataContext;
            this.second.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var item in (this.DataContext as MainVM).RandomRooms)
            {
                (this.DataContext as MainVM).DeleteVM(item.Id);
            }

            this.second.Close();
        }
    }
}
