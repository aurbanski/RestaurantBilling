using System;
using MvvmCross.Core.ViewModels;
using RestaurantBilling.Core.Services;
using RestaurantBilling.Core.Models;
using System.Windows.Input;
using MvvmCross.Platform;

namespace RestaurantBilling.Core.ViewModels
{
    public class BillViewModel : MvxViewModel
    {
        readonly IBillCalculator _calculation;
        Bill _bill;
        int _gratuity;

        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        public string CustomerEmail
        {
            get
            {
                return _bill.CustomerEmail;
            }
            set
            {
                _bill.CustomerEmail = value;
                RaisePropertyChanged(() => CustomerEmail);
            }
        }

        public double SubTotal
        {
            get
            {
                return _bill.SubTotal;
            }
            set
            {
                _bill.SubTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        public int Gratuity
        {
            get
            {
                return _gratuity;
            }
            set
            {
                _gratuity = value;
                RaisePropertyChanged(() => Gratuity);
                Recalculate();
            }
        }

        public double Tip
        {
            get 
            {
                return _bill.Tip;    
            }
            set{
                _bill.Tip = value;
                RaisePropertyChanged(() => Tip);

            }
        }

        public double Total
        {
            get
            {
                return _bill.AmountPaid;
            }
            set
            {
                _bill.AmountPaid = value;
                RaisePropertyChanged(() => Total);
            }
        }

        public BillViewModel(IBillCalculator calculation)
        {
            _calculation = calculation;
        }

        public ICommand SaveBill
        {
            get{
                return new MvxCommand(() =>
                {
                    if(_bill.IsValid())
                    {
						Mvx.Resolve<Repository>().CreateBill(_bill).Wait();
						Close(this);
                    }
                });
            }
        }

        public void Init(Bill bill = null)
        {
			_bill = bill == null ? new Bill() : bill;
			_gratuity = (int)_calculation.Gratuity(_bill.SubTotal, bill.Tip);
			RaiseAllPropertiesChanged();
        }

        public override void Start()
        {
            _gratuity = 10;
            Recalculate();
            base.Start();
        }

        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Gratuity);
            Total = _calculation.BillTotal(SubTotal, Gratuity);
        }
    }
}
