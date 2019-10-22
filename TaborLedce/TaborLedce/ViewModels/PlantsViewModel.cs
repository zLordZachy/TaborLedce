using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TaborLedce.Models;
using TaborLedce.Resources;
using TaborLedce.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TaborLedce.ViewModels
{
    public class PlansViewModel : BaseViewModel
    {
        public ObservableCollection<Plant> Plants { get; set; }
        public ICommand GetItemDetailCommand { get; set; }

        private readonly INavigation _navigation;

        public PlansViewModel(INavigation navigation)
        {
            _navigation = navigation;
            Plants = new ObservableCollection<Plant>();
            PlantsResource pnPlantsResource = PlantsResource.Instance;

            IList<Plant> plats = pnPlantsResource.Data;
            plats.ForEach(x => Plants.Add(x));
            GetItemDetailCommand = new Command(GetItemDetail);
        }

        private void GetItemDetail(object obj)
        {
            Plant selectedPlant  = obj as Plant;
            _navigation.PushAsync(new PlantsDetailPage(selectedPlant));
        }
    }
}
