using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TaborLedce.Assets;
using TaborLedce.Models;
using TaborLedce.Services;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class InstagramViewModel : BaseViewModel
    {
        private readonly IInstagramService _instagramService;
        public ObservableCollection<StandardResolution> Images { get; set; }


        public InstagramViewModel(IInstagramService instagramService)
        {
            _instagramService = instagramService;
            Images = new ObservableCollection<StandardResolution>();
        }


        public async Task OnLoad()
        {
            try
            {
                Images.Clear();
                var instagramMetadata = await _instagramService.GetInstagramMetadata();
                IEnumerable<StandardResolution> data = instagramMetadata.data.Select(x => x.images.standard_resolution);
                foreach (var image in data)
                {
                    Images.Add(image);
                }
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert(Messages.ChybaPripojeni, Messages.M001, "Ok");
            }
            
        }
    }
}
