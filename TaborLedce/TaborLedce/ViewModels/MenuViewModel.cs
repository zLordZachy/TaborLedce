using System.Collections.ObjectModel;
using TaborLedce.Assets;
using TaborLedce.Models;
using TaborLedce.Utils;
using TaborLedce.Views;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
     
        public ObservableCollection<HomeMenuItem> MenuItems { get; set; }
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        public HomeMenuItem SelectedHomeItem
        {
            get => _selectedHomeItem;
            set
            {
                _selectedHomeItem = value;
                SelectedItemChange(value);
            }
        }

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.MorseCode, Title=Messages.Morseovka, Icon= $"{FontAwesomeIcons.CommentDots}", FontFamily = Application.Current.Resources["FontAwesomeSolid"]},
                new HomeMenuItem {Id = MenuItemType.Plans, Title=Messages.Rostliny, Icon= $"{FontAwesomeIcons.Seedling}", FontFamily = Application.Current.Resources["FontAwesomeSolid"]},
                new HomeMenuItem {Id = MenuItemType.MarchingMarks, Title=Messages.MarchingMarks, Icon= $"{FontAwesomeIcons.MarsStrokeH}", FontFamily = Application.Current.Resources["FontAwesomeSolid"]},
                new HomeMenuItem {Id = MenuItemType.Instagram, Title=Messages.InstagramFotky, Icon= $"{FontAwesomeIcons.Instagram}", FontFamily = Application.Current.Resources["FontAwesomeBrands"]},
                new HomeMenuItem {Id = MenuItemType.About, Title=Messages.Oaplikaci, Icon= $"{FontAwesomeIcons.Info}", FontFamily = Application.Current.Resources["FontAwesomeSolid"]},
            };
            
        }

        public async void SelectedItemChange(HomeMenuItem homeMenuItem)
        {
            if(homeMenuItem == null)
                return;

            await RootPage.NavigateFromMenu((int)homeMenuItem.Id);
        }

        private HomeMenuItem _selectedHomeItem;
    }
}
