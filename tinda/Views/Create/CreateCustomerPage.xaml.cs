using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
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
            //AnimatePage(0);
            Navigation.PopModalAsync(true);
		}

		public CreateCustomerPage()
        {
            InitializeComponent();

            //AnimatePage(1);
        }

		//async Task AnimatePage(int opacity)
		//{
  //          await contentViewMain.FadeTo(opacity, 500);
		//}
    }
}
