using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaborLedce.Models;
using TaborLedce.Services;

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
            var a = await _instagramService.GetInstagramMetadata();
            IEnumerable<StandardResolution> aa = a.data.Select(x => x.images.standard_resolution);
            foreach (var cc in aa)
            {
                Images.Add(cc);
            }
        }
    }
}
