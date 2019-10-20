using System;
using System.Windows.Input;
using TaborLedce.Assets;
using Xamarin.Forms;

namespace TaborLedce.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = $"{Messages.Oaplikaci}";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/taborledcekopidlno/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}