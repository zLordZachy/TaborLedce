using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Syncfusion.Data.Extensions;
using TaborLedce.Models;
using TaborLedce.Services;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class TranslationViewModel: BaseViewModel
    {
        private readonly ILocalDataManager _localDataManager;
        public ObservableCollection<TranslationItem> MyTranslations { get; set; }
        public string TranslationText { get; set; }

        public ICommand CreateTranslationCommand { get; set; }

        public ICommand DeleteAllTranslationCommand { get; set; }

        public TranslationViewModel(ILocalDataManager localDataManager)
        {
            _localDataManager = localDataManager;
            CreateTranslationCommand = new Command(CreateNewTranslation);
            DeleteAllTranslationCommand = new Command(DeleteAllTranslations);
            MyTranslations = new ObservableCollection<TranslationItem>();
            IList<TranslationItem> currentTranslations = _localDataManager.LoadTransalations();
            currentTranslations.ForEach(x => MyTranslations.Add(x));
        }

        private void DeleteAllTranslations()
        {
            MyTranslations.Clear();
            _localDataManager.SaveTransaltions(new List<TranslationItem>());
        }

        private void CreateNewTranslation()
        {
            if(string.IsNullOrEmpty(TranslationText) || string.IsNullOrWhiteSpace(TranslationText))
                return;

            MyTranslations.Insert(0,new TranslationItem{Text = TranslationText});
            _localDataManager.SaveTransaltions(Enumerable.ToList(MyTranslations));
            TranslationText = string.Empty;
        }


    }
}
