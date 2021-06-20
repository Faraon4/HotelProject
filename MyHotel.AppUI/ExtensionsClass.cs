namespace MyHotel.AppUI
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Extension Class for Having the ToConsole method.
    /// </summary>
    public static class ExtensionsClass
    {
        /// <summary>
        /// The ToConsole Method.
        /// </summary>
        /// <typeparam name="T">Generic type of the method.</typeparam>
        /// <param name="input">input param.</param>
        /// <param name="str">str param.</param>
        public static void ToConsole<T>(this IEnumerable<T> input, string str)
        {
            Console.WriteLine("*** BEGIN " + str);
            foreach (T item in input)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("*** END " + str);
            Console.ReadLine();
        }
    }
}
