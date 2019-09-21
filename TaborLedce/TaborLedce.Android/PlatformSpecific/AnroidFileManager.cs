using System;
using System.IO;
using System.Linq;
using TaborLedce.Droid.PlatformSpecific;
using TaborLedce.PlatformSpecific;
using Xamarin.Forms;

[assembly: Dependency(typeof(AnroidFileManager))]
namespace TaborLedce.Droid.PlatformSpecific
{
    public class AnroidFileManager : IFileManager
    {
        private readonly string _basePath;

        public AnroidFileManager()
        {
            _basePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        public void AppendLine(string relativeFilePath, string data)
        {
            var filePath = Path.Combine(_basePath, relativeFilePath);
            File.AppendAllLines(filePath, new[] {data});
        }

        public string[] GetAllDirectories(string relativeDirectoryPath = null, string searchPattern = null)
        {
            var directoryPath = string.IsNullOrEmpty(relativeDirectoryPath)
                ? _basePath
                : Path.Combine(_basePath, relativeDirectoryPath);
            if (!Directory.Exists(directoryPath))
                return new string[0];

            if (string.IsNullOrEmpty(searchPattern))
                return Directory.GetDirectories(directoryPath);

            return Directory.GetDirectories(directoryPath, searchPattern, SearchOption.TopDirectoryOnly);
        }

        public void DeleteFile(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath)) File.Delete(filePath);
        }

        public void CreateFolder(string relativeDirectoryPath)
        {
            var filePath = Path.Combine(_basePath, relativeDirectoryPath);
            Directory.CreateDirectory(filePath);
        }

        public string ReadFirstLine(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return null;

            return File.ReadLines(filePath).FirstOrDefault();
        }
    }
}
