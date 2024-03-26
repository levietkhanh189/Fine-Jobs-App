using AnimationSliding_Sign_In_Sign_Up;
using FineJobsApp.Controller;
using System.Diagnostics;

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
            ApplicationConfiguration.Initialize();
            //Application.Run(new CPNLoginForm());

            Application.Run(new FrmHome());
        }



    }
}