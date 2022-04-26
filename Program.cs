

namespace OilTycoonGame
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
            Console.WriteLine("This is a test number 123124");
            ApplicationConfiguration.Initialize();
            Application.Run();
            // here is where we should setup the loop and 
        }
    }
}