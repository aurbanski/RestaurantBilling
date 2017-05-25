using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RestaurantBilling.Core.Services;

namespace RestaurantBilling.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<IBillCalculator, BillCalculator>();
            var calcExample = Mvx.Resolve<IBillCalculator>();

            var appStart = new CustomAppStart();
            Mvx.RegisterSingleton<IMvxAppStart>(appStart);
        }
    }
}
