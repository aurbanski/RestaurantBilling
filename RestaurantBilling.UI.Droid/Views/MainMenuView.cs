using System;
using Android.App;
using MvvmCross.Droid.Views;

namespace RestaurantBilling.UI.Droid.Views
{
    [Activity(Label = "Main Menu")]
    public class MainMenuView : MvxActivity
    {
        protected override void OnViewModelSet() 
        {
            SetContentView(Resource.Layout.View_MainMenu);
        }
    }
}
