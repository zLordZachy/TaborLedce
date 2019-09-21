using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Syncfusion.Data.Extensions;
using TaborLedce.BL;
using TaborLedce.Models;
using TaborLedce.Services;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class TranslationViewModel: BaseViewModel
    {
        private readonly ILocalDataManager _localDataManager;
        private readonly ITranslationFacade _translationFacade;
        public ObservableCollection<TranslationItem> MyTranslations { get; set; }
        public string TranslationText { get; set; }
        public bool TranslationMorseCode { get; set; }
        public ICommand CreateTranslationCommand { get; set; }

        public ICommand DeleteAllTranslationCommand { get; set; }

        public ICommand KeyPressedCommand { get; set; }
        

        public TranslationViewModel(ILocalDataManager localDataManager, ITranslationFacade translationFacade)
        {
            _localDataManager = localDataManager;
            _translationFacade = translationFacade;
            CreateTranslationCommand = new Command(CreateNewTranslation);
            DeleteAllTranslationCommand = new Command(DeleteAllTranslations);
            KeyPressedCommand = new Command(KeyPressed);
            MyTranslations = new ObservableCollection<TranslationItem>();
            IList<TranslationItem> currentTranslations = _localDataManager.LoadTransalations();
            currentTranslations.ForEach(x => MyTranslations.Add(x));
        }

        private void KeyPressed(object obj)
        {
            string character = (string)obj;

            if (character == "back")
            {
                if (TranslationText.Length > 0)
                {
                    TranslationText = TranslationText.Remove(TranslationText.Length - 1);
                }
                return;
            }

            TranslationText = String.Join(String.Empty, TranslationText, character);
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

            if (TranslationMorseCode)
            {
                _translationFacade.TranslateFromMorseCodeToClassic();
            }


            MyTranslations.Insert(0,new TranslationItem{Text = TranslationText});
            _localDataManager.SaveTransaltions(Enumerable.ToList(MyTranslations));
            TranslationText = string.Empty;
        }
    }
}
