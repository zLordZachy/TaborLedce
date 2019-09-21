namespace TaborLedce.PlatformSpecific
{
    public interface IFileManager
    {
        void AppendLine(string relativeFilePath, string data);

        string[] GetAllDirectories(string relativeDirectoryPath = null, string searchPattern = null);

        void DeleteFile(string filePath);

        void CreateFolder(string relativeDirectoryPath);

        string ReadFirstLine(string filePath);
    }
}