

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Syncfusion.Data.Extensions;
using TaborLedce.Models;
using TaborLedce.Views;

namespace TaborLedce.ViewModels
{
    public class PlansViewModel : BaseViewModel
    {
        public ObservableCollection<Plant> Plants { get; set; }


        public PlansViewModel()
        {
            Plants = new ObservableCollection<Plant>();
            GetJsonData();
        }

        void GetJsonData()
        {
            string jsonFileName = "Plants.json";
            List<Plant> plats = new List<Plant>();
            string a = JsonConvert.SerializeObject(plats);

            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Resources.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                string jsonString = reader.ReadToEnd();
                plats = JsonConvert.DeserializeObject<List<Plant>>(jsonString);
            }
            plats.ForEach(x => Plants.Add(x));
        }
    }
}
