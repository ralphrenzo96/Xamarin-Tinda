using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace tinda.Views.Details.Customers
{
    public partial class ViewCustomerPage : ContentPage
    {
		public static readonly BindableProperty BindableNavLeftIcon = BindableProperty.Create("NavLeftIcon", typeof(string), typeof(ViewCustomerPage), "arrow_down");
		public string NavLeftIcon { get { return (string)GetValue(BindableNavLeftIcon); } }

		public static readonly BindableProperty BindableNavLeftIconCommand = BindableProperty.Create("NavLeftIconCommand", typeof(ICommand), typeof(ViewCustomerPage), null);
		public ICommand NavLeftIconCommand { get { return new Command(() => LeftIconClicked()); } }

		public static readonly BindableProperty BindableNavRightIcon = BindableProperty.Create("NavRightIcon", typeof(string), typeof(CustomersPage), "trashbin");
		public string NavRightIcon { get { return (string)GetValue(BindableNavRightIcon); } }

		private void LeftIconClicked()
		{
			//AnimatePage(0);
            Navigation.PopModalAsync(true);
		} 

        public ViewCustomerPage()
        {
            InitializeComponent();
        }
    }
}
