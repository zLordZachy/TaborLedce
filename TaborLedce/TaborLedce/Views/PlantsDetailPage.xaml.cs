using TaborLedce.Models;
using TaborLedce.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TaborLedce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantsDetailPage : ContentPage
    {
        public PlantsDetailPage(Plant selectedPlant)
        {
            BindingContext = new PlantsDetailViewModel(selectedPlant);
            InitializeComponent();
        }
    }
}