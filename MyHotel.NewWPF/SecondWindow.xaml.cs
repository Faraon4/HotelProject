// <copyright file="SecondWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
    using MyHotel.Logic;
    using MyHotel.Models;
    using MyHotel.Repository;

    /// <summary>
    /// Interaction logic for SecondWindow.xaml.
    /// </summary>
    public partial class SecondWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondWindow"/> class.
        /// </summary>
        public SecondWindow()
        {
            this.InitializeComponent();
        }
    }
}
