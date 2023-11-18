using CineFront;
using CineFront.Vistas;

namespace Cine
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
            FrmLoginPrincipal frmLogin = new FrmLoginPrincipal();
            Application.Run(frmLogin);
        }
    }
}