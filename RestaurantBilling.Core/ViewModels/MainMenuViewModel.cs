﻿using System;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace RestaurantBilling.Core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        public ICommand NavigateCreateBill
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<BillViewModel>(new { subTotal = 40 }));
            }
        }
    }
}
