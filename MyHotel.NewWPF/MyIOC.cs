// <copyright file="MyIOC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyHotel.NewWPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CommonServiceLocator;
    using GalaSoft.MvvmLight.Ioc;

    /// <summary>
    /// MyIOC class.
    /// </summary>
    public class MyIOC : SimpleIoc, IServiceLocator
    {
        /// <summary>
        /// Gets MyIOC Instance.
        /// </summary>
        public static MyIOC Instance { get; private set; } = new MyIOC();
    }
}
