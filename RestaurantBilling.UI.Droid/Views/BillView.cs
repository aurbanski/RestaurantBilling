
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using MvvmCross.Droid.Views;

namespace RestaurantBilling.UI.Droid.Views
{
    [Activity(Label = "Create Bill", NoHistory = true)]
    public class BillView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Bill);
        }
    }
}
