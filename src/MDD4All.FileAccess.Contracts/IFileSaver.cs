using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.FileAccess.Contracts
{
    public interface IFileSaver
    {
        bool ShowFileSaveDialog(out string selectedFilename, string defaultFielname = "",
                                string defaultFileExtension = "",
                                string filter = "All Files (*.*)|*.*");

        void WriteDataToFile(string filename, byte[] data);
    }
}
