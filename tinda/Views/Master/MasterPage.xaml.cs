using System;
using System.Collections.Generic;
using tinda.Models;
using tinda.Views.Details;
using Xamarin.Forms;

namespace tinda.Views.Master
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Customers",
				IconSource = "icon.png",
				TargetType = typeof(CustomersPage)
			});
			listView.ItemsSource = masterPageItems;
        }
    }
}
