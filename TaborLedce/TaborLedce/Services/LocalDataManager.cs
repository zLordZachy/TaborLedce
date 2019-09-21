using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TaborLedce.Models;
using TaborLedce.PlatformSpecific;
using static System.IO.Path;

namespace TaborLedce.Services
{
    public class LocalDataManager : ILocalDataManager
    {
        private readonly IFileManager _fileManager;

        public LocalDataManager(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        private const string FileName = "Translations.txt";
        private const string FolderName = "Translations";

        public void SaveTransaltions(List<TranslationItem> translationItems)
        {
            string data = JsonConvert.SerializeObject(translationItems);
            SaveDataToFileAsync(data, FolderName, FileName);
        }

        public List<TranslationItem> LoadTransalations()
        {
            var localData = ReadDataFromFileAsync(FolderName, FileName);
            if (string.IsNullOrEmpty(localData))
                return new List<TranslationItem>();

            return JsonConvert.DeserializeObject<List<TranslationItem>>(localData);
        }


        private void SaveDataToFileAsync(string data, string folderName, string fileName)
        {
            _fileManager.CreateFolder(FolderName);
            string[] files = _fileManager.GetAllDirectories();
            string fileFolder = files.FirstOrDefault(x => GetFileName(x).Equals(FolderName));
            string path = Combine(fileFolder, fileName);
            _fileManager.DeleteFile(path);
            _fileManager.AppendLine(path, data);
        }

        private string ReadDataFromFileAsync(string folder, string fileName)
        {
            string[] files = _fileManager.GetAllDirectories();
            string fileFolder = files.FirstOrDefault(x => GetFileName(x).Equals(FolderName));

            if (fileFolder == null)
                return null;

            return _fileManager.ReadFirstLine(Combine(fileFolder, fileName));
        }
    }
}