using System.Globalization;

namespace _18_palautus_DelegatesandEvents
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-US"); //muuttaa koko ohjelman USAn tyyppiin
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US"); //muuttaa koko ohjelman UI:n USAn tyyppiin
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    }
}