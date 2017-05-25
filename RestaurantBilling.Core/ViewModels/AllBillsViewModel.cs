using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RestaurantBilling.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RestaurantBilling.Core.ViewModels
{
    public class AllBillsViewModel : MvxViewModel
    {
        public List<Bill> AllBills { get; set; }

        public ICommand NavBack
        {
            get{
                return new MvxCommand(() => Close(this));
            }
        }

        public void Init()
        {
            Task<List<Bill>> result = Mvx.Resolve<Repository>().GetAllBills();
            result.Wait();
            AllBills = result.Result;
        }
    }
}
