using TaborLedce.PlatformSpecific;
using TaborLedce.Services;
using TaborLedce.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TaborLedce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstagramPage : ContentPage
    {
       
        private readonly InstagramViewModel _viewModel;

        public InstagramPage()
        {
            _viewModel = new InstagramViewModel(new InstagramService(DependencyService.Get<IHttpClient>()));
            BindingContext = _viewModel;
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
             await _viewModel.OnLoad();
            base.OnAppearing();
        }

    }
}