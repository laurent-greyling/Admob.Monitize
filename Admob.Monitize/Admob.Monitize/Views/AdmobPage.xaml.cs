using Admob.Monitize.Controls;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Admob.Monitize.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdmobPage : ContentPage
	{
		public AdmobPage ()
		{
			InitializeComponent ();
		}

        public async Task Show_Ad(object sender, EventArgs e)
        {
            DependencyService.Get<IAdmobInterstitial>().Show("");
            await Navigation.PushAsync(new LandingPage());
        }
    }
}