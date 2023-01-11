namespace MDD4All.FileAccess.Contracts
{
    public interface IFileLoader
    {
        bool ShowOpenFileDialog(out string selectedFilename, string defaultFielname = "",
                                string defaultFileExtension = "",
                                string filter = "All Files (*.*)|*.*");

        byte[] ReadDataFromFile(string filename);
    }
}
