using TaborLedce.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaborLedce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MorseCodeTabPage : ContentPage
    {
        public MorseCodeTabPage()
        {
            MorseCodeTabViewModel viewModel = new MorseCodeTabViewModel(Navigation);
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}