using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using tinda.Models;
using tinda.Views.Create;
using Xamarin.Forms;

namespace tinda.Views.Details
{
    public partial class CustomersPage : ContentPage
    {
		public static readonly BindableProperty BindableNavTitle = BindableProperty.Create("NavTitle", typeof(string), typeof(CustomersPage), "Customers");
		public string NavTitle { get { return (string)GetValue(BindableNavTitle); } }

		public static readonly BindableProperty BindableNavIcon = BindableProperty.Create("NavIcon", typeof(string), typeof(CustomersPage), "people");
		public string NavIcon { get { return (string)GetValue(BindableNavIcon); } }

		public static readonly BindableProperty BindableNavLeftIcon = BindableProperty.Create("NavLeftIcon", typeof(string), typeof(CustomersPage), "burger");
        public string NavLeftIcon { get { return (string)GetValue(BindableNavLeftIcon); } }

		public static readonly BindableProperty BindableNavRightIcon = BindableProperty.Create("NavRightIcon", typeof(string), typeof(CustomersPage), "add");
		public string NavRightIcon { get { return (string)GetValue(BindableNavRightIcon); } }

        public static readonly BindableProperty BindableNavLeftIconCommand = BindableProperty.Create("NavLeftIconCommand", typeof(ICommand), typeof(CustomersPage), null);
        public ICommand NavLeftIconCommand { get { return new Command(() => LeftIconClicked()); } }

		public static readonly BindableProperty BindableNavRightIconCommand = BindableProperty.Create("NavRightIconCommand", typeof(ICommand), typeof(CustomersPage), null);
		public ICommand NavRightIconCommand { get { return new Command(() => RightIconClicked()); } }

        private void LeftIconClicked()
        {
            MainPage detail = (MainPage)this.Parent.Parent; 
            detail.IsPresented = true;
        }

		private void RightIconClicked()
		{
            Navigation.PushModalAsync(new CreateCustomerPage(), true);
		}

        public CustomersPage()
        {
            InitializeComponent();

            var customers = new List<CustomerModel>();
            customers.Add(new CustomerModel { Name = "Green Cross", Age = 18, Address = "Mandaue City",  Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg"});
			customers.Add(new CustomerModel { Name = "One Two", Age = 20, Address = "Cebu City", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Three Four", Age = 19, Address = "Liloan", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Five Six", Age = 30, Address = "Talisay", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Seven Eight", Age = 32, Address = "Lapu-Lapu", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Nine Ten", Age = 44, Address = "Mactan", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Eleven Twelve", Age = 52, Address = "Consolacion", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Two One", Age = 51, Address = "Foodland", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });
			customers.Add(new CustomerModel { Name = "Four Three", Age = 70, Address = "Banilad", Image = "http://img.timeinc.net/time/daily/2010/1011/poy_nomination_agassi.jpg" });



			listView.ItemsSource = customers;

        }


    }
}
