using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TaborLedce.MyCommands;
using TaborLedce.Models;
using TaborLedce.Views;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class MorseCodeTabViewModel: BaseViewModel
    {
        public ObservableCollection<MorseCodeItem> AlphabetMorseCodes { get; set; }
        public ObservableCollection<MorseCodeItem> NumberMorseCodes { get; set; }
        public IAsyncCommand<object> TranslationCommand { get; set; }
        public ICommand NumberImageClickCommand { get; set; }
        public ICommand AlphabetImageClickCommand { get; set; }

        private readonly INavigation _navigation;

        public int SelectedIndex { get; set; }

        public MorseCodeTabViewModel(INavigation navigation)
        {
            _navigation = navigation;
            AlphabetMorseCodes = new ObservableCollection<MorseCodeItem>(MorseCodeItems.GetAllAlphabet());
            NumberMorseCodes = new ObservableCollection<MorseCodeItem>(MorseCodeItems.GetAllNumbers());
            TranslationCommand = new AsyncCommand<object>(OpenTransaltionPage);
            NumberImageClickCommand = new Command(SwichNumberTab);
            AlphabetImageClickCommand = new Command(SwichAlphabetTab);
            SelectedIndex = 0;
        }

        private void SwichAlphabetTab(object obj)
        {
            SelectedIndex = 0;
        }

        private void SwichNumberTab(object obj)
        {
            SelectedIndex = 1;
        }

        private async Task OpenTransaltionPage(object o)
        {
            await Task.Delay(50);
            await _navigation.PushModalAsync(new NavigationPage(new TranslationPage()));
        }
    }
}
