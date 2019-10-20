using TaborLedce.Models;

namespace TaborLedce.ViewModels
{
    public class PlantsDetailViewModel : BaseViewModel
    {
        public Plant SelectedPlant { get; set; }
        public PlantsDetailViewModel(Plant selectedPlatn)
        {
            SelectedPlant = selectedPlatn;
        }
        
    }
}
