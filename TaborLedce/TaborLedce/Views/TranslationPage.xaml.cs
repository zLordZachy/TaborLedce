using System.ComponentModel;
using TaborLedce.BL;
using TaborLedce.PlatformSpecific;
using TaborLedce.Services;
using TaborLedce.ViewModels;
using Xamarin.Forms;

namespace TaborLedce.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class TranslationPage : ContentPage
    {
        public TranslationPage()
        {
            TranslationViewModel viewModel = new TranslationViewModel(new LocalDataManager(DependencyService.Get<IFileManager>()), new TranslationFacade());
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}