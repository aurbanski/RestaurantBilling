using System;
using MvvmCross.Core.ViewModels;
using RestaurantBilling.Core.ViewModels;

namespace RestaurantBilling.Core
{
    public class CustomAppStart :MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainMenuViewModel>();
        }
    }
}
