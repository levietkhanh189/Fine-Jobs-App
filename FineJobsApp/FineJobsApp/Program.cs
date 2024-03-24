using FineJobsApp.Controller;

namespace FineJobsApp
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
            MessageBox.Show("Hello World!" + MailController.GenerateRandomCode());
            ApplicationConfiguration.Initialize();
            Application.Run(new CPNLoginForm());
        }
    }
}