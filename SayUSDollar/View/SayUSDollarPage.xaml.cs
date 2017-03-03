﻿using SayUSDollar.ViewModel;
using Xamarin.Forms;

namespace SayUSDollar
{
	public partial class SayUSDollarPage : ContentPage
	{
		public SayUSDollarPage()
		{
			InitializeComponent();
			var currencyViewModel = new CurrencyListViewModel();
			BindingContext = currencyViewModel;

			CurrencyList.IsPullToRefreshEnabled = true;
			CurrencyList.RefreshCommand = currencyViewModel.RefreshCommand;
			CurrencyList.SetBinding(ListView.IsRefreshingProperty, nameof(currencyViewModel.IsBusy));

			CurrencyList.ItemTapped += (sender, e) =>
			{
				CurrencyList.SelectedItem = null;
			};
		}
	}
}
