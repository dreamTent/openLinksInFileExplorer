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
            //load config
            string protocolName = "localdrive:///";


            //check what arguments were given
            if (args.Length > 0 && (args[0] == "/Uninstall" || args[0] == "/uninstall"))
            {
                //uninstall
                new ConfigLoader().delete();
                return;
            }
            else if (args.Length > 0 && args[0].StartsWith(protocolName))
            {

                //start protocol handler
                ProtocolHandler.main(args);

            }
            else
            {
                //load gui
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}