using Admob.Monitize.Controls;
using Admob.Monitize.Droid;
using Android.Gms.Ads;
using Xamarin.Forms;

[assembly: Dependency(typeof(AdmobInterstitial))]
namespace Admob.Monitize.Droid
{
    public class AdmobInterstitial : IAdmobInterstitial
    {
        InterstitialAd _ad;

        public void Show(string adUnit)
        {
            _ad = new InterstitialAd(Forms.Context)
            {
                AdUnitId = adUnit
            };

            var intlistener = new InterstitialAdListener(_ad);
            intlistener.OnAdLoaded();
            _ad.AdListener = intlistener;

           _ad.LoadAd(new AdRequest.Builder().Build());
        }
    }
}