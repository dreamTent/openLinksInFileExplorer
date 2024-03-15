using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace openLinksInFileExplorerCore
{
    internal class Program
    {
        static string protocolName = "localdrive:///";
        //get config
        static string[] allowedFiles = new ConfigLoader().get().allowedExtensions;





        /* Examples:
         * 
         * localDrive:///C:\
         * localDrive:///C:\Users\testuser\Documents\testFileGood.txt
         * localDrive:///%UserProfile%\
         * localDrive:///%UserProfile%\Documents
         * 
         */


        static void Main(string[] args)
        {




            Console.WriteLine("Allowed protocoll: " + protocolName);
            Console.WriteLine("Allowed File extensions: " + string.Join(", ", allowedFiles));

            //check if any arguments where give, exit if there arent any
            if (args.Length < 1)
            {
                Console.WriteLine("no path given");
                return;
            }
            Console.WriteLine("path given");
            Console.WriteLine(args[0]);
            //get arguments
            string originalWebPath = args[0];

            try {
                //convert web path to windows format
                string winpath = ConvertBrowserPathToWindowsPath(originalWebPath);

                //validate if path is valid for settings that where set
                string validatedPath = ValidatePath(winpath);

                //if folder, show folder
                if(Directory.Exists(winpath))
                {
                    //if folder, open folder in explorer
                    Process.Start("explorer.exe", "\"" + validatedPath + "\"");

                    Console.WriteLine("opening folder");

                }
                else
                {
                    //else highlight a file in explorer
                    Process.Start("explorer.exe", "/select, \"" + validatedPath + "\"");

                    Console.WriteLine("highlighting file");

                }

            } catch (Exception e) {

                Console.WriteLine("error message:");
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
        }
        static string ConvertBrowserPathToWindowsPath(string browserPath)
        {
            //check if the path starts with the right protocol name
            if (browserPath.StartsWith(protocolName))
            {
                //remove protocol from path
                string urlPath = browserPath.Substring(protocolName.Length);


                //change the uri encoded path to windows path
                string systemPath = Uri.UnescapeDataString(urlPath);

                //change / to \\
                systemPath = systemPath.Replace("/", "\\");
                return systemPath;

            }
            else
            {
                Console.WriteLine(protocolName);
                throw new Exception("bad protocol");
            }
        }
        static string ValidatePath(string path)
        {
            //Remove invalid characters
            path = Path.GetInvalidPathChars().Aggregate(path, (current, c) => current.Replace(c.ToString(), string.Empty));


            //Regex for checking if path is valid and athears to the settings
            //TODO: check regex
            Console.WriteLine(path);
            if (!Regex.IsMatch(path, @"^([a-zA-Z]:\\|%UserProfile%\\)(?:[^\\/:*?<>|""\u0000-\u001F\u0080-\u009F]+\\)*[^\\/:*?<>|""\u0000-\u001F\u0080-\u009F]*$"))
            {
                
                throw new Exception("bad characters in path");
            }
            // Expand Enviroment Variables
            path = Environment.ExpandEnvironmentVariables(path);
            Console.WriteLine("Enviroment Expanded path: " + path);

            //get file extension of path
            string extension = Path.GetExtension(path);

            //throw extension if file extension is not on the allowed list
            //check if its a file and if the file exists
            if(!string.IsNullOrEmpty(extension))
            {
                //is valid file
                //check if is allowed file extension, throw exception if not
                var match = allowedFiles.FirstOrDefault(stringToCheck => stringToCheck.Contains(extension)) ?? throw new Exception("disallowed File extension: "+ extension);

                //return valid path
                return path;
            
            }
            else if(Directory.Exists(path)) 
            {
                return path;

            }

            throw new Exception("invalid path");

        }
    }
}