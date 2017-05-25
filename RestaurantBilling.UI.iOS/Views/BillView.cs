using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using RestaurantBilling.Core.ViewModels;

using UIKit;

namespace RestaurantBilling.UI.iOS.Views
{
    public partial class BillView : MvxViewController<BillViewModel>
    {
        public BillView() : base("BillView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VCEmail).To((BillViewModel vm) => vm.CustomerEmail).Apply();

            this.CreateBinding(VCSubTotal).For(label => label.Text).To((BillViewModel vm) => vm.SubTotal).Apply();

            this.CreateBinding(VCGratuity).To((BillViewModel vm) => vm.Gratuity).Apply();
            this.CreateBinding(VCTip).To((BillViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(VCTotal).To((BillViewModel vm) => vm.Total).Apply();

			View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
			{
				this.VCEmail.ResignFirstResponder();
				this.VCSubTotal.ResignFirstResponder();
			}));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

