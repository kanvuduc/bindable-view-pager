using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace Kan.Sample.Droid
{
    [Activity(Label = "Splushy", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity
        : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}

