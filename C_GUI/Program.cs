using C_GUI.Views;

namespace C_GUI
{
    internal static class Program
    {
        public static TrangChu TrangChu = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< Updated upstream
            Application.Run(TrangChu);
=======
            Application.Run(new TrangChu());
>>>>>>> Stashed changes
        }
    }
}