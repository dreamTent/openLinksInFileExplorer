using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace openLinksInFileExplorer
{
    public class ConfigLoader
    {

        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\openLinksInFileExplorer\\openLinksInFileExplorer" + "/settings.xml";


        public Configuration get()
        {


            // check if file exists

            if (!File.Exists(filePath))
            {
                return new Configuration();
            }


            Configuration config;

            using (var reader = new StreamReader(filePath))
            {
                config = (Configuration)new XmlSerializer(typeof(Configuration)).Deserialize(reader);
            }

            return config;


        }
        public int set(Configuration config)
        {




            // Insert code to set properties and fields of the object.  
            XmlSerializer mySerializer = new XmlSerializer(typeof(Configuration));
            // To write to a file, create a StreamWriter object.  
            StreamWriter myWriter = new StreamWriter(filePath);
            mySerializer.Serialize(myWriter, config);
            myWriter.Close();



            return 1;
        }
        public int delete()
        {
            try
            {
                File.Delete(filePath);
                return 1;
            }
            catch (Exception)
            {
                return -1;

            }
            

        }

    }
}