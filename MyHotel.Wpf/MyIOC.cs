namespace MyHotel.Wpf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CommonServiceLocator;
    using GalaSoft.MvvmLight.Ioc;

    /// <summary>
    /// Creating my IOC.
    /// </summary>
    public class MyIOC : SimpleIoc, IServiceLocator
    {
        /// <summary>
        /// Gets MyIOC instance.
        /// </summary>
        public static MyIOC Instance { get; private set; } = new MyIOC();
    }
}
