using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaklychenieMDI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HelloForm());
        }

        public static class Connection
        {
            public static string GetConnectionStringByName(string name)
            {
                // Assume failure.
                string returnValue = null;

                // Look for the name in the connectionStrings section.
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

                // If found, return the connection string.
                if (settings != null)
                    returnValue = settings.ConnectionString;

                return returnValue;
            }
        }
    }
}
