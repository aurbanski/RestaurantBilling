using System;
using Android.App;
using MvvmCross.Core.Views;
using MvvmCross.Droid.Views;

namespace RestaurantBilling.UI.Droid.Views
{
    [Activity(Label = "My App", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity() : base(Resource.Layout.View_SplashScreen)
        {
        }
    }
}
