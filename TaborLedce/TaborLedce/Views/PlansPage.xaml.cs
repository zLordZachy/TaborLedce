using TaborLedce.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaborLedce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlansPage : ContentPage
    {
        public PlansPage()
        {
            BindingContext = new PlansViewModel();
            InitializeComponent();
        }
    }
}