namespace BusManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new Login());
=======
            Application.Run(new BusManage());
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
        }
    }
}