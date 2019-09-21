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
            AlphabetMorseCodes= new ObservableCollection<MorseCodeItem>
            {
                new MorseCodeItem{Lettr = "A",Helpr = "akát", Image = "codeA.png" },
                new MorseCodeItem{Lettr = "B",Helpr = "blýskavice", Image = "codeB.png" },
                new MorseCodeItem{Lettr = "C",Helpr = "cílovníci", Image = "codeC.png" },
                new MorseCodeItem{Lettr = "D",Helpr = "dálava, dálnice", Image = "codeD.png" },
                new MorseCodeItem{Lettr = "E",Helpr = "erb", Image = "codeE.png" },
                new MorseCodeItem{Lettr = "F",Helpr = "Filipíny, filiálka", Image = "codeF.png" },
                new MorseCodeItem{Lettr = "G",Helpr = "Grónská zem, gnómóny", Image = "codeG.png" },
                new MorseCodeItem{Lettr = "H",Helpr = "hrachovina, holubice", Image = "codeH.png" },
                new MorseCodeItem{Lettr = "CH",Helpr = "chléb nám dává, chvátá k nám sám,", Image = "codeCH.png" },
                new MorseCodeItem{Lettr = "H",Helpr = "hrachovina, holubice", Image = "codeH.png" },
                new MorseCodeItem{Lettr = "I",Helpr = "ibis, Ivan", Image = "codeI.png" },
                new MorseCodeItem{Lettr = "J",Helpr = "jasmín bílý, junácká hůl", Image = "codeJ.png" },
                new MorseCodeItem{Lettr = "K",Helpr = "krákorá, království", Image = "codeK.png" },
                new MorseCodeItem{Lettr = "L",Helpr = "lupíneček", Image = "codeL.png" },
                new MorseCodeItem{Lettr = "M",Helpr = "hrachovina", Image = "codeM.png" },
                new MorseCodeItem{Lettr = "N",Helpr = "národ, nástup", Image = "codeN.png" },
                new MorseCodeItem{Lettr = "O",Helpr = "ó náš pán, ó náš háj", Image = "codeO.png" },
                new MorseCodeItem{Lettr = "P",Helpr = "papírníci", Image = "codeP.png" },
                new MorseCodeItem{Lettr = "Q",Helpr = "kvílí orkán", Image = "codeQ.png" },
                new MorseCodeItem{Lettr = "R",Helpr = "rarášek", Image = "codeR.png" },
                new MorseCodeItem{Lettr = "S",Helpr = "sekera", Image = "codeS.png" },
                new MorseCodeItem{Lettr = "T",Helpr = "tón", Image = "codeT.png" },
                new MorseCodeItem{Lettr = "U",Helpr = "uličník", Image = "codeU.png" },
                new MorseCodeItem{Lettr = "V",Helpr = "vyvolený", Image = "codeV.png" },
                new MorseCodeItem{Lettr = "W",Helpr = "wagón klád", Image = "codeW.png" },
                new MorseCodeItem{Lettr = "X",Helpr = "Xénokratés", Image = "codeX.png" },
                new MorseCodeItem{Lettr = "Y",Helpr = "ý se ztrácí", Image = "codeY.png" },
                new MorseCodeItem{Lettr = "Z",Helpr = "zrádná žena", Image = "codeZ.png" },
            };

            NumberMorseCodes = new ObservableCollection<MorseCodeItem>
            {
                new MorseCodeItem{Lettr = "0",Helpr = "", Image = "code0.png" },
                new MorseCodeItem{Lettr = "1",Helpr = "", Image = "code1.png" },
                new MorseCodeItem{Lettr = "2",Helpr = "", Image = "code2.png" },
                new MorseCodeItem{Lettr = "3",Helpr = "", Image = "code3.png" },
                new MorseCodeItem{Lettr = "4",Helpr = "", Image = "code4.png" },
                new MorseCodeItem{Lettr = "5",Helpr = "", Image = "code5.png" },
                new MorseCodeItem{Lettr = "6",Helpr = "", Image = "code6.png" },
                new MorseCodeItem{Lettr = "7",Helpr = "", Image = "code7.png" },
                new MorseCodeItem{Lettr = "8",Helpr = "", Image = "code8.png" },
                new MorseCodeItem{Lettr = "9",Helpr = "", Image = "code9.png" },
            };
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
