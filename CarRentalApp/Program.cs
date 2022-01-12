using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() // starts the overall program
        {
            Application.EnableVisualStyles(); // initializes some visual styles
            Application.SetCompatibleTextRenderingDefault(false); // renders some text

            // opens and runs the first form
            Application.Run(new Login()); // here you can change which form to run first
        }
    }
}
