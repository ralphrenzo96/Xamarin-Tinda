using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace tinda.Views.Details
{
    public partial class CustomersPage : ContentPage
    {
		public static readonly BindableProperty BindableNavTitle = BindableProperty.Create("NavTitle", typeof(string), typeof(CustomersPage), "Customers");
		public string NavTitle { get { return (string)GetValue(BindableNavTitle); } }

        public CustomersPage()
        {
            InitializeComponent();
        }
    }
}
