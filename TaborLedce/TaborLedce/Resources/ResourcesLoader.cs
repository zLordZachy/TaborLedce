using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using TaborLedce.Views;

namespace TaborLedce.Resources
{
    public abstract class ResourcesLoader<T,TD>   where T : ResourcesLoader<T,TD>, new()
    {
        public static T Instance { get; } = new T();

        public IList<TD> Data;
        

        protected void LoadResources(string jsonFileName)
        {
            if (string.IsNullOrEmpty(jsonFileName))
                Data  =  new List<TD>();

            Data = new List<TD>();
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;

            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Resources.{jsonFileName}");
            using (var reader = new StreamReader(stream))
            {
                string jsonString = reader.ReadToEnd();
                Data = JsonConvert.DeserializeObject<List<TD>>(jsonString);
            }
        }
    }
}
