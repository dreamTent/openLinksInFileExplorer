using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openLinksInFileExplorerCore
{
    [Serializable()]
    public class Configuration
    {
        public string[] allowedExtensions = [".docx", ".doc", ".xlsx", ".xls", ".pptx", ".ppt", ".txt", ".pdf", ".rtf"];

    }
}
