using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using tinda.Utilities;
using Xamarin.Forms;

namespace tinda.Views.Create
{
    public partial class CreateCustomerPage : ContentPage
    {
		public static readonly BindableProperty BindableNavTitle = BindableProperty.Create("NavTitle", typeof(string), typeof(CreateCustomerPage), "Add Customer");
		public string NavTitle { get { return (string)GetValue(BindableNavTitle); } }

		public static readonly BindableProperty BindableNavIcon = BindableProperty.Create("NavIcon", typeof(string), typeof(CreateCustomerPage), "person_add");
		public string NavIcon { get { return (string)GetValue(BindableNavIcon); } }

        public static readonly BindableProperty BindableNavLeftIcon = BindableProperty.Create("NavLeftIcon", typeof(string), typeof(CreateCustomerPage), "arrow_down");
		public string NavLeftIcon { get { return (string)GetValue(BindableNavLeftIcon); } }

		public static readonly BindableProperty BindableNavLeftIconCommand = BindableProperty.Create("NavLeftIconCommand", typeof(ICommand), typeof(CreateCustomerPage), null);
		public ICommand NavLeftIconCommand { get { return new Command(() => LeftIconClicked()); } }

		private void LeftIconClicked()
		{
            Navigation.PopModalAsync(true);
		}

		public CreateCustomerPage()
        {
            InitializeComponent();
        }

        void Customer_Add(Object sender, EventArgs e)
        {
            DummyDatas.AddCustomer(entryName.Text, Convert.ToInt32(entryAge.Text), entryAddress.Text, entryImage.Text);
			Navigation.PopModalAsync(true);
        }
    }
}
