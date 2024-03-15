using openLinksInFileExplorerCore;
namespace openLinksInFileExplorer
{
    internal static class Program
    {

        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {



            if (args.Length > 0 && (args[0] == "/Uninstall" || args[0] == "/uninstall"))
            {
                new ConfigLoader().delete();
                return;
            }
            else
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}