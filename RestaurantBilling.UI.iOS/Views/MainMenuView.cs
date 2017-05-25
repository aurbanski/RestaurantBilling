using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using RestaurantBilling.Core.ViewModels;

using UIKit;

namespace RestaurantBilling.UI.iOS.Views
{
    public partial class MainMenuView : MvxViewController<MainMenuViewModel>
    {
        public MainMenuView() : base("MainMenuView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VCCreateBill).To((MainMenuViewModel vm) => vm.NavigateCreateBill).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

