using Admob.Monitize.Views;
using System;

using Xamarin.Forms;

namespace Admob.Monitize
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new AdmobPage();
            else
                MainPage = new NavigationPage(new AdmobPage());
        }
    }
}