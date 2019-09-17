using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TaborLedce.MyCommands;
using TaborLedce.Models;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class TranslationViewModel: BaseViewModel
    {
        public ObservableCollection<TranslationItem> MyTranslations { get; set; }
        public string TranslationText { get; set; }

        public ICommand CreateTranslationCommand { get; set; }

        public TranslationViewModel()
        {
            CreateTranslationCommand = new Command(CreateNewTranslation);
            MyTranslations = new ObservableCollection<TranslationItem>();
            MyTranslations.Add(new TranslationItem{Text = "Zachy je nejlepší, král a vládce tohoto světa"});
        }

        private void CreateNewTranslation()
        {
            MyTranslations.Insert(0,new TranslationItem{Text = TranslationText});
        }
    }
}
