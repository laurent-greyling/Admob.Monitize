using Admob.Monitize.Droid;
using Xamarin.Forms;
using Admob.Monitize.Controls;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;
using Android.Widget;

[assembly: ExportRenderer(typeof(AdControlView1), typeof(AdViewRenderer1))]
namespace Admob.Monitize.Droid
{
    public class AdViewRenderer1 : ViewRenderer<AdControlView1, AdView>
    {
        string adUnitId = "";
        AdSize adSize = AdSize.MediumRectangle;
        AdView adView;

        AdView CreateAdView()
        {
            if (adView != null)
            {
                return adView;
            }

            adView = new AdView(Forms.Context)
            {
                AdSize = adSize,
                AdUnitId = adUnitId
            };

            var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);
            adView.LayoutParameters = adParams;

            adView.LoadAd(new AdRequest.Builder().Build());
            return adView;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView1> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                CreateAdView();
                SetNativeControl(adView);
            }
        }
    }
}