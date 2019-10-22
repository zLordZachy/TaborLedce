using TaborLedce.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaborLedce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarchingMarksPage : ContentPage
    {
        public MarchingMarksPage()
        {
            BindingContext = new MarchingMarksViewModel();
            InitializeComponent();
        }
    }
}