using System;
using System.Collections.Generic;

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

        public CustomersPage()
        {
            InitializeComponent();
        }
    }
}
